---
title: "Chapter 0.19 — Module 0 Self-Check"
document_id: CH-00.19
chapter: "0.19"
module: 0
block: "0C — Dependencies and the dev loop"
track: Q
paths: "🐣🚶🏃"
platforms: "🪟 Windows 11 · 🐧 Linux (native)"
scaffolding: "20 / 80 — guided / independent"
time: "60–90 min"
prerequisites: "0.1–0.18"
status: Published
version: 1.0
created: 2026-09-02
last_updated: 2026-09-02
---

# Chapter 0.19 — Module 0 Self-Check

🪜 **Scaffolding: 20 / 80.** The most independent chapter so far, deliberately.

---

## 🎯 Goal

By the end you will have **rebuilt the entire Module 0 loop from nothing, without opening a chapter**, answered nineteen questions from memory, and left the module with an honest record of what you can and cannot do unaided.

---

## 🏃 Fast-Track Summary

*Path C: do the rebuild. The questions are optional; the rebuild is not.*

- ⬜ **Blank-page assessment:** a new Godot project → C# script → runs on the phone → committed. **No chapters open. Timed.**
- Then the retrospective: skills self-assessment · `Journal.md` · review every open doubt · clear what you can.
- Then nineteen questions, answered **before** looking.
- Mark each ✅ confident · ⚠️ slow or partial · ❌ could not. **Every ⚠️ and ❌ becomes a row in [`Doubts.md`](../meta/Doubts.md).**
- ⭐ **Re-take this in two weeks.** Spaced repetition is what turns "I did the tutorial" into "I know this."
- Commit: `ch 0.19: module 0 self-check`

---

## 🧭 Before you start

| You need | Why |
|---|---|
| 60–90 uninterrupted minutes | The rebuild is timed |
| **Every chapter closed** | That is the assessment |
| A stopwatch | |

