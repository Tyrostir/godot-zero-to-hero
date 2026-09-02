---
title: "Exercises — Drills, Challenges and Autopsies"
document_id: EXER
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a new standalone exercise is added"
---

# Exercises

Chapter exercises are stated inside their chapters. This file holds the **standalone drills** — the ones worth repeating, and the ones that don't belong to a single chapter.

Three kinds:

- **Drills (D)** — short, repeatable, skill-building. Do them more than once.
- **Challenges (C)** — one-off, harder, no instructions given. Struggle is the point.
- **Autopsies (A)** — analysing something that already exists. The most underrated way to learn.

Log completions in [meta/CourseState.md](meta/CourseState.md). Record what you had to look up in [Journal.md](meta/Journal.md) — that list is your real skill map.

---

## Module 0

**D0.1 — The five-minute deploy.** From a cold machine, get a change from your editor onto your phone. Time it. Repeat weekly until it's under three minutes. If it's slow, fix the *process* (wireless adb, a one-click export preset), not your typing speed.

**C0.1 — Break the pipeline on purpose.** Rename the keystore. Deploy. Read the error. Restore. Then delete the export templates. Deploy. Read the error. Restore. Then set the wrong package name format. Read the error. **Write all three error messages and their causes into [reference/Troubleshooting.md](reference/Troubleshooting.md).** You now recognise the three most common Module 0 failures on sight.

---

## Module 1 — Godot foundations

**D1.1 — Three ways to move.** Move a cube 5 m forward using: (a) `Position +=`, (b) `Translate()`, (c) `GlobalTransform` with a new `Basis`. Explain when each is correct.

**D1.2 — The rotation gauntlet.** Rotate an object to face a moving target using: Euler angles, `LookAt()`, and `Basis.Slerp`. Make each one wrong on purpose (gimbal lock, up-vector flip, snapping) and describe the visible symptom.

**D1.3 — Layer design.** Given a game with player, enemies, projectiles, pickups, terrain, triggers and a camera, design the collision layer/mask matrix on paper. Then implement it and verify each interaction.

**C1.1 — Blind control scheme.** Implement a third control method for the marble that isn't tilt or joystick and isn't obviously terrible. Playtest all three against each other and pick a default with a written reason.

**C1.2 — The unbreakable save.** Make your save system survive: app killed mid-write, a corrupted file, a save from an older version, and a device with no free storage. Four failure modes, four handled cases.

**A1.1 — Autopsy a mobile game.** Pick a 3D mobile game you like. Play for 15 minutes and write down: how many buttons are on screen, what the camera does when you stop moving, how long the app takes to first input, and what happens on a phone call interrupt. Three of these will change how you build P01.

---

## Module 3 — Blender & the pipeline

**D2.1 — The primitive drill.** Model five primitives to exact given dimensions in under five minutes, transforms applied, origins placed correctly. Repeat daily for a week. This is the Blender equivalent of scales.

**D2.2 — Ten-minute prop.** Model a real object from your desk in ten minutes flat. No texturing. Delete it afterwards. Daily.

**D2.3 — Unwrap under pressure.** Unwrap three given models with no visible stretching, using a checker texture to verify. Time yourself.

**C2.1 — One-material scene.** Build a small scene where *every* object shares a single material and a single 1024 texture, and it still looks intentional. This constraint teaches trim sheets faster than any tutorial.

**C2.2 — Halve it.** Take any model you've made and halve its triangle count with no visible difference at gameplay distance. Then halve it again. Note where it breaks.

**A2.1 — Autopsy a CC0 asset.** Download a Kenney or Quaternius model. Open it in Blender. Answer: how many triangles, how is it UV'd, does it use one atlas, where are the origins, why did the author make those choices? Write half a page.

---

## Module 4 — Characters

**D3.1 — Pose to extremes.** Take any rigged character and pose every joint to its limit. Find three places the deformation breaks. Fix them in weight paint. Repeat with a different character.

**D3.2 — Cycle timing.** Take an existing walk cycle and retime it to feel: exhausted, sneaking, triumphant. Same poses, different curves only. This teaches you that timing *is* the performance.

**C3.1 — The dodge roll.** Add a dodge-roll state with invincibility frames, a cooldown, direction based on input, and clean blending in and out — from scratch, no guidance.

**C3.2 — Interrupt everything.** Make every animation state interruptible at any frame without visual popping. Then find the one that still pops and fix it.

**A3.1 — Autopsy a character controller.** Play a 3D platformer with a controller in one hand and a notebook in the other. Record: jump apex time, whether coyote time exists (jump off a ledge *late* and see), whether the jump has variable height, how long the landing recovery is. Then match those numbers in your own.

