# Answers — Module 1: Godot Foundations

## Engine model

**1. Node / Scene / Resource.**
A **Node** is an object in the scene tree with a lifecycle (`_Ready`, `_Process`) and a position in a hierarchy. A **Scene** is a saved tree of nodes that can be instanced many times — Godot's equivalent of a prefab. A **Resource** is reference-counted *data* (a mesh, a material, a texture, your own `[GlobalClass]` data type) that lives outside the tree and can be shared between nodes.

**2. Resource over Node.**
Use a Resource when the thing is data, not a participant in the scene. In Marble Runner: a `LevelData` resource holding par time, collectible count and level name; and a `PhysicsMaterial` shared by every ramp so you change friction once.

**3. `_Ready()` vs a constructor.**
The C# constructor runs when the object is created — before it is in the tree, before its children exist, and before values from the `.tscn` are applied. `_Ready()` runs after the node **and all its children** have entered the tree and been initialised. So `GetNode(...)` in a constructor fails; in `_Ready()` it works.

**4. `_Process` vs `_PhysicsProcess`.**
`_Process` runs once per rendered frame; `delta` varies with framerate. `_PhysicsProcess` runs at a fixed tick rate (60 Hz by default) with an essentially constant `delta`. Anything that touches physics — including moving a `CharacterBody3D` — belongs in `_PhysicsProcess`, or your movement changes with framerate and your collisions get unreliable.

**5. Why `[Export]`.**
Beyond designer convenience: exported values are serialised into the scene, so different instances can differ without new code; you can tune them **while the game runs** in the remote inspector; and it forces a separation between "what this thing does" and "how this instance is configured" — which is exactly the separation that makes code reusable.

**6. `QueueFree()` vs `Free()`.**
`QueueFree()` marks the node for deletion at the end of the current frame. `Free()` deletes immediately. Immediate deletion during a signal callback, a physics query, or while iterating children corrupts state Godot is mid-way through using — you get an error about flushing queries, or a crash. Default to `QueueFree()` always.

## Space & motion

**7. Axes.** **Y is up**, the system is right-handed, and a node's local **−Z is forward**. (This trips up anyone coming from Unity's left-handed +Z-forward.)

**8. `Basis`.** A 3×3 matrix representing rotation *and* scale. Its three columns — `Basis.X`, `Basis.Y`, `Basis.Z` — are where the object's local X, Y and Z axes point in the parent's space. `-Basis.Z` is therefore the object's forward direction.

**9. Gimbal lock.** When two of three Euler rotation axes align, you lose a degree of freedom and rotation becomes ambiguous/jumpy. In Marble Runner: a follow camera that pitches to look straight down at the marble — at exactly 90° the yaw and roll collapse onto each other and the camera snaps.

**10. When `LookAt()` is wrong.** When the target lies along the up vector (degenerate — Godot will error or flip); when you want smooth turning (`LookAt` snaps instantly, so you need `Basis.Slerp` or a rotation toward the target over time); and when you need to control roll, which `LookAt` overwrites.

## Physics

**11. Four body types.**
`StaticBody3D` — ramps, walls, the level. `RigidBody3D` — the marble itself, fully simulated. `CharacterBody3D` — a scripted mover with `MoveAndSlide` (a patrolling hazard, or the Module 3 character). `Area3D` — non-solid detection volumes: collectibles, the goal, kill planes. (`AnimatableBody3D` is the fifth: a static body designed to be moved by script/animation — the right choice for a moving platform.)

**12. Layer vs mask.**
**Layer** = which layers this body *exists on* — "what I am". **Mask** = which layers this body *scans* — "what I care about colliding with". They are independent, and A detecting B does not imply B detects A.

**13. Never set `Position` on a `RigidBody3D`.**
The physics server owns that body's transform. Assigning `Position` teleports it outside the simulation, skipping collision resolution — so it tunnels through walls and its velocity becomes nonsense. Use `ApplyImpulse` / `ApplyForce` / `ApplyTorque`, or override `_IntegrateForces` and modify the `PhysicsDirectBodyState3D` you're handed.

**14. Impulse vs force.**
An **impulse** is an instantaneous change in momentum, applied once — a kick. A **force** is applied continuously and must be re-applied every physics frame to keep acting — a push. A jump is an impulse; wind is a force.

**15. Space-state query vs `RayCast3D` node.**
The node is persistent and updates once per physics frame — good for a permanent "am I on the ground?" sensor. A direct query on `PhysicsDirectSpaceState3D` is right when you need a ray at an arbitrary origin/direction computed this instant, or many rays, or a one-off check — no node bookkeeping required.

