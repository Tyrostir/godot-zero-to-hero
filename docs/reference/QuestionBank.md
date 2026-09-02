---
title: "Question Bank — Check Yourself"
document_id: QBANK
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a module's questions are written or revised"
---

# Q&A Bank — Check Yourself

Questions for every module. **Answers live in [answers/](answers), one file per module.**

## How to use this properly

Answer from memory, **out loud or in writing**, before opening the answer file. Recognising a correct answer is not the same as being able to produce one — and only the second one helps you at 11pm when your character is falling through the floor.

Mark each question:

- ✅ answered confidently and correctly
- ⚠️ got there, but slowly or partially → **revisit the chapter**
- ❌ couldn't answer → **redo the chapter's build section**

Any question you mark ⚠️ or ❌ becomes a row in [../meta/Doubts.md](../meta/Doubts.md).

Re-take each module's questions **two weeks later**. Spaced repetition is the only thing that reliably converts "I did the tutorial" into "I know this."

---

## Module 0 — Toolchain
→ answers: [answers/module-00.md](answers/module-00.md)

1. Why does this course need the .NET build of Godot specifically, and what error appears if you use the wrong one?
2. What must be true about your export templates' version, and what goes wrong if it isn't?
3. What are the three devices in this course and what is each one's job?
4. Why can't you run the Godot C# editor on your Android phone?
5. What does the debug keystore do, and why does Godot need one before it can deploy?
6. `adb devices` prints your phone with the word `unauthorized`. What happened and where's the fix?
7. Name the six independent tools that must all work for a C# APK to reach your phone.
8. Why does this course deploy to a real device in Module 0 rather than Module 10?

---

## Module 1 — Godot Foundations
→ answers: [answers/module-01.md](answers/module-01.md)

**Engine model**
1. In one sentence each: what is a Node, what is a Scene, what is a Resource?
2. When would you use a Resource rather than a Node? Give two concrete examples from Marble Runner.
3. What does `_Ready()` guarantee that a constructor does not?
4. `_Process` vs `_PhysicsProcess` — what is different about `delta` in each, and which one should move a `CharacterBody3D`?
5. Why should gameplay values be `[Export]`ed instead of hard-coded, beyond "designers can edit them"?
6. What's the difference between `QueueFree()` and `Free()`, and when does the difference bite you?

**Space & motion**
7. Godot 3D: which axis is up, and which direction does a node's local −Z point?
8. What is a `Basis`, and what are its three columns?
9. Explain gimbal lock in one sentence and name one situation in Marble Runner where it could appear.
10. When is `LookAt()` the wrong tool?

**Physics**
11. Name the four 3D body types and give one Marble Runner use for each.
12. Collision **layer** vs collision **mask** — say it in one sentence each.
13. Why should you never set `Position` directly on a `RigidBody3D`, and what do you do instead?
14. What's the difference between `ApplyImpulse` and `ApplyForce`?
15. When would you use a raycast query on the space state instead of a `RayCast3D` node?

**Input**
16. Why is `Input.IsActionPressed()` inside `_PhysicsProcess` correct for movement, but wrong for a jump?
17. What is the InputMap for, and what breaks the day you skip it?
18. Name two problems with accelerometer tilt controls that don't exist with a joystick.
19. Which events does a multi-touch virtual joystick need to handle, and what happens if you ignore the touch **index**?

**Camera & UI**
20. What does `SpringArm3D` do that a plain camera parented to the player doesn't?
21. Why does a UI that looks correct in the editor get clipped by a phone's notch, and what API tells you the safe area?
22. Anchors vs containers — when do you reach for each?

**Structure & persistence**
23. What belongs in an autoload, and what emphatically doesn't?
24. Why is `CallDeferred` needed when changing scenes from inside a physics callback?
25. Where does `user://` actually live on Android, and what does that mean for debugging a save bug?
26. Your save works in the editor and fails on device. Name three plausible causes.