---

## Module 5 — Worlds & performance

**D4.1 — Greybox to brief.** Given a one-paragraph level brief, greybox it in 45 minutes. Repeat with a different brief. Speed of iteration is the level designer's core skill.

**D4.2 — Frame budget arithmetic.** Given a 16.6 ms frame budget, allocate it across rendering, physics, scripts and audio for a mobile game. Then measure your actual level against your allocation.

**C4.1 — The optimisation challenge.** Deliberately build a scene that runs at ~20fps on your phone. Then optimise it to 60fps, documenting every single change and its measured effect. This is the most professionally useful exercise in the course.

**C4.2 — Light it three ways.** Light one room as: dawn, harsh noon, and lantern-lit night. Same geometry. Each must read clearly and each must hold framerate.

**A4.1 — Autopsy a level.** Pick a level from a game you admire. Map it on paper. Mark the critical path, the landmarks, the optional routes, and every place the game taught you something without a tutorial prompt.

---

## Module 6 — Shaders & VFX

**D5.1 — One-uniform shaders.** Write five different visual effects that each use exactly one uniform and no textures. Constraint breeds understanding.

**D5.2 — Read and rebuild.** Take a shader from godotshaders.com. Read it until you understand every line. Close it. Rebuild it from memory. Compare.

**C5.1 — Effect on a budget.** Author an impact effect that reads clearly at phone-screen size and costs under 0.5 ms of GPU time. Measure it.

**C5.2 — No textures.** Make a scene that looks good using only procedural shaders — no image textures anywhere.

**A5.1 — Autopsy an effect.** Slow-motion capture an effect from a game you like (screen record, step frame by frame). Break it into layers: what's particles, what's a shader, what's a decal, what's a screen effect, what's just animation. Almost every effect is 4–6 cheap layers, not one clever thing.

---

## Module 7 — Audio & feel

**D6.1 — Silent playtest.** Play your game with sound off for five minutes, then with sound on. Write down every moment where the silence felt broken. Those are your missing sounds.

**D6.2 — One-sound-a-day.** Record a sound with your phone. Edit it in Audacity into something game-usable. Daily for a week. Foley is a skill and it's mostly confidence.

**C6.1 — Feel without content.** Improve how your game feels using only tweens, timing and audio. No new art, no new mechanics. Record before/after.

**A6.1 — Autopsy game feel.** Screen-record 30 seconds of a game that feels great. Step through frame by frame at an impact. Count the frames of hitstop, the pixels of screenshake, the number of distinct sounds layered on the hit.

---

## Module 8 — Story & cinematics

**D7.1 — Logline drill.** Write loglines for five games you've played, in one sentence each, without naming the genre. Then write one for yours.

**D7.2 — Wordless beat.** Communicate a single story beat using only the environment. No text, no dialogue, no cutscene.

**C7.1 — Sixty seconds, no words.** Build a one-minute experience that tells a complete story with no text. (This is also Mini-Jam 4.)

**C7.2 — The unskippable test.** Make your intro cinematic good enough that a playtester chooses not to skip it. Then make it skippable anyway, because you're not a monster.

**A7.1 — Autopsy an opening.** Watch the first three minutes of three games. For each: when does the player first press a button, what have they learned by minute three, and what question are they left holding?

---

## Module 9 — Your own character

**D8.1 — Silhouette thumbnails.** Twenty character silhouettes in twenty minutes, black shapes only. Pick the three most readable at thumbnail size.

**D8.2 — Anatomy study.** Sculpt one body part from reference, timed at 30 minutes. Rotate through: hand, foot, shoulder, head, knee.

**C8.1 — Under budget.** Deliver the Warden under 20k triangles with no visible quality loss versus your first, over-budget version.

**A8.1 — Autopsy a game character.** Import a CC0 rigged character into Blender. Count its bones, check its topology at the shoulder and knee, look at its UV layout and texture budget. Compare with your own.

---

## Modules 9–10 — Systems & shipping

**D9.1 — Allocation hunt.** Profile a scene. Find every per-frame heap allocation. Eliminate them. Re-profile.

**C9.1 — Hand it over.** Give your codebase to another developer (or to me) with no explanation and ask them to add a feature. Every question they ask is a documentation or architecture bug.

**C10.1 — The stranger test.** Give your APK to someone who has never seen it and say nothing at all. Watch. Do not help. Do not explain. Write down every moment of confusion. This is the single most valuable 20 minutes in the entire course.

**A10.1 — Autopsy a store page.** Analyse five successful mobile game store pages: first screenshot, icon legibility at small size, first line of the description, video length. Then build yours.