## Input

**16. `IsActionPressed` for movement, not for jump.**
Movement wants "is it held right now" — continuous state, polled every physics tick. A jump is an **event**: `IsActionPressed` would fire on every tick the button is held, giving you infinite jumps. Use `IsActionJustPressed`, and be aware that polling can still miss a tap that began *and ended* between two physics ticks — which is one of the reasons jump buffering (ch 3.8) exists.

**17. The InputMap.**
It maps named actions ("jump") to concrete inputs, so gameplay code never mentions a key or a touch position. Skip it and you cannot add a second control scheme, cannot offer remapping, and cannot support a gamepad — without editing every gameplay script. On a phone, where you'll ship at least two schemes, this bites in week one.

**18. Two tilt-control problems.**
There is no neutral position — "flat" depends on how the player is holding the phone (sitting, lying down, in bed), so you need a calibratable zero. And there is no discrete state — you can't "tap" a tilt, so any action needing a distinct press still requires a touch control. (Third: noise, requiring smoothing that adds latency.)

**19. Multi-touch joystick.**
It must handle `InputEventScreenTouch` (press and release, each carrying an `Index`) and `InputEventScreenDrag` (with `Index`, `Position`, `Relative`). If you ignore `Index`, a second finger anywhere on screen hijacks the joystick — and a player pressing jump with their right thumb makes the character veer left.

## Camera & UI

**20. `SpringArm3D`.**
It casts from its own origin toward where the child camera would sit and shortens the arm when it hits geometry — so the camera slides in rather than clipping through a wall. A plain parented camera has no such awareness and will happily end up inside the level.

**21. Notch clipping.**
The editor viewport shows the full display rectangle; a physical phone reserves parts of it for a cutout, a status bar and gesture areas. Query `DisplayServer.GetDisplaySafeArea()` and inset your root UI margins by the result. Test on a device with a cutout — this is not something you can eyeball on a desktop.

**22. Anchors vs containers.**
**Anchors** pin a control to positions in its parent — right when you want a specific element in a specific corner (a pause button top-right). **Containers** lay children out automatically — right for lists, rows, grids, and anything that must reflow with content or language. Rule of thumb: containers for anything with more than one child of the same kind.

## Structure & persistence

**23. Autoloads.**
Belongs: cross-scene *services* with no level-specific state — audio manager, save manager, settings, an event bus, a scene loader. Doesn't belong: gameplay logic, anything holding a reference to a node in the current level (it'll dangle after a scene change), and anything you'd want two of. An autoload is a global; every global you add makes the system harder to reason about, so the bar should be high.

**24. `CallDeferred` when changing scenes.**
During a physics callback the physics server is mid-step and the scene tree is effectively locked. Freeing the current scene there deletes objects the server is still using. `CallDeferred` defers the call to idle time, after the physics step completes.

**25. `user://` on Android.**
It maps to the app's private internal data directory, not to shared storage — nothing else on the phone can see it, and it's wiped when the app is uninstalled. For debugging you can't just browse to it in a file manager; on a debuggable build use `adb shell run-as <your.package>` to reach it, or log the contents from inside the game.

**26. Save works in editor, fails on device — three causes.**
(a) You wrote to `res://` or an absolute desktop path — `res://` is read-only in an exported build. (b) The file exists but was never flushed/closed before the app was backgrounded and killed. (c) Case sensitivity — Android's filesystem is case-sensitive where Windows isn't, so `SaveData.json` ≠ `savedata.json`. (Also: your export preset's filters excluded a file you assumed shipped.)

## Judgement

**27. 30fps on phone, 300fps on desktop — first four checks.**
(1) Which renderer is the export using — Forward+ on a phone is often the whole answer; try Mobile. (2) Open the profiler on-device and split CPU vs GPU frame time; optimising the wrong one wastes days. (3) If GPU-bound: resolution/overdraw/transparency, texture sizes and compression format, real-time shadows and any real-time GI. (4) If CPU-bound: draw call count, physics tick rate and active bodies, and per-frame allocations in C#. Only then start changing things — and measure after each change, one at a time.

**28. Moving platform.**
Use `AnimatableBody3D` (a static-natured body meant to be moved by script or `AnimationPlayer`) with sync-to-physics enabled, driven by an `AnimationPlayer` or `Tween`. A `RigidBody3D` marble is carried by friction. A `CharacterBody3D` needs the platform's velocity applied — Godot's `MoveAndSlide` exposes platform velocity handling for exactly this. Never use a `StaticBody3D` and move it by setting `Position`: bodies resting on it won't be pushed correctly and will jitter or fall through.