**Judgement**
27. Marble Runner drops to 30fps on the phone but runs at 300fps on the desktop. Give an ordered list of the first four things you'd check.
28. You're asked to add a moving platform. Which body type, and how does the marble stay on it?

---

## Module 2 — Android Runtime & Engineering Practice
→ answers: [answers/module-02.md](answers/module-02.md) *(written when you reach Module 2)*

1. Name four things Android can do to your running game without asking, and what each one should trigger in your code.
2. What is `NOTIFICATION_APPLICATION_PAUSED` for, and what must happen before it returns?
3. Why can a backgrounded Android game lose all its state, and what is the only reliable defence?
4. List the ten steps of the chaos test, and say which one most games fail first.
5. What is the difference between the back *button* and the back *gesture*, and why does it matter for a pause menu?
6. Why is your own phone the wrong device to validate a release against?
7. What is a frame budget, and how do you spend 16.67 ms across CPU, GPU, draw calls and load time?
8. What is the correct order of operations when something feels slow — and what is the most common mistake?
9. Why does testing start in Module 2 rather than Module 10?
10. What does `git bisect` do, and what must be true of your commit history for it to work?

---

## Module 3 — Blender & Pipeline
→ answers: [answers/module-03.md](answers/module-03.md)

1. What does "1 unit" mean in Blender, and what must be true for it to match Godot?
2. Why does an unapplied scale cause problems, and name three things it breaks.
3. `Shift+D` vs `Alt+D` — what's the difference and which one builds a modular kit?
4. Explain the object/mesh data-block distinction in one sentence.
5. Why glTF rather than FBX or OBJ? Give three reasons.
6. What do the suffixes `-col`, `-convcol` and `-noimp` do on import into Godot?
7. What is texel density and why does inconsistent density make a kit look amateur?
8. What is a trim sheet, and why is it so valuable specifically on mobile?
9. In PBR: what must **not** be in an albedo map, and why?
10. What is a normal map storing, and what does "tangent space" mean?
11. Describe the high-to-low bake workflow, and what a "cage" is for.
12. You bake a normal map and get dark streaks and stray artefacts. Name three likely causes.
13. Why does putting the whole kit on one atlas reduce draw calls?
14. When does topology genuinely not matter, and when is it critical?
15. Your model imports into Godot at 1/100th the expected size. List the checks in order.

---

## Module 4 — Characters I
→ answers: [answers/module-04.md](answers/module-04.md) *(written when you reach Module 4)*

1. FK vs IK — what is each for, and why do legs usually want IK?
2. What is bone roll and what does a wrong one cause?
3. Why does `.L`/`.R` naming syntax matter mechanically, not just tidily?
4. What is the candy-wrapper twist and how do you fix it?
5. Root motion vs in-place: what does each cost you in engine?
6. What has to be true of three locomotion clips for them to blend in a `BlendSpace1D`?
7. Why is a state machine better than a chain of `if` statements for a character controller?
8. What are coyote time and jump buffering, and why does the player never notice them working?
9. How do you export multiple named animation clips in a single `.glb`?
10. Your Mixamo animation plays with the character lying on its side. What went wrong?

---

## Module 5 — Worlds, Lighting, Performance
→ answers: [answers/module-05.md](answers/module-05.md) *(written when you reach Module 5)*

1. Why does mobile mean baked lighting, in terms of actual hardware?
2. `LightmapGI` vs `VoxelGI` vs `SDFGI` — cost, quality, and which one ships on a phone?
3. What is UV2 and why does a lightmap need one?
4. What is a tile-based GPU, and which two techniques does it change your opinion about?
5. What is overdraw and why is transparency so expensive on mobile?
6. ETC2 vs ASTC — what are they and how do you choose?
7. What does a draw call cost, and name three ways to have fewer?
8. Thermal throttling: why is a 30-second benchmark a lie?
9. What is the "critical path" in level design, and how do you make players follow it without signposts?
10. Your scene is at 35fps. Describe an ordered diagnostic procedure.