> 📌 **This is the 10% independent portion of Module 0** ([ADR-033](../meta/Decisions.md#adr-033)). Every chapter so far has been 90% guided. From Module 3 the ratio starts shifting, and by the capstone it inverts. **This is the first honest measurement of what you can do alone.**

---

## 🔨 Build

### Step 1 — ⬜ The blank-page rebuild

**Requirements only. No steps, no reference, no open chapters.**

> **Produce a new Godot project, containing a C# script of your own, running on your phone, committed to git — in under 45 minutes.**
>
> It must:
> - be a **new** project, not P00
> - use the **Mobile** renderer
> - contain **one C# script** that prints `OS.GetName()` and does something visible
> - **run on your phone**, deployed from your machine
> - have a `.gitignore` that excludes derived files, verified with `git check-ignore -v`
> - be committed with a message following [`Conventions.md`](../reference/Conventions.md)

**Start the stopwatch. Close every chapter. Go.**

<details>
<summary>Stuck for more than five minutes on one step? Open this — but note which step first.</summary>

Hints only, in order. Take the fewest you can.

1. New project → renderer **Mobile** → `Node3D` root → save the scene.
2. Attach Script → **C#** → the filename must match the class name.
3. `public partial class X : Node3D`, and press **Build** before running.
4. `Project → Project Settings → Application → Run → Main Scene`.
5. `Project → Export… → Add… → Android` → Unique Name needs a dot.
6. `adb devices` must show `device` before the deploy button appears.
7. Copy `.gitignore` from the course repo root.

**Which hint you needed is the useful data.** Write it down — that is the gap Module 1 should close for you.

</details>

**Record:** total time · how many hints · which step cost the most.

### Step 2 — The retrospective

**A — Skills.** Open [`CourseState.md` §6](../meta/CourseState.md) and fill the **Start** column honestly. 1 = never done it · 3 = can do it unaided · 5 = could teach it.

> ⚠️ **Rate what you can do *without the chapter open*.** The rebuild you just did is your evidence. Inflating this column only produces a course that skips things you needed.

**B — Journal.** Fill in [`Journal.md`](../meta/Journal.md) for Module 0: hours, what you reached for first, **what you had to look up**. That last column is your real skill map.

**C — Doubts.** Open [`Doubts.md`](../meta/Doubts.md). For each open entry: can you close it now? Any question you carried through the module and never resolved is a gap Module 1 will build on.

**D — Verification.** Open [`VerificationRuns.md`](../internal/VerificationRuns.md). **V-07 to V-15** are open, and each one is something I could not check from my environment. Paste what you can into [`toAgent/`](../../toAgent/).

> 🚨 **The two worth prioritising:** **V-14** — whether a C#/.NET Android export needs any option a GDScript export does not. And **V-15** — whether the editor Debugger shows a **C#** stack trace for a device-side exception, or an engine-level one. Both change later chapters, and neither is answerable from here.

### Step 3 — The questions

Answer **out loud or in writing, before opening anything.** Mark each ✅ ⚠️ ❌.

**Toolchain and platform**

1. Why does this course need the .NET build of Godot specifically, and what is the symptom of using the wrong one?
2. Why can the whole course not run inside WSL2?
3. Why must export templates match the editor version exactly?
4. What are the three devices in this course, and what must never happen on each?

**Languages**

5. Are `rotate_y` and `RotateY` one function or two? What follows for reading addons?
6. Name the four things Godot requires of a C# class. Which fails silently?
7. Why can a shader not print anything?
8. What single question decides which language a job gets?

**The pipeline**

9. Name the eight tools that must cooperate for an APK to reach your phone.
10. Three export failures happen at three different points. What does *how far it got* tell you before you read the message?
11. What does `OS.GetName()` printing `Android` prove that a spinning cube does not?

**Errors and debugging**

12. Name the four places a failure can surface, and what each is best at.
13. Why does the Godot Debugger show nothing when you launch the app from the phone's own launcher?
14. What does `unauthorized` from `adb devices` rule out?

**Version control and dependencies**

15. What is the test for whether a file belongs in git?
16. Why is `.import` committed when it looks generated?
17. Name the six dependency-evaluation questions, in order. Why that order?
18. Which failure mode is more dangerous — an addon that fails on enable, or one that installs and works?
19. What does git structurally fail to record, and what do you keep instead?

<details>
<summary>Answers</summary>

1. Godot ships **two binaries**; only the **.NET/mono** build contains the C# runtime and MSBuild integration. Symptom: **no Build (hammer) button**, or *"C# support is not enabled"*. → [0.2](Chapter_00.02_GodotAndDotNet.md)
2. **WSL2 has no USB passthrough**, so `adb` cannot see a phone plugged into the PC — and deploying to a device is this course's core loop. Also: Vulkan through a translation layer, and a slow filesystem boundary. → [`Platforms.md`](../reference/Platforms.md)
3. An export template **is the Godot engine**, precompiled for a target platform. Editor and engine must agree on the data format they exchange. Mismatch → export refused, or an APK that installs and crashes instantly. → [0.2](Chapter_00.02_GodotAndDotNet.md), [0.17](Chapter_00.17_DevLoopTools.md)
4. **Desktop** — never make a performance judgement on it. **Phone** — never author on it. **Termux** — never build on it. → [0.1](Chapter_00.01_MachinesAndTheirRoles.md)
5. **One.** Godot registers each class once in C++ with type metadata; GDScript reads that registry and C# generates bindings from it. So converting a GDScript snippet to C# is usually **case conversion** — which makes the overwhelmingly-GDScript addon ecosystem readable. → [0.10](Chapter_00.10_GDScriptFirstContact.md)
6. `public` · `partial` · derives from a Godot type · **filename matches the class name**. The **filename rule** fails silently — no build error, no runtime error, the script simply does not attach. → [0.11](Chapter_00.11_CSharpFirstContact.md)
7. Because **thousands of copies run in parallel** on the GPU with no communication and no shared ordered output. Every shader restriction — no printing, no memory, no node access — follows from that one fact. → [0.13](Chapter_00.13_GDShaderFirstContact.md)
8. **What does this job do most often?** Edited → GDScript. Maintained → C#. Runs per pixel → GDShader. Executed millions of times *and profiled* → C++. → [0.14](Chapter_00.14_LanguageDecisionTable.md)
9. Godot editor · .NET SDK/MSBuild · export templates · JDK · Android build-tools · debug keystore · adb · the phone's USB/Wi-Fi stack. → [0.8](Chapter_00.08_P00HelloPhone.md)
10. **Instantly, in the dialog** → validation, your settings. **Before packaging** → a missing prerequisite (templates, SDK, JDK). **After packaging** → signing or install. **Ask how far it got before asking what went wrong.** → [0.8](Chapter_00.08_P00HelloPhone.md)
11. That **the code is executing where you think it is.** A cube can spin because of a stale build, a forgotten desktop window, or a previously installed APK. The cube is an impression; the log line is evidence. → [0.8](Chapter_00.08_P00HelloPhone.md)
12. **MSBuild** — compile errors, nothing ran. **Debugger** — exceptions with a stack trace, including from the device. **Output** — prints and warnings. **`adb logcat`** — everything the OS saw, including processes that died or never started. → [0.9](Chapter_00.09_ReadingErrors.md)
13. The debug link is established **only when Godot launches the app** and hands it the desktop's address. Started from the launcher, the app has no idea an editor exists. **An empty panel looks identical to "no problems"** — which is the trap. → [0.9](Chapter_00.09_ReadingErrors.md)
14. That **the physical layer works** — cable, port, USB mode, driver are all fine, and the phone is refusing on trust grounds. The fix is on the phone's screen. An empty list means the opposite. → [0.5](Chapter_00.05_ConnectingYourPhone.md)
15. **Can the tools regenerate it exactly if I delete it?** Yes → derived, ignore. No → authored, commit. → [0.7](Chapter_00.07_GitForGameProjects.md)
16. Because it is **not derivable** — it encodes *your decisions* about how each asset is imported. Delete it and Godot re-imports with defaults, silently undoing hours of work. → [0.7](Chapter_00.07_GitForGameProjects.md)
17. Licence · maintained · works from C# · mobile cost · abandonment risk · could I write it in a day. **Each is cheaper than the next and can end the evaluation**, so the order stops you benchmarking something you cannot legally ship. → [0.15](Chapter_00.15_EvaluatingADependency.md)
18. **The one that installs and works.** A Godot 3 addon fails loudly in a minute. The expensive failure works now, is unmaintained, is too large to fork, and turns out to be GPL — invisible at install, arriving months later. → [0.15](Chapter_00.15_EvaluatingADependency.md)
19. Git records **decisions** — source, scenes, `.csproj` — and **not the environment**. So you keep: `ENGINE_VERSION.md`, `packages.lock.json`, `Machines.md`, `DecisionsLog.md`, and the ADRs. → [0.18](Chapter_00.18_TheVersionMatrix.md)

</details>

### Step 4 — Commit

```bash
git add .
git commit -m "ch 0.19: module 0 self-check"
git push
```

---

## ▶️ Run it

- [ ] Blank-page rebuild completed, timed, hints counted
- [ ] Skills column filled honestly in `CourseState.md`
- [ ] `Journal.md` updated with what you had to look up
- [ ] Every open doubt reviewed
- [ ] What you can of V-07 to V-15 pasted into `toAgent/`
- [ ] All nineteen questions marked ✅ ⚠️ ❌
- [ ] Every ⚠️ and ❌ recorded as a doubt

---

## 👀 Observe

Two numbers matter more than the score.

**The hints you needed in Step 1.** Zero means Module 0 landed. Three or more from one area means that area needs a re-read before Module 1 — and the *area* matters more than the count.

**Your ⚠️ answers, not your ❌ ones.** A ❌ is a clean gap and you know it exists. A ⚠️ — *"I got there, slowly"* — is knowledge that will fail you under time pressure, in the middle of a real problem, when you also have four other things wrong. **Those are the ones to convert.**

---

## 🧠 Why it works

### Why a rebuild rather than only questions

Questions test **recognition**; a rebuild tests **capability**, and they diverge sharply. You can answer "what does `partial` do?" perfectly and still stall for ten minutes because you forgot the main scene must be set before exporting.

That is exactly the gap [ADR-033](../meta/Decisions.md#adr-033)'s scaffolding gradient exists to close. **The goal was never to complete chapters** — it is *"given a requirement, can I design → implement → debug → test → validate on Android → ship it?"*

### Why to re-take this in two weeks

You will lose most of the detail within a fortnight — normal, and unavoidable at the first pass. Retrieving it **once more, from memory, after forgetting some of it** is what moves it from recent to durable.

**Two weeks. Same nineteen questions, closed book.** Anything that drops from ✅ to ⚠️ was never as solid as it felt.

> 🔬 **Deep dive — why the ⚠️ answers are the dangerous ones.** Retrieval takes effort, and effort is a limited resource. A fact you retrieve slowly consumes attention you needed for the actual problem. This is why professionals memorise things that look trivial — the four `adb` states, the three failure panels, the six evaluation questions. **Not because recall is impressive, but because it leaves capacity free for the part that is genuinely hard.** [`cheatsheets/`](../reference/cheatsheets/) exists for exactly the things worth converting.

---

## 🏋️ Practicals

**⭐ P1 — Close the gaps.** For each ⚠️ or ❌: re-read that chapter's **Build** section only — not the theory — and redo the step. Then re-answer.

**⭐ P2 — Schedule the retake.** Two weeks from today, in whatever you actually use for reminders. Same questions, closed book. Compare.

**P3 — Write your first cheat sheet.** Start [`cheatsheets/Adb.md`](../reference/cheatsheets/) with every `adb` command you have used and the four device states. This is [T-015](../meta/ToDos.md), and it should be built from **your** journal — anything you looked up twice belongs on it.

**🔬 P4 — Teach it.** Explain to someone — a person, a rubber duck, a written page — why the .NET build is a separate download and why templates must match. **The place you stumble is the place you do not understand.**

---

## 📎 Module 0 in one page

| You now have | From |
|---|---|
| A workshop, a target and a notebook, with specs recorded | 0.1 |
| Godot .NET, .NET SDK, matching templates | 0.2 |
| Blender, configured, unit-verified against Godot | 0.3 |
| JDK, Android SDK, debug keystore | 0.4 |
| A phone reachable over USB **and** Wi-Fi | 0.5 |
| Fluency in the editor, including the **remote** tree | 0.6 |
| A repository with a `.gitignore` you **proved** | 0.7 |
| ⭐ **An app of your own, running on your phone** | 0.8 |
| Four ways to read a failure, including from the device | 0.9 |
| GDScript, C#, GDShader written; C++ scheduled | 0.10–0.13 |
| A language decision table built from **your** measurements | 0.14 |
| A dependency-evaluation method, and three recorded verdicts | 0.15 |
| NuGet, audited and measured | 0.16 |
| In-editor git and a version manager | 0.17 |
| ⭐ **A pinned, reproducible toolchain** | 0.18 |

| The ideas worth carrying forward | |
|---|---|
| **Ask how far it got before asking what went wrong** | 0.8 |
| **Which panel spoke?** | 0.6, 0.9 |
| **A string that names something is a check the compiler cannot make** | 0.6, 0.11, 0.13, 0.16 |
| **Warm up · repeat · median · one variable · record conditions** | 0.12 |
| **Match the language to the dominant verb** | 0.14 |
| **Git records decisions, not environment** | 0.18 |

---

## 🔗 Further reading

- [`QuestionBank.md`](../reference/QuestionBank.md) — all modules' questions, for the retake
- [`CourseState.md`](../meta/CourseState.md) — your tracker
- [ADR-033](../meta/Decisions.md#adr-033) — the scaffolding gradient this chapter measures

---

## 💾 Commit

```text
ch 0.19: module 0 self-check
```

---

## ➡️ What's next

**Module 1 — Godot Foundations**, and [Project 01: *Marble Runner*](../../projects/README.md). Forty-four chapters that turn a spinning cube into a finished three-level game — physics, touch controls, a camera, a HUD, saves and a title screen.

The scaffolding stays at **90/10** through Module 1, then starts dropping. What you just measured is the baseline it drops from.

---

## 🪞 Reflection

In two sentences: **which of your answers were ⚠️ rather than ✅, and why is that the more important list?**

---

## 📝 Chapter changelog

| Version | Date | Change |
|---|---|---|
| 1.0 | 2026-09-02 | First published. Module 0 complete: 19 chapters. |