---

## Module 6 — Shaders & VFX
→ answers: [answers/module-06.md](answers/module-06.md) *(written when you reach Module 6)*

1. What runs in `vertex()` vs `fragment()`, and how many times does each run?
2. What is a varying, and why can't you just use a global?
3. What is fresnel, and which three effects in this course use it?
4. Why is `discard` cheap on desktop and expensive on mobile?
5. What causes shader compilation stutter and how do you prewarm it?
6. `GPUParticles3D` vs `CPUParticles3D` on Android — what's the trade-off?
7. Why bake a Blender smoke sim to a flipbook rather than simulating in-engine?
8. What is a decal actually doing, and what does it cost?
9. Name four cheap layers that together read as one expensive effect.
10. How would you measure whether a shader is actually your bottleneck?

---

## Module 7 — Audio & Feel
→ answers: [answers/module-07.md](answers/module-07.md) *(written when you reach Module 7)*

1. Why route through buses rather than setting volume per-player?
2. What is ducking and where would you use it in this game?
3. Why does screenshake driven by `randf()` feel worse than noise-driven shake?
4. What is hitstop and why does it read as "power"?
5. How does a footstep system know what surface it's on?
6. What breaks when you mix your game only on headphones?
7. Name three CC-licences you must not accept for game audio, and why.
8. What's the difference between a music loop, a stinger and a layer?

---

## Module 8 — Story & Cinematics
→ answers: [answers/module-08.md](answers/module-08.md) *(written when you reach Module 8)*

1. Premise, theme and logline — what is each, in one sentence?
2. What is ludonarrative dissonance? Give an example from a game you've played.
3. Why does three-act structure need adapting for games?
4. What is environmental storytelling and why is it more efficient than dialogue?
5. Why must a dialogue system be data-driven, in terms of who edits what?
6. Why is an intro cinematic skippable, always, without exception?
7. What is the 180° rule and what does breaking it feel like?
8. Why load scenes on a thread, and what's the trap with doing so?
9. How does a credits roll get generated from your licence ledger, and why build it that way?

---

## Module 9 — Characters II
→ answers: [answers/module-09.md](answers/module-09.md) *(written when you reach Module 9)*

1. Why retopologise by hand instead of using Decimate?
2. Where must edge loops go on a character, and why exactly there?
3. What is ray distance in a bake and what does getting it wrong look like?
4. What is an ID mask and what does it let you do?
5. Alpha-tested vs alpha-blended hair on mobile — which, and why?
6. Why do control bones not get exported?
7. What are shape keys and when do you use them instead of bones?
8. How do you verify skinning is correct before you animate anything?

---

## Module 10 — Architecture & Performance
→ answers: [answers/module-10.md](answers/module-10.md) *(written when you reach Module 10)*

1. What is the marshalling boundary in Godot's C# binding, and what does crossing it cost?
2. Why do per-frame allocations hurt more on mobile than on desktop?
3. `struct` vs `class` — when does the choice actually matter here?
4. What is object pooling and what does it trade away?
5. Composition over inheritance in a node tree — what does that look like concretely?
6. Why is `GetNode("../../Player")` a bug waiting to happen, and what replaces it?
7. How do you version a save format so old saves still load?
8. What should a graphics tier actually change, in priority order?

---

## Module 11 — Capstone & Release
→ answers: [answers/module-11.md](answers/module-11.md) *(written when you reach Module 11)*

1. What is a vertical slice and what is it *for*?
2. Why is scope, not skill, what kills projects?
3. AAB vs APK — what's the difference and when do you need each?
4. What happens if you lose your release keystore?
5. What does a navmesh actually store?
6. How do you telegraph an attack so it's fair, and what makes one feel unfair?
7. What do you record during a playtest, and what do you deliberately ignore?
8. Name five accessibility features that cost almost nothing to implement.
9. Why does your store page's first screenshot matter more than your trailer?
