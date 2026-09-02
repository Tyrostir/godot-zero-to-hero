---
title: "Doubts — Questions Asked and Answered"
document_id: DOUBTS
version: 2.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-02
update_trigger: "Every time the learner asks a question — no exceptions, and without being asked"
---

# ❓ Doubts.md

> **The rule ([ADR-011](Decisions.md#adr-011)).** No question is ever answered only in conversation. Every question you ask — at any time, about anything, however small — gets a permanent, dated entry here with **your question verbatim**, a **short answer**, and a **full answer**.
>
> This is my job, not yours. It happens at the end of every turn whether or not you remind me.

---

## Why this exists

1. **Reasoning that lives only in a chat window dies with the session.** This project will run for months across many sessions; anything not written down is gone.
2. **Writing a question well solves about a third of them.** Stating precisely what you expected and what happened *is* the debugging technique.
3. **It becomes the course's FAQ.** Over time the questions you ask drive improvements to the chapters themselves — that's what the **Action taken** field is for.
4. **It stops confusion compounding.** Chapter 5 assumes chapter 3 landed.

---

## How an entry works

| Field | Meaning |
|-------|---------|
| **ID** | `D-NNN`, assigned in order, **never reused** |
| **Date** | When you asked |
| **Context** | What we were doing when you asked |
| **Category** | For the index below |
| **Question** | **Your words, verbatim** — wording, typos and all |
| **Short answer** | 2–3 sentences — enough to unblock you |
| **Full answer** | As deep as the question deserves |
| **Related** | Chapters, guides, ADRs, external links |
| **Status** | ✅ Answered · 🔍 Needs verification (on real hardware/software) · ⬜ Open · ⏸️ Parked |
| **Action taken** | Any chapter edit, ADR, or ToDo that resulted |

**Categories:** `Concept` · `Setup/Install` · `Godot/C#` · `Blender` · `Art pipeline` · `Shaders/VFX` · `Audio/Narration` · `Design/Narrative` · `Performance` · `Android/Shipping` · `Licensing` · `Course logistics`

---

## 💬 The `/btw` convention

Prefix any aside with **`/btw`** and it becomes a `D-NNN` entry here — no matter how small, how tangential, or how mid-task it arrives.

```text
/btw why is the APK 60 MB when the game is one cube?
/btw what does "tangent space" actually mean?
```

> ⚠️ **Put the question on the same line as `/btw`.** A bare `/btw` prints a usage hint and the question never reaches me. (This happened three times on 2026-09-02 — see [D-006](#d-006).)

**Why have a marker at all?** Questions asked in passing are exactly the ones that get answered in conversation and then lost. The marker makes the intent unambiguous: *this is a question, and I want it in the record.*

You do not have to use it — **any question gets logged** ([ADR-011](Decisions.md#adr-011)). The prefix just guarantees nothing is read as a rhetorical aside. Questions may also arrive inside a file dropped in [`../../toAgent/`](../../toAgent/); put `/btw` on its own line there too.

### When *you* want to write the answer

Some entries below have a **"In my own words"** line. That is yours to fill in, and it is worth doing: if you can't restate an answer without looking, you haven't got it yet. My **Full answer** stays regardless — the two serve different purposes.

---

## Index

| ID | Date | Category | Question (short) | Status |
|----|------|----------|------------------|--------|
| [D-001](#d-001) | 2026-09-01 | Setup/Install | Which desktop machine will I build on? | ✅ (revised) |
| [D-002](#d-002) | 2026-09-01 | Setup/Install | Which exact Godot .NET version, and does it have known Android C# issues? | ⬜ |
| [D-003](#d-003) | 2026-09-01 | Performance | What are my test phone's GPU, RAM, Android version and Vulkan support? | ⬜ |
| [D-004](#d-004) | 2026-09-01 | Course logistics | One learning path, or three? | ✅ |
| [D-005](#d-005) | 2026-09-02 | Design/Narrative | Is story, narration, walkthrough, first/end-page animation and music planned across **all** projects? | ✅ |
| [D-006](#d-006) | 2026-09-02 | Course logistics | Will you keep documenting my `/btw` questions **and your answers**? | ✅ |
| [D-007](#d-007) | 2026-09-02 | Course logistics | Which free Blender and Godot libraries exist, can we adopt them, and can I reach AAA? | ✅ |
| [D-008](#d-008) | 2026-09-02 | Godot/C# | Would GDScript or C++ give more free libraries? And can one game use all three languages? | ✅ |
| [D-009](#d-009) | 2026-09-02 | Course logistics | Restructure for all three languages and adopt **every** library we explored | ✅ |
| [D-010](#d-010) | 2026-09-02 | Course logistics | Which points from the external review are worth adopting? | ✅ |
| [D-011](#d-011) | 2026-09-02 | Course logistics | What is a "vertical slice", and where should the capstone finish line be? | ✅ |
| [D-012](#d-012) | 2026-09-02 | Design/Narrative | Ship after Level 1 — but Levels 2–4 stay mandatory. How does that restructure the capstone? | ✅ |
| [D-013](#d-013) | 2026-09-02 | Setup/Install | My workshop is Windows 11 **or** Ubuntu/WSL. Can the course support both? | ✅ |
| [D-014](#d-014) | 2026-09-02 | Blender | Chapter 0.3: no Clip Start, no Extra Objects/Copy Attributes, and the cube is not 3 grid squares | ✅ |
| [D-015](#d-015) | 2026-09-02 | Setup/Install | Chapter 0.4 gives commands for the command-line tools zip but never says where to download it | ✅ |
| [D-016](#d-016) | 2026-09-02 | Setup/Install | `keytool` not recognised on Windows — and the `setx PATH` command I gave was harmful | ✅ |
| [D-017](#d-017) | 2026-09-03 | Godot/C# | Chapter 0.13: `mesh.MaterialOverride is ShaderMaterial` is always false | ✅ |

---

## D-001

**Date:** 2026-09-01 · **Context:** Course inception, before any chapter could be scoped · **Category:** Setup/Install · **Status:** ✅ Answered

### Question
> *(Asked of you rather than by you — but it blocked everything, so it is logged the same way.)*
> Which desktop machine will you actually use for Godot + Blender, and does it meet the requirements?

### Short answer
**Originally: a Linux desktop.** ⚠️ **Revised 2026-09-02 → Windows 11 *or* Linux, both supported.** See [D-013](#d-013).

### Full answer
This was the hardest blocker in the project, because Godot's Android editor build has **no C#/.NET support** — C# needs a desktop .NET SDK and MSBuild — so no chapter of Module 0 could be written concretely until the machine was known.

Choosing Linux has four immediate consequences, all now baked into the guides:

1. **The lean Android SDK route.** Command-line tools only (~1 GB) instead of Android Studio (~8 GB). You never open an IDE you won't use.
2. **A `udev` rule is required.** Without it `adb` reports `no permissions` or lists nothing. The reflex fix — running `adb` as root — then fights the user-owned adb server and produces confusing intermittent failures. [Setup 04 §5b](../guides/Setup_04_Android_And_Device.md) does it properly instead, and it is marked ⭐.
3. **OpenJDK comes from your distribution's packages** rather than a downloaded Temurin bundle.
4. Windows and macOS instructions **stay in the guides** for other readers — they cost little, and [ADR-024](Decisions.md#adr-024)'s reasoning (the course should stand alone) applies here too.

### Related
[ADR-004](Decisions.md#adr-004) · [Setup 01 §2](../guides/Setup_01_Prerequisites.md) · [Setup 04](../guides/Setup_04_Android_And_Device.md)

### Action taken
[ADR-004](Decisions.md#adr-004) revised. Setup 04 rewritten Linux-first and gained the ⭐ `udev` section. Setup 01's OS row updated. [T-003](ToDos.md) closed.

---

## D-002

**Date:** 2026-09-01 · **Context:** Drafting [Setup 02](../guides/Setup_02_Godot_And_DotNet.md) · **Category:** Setup/Install · **Status:** ⬜ Open — **needs your machine**

### Question
> Which exact Godot 4.x .NET version should I install, and does that version's Android C# export have known issues?

### Short answer
Install the current stable **.NET build** (not the standard one), install the .NET SDK matching the `<TargetFramework>` in the `.csproj` Godot generates for you, and record both in the version log. Then check Godot's GitHub issues for `C#` + `Android` before assuming any problem is yours.

### Full answer
I deliberately cannot answer the version half of this from here — I have no Godot and no network access to a live download page at authoring time, and inventing a version number would be exactly the failure mode [ADR-016](Decisions.md#adr-016) exists to prevent.

What I can tell you with confidence:

- **Godot ships two binaries per platform.** Standard = GDScript only. **.NET** = C# as well. Downloading the wrong one and then getting *"C# support is not enabled"* is the single most common Module 0 mistake. Verify in `Help → About`.
- **Export templates must match your editor version exactly**, including the release suffix (`4.x.y.stable` vs `4.x.y.rc1`) *and* the .NET variant. A mismatch gives either an export error naming the expected version, or — worse — an APK that installs and crashes instantly.
- **The TFM is authoritative, not my guess.** Create a throwaway project, add a C# script, open the generated `.csproj`, read `<TargetFramework>`, install that SDK.
- **C# on Android is the less-travelled path** ([ADR-022](Decisions.md#adr-022)). Expect longer export times, larger APKs, and occasional issues with no Stack Overflow answer. Search [Godot's GitHub issues](https://github.com/godotengine/godot/issues) before assuming a bug is yours — it frequently isn't.

### Related
[ADR-016](Decisions.md#adr-016) · [ADR-022](Decisions.md#adr-022) · [Setup 02](../guides/Setup_02_Godot_And_DotNet.md) · [V-01](../internal/VerificationRuns.md)

### Action taken
Recorded as verification block [V-01](../internal/VerificationRuns.md) and [T-006](ToDos.md). Clears when you paste `dotnet --list-sdks`, the `<TargetFramework>` line and Godot's `Help → About` into [`../../toAgent/`](../../toAgent/).

---

## D-003

**Date:** 2026-09-01 · **Context:** [Setup 01](../guides/Setup_01_Prerequisites.md), and it governs Module 5's entire budget · **Category:** Performance · **Status:** ⬜ Open — **needs your device**

### Question
> What is my test phone's GPU, RAM, Android version and Vulkan support?

### Short answer
Unknown, and it decides more than it looks like it does: **Vulkan support chooses your renderer**, and the GPU sets your realistic triangle, texture and shader budget for the whole course.

### Full answer
Three separate decisions hang on this:

1. **Renderer** (chapter 5.13). Godot 4 offers Forward+, **Mobile** and **Compatibility**. Vulkan-capable devices can use Mobile — the intended phone path. A device without usable Vulkan drops you to Compatibility, which changes what shaders and lighting features are available, and therefore changes several chapters in Modules 4 and 5.
2. **Performance budget** (5.12–5.18). A mid-range phone has roughly the GPU budget of a 2013 laptop and a **thermal budget of about ten minutes**. Triangle counts, texture resolution, shadow settings and post-processing all get set against your actual hardware, not a generic target.
3. **UI** (1.29). Screen resolution, aspect ratio, refresh rate and whether you have a notch decide how much the safe-area work matters to you.

**How to get the numbers:** Settings → About phone for model, Android version and RAM. An app like *Device Info HW* for the chipset. *Vulkan Hardware Capability Viewer* for Vulkan. Fill the table in [Setup 01 §3](../guides/Setup_01_Prerequisites.md#3-your-version-log).

**Worth doing if you can:** borrow an older or cheaper Android device. Your daily phone is probably better than your median player's; a five-year-old handset becomes your *performance truth*. Build for that one and the good phone looks after itself.

### Related
[Setup 01 §3](../guides/Setup_01_Prerequisites.md) · [ADR-010](Decisions.md#adr-010) · chapters 1.29, 5.12–5.18

### Action taken
[T-004](ToDos.md). Also verification block [V-03](../internal/VerificationRuns.md).

---

## D-004

**Date:** 2026-09-01 · **Context:** Adopting the `qnx-zero-to-hero` conventions · **Category:** Course logistics · **Status:** ✅ Answered

### Question
> Should the course be written for one path, or three (🐣 Absolute Beginner / 🚶 Self-Learner / 🏃 Fast-Track Pro), as in the QNX course?

### Short answer
**Three, all authored in full** — overriding my own recommendation, which was to use lightweight ⭐/🔬 markers instead.

### Full answer
I recommended **against** three paths, on the grounds that this course's structure already provides the same separation for free: the **Build** section *is* the fast track and **Why it works** *is* the depth, so ⭐/🔬 markers would have got ~80% of the value at ~10% of the cost.

You overrode it, and the reasoning is sound: my recommendation optimised for **authoring cost**; you are optimising for **the course standing on its own for readers who are not you** — the same reasoning that produced the QNX decision. Consistency across your two courses is worth something in itself: one mental model serves both, and an agent onboarded to either is immediately competent in the other.

**The consequence that mattered most** was a latent contradiction that had to be resolved immediately rather than discovered at chapter 20: [ADR-002](Decisions.md#adr-002) mandates ≥50% build and ≤30% theory, but [ADR-024](Decisions.md#adr-024)'s 🐣 boxes and 🏃 summaries are *neither*. Resolved explicitly — **the ratios are measured on the Path B reading**, the chapter minus 🐣 boxes and the 🏃 summary. Path material *adds*; it never displaces the build.

**Cost, accepted knowingly:** roughly 1.5–2× authoring effort per chapter, and longer chapters.

**Timing note:** this was asked and answered *before a single chapter existed*, which is exactly why it was raised in Session 001. Hazard H-07 was that a later "yes" would require retrofitting every written chapter. Nothing needed retrofitting.

### Related
[ADR-024](Decisions.md#adr-024) · [ADR-002](Decisions.md#adr-002) · [PLAN §1b](../PLAN.md) · [chapters/README.md](../chapters/README.md)

### Action taken
[ADR-024](Decisions.md#adr-024) moved ⏳ → ✅ and rewritten. Chapter template gained a 🏃 Fast-Track Summary section. `PLAN.md §1b` added. ToC gained a path legend. [T-005](ToDos.md) closed.

---

## D-005

**Date:** 2026-09-02 · **Context:** Plan review, after the scaffold was pushed · **Category:** Design/Narrative · **Status:** ✅ Answered

### Question *(verbatim)*
> I hope you have planned story development, story telling, narrating game, game walk-through, first page animation scene, end page animation scene, with audio for background music and narration on all the projects wherever applicable. If not, review and ensure it one more time in the plan. Remember I want to LEARN by DOING (with required theory wherever it makes sense).

### Short answer
**Partly.** Most of it was planned — but three real gaps existed, and two of them were invisible from the module titles. Narration was entirely absent; all presentation was quarantined in Modules 6–7 (so P01–P05 shipped with no title screen, no ending and no music); and "walkthrough" was unaddressed in both its senses. All three are now fixed by [ADR-026](Decisions.md#adr-026) and [ADR-027](Decisions.md#adr-027).

### Full answer

**What was already planned.** Story development, premise/theme/logline, character arc, environmental storytelling, ludonarrative harmony, splash/intro animation, main-menu animation, first-play opening, ending sequence, credits roll, cutscenes, camera language, Blender-rendered cinematics, background music and adaptive layers.

**Gap 1 — narration was entirely absent.** The word appeared nowhere in the plan. No writing for the ear, no recording, no cleaning a take, no ducking, no subtitles, no text-to-speech. A straightforward miss against an explicit request in your very first prompt.

**Gap 2 — everything was quarantined in Modules 6–7.** This is the serious one. Projects P01–P05 shipped with no title screen, no ending screen and no music. That contradicted your *"on all the projects wherever applicable"* — but far worse, **it contradicted [ADR-002](Decisions.md#adr-002) from the inside.** You would have reached roughly **hour 180** before building your first title screen, and would then have had to learn timing, camera language, sound design and pacing *simultaneously, at full difficulty, with no practice*. That is precisely the theory-then-practice failure this course exists to prevent — hiding inside a plan that claims to prevent it.

**Gap 3 — "walkthrough" was unaddressed in both senses:** the *designed* walkthrough (a level that teaches with no tutorial prompt) and the *written* one (a player-facing guide).

**Why the audit was worth running rather than answering "yes".** Two of the three gaps were invisible from the module titles. Module 8 is called *Story, Narrative & Cinematics* and Module 7 *Audio & Game Feel*. A glance at those names would have produced a confident and wrong "yes, it's all covered." The ToC had to be read line by line against your list.

**The fix.**

- **[ADR-026 — The Presentation Spine].** Presentation runs through **every project from P01**, escalating. From P01 a project is not shipped without an animated first page, an ending screen, music, ambience, a narrative frame and a walkthrough — as **done-criteria**, not suggestions. You build a title screen **four times**: crude tween (1.35) → live 3D character (3.12) → your own shaders (6.22) → directed, scored, narrated opening (8.16–8.18). Same escalation for the ending, music, and the walkthrough.
- **[ADR-027 — Narration].** Eleven chapters, record-before-theorise, built around a phone and a wardrobe of soft furnishings — **no purchase required**. TTS treated as a legitimate option with its licensing trap stated. **Subtitles mandatory**: a phone gets played on mute, on a bus, by someone who is deaf, and by someone at 4% battery, and all four are the same requirement.

**Rejected:** the cheap fix — bolting narration chapters onto Module 8 and leaving the rest. That would have closed gap 1 and left the pedagogy broken.

**Cost, stated plainly:** 43 chapters added, **215 → 258**; pacing ~400–450 h → **~430–480 h**. Accepted because the chapters are short and distributed rather than lumped, and because every intermediate project now feels like a *game* rather than a tech demo — which is the strongest available defence against the thing that actually ends long courses, which is not difficulty but loss of interest.

### Related
[ADR-026](Decisions.md#adr-026) · [ADR-027](Decisions.md#adr-027) · [PresentationSpine.md](../PresentationSpine.md) · [PLAN §3b](../PLAN.md) · [PROMPT#5](../../PROMPTS.md)

### Action taken
New document [`../PresentationSpine.md`](../PresentationSpine.md). ToC rewritten (+43 chapters). `projects/README.md` gained 34 presentation done-criteria. `PLAN.md §3b` added; Modules 6–7 syllabus and the pacing table updated. Glossary gained 18 audio/narrative terms. CourseState tracker and all counts regenerated. Committed as `36c91e3`.

### In my own words
*(yours to fill in)*

---

## D-006

**Date:** 2026-09-02 · **Context:** Immediately after D-005, following three empty `/btw` invocations · **Category:** Course logistics · **Status:** ✅ Answered

### Question *(verbatim)*
> can you keep documenting my btw questions and your answer also ? I already asked one btw question and you answered, please document that also.

### Short answer
**Yes — and you were right that I'd dropped one.** [D-005](#d-005) is that question, back-filled above. The structural reason it slipped is that this file's old format had a column for *your* answer in your own words but **nowhere for mine**, so my answers were landing in `PROMPTS.md` and never here. Format rebuilt; [ADR-011](Decisions.md#adr-011) amended to say both halves, every time, unprompted.

### Full answer

**On the three empty `/btw` calls.** All three printed `Usage: /btw <your question>` and no question text reached me. The command needs the question on the same line:

```text
/btw why is the APK 60 MB when the game is one cube?
```

A bare `/btw` on its own line is swallowed by the command handler before I see anything.

**On the dropped question.** Verifiably real, and my fault. Your PROMPT#5 question about story/narration/walkthrough coverage was recorded in `PROMPTS.md` (the narrative log) and in `DecisionsLog.md` (the decisions that came out of it) — but **never as a `D-NNN` entry**, which is where a reusable technical answer belongs. It is now [D-005](#d-005).

**Why it slipped, structurally.** The old `Doubts.md` was a thin table: `ID | Date | Ch. | Question | Status | Notes` for open items, and `ID | Ch. | Question | Answer, in my own words | Resolved on` for closed ones. That last column was designed for **you** to restate an answer in your own words — a good exercise — but it left **no field for my answer at all**. So my answers had nowhere to go and drifted into `PROMPTS.md`. A format that makes the right thing hard is a format bug, not a discipline problem.

**What changed.**

1. **This file rebuilt in the full entry format** — Context, Category, **Question verbatim**, **Short answer**, **Full answer**, Related, Status, **Action taken** — matching `qnx-zero-to-hero`'s `Doubts.md` ([ADR-025](Decisions.md#adr-025)). Your "In my own words" line survives as an *optional extra* on answered entries, because restating an answer unprompted is still the best test of whether you have it.
2. **[ADR-011](Decisions.md#adr-011) amended** to state explicitly that **both halves** get logged — your question verbatim *and* my full answer — and that I do it **at the end of every turn, unprompted**. Previously it said only "every question gets an entry", which I satisfied narrowly for questions *I* asked *you* (D-001 to D-004) while missing one you asked me.
3. **All six questions from Sessions 001–002 back-filled**, including the two open ones, with full answers rather than one-line notes.

**The distinction between the three logs**, so it's clear where to look:

| File | Records | Use it when |
|------|---------|-------------|
| **`Doubts.md`** *(this file)* | Reusable **technical answers**, indexed and searchable | You want to look something up |
| **`PROMPTS.md`** | The **narrative** — what was asked and what was said, verbatim, in order | You want to know why a turn went the way it did |
| **`DecisionsLog.md`** | **Decisions**, with rationale, rejected alternatives and history | You want to know why the course is shaped this way |

One prompt may produce zero, one, or several `D-NNN` entries. PROMPT#5 produced one ([D-005](#d-005)) plus two ADRs.

### Related
[ADR-011](Decisions.md#adr-011) · [ADR-025](Decisions.md#adr-025) · [PROMPTS.md](../../PROMPTS.md) · [DecisionsLog.md](DecisionsLog.md)

### Action taken
This file rewritten to v2.0 in the full entry format. [ADR-011](Decisions.md#adr-011) amended. [D-005](#d-005) back-filled. Six entries now carry full answers.

---

## D-007

**Date:** 2026-09-02 · **Context:** Plan review, after the Presentation Spine was added · **Category:** Course logistics · **Status:** ✅ Answered

### Question *(verbatim)*
> There are some publicly available famous free useful blender libraries to generate various assets and for multiple purposes. Do you aware of them? Similarly Is there any such famous free useful libraries for Godot for multiple purposes as long as you know? Can you list them and Can you adopt those in our course applicable/useful/gives meaning? REMEMBER: LEARNING BY DOING rule while adopting. Restructure the course accodingly (without compromizing the qualirty). At the end I want to be able to develope AAA standard - professional - industry grade games. Plan accordingly.

### Short answer
Yes to all of it — with one correction. The free ecosystem is large and the plan was ignoring it; it is now catalogued in **[`../Toolchain.md`](../Toolchain.md)** and adopted through **28 new 🧰 chapters** that always follow *hand-build → read the source → decide and record why*. The correction: **"AAA" describes budget and headcount, not quality**, and is not achievable solo — but **professional / industry-grade craft** is, and the course now targets it explicitly.

### Full answer

**1 — The libraries.** Catalogued in full, with licences, caveats and the exact chapter that adopts each: [`../Toolchain.md`](../Toolchain.md). The headline items:

*Blender built-ins that most people never enable* — **Rigify** (the free industry-standard rig generator, and the direct answer to paid Auto-Rig Pro), Node Wrangler, LoopTools, Bool Tool, **3D-Print Toolbox** (its mesh checker is the fastest way to find the non-manifold geometry that breaks bakes), A.N.T. Landscape, Cell Fracture. And the built-in *systems* that are libraries in all but name: the **Asset Browser** (how studios actually manage a kit), **Geometry Nodes**, **Grease Pencil** (storyboarding — real previz practice), Mantaflow, QuadriFlow, the VSE and Compositor, and **OpenColorIO/AgX** colour management.

*External free Blender addons* — **TexTools** (texel density as a number rather than by eye), **RetopoFlow** (GPL, free from GitHub), the Poly Haven / ambientCG / BlenderKit browsers, MACHIN3tools, Camera Shakify, Blender Kitsu.

*Free standalone tools* — Instant Meshes, **Material Maker** (MIT, and it exports Godot shaders directly), Krita/GIMP/Inkscape, **FFmpeg** and **ImageMagick** (genuine professional workhorses for flipbooks, channel packing and atlases), Cascadeur, Ardour, OBS, scrcpy.

*Godot* — **Phantom Camera** (Cinemachine-style rigs), **Terrain3D**, **Proton Scatter**, **Beehave** / **LimboAI** (behaviour trees), **Godot State Charts**, **Dialogue Manager** and **Dialogic 2**, **Sky3D**, **Debug Draw 3D**, **GdUnit4**, **godot-ci**.

**2 — The most consequential find, and it is specific to you.** ⭐ **Chickensoft** — a maintained, MIT-licensed, **C#-first** Godot ecosystem: LogicBlocks (hierarchical serialisable state machines), AutoInject (DI through the node tree), GodotNodeInterfaces (makes scene code genuinely unit-testable), SaveFileBuilder, GodotTest, GodotEnv.

Why it matters so much here: **every "best Godot addons" list online is written for GDScript users.** Most Godot addons *are* GDScript. They work from C# — they are nodes, you call them — but you lose type safety at exactly the boundary you most want it. A C# developer following those lists spends their life writing `Call("do_thing")`. Chickensoft is the answer, and knowing it exists is worth more than any single addon.

Two further responses to that same problem are now taught: **wrap any GDScript addon behind a C# interface** (10.6b — one ugly file, the rest of your codebase stays typed), and **NuGet** (0.11), which is a large compensation GDScript users simply do not have.

**3 — Adopting them without breaking learn-by-doing.** This was the real design problem, and the answer is [ADR-028](Decisions.md#adr-028):

> **1️⃣ Hand-build it** → you understand the problem, not an API, and can debug anything built on it.
> **2️⃣ Compare** → install it, **read its source**, find what it does better *and worse*.
> **3️⃣ Decide** → adopt or keep yours, and **record why** in `DecisionsLog.md`.

Adoption chapters are numbered `N.Mb` and marked 🧰, so the pairing is visible and existing numbering stays stable. Rigify comes *after* you hand-rig a biped (B24b). Phantom Camera *after* you write a follow camera (1.24b). LogicBlocks *after* your own FSM has silently got hierarchical states wrong (4.7b). RetopoFlow *after* hand retopology (B34b).

**Step 3 is mandatory, and "a tutorial used it" is not a rationale.** Chapter **0.10** teaches the six evaluation questions — licence · maintenance · **does it work from C#** · mobile cost *measured on device* · abandonment risk · could you write it in a day. Choosing and rejecting dependencies is a larger part of professional work than writing code is, and the Godot 3→4 break orphaned enough addons to make the point concrete.

**Rejections are recorded too** ([`../Toolchain.md` §8](../Toolchain.md)): FMOD/Wwise (community integration + C# + Android is three compounding risks — awareness only, 7.2b, no install), every paid Blender addon that has a free equivalent taught here, GPL addons in shipped code, and anything abandoned since Godot 4.0.

**4 — On "AAA", honestly.** You asked for *AAA standard — professional — industry grade*. Two of those three are achievable through this course. One is not, and saying so is more useful than agreeing ([ADR-030](Decisions.md#adr-030)).

**AAA is a description of budget and headcount, not of quality**: 100–300 people, $50–200 M, three to five years, with marketing that often exceeds production. No course produces that and no solo developer achieves it — not for want of skill, but because it is a claim about organisational scale.

**Professional and industry-grade craft is entirely achievable, and the course now targets it in full.** The gaps I found and closed: **industry milestones** (first playable, vertical slice, alpha, beta, content lock, gold — 11.1b) · **production tracking with Kitsu**, an open-source tool used in real studios (10.3b) · **code standards** — `.editorconfig`, .NET analyzers, `dotnet format`, XML doc comments, warnings-as-errors (10.2b) · **structured logging** with Serilog rather than `GD.Print` (9.11b) · **unit-testable scene code** (10.9b) · **storyboarding and previz** (8.2b) · **colour management** (8.24b) · **the post-mortem**, written honestly and published (11.11b) · and **a portfolio and breakdown reel** for studio applications (11.20b).

What is deliberately *not* attempted, and why that is right: large content volume (scope kills solo projects — [ADR-019](Decisions.md#adr-019)), photoreal fidelity (wrong target for a phone — [ADR-010](Decisions.md#adr-010)), multiplayer infrastructure (an entire discipline; awareness only), and marketing at scale.

**The honest summary:** at the end you will not have made a AAA game. You will have the craft, the pipeline discipline and the shipped evidence to work on one — or to make something small and excellent on your own, which is the harder and rarer achievement.

**5 — Cost.** 32 chapters added, **258 → 290**. Pacing ~430–480 h → **~470–530 h**. Module 10 grew most (13 → 19) because that is where professional practice concentrates.

**6 — One caveat I cannot remove.** [`[UNVERIFIED]`](../internal/VerificationRuns.md) applies to this whole document. I cannot install or run any of these libraries ([ADR-016](Decisions.md#adr-016)). Versions, current maintenance status, real C# ergonomics and actual mobile cost must be checked **by you at the point of adoption** — which is exactly the exercise in step 2 anyway, so the constraint and the pedagogy happen to point the same way.

### Related
[ADR-028](Decisions.md#adr-028) · [ADR-029](Decisions.md#adr-029) · [ADR-030](Decisions.md#adr-030) · [`../Toolchain.md`](../Toolchain.md) · [PLAN §3c, §3d](../PLAN.md) · [PROMPT#7](../../PROMPTS.md)

### Action taken
New document [`../Toolchain.md`](../Toolchain.md). Three ADRs added. ToC gained 32 chapters including 28 🧰 adoption chapters and 6 professional-practice chapters. `PLAN.md` gained §3c and §3d. `Practicals.md`, `CourseState.md`, `CompactContext.md`, `CLAUDE-MEMORY.md`, `README.md` and `ToDos.md` (T-023) updated.

### In my own words
*(yours to fill in)*

---

## D-008

**Date:** 2026-09-02 · **Context:** Immediately after the toolchain audit ([D-007](#d-007)) · **Category:** Godot/C# · **Status:** ✅ Answered

### Question *(verbatim)*
> 1. So do you mean, if we make this course for gdscript or C++ instead of having only c#, then we will be having more number of publicly available free libraries/plugin we can adopt to our course?
> 2. Also is it possible to develop (at anytime) a single game with scripts written in all three languages (C++, C# and GDScript - optionally if developer finds useful), just asking? Like multi-language development for one game goal approach?

### Short answer
**1.** Partly — and I need to correct something I implied. **GDScript has far more Godot *addons*; C# has vastly more *general-purpose* libraries via NuGet; C++ has the most performance headroom.** Three different answers, not a ranking. Crucially, **choosing C# does not lose you the GDScript addons** — they are nodes, you call them. You lose *ergonomics*, not *access*.
**2.** **Yes, and it is normal practice.** Godot's .NET build runs GDScript and C# side by side, and a C++ GDExtension class registers as an engine type both languages can use. Now recorded as [ADR-031](Decisions.md#adr-031) with two new chapters.

### Full answer

**Part 1 — "more libraries" has three answers.**

| | GDScript | C# | C++ (GDExtension) |
|---|---|---|---|
| **Godot addons** (Asset Library, editor plugins) | 🥇 **Overwhelmingly the most** — the Asset Library is a few thousand entries, mostly GDScript | 🥉 Almost none written *in* C# | 🥈 Few, but the heavyweights: Terrain3D, Voxel Tools, LimboAI, Debug Draw 3D |
| **General-purpose libraries** | 🥉 **None.** No package manager, no ecosystem | 🥇 **NuGet — hundreds of thousands of packages** | 🥈 The whole C++ world, but each is real integration work |
| **Editor `@tool` scripts** | 🥇 Best integration, no build step | 🥈 Works, slower loop | 🥉 Overkill |
| **Static typing / refactoring** | 🥉 | 🥇 | 🥇 |
| **Raw performance** | 🥉 | 🥈 | 🥇 |
| **Android maturity** | 🥇 Longest-travelled, smallest APK | 🥉 Newer, larger APK (ships the .NET runtime) | 🥈 Mature, compile per ABI |

**⚠️ The correction.** [ADR-029](Decisions.md#adr-029) said most Godot addons are GDScript and that this costs you. True — but easy to read as *"C# can't use them."* **It can.** They are nodes and scripts; you instantiate them and call them from C#. What you lose is type safety and autocomplete **at the seam**. The distinction matters: the first reading would justify switching languages, and the second one does not. [ADR-031](Decisions.md#adr-031) records the correction.

**So the real trade is:** GDScript trades away a general-purpose ecosystem for the most convenient access to Godot-specific addons. C# trades away addon ergonomics for NuGet, static typing and a transferable skill. C++ trades away iteration speed for performance.

**Would I switch the course?** No — and this is genuinely the last cheap moment to, since zero chapters are written, so it is worth stating the case honestly rather than just defending the earlier decision.

*What switching to GDScript would gain:* frictionless addon use, faster iteration (no build step), smaller APKs, and the better-travelled Android path — [ADR-022](Decisions.md#adr-022) is a real cost you are paying.
*What it would lose:* NuGet, static typing and IDE refactoring across a 292-chapter project, and the transferable skill you asked for in your first prompt. Given [ADR-030](Decisions.md#adr-030) — professional/industry-grade craft is the goal — typing and testability matter more here than addon convenience, and the addon gap is bounded and now mitigated. **Say the word if you disagree; the cost of changing rises steeply from chapter one.**

**Part 2 — yes, all three in one game.**

Godot's .NET build runs **GDScript and C# in the same project simultaneously**, and a **GDExtension (C++) class registers as an engine class visible to both**. Terrain3D is the everyday proof: written in C++, used from GDScript and C# alike. This mirrors the rest of the industry — Unreal pairs C++ with Blueprints, Unity pairs C# with native plugins.

*How they talk:*

| Direction | Mechanism | Cost |
|---|---|---|
| C# ↔ GDScript | Signals, `Call()`, `Get()`/`Set()`, `GetNode<T>()` | Variant marshalling per call; **no compile-time checking** |
| C# ↔ C++ (GDExtension) | The C++ class *is* an engine type | Cheap and **fully typed** — why GDExtension addons have the best C# story |
| GDScript ↔ C++ | Same | Cheap |

*The four real costs, which the course teaches rather than hides:*

1. **Marshalling at the boundary.** Fine at low frequency, bad in a per-frame loop. Cross a boundary **once per frame, never once per entity per frame**.
2. **Two of everything** — idioms, debuggers, conventions. For a solo developer, a genuine tax.
3. **C++ means compiling per Android ABI** (arm64-v8a, armeabi-v7a, x86_64…). A real chore and a build-server problem.
4. **Lost type safety exactly at the seams**, which is where bugs hide.

⚠️ **Cross-language *inheritance* is not supported** — GDScript cannot extend a C# class or vice versa. `[UNVERIFIED]` for your exact version; the advice holds either way: **compose at the boundary, never inherit across it.**

*The heuristic now baked into the course* ([ADR-031](Decisions.md#adr-031)):

| Language | For | Not for |
|---|---|---|
| **C#** *(primary)* | Gameplay systems, architecture, data, saves, tests | Quick editor scripts |
| **GDScript** *(secondary)* | `@tool` editor scripts, UI glue, **consuming and patching addons** | Core architecture |
| **C++ / GDExtension** *(last resort)* | A **measured** hot path, or wrapping a native library | Anything before profiling |

**The rule that makes it safe:** every boundary lives in **one place** — one wrapper file per GDScript addon exposing a clean C# interface; one GDExtension module with a narrow documented API.

**Practical consequence for you.** When you find a GDScript-only addon you want, you have three options in increasing cost: use it from C# and accept the friction · wrap it behind a C# interface (usually an hour) · read it and reimplement the 200 lines you actually need. The [ADR-028](Decisions.md#adr-028) evaluation makes that a deliberate choice rather than a default.

### Related
[ADR-031](Decisions.md#adr-031) · [ADR-029](Decisions.md#adr-029) · [ADR-022](Decisions.md#adr-022) · [`../Toolchain.md` §4b–§4c](../Toolchain.md) · [PLAN §3c](../PLAN.md)

### Action taken
[ADR-031](Decisions.md#adr-031) added. `Toolchain.md` gained §4b (the three-way language comparison) and §4c (using all three in one game). Two chapters added — **0.10b** *GDScript, C# and C++ in one project* and **10.1b** *Polyglot architecture: where the boundary goes*; **12.4** and **12.5** expanded. Course 290 → 292.

### In my own words
*(yours to fill in)*

---

## D-009

**Date:** 2026-09-02 · **Context:** Immediately after [D-008](#d-008) · **Category:** Course logistics · **Status:** ✅ Answered

### Question *(verbatim)*
> Ok. Plan this course with all three (c++, C# and GDScript) languages not just C#. Plan wisely. And adopt ALL the libraries and ALL the plugins (we explored [for both blender and godot] just before) in the course plan. REMEMBER: STRICTLY LEARNING BY DOING APPROACH. Restructure all the course documents wisely without compromizing the quality.

### Short answer
Done — **333 chapters**, and the two hard parts were solved by design rather than by addition. Languages are taught by **building the same cube three ways and measuring it yourself** (Module 0 block 0B), so you *derive* the decision table rather than being handed it. Libraries are **clustered into doing-sessions** rather than given a chapter each, which is what stops "adopt everything" turning the course into a catalogue.

### Full answer

**The two design problems, and how each was solved.**

*Problem 1 — teaching three languages naively triples the work and teaches none of them well.* Solved by **teaching by role and by measurement**, not in parallel. Module 0 gains a new block **0B — The four languages you will write**:

| Chapter | You build | You measure |
|---|---|---|
| 0.10 | The cube in **GDScript** — six lines, no build step | Edit→see time |
| 0.11 | The cube in **C#** — `partial`, class-name rule, `[Export]` | The same, now with a build |
| **0.12** ⭐ | *(nothing new — you compare)* | Build time · APK size · LOC · iteration speed |
| 0.13 | The cube as a **C++ GDExtension node** — `godot-cpp`, SCons | How long the toolchain honestly took |
| 0.14 | That node **on your phone** — per-ABI builds, `.gdextension` | APK delta; does it run |
| **0.15** ⭐ | *(the three-way comparison)* | Everything, on **your** hardware |
| 0.16 | **GDShader** — a one-line fragment shader | That it is a different kind of thing entirely |
| **0.17** | **The decision table — written by you, from your numbers** | Used for the next 300 chapters |

Any course can assert *"C++ is faster, GDScript iterates quicker."* A number you produced on your own phone is one you believe, remember, and can defend — and you will notice when it stops being true for your hardware or Godot version. That is the difference between learning by doing and being told.

⚠️ **0.13–0.14 will take an afternoon and feel disproportionate.** Deliberate. You will not touch C++ again until Module 10; doing the toolchain once now, when nothing depends on it, means Module 10 is about *performance* rather than about SCons.

**Where each language actually lives** (full detail in [`../Languages.md`](../Languages.md)):

- **C#** — ~180 chapters. Systems, architecture, data, saves, tests.
- **GDScript** — **8 chapters where it is genuinely the right choice**, not token ones: `@tool` animation validator (4.2b), `@tool` level validator (5.9b), a full editor plugin with a custom dock (10.10b), consuming Panku Console from C# (1.31b), evaluating Dialogue Manager/Dialogic (8.10b) and Beehave (11.6b), and the wrapper pattern (10.6b).
- **C++/GDExtension** — **7 chapters, all earned.** The centrepiece is **10.1e — the measured rewrite**: take one profiled hot path, implement it GDScript → C# → C++, benchmark each step **on the phone**, and decide where to stop. That chapter is what makes *"use C++ only after profiling"* a fact you have proven rather than a slogan you were given.
- **GDShader** — Module 6's twelve chapters, now introduced in 0.16 so it is not a surprise.

*Problem 2 — adopting ~50 libraries naively adds ~50 chapters and produces a tool catalogue*, which is the exact opposite of [ADR-002](Decisions.md#adr-002). Solved by **[ADR-032](Decisions.md#adr-032): cluster by session, not by tool.** Where several small tools share a purpose they get **one chapter in which each is used once, on your own asset**:

| Cluster | Covers |
|---|---|
| **B5b** | LoopTools · Bool Tool · 3D-Print Toolbox · Extra Objects · Copy Attributes |
| **B15b/c/d** | Poly Haven · ambientCG · BlenderKit · Material Maker · Krita · GIMP · Inkscape |
| **5.2b/c** | A.N.T. Landscape · Sapling · Cell Fracture · Blender GIS |
| **4.4c** | HTerrain · Zylann Voxel Tools |
| **B29b · B31b · B34c · B41b** | Rokoko · Mixamo converters · MakeHuman · MB-Lab · Instant Meshes · Cascadeur |
| **1.13b/1.16b/1.31b/1.33b** | Jolt · Input Helper · Panku Console · System.Text.Json |
| **9.7c/10.10b/9.10c** | MemoryPack · MessagePack · a GDScript editor dock · the rest of Chickensoft |
| **6.20b · 6.4b · 7.19b · 7.24c · 0.20 · 11.14b · 11.3b** | OBS · scrcpy · Ardour · Inkscape · Blender VSE · Git Plugin · GodotEnv · Play Games/Billing · Sverchok · Animation Nodes |

Every cluster chapter is still a **doing** session — each tool used once on real content — and every one still sits *after* the manual technique it accelerates ([ADR-028](Decisions.md#adr-028)). MACHIN3tools after manual hard-surface work. The asset browsers after you have sourced and licence-checked by hand. Instant Meshes after hand retopology.

**One genuinely useful accident:** **B31b** (MakeHuman + MB-Lab) becomes a **live case study in evaluation question #2** — MB-Lab's maintenance has been patchy, so it is a real example of deciding what to do with a useful but under-maintained addon, rather than a hypothetical one.

**Cost, stated plainly.** 41 chapters added, **292 → 333**. Pacing ~470–530 h → **~540–620 h**. Modules 0 (21→ from 14), 4, 9 (27) and 2 (34) grew most. That is a long course — but it is the course you asked for, and the clustering is what stops it being a much longer and much worse one.

**What I did *not* do, and why.** I did not make GDScript or C++ co-primary. Spreading ~180 gameplay chapters across three languages would have taught three languages shallowly and none well, and would have contradicted [D-008](#d-008), where the case for keeping C# primary was made and accepted. Each language is scoped to the jobs it is clearly best at, and the boundary rule — **every seam in one wrapper file** — is what keeps four languages from becoming four sets of problems.

### Related
[ADR-001](Decisions.md#adr-001) *(revised)* · [ADR-031](Decisions.md#adr-031) · [ADR-032](Decisions.md#adr-032) · [`../Languages.md`](../Languages.md) · [`../Toolchain.md` §7b](../Toolchain.md) · [PLAN §3c-2](../PLAN.md)

### Action taken
New document [`../Languages.md`](../Languages.md). [ADR-001](Decisions.md#adr-001) revised to four languages; [ADR-032](Decisions.md#adr-032) added. Module 0 restructured into blocks 0A/0B/0C (14 → 21 chapters). 41 chapters added across all modules including the Module 10 C++ block (10.1c–10.1f). `Toolchain.md` gained §7b (coverage guarantee). `PLAN.md` gained §3c-2 and a refreshed pacing table. `CourseState.md` tracker regenerated. `Practicals.md`, `README.md`, `CompactContext.md`, `CLAUDE-MEMORY.md` updated.

### In my own words
*(yours to fill in)*

---

## D-010

**Date:** 2026-09-02 · **Context:** An external review of the plan (ChatGPT), supplied as `godot-course-review.md` · **Category:** Course logistics · **Status:** ✅ Answered

### Question *(verbatim)*
> can you read /root/claude/godot-zero-to-hero/godot-course-review.md (from chatgpt) and deeply analyze and figure-out which of these points are worth to consider in our course? I STILL INSIST on LEARNING BY DOING approach (with theory and explanation needed on demand). Please analyze from your side and give your comments.

### Short answer
**The review is substantially right and worth acting on.** I verified its factual claims first: it caught **a live bug I had introduced** (a stale counts table), a **real design error** (starting on Forward+ then migrating to Mobile), and a genuine **total absence of Android lifecycle coverage**. Both defects are fixed. Full point-by-point triage: [`ReviewTriage.md`](ReviewTriage.md). Its single most valuable point also names a failure of mine: I optimised for coverage instead of independent capability.

### Full answer

**First, verification rather than agreement.** The review makes specific factual claims about the repository, so I checked them before assessing any argument:

- *"README says 333 builds, another section says 292"* — **true, and my bug.** `Practicals.md`'s per-module table still totalled 292/30 after the last restructure; I had updated the summary rows and missed the breakdown. **Fixed.**
- *"Forward+ then switch to Mobile"* — **true, and a real design error** in an Android-first course. Beginning on the renderer you do not ship on manufactures a migration that finds problems late. **Fixed:** P00 starts on Mobile, and 5.13 became a *comparison* rather than a port.
- *"No Android lifecycle coverage"* — **true.** `grep` for lifecycle / backgrounding / process-death / ANR / battery returned **nothing** across 333 chapters. The largest content gap in the plan.
- *"No git branching or bisect"* — **true.**
- *"Blender numbering B0–B19 vs B42"* — **was** true; that README line has said `B1–B42` since the restructure. The review read a partly stale snapshot on that one point.

**Second, the systemic criticism — and my own failure.** The review's closing line is the most valuable thing anyone has said about this plan:

> *"Do not optimize for the number of chapters. Optimize for the number of capabilities you can demonstrate independently."*

Across four consecutive turns the plan went **215 → 258 → 290 → 292 → 333** chapters. Each turn answered a legitimate request, and I stated the cost each time — **but not once did I propose removing anything.** Somewhere around hour 500 a careful collaborator should have asked *"what comes out?"* I did not. That is a failure of judgement, not of taste.

Its concrete form is **[ADR-032](Decisions.md#adr-032)** — *"every catalogued library gets a chapter that uses it"* — which was the wrong answer to *"adopt all the libraries."* The right answer is the review's §3: **some tools deserve a chapter, some a paragraph, some only "this exists."** Revising ADR-032 **removes** chapters.

**Third, what I am adopting** (detail in [`ReviewTriage.md` §2](ReviewTriage.md)): the **scaffolding gradient** (90/10 guided → 10/90 independent) and **blank-page builds**, which together are the load-bearing fix; a dedicated **Android runtime engineering** block (lifecycle, chaos test, input beyond touch, fragmentation); **thermal soak, battery, memory-pressure and GPU bottleneck taxonomy**; **explicit performance budgets and a device tier matrix**; a **version matrix** with upgrade discipline; **debugging as a taught skill**; **git branching, CI, testing, playtesting and profiling all starting earlier and growing** — which is our own three-pass spiral, applied to engineering practice, where we had failed to apply it; **crash and ANR monitoring**; **priority tiers** L1/L2/L3; and three additions to the chapter loop — **Observe**, **Diagnose before theory**, and **Reflection**.

**Fourth, where I adapt rather than adopt.** The review says C++ in Module 0 is excessive cognitive load. **It is right, and that was my error** — but the fix is *resequencing*, not removal, because you explicitly asked for all three languages. The GDScript-vs-C# measured comparison **stays** in Module 0 (both trivial, no toolchain); the C++ leg moves to Module 10 beside `10.1e`, the measured rewrite, where it already has an earned trigger. The "measure it yourself" pedagogy survives; the afternoon of SCons moves to where it is motivated.

Similarly, its C# foundations point is right for 🐣 Path A but assumes a true beginner. You are a C/C++-solid, Python-strong embedded engineer, so the micro-track is scoped to **C#-specific** things — properties, `partial`, attributes, delegates/events, LINQ, generics, `async`, nullable references, records — not to variables and methods.

**Fifth, where I disagree.** Its *"actual completeness: 4/10"* scores us on the completeness of something we have explicitly not started. `CourseState.md` states *Phase 1 — planning · 0/333 published · plan awaiting your review*, and that is the case **because you asked for the plan first and then asked to review it before any chapter was written.** The observation is correct; folding a 4/10 into the headline verdict is a category error. Its "GDShader should come later" is also already true — it is Module 6; only one first-contact chapter is early.

**Sixth, the net effect is smaller, not larger.** Roughly **315–325 chapters**, because demoting L3 tools to awareness removes 12–18 and the Android/measurement additions cost about 20. The gain is that ~40 tool-tour chapters become ~30 chapters of Android engineering, measurement, debugging and independent building.

**Seventh, the thing the review understates.** It treats scaffolding removal as a delivery detail. **It is the load-bearing fix.** Every chapter currently written into the plan is guided; the four mini-jams are the only unscaffolded work in 333 chapters. A course whose entire premise is learning by doing has **no gradient toward doing it alone**. Independent capability is not a by-product of finishing guided chapters — it must be built by removing help on a schedule. That deserves its own ADR with a declared percentage per module, for the same reason [ADR-002](Decisions.md#adr-002) got numeric thresholds: a gradient you can check beats an intention you can drift away from.

**Two questions returned to you**, because they contradict instructions you gave emphatically: the **presentation spine's scope** (§20) and the **capstone's size** (§34). I will not silently reverse either.

### Related
[`ReviewTriage.md`](ReviewTriage.md) · [ADR-032](Decisions.md#adr-032) · [ADR-026](Decisions.md#adr-026) · [ADR-019](Decisions.md#adr-019) · [ADR-002](Decisions.md#adr-002)

### Action taken
`Practicals.md` counts table repaired. `Setup_05` and ToC `5.13` switched to Mobile-first. New [`ReviewTriage.md`](ReviewTriage.md) with the full point-by-point triage. Restructure pending your answers on the two ⏸️ items.

### In my own words
*(yours to fill in)*

---

## D-011

**Date:** 2026-09-02 · **Context:** Applying the review triage; the learner asked for the capstone question to be explained properly · **Category:** Course logistics · **Status:** ✅ Answered

### Question *(verbatim)*
> I don't understand this question. Please explain in detail and ask me again.

*(In response to: "§34 says the capstone is too large, and prefers one excellent vertical slice. ADR-019 currently locks 4 short levels.")*

### Short answer
Fair — **"vertical slice" is industry jargon and I used it without defining it.** A vertical slice is a *narrow* piece of the game finished to *final* quality through every layer — art, audio, UI, narrative, polish — as opposed to building all four levels roughly and polishing later. The question was really: **where is the finish line?** You chose **all four levels**, and that stands.

### Full answer

**The metaphor.** Picture the game as a layer cake: gameplay systems → art → animation → audio → UI → narrative → polish.

- A **horizontal** approach builds one layer across the whole game: rough out all four levels, *then* art-pass all four, *then* audio-pass all four.
- A **vertical slice** cuts down through **every layer** for a narrow width — one level, fully finished. You can hand it to a stranger and they experience what the finished game *feels* like. It is what studios show publishers.

**What the question actually decided** — not how many levels you are allowed to build, but **when the course counts as complete**:

| | Slice ships | Four levels ship *(your choice)* |
|---|---|---|
| "Complete" means | Level 1 final-quality + boss + intro + ending + credits + settings + released | All four levels finished + released |
| Playtime | ~8–10 min | ~25 min |
| Extra hours | — | **+60–90 h** |
| Levels 2–4 | Optional post-release expansion | Required before release |

**The argument for the slice**, which you have now heard and set aside: levels 2–4 teach almost nothing new. Once level 1 is finished to final quality you have used every skill in the course — modelling, rigging, lighting, shaders, audio, AI, narrative, optimisation, release. Levels 2–4 are pure production, and production is where solo projects most often stall: 500 hours in, systems all working, and the person burns out on level 3 with nothing ever released.

**Your decision: four levels.** Recorded as a reaffirmation of [ADR-019](Decisions.md#adr-019), and **not to be revisited.** A 25-minute game is a materially better portfolio piece than a 10-minute one, and production stamina is itself a real skill.

**The mitigation I have added**, because the risk is real even though the decision is yours: **the vertical slice becomes a milestone rather than the ship target.** Level 1 must reach final quality and be validated on device *before* levels 2–4 begin. If appetite runs out at level 3, there is still a complete, releasable game behind you rather than four half-finished ones.

### Related
[ADR-019](Decisions.md#adr-019) · [ADR-035](Decisions.md#adr-035) · [`ReviewTriage.md` §3](ReviewTriage.md)

### Action taken
[ADR-019](Decisions.md#adr-019) reaffirmed with the vertical-slice-as-milestone mitigation. Capstone scope unchanged at four levels plus boss.

### In my own words
*(yours to fill in)*

---

## D-012

**Date:** 2026-09-02 · **Context:** Re-asking the capstone question after [D-011](#d-011) explained "vertical slice" · **Category:** Design/Narrative · **Status:** ✅ Answered

### Question *(verbatim)*
> I choose option 2. Ship after level 1. But Level 2 to 4 are mandatory, not optional. I do not compromize on the features, intermediate steps and quality. Please restructure the course accoding to this.

### Short answer
This is a **staged release** model, and it is a better answer than either option I offered. You took the *sequencing* change and rejected the *scope* reduction: the game goes public **four times** — v1.0 after Level 1, then v1.1–v1.3 as Levels 2, 3 and 4 ship as real updates — with all four levels mandatory and no quality bar moved. Module 11 is restructured around it and gains a **live-operations block** that the ship-once model could not have taught.

### Full answer

**What you actually chose.** I offered a scope reduction (ship one level, make 2–4 optional) or the status quo (build all four, then ship once). You took neither and produced a third: **ship early *and* keep everything.**

| Release | Contains | What it teaches |
|---------|----------|-----------------|
| **v1.0** | Level 1 at final quality, boss systems, narrative frame, settings, accessibility | Shipping |
| **v1.1** | Level 2 | **Save migration across shipped versions** · staged rollout |
| **v1.2** | Level 3 | Acting on real crash data and real feedback |
| **v1.3** | Level 4 + boss, content lock | Finishing |

**Why this is genuinely better than what I proposed** — three reasons, and I want to be clear that I did not think of it:

1. **It de-risks without compromising anything.** The commonest way a solo project dies is 500 hours in with nothing released. After v1.0 that failure mode is simply gone, and every hour after it is additive rather than load-bearing. My "make 2–4 optional" version bought the same safety by *giving something up*. Yours does not.
2. **It teaches a discipline the ship-once model structurally cannot.** A game released once never exercises **patching live software** — save migration across released versions, staged rollout and rollback, crash triage from strangers' devices whose logs you will never see, release notes, hotfix branches, and triaging feedback from people who are not you. That is now **Module 11D**, six chapters that would not have existed under either of my options.
3. **Levels 3 and 4 get built with evidence.** Real telemetry and real reviews from v1.0 and v1.1 shape them, instead of guesswork.

**The one thing this makes critical**, and it is new: **chapter 11.8b — *designing for content you have not built yet***. The level format, the spawn data, and above all the **save schema** must be right *before* v1.0 goes out, or v1.1 is a rewrite rather than an update. Under ship-once this chapter would not have needed to exist, because there is no "before". Under your model the whole plan rests on it.

**Module 11 restructured** into six blocks: **11A** pre-production and the release plan · **11B** systems built once and used by every level · **11C** 🚢 v1.0 — Level 1 to final quality and out the door · **11D** live operations · **11E** 🚢 v1.1–v1.3, the remaining levels as staged updates · **11F** upgrade discipline, walkthrough, post-mortem, portfolio reel.

**Cost:** Module 11 grows 32 → 43 chapters; the course goes **348 → 359**; pacing to roughly **580–670 hours**. Nothing was cut, exactly as you asked.

**New done-criteria on P10:** a v1.0 save file must load correctly in v1.3, verified; and at least one hotfix shipped in response to a real crash report.

### Related
[ADR-019](Decisions.md#adr-019) *(rewritten)* · [D-011](#d-011) · [`../../projects/README.md`](../../projects/README.md) · [PLAN §3a-2](../PLAN.md)

### Action taken
[ADR-019](Decisions.md#adr-019) rewritten as a staged-release model. Module 11 restructured into 11A–11F with the new live-operations block (11.21–11.26) and 11.8b. `CourseState.md` regenerated with four release milestones. `PLAN.md` §3a-2 added; `projects/README.md`, `README.md`, `CompactContext.md`, `CLAUDE-MEMORY.md` updated.

### In my own words
*(yours to fill in)*

---

## D-013

**Date:** 2026-09-02 · **Context:** After chapters 0.1–0.4 were published Linux-first · **Category:** Setup/Install · **Status:** ✅ Answered

### Question *(verbatim)*
> I want to have one correction. My Workshop setup will be either windows 11 or Ubuntu/WSL. I should be able to proceed this course on both kind of machines as my workshop system. Possible for you to think and make necessary changes accordingly in this course?

### Short answer
**Yes for Windows 11 and native Linux — both are now fully supported, and chapters 0.1–0.4 give commands for each.** But **not for WSL2 as the workshop**, and that is a technical blocker rather than a preference: **WSL2 has no USB passthrough, so `adb` cannot see your phone from inside it.** Since deploying to a device is this course's core loop, that is disqualifying. Use **Windows natively for the tools, WSL as a companion shell** — the recommended split is in [`../reference/Platforms.md`](../reference/Platforms.md).

### Full answer

**The three configurations, and the verdict on each.**

| | A — Windows 11 native | B — Linux native | C — inside WSL2 |
|---|---|---|---|
| Godot editor | ✅ | ✅ | ⚠️ WSLg; Vulkan via a translation layer |
| Blender | ✅ | ✅ | ⚠️ GPU rendering unreliable |
| .NET SDK · Android SDK | ✅ | ✅ | ✅ |
| **`adb` over USB** | ✅ (OEM driver) | ✅ (`udev` rule) | ❌ **no USB passthrough** |
| **Verdict** | ✅ **Supported** | ✅ **Supported** | ❌ **Not a workshop** |

**Why WSL2 fails, in order of severity.**

1. **No USB passthrough — the fatal one.** WSL2 is a virtual machine with no direct access to USB devices. There is no setting to change; it is architectural. `usbipd-win` forwards USB over IP and needs an elevated `usbipd attach` after every replug and reboot; alternatively you run `adb` on Windows and point WSL's `ADB_SERVER_SOCKET` at it, and now you maintain two `adb` installations that must stay version-matched. Both work. Both are real solutions to a problem you can avoid by not creating it — and you will deploy to the device *thousands* of times ([ADR-005](Decisions.md#adr-005), [ADR-034](Decisions.md#adr-034)).
2. **Graphics go through a translation layer.** Godot 4 wants Vulkan; WSLg provides it through a Direct3D shim rather than your vendor's driver. Blender's GPU rendering is unreliable there, and you need it for bakes from Module 4. **You will spend 500+ hours in those two editors** — neither should be running through a compatibility layer.
3. **The filesystem boundary is slow** in the direction that matters — fine for git and text, not fine for an engine importing a thousand assets.

**The recommended Windows setup is a hybrid, and it is genuinely good:**

```text
🪟 Windows 11 (workshop)            🐧 WSL2 (companion shell)
   Godot · Blender · .NET SDK          git · ffmpeg · ImageMagick
   JDK · Android SDK · adb             shell scripts · docs
   project files  ───────────────────► reachable at /mnt/c/...
```

Four rules keep it clean: the project lives on the **Windows** filesystem · WSL reaches it at `/mnt/c/...` · **`adb` runs on Windows only** · **never run the Godot or Blender editor inside WSL**.

Keeping WSL is worth it — `ffmpeg`, `ImageMagick`, `sed` and a real shell are genuinely nicer than the PowerShell equivalents, and this course uses all of them (chapters **B12b**, **6.18b**).

**One new hazard this creates, and it is a real one.** Windows filesystems are **case-insensitive**; Android's are **not**. A project that happily loads `res://Textures/rock.png` when the file is actually `res://textures/Rock.png` will run perfectly on your Windows desktop and fail on device with missing textures. **A game that works on desktop and has missing textures on the phone is almost always this.** Be strict about case from chapter one.

**What changed in the repository.** New [`../reference/Platforms.md`](../reference/Platforms.md) (the configuration matrix, the WSL analysis, the recommended hybrid, and a per-chapter gotcha table). New [ADR-036](Decisions.md#adr-036); [ADR-004](Decisions.md#adr-004) revised. Chapters **0.1–0.4 all now carry paired 🪟/🐧 command blocks** — PowerShell alongside bash for every step, plus the Windows-specific traps: `Unblock-File` on downloaded archives before Defender quarantines `GodotSharp/`, `setx` needing a new terminal, and `%APPDATA%\Godot\export_templates`. Setup guides 01–04 updated to match.

### Related
[ADR-036](Decisions.md#adr-036) · [ADR-004](Decisions.md#adr-004) · [D-001](#d-001) · [`../reference/Platforms.md`](../reference/Platforms.md)

### Action taken
`Platforms.md` created. ADR-036 added, ADR-004 and D-001 revised. Chapters 0.1–0.4 made dual-platform. `Machines.md` gained a workshop-config row.

### In my own words
*(yours to fill in)*

---

## D-014

**Date:** 2026-09-02 · **Context:** Working chapter 0.3, Step 2 and Step 6 · **Category:** Blender · **Status:** ✅ Answered — **three authoring errors found and fixed**

### Question *(verbatim)*
> In Chapter 0.03, Step2, I couldnot find "Clip Start" in Viewport and I couldn't find "Extra Objects" and "Copy Attributes Menu" in Add-ons. And In GoDot, I don't see that the cube is taking exactly 3 units in the 3d viewport, also I cannot verify from inspector window. Please refer toAgent/1.jpg and toAgent/2.jpg and toAgent/3.jpg

### Short answer
**All three were my errors, not yours.** Clip Start is not in Preferences at all — it is per-viewport, in the `N` sidebar's View tab. Extra Objects and Copy Attributes Menu are **no longer bundled** in Blender 4.2+; they moved to Extensions, and nothing in this course needs them. And the cube check was simply the wrong method — Godot's grid subdivides with zoom, and the Inspector shows the imported `Node3D` root's transform, not the mesh's size. Chapter 0.3 and Setup 03 are corrected; the verification now uses a `GetAabb()` script.

### Full answer

**Error 1 — Clip Start is not a preference.** *(`toAgent/1.png`)* Your screenshot shows Preferences → Viewport containing exactly four sections: Display, Quality, Textures, Subdivision. **No Clip Start.** It is a **per-viewport, per-file** setting, found at `N` → **View** tab in the 3D viewport. That also explains why it matters that you set it *before* saving the startup file — otherwise it does not follow you into new files. Chapter 0.3 gained a **Step 2b** for it.

**Error 2 — the add-on list was three versions out of date.** *(`toAgent/2.png`)* Blender 4.2 introduced the **Extensions** system and cut the bundled add-on list to seven:

```text
Cycles Render Engine · glTF 2.0 format · Hydra Storm · Manage UI translations
Node Wrangler · Pose Library · Rigify · VR Scene Inspection
```

**Extra Objects and Copy Attributes Menu are not among them** — they are now Extensions, installable from **Get Extensions** in the sidebar. **Nothing in this course requires either; I over-specified.** The corrected chapter tells you to enable exactly one thing (**Node Wrangler**), confirm **glTF 2.0** is on, and *leave Rigify off* until **B24b** — where you enable it only after hand-building an armature ([ADR-028](Decisions.md#adr-028)).

Your screenshot is also a small bonus: it confirms **Rigify ships built in**, which is the free industry-standard rig generator and a load-bearing part of Module 4.

**Error 3 — the measurement method was wrong, twice over.** *(`toAgent/3.png`)*

1. **"Count 3 grid squares" does not work.** Godot's 3D grid **subdivides with zoom** — it is a navigation aid, not a ruler.
2. **The Inspector cannot show you this.** Your screenshot shows the imported node is a **`Node3D`**, not a `MeshInstance3D`. A `.glb` imports as a whole *scene*: a `Node3D` root with the mesh as a **child**, and Godot hides an instanced scene's children in the Scene dock. The Inspector was showing the root's transform — Scale `1,1,1`, Position `1.5,0,0` — which says nothing about the mesh's size. **You were right that it could not be verified there.**

The chapter now gives two working methods: **Method A**, a short C# script using `FindChildren(..., owned:false)` and `GetAabb().Size` to print the real dimensions — which reuses the C# you got working in 0.2; and **Method B**, adding a `BoxMesh` set to `3,3,3` and comparing visually.

**What your screenshots also cleared, unprompted.** Three `[UNVERIFIED]` markers, now facts:

| Fact | Evidence |
|---|---|
| **Godot `v4.7.2.stable.mono.official`** — the .NET build does report itself as `mono` | Output banner |
| **`D3D12 12_0 — Forward Mobile`** works on an NVIDIA T600 Laptop GPU | Output banner — validates [ADR-010](Decisions.md#adr-010) and the Mobile-renderer instruction in 0.2 |
| **Workshop is Config A, Windows 11 native** | D3D12 in the banner — matches [ADR-036](Decisions.md#adr-036) |

**Why this is the protocol working rather than failing.** [ADR-016](Decisions.md#adr-016) exists because I cannot run Blender or Godot. Two of these three errors were marked `[UNVERIFIED]`; the third — the grid-counting instruction — was **not marked, and should have been.** I stated a measurement technique as fact without being able to check it. That is the more useful lesson: the marker discipline is only as good as my honesty about what I actually know.

### Related
[ADR-016](Decisions.md#adr-016) · [ADR-028](Decisions.md#adr-028) · [chapter 0.3](../chapters/Chapter_00.03_Blender.md) · [Setup 03](../guides/Setup_03_Blender.md) · [VerificationRuns](../internal/VerificationRuns.md)

### Action taken
Chapter 0.3: Clip Start moved to a new Step 2b; add-on list rewritten for Blender 4.2+; Step 6 verification replaced with the `GetAabb()` script and the BoxMesh comparison. Setup 03 corrected to match. Chapter 0.2's `mono` marker cleared. Three V-08/V-09 items cleared in `VerificationRuns.md`. `Machines.md` pre-filled with the confirmed Godot version, GPU and renderer.

### In my own words
*(yours to fill in)*

---

## D-015

**Date:** 2026-09-02 · **Context:** Working chapter 0.4, Step 3 · **Category:** Setup/Install · **Status:** ✅ Answered — **authoring gap, fixed**

### Question *(verbatim)*
> Thanks. In chapter 0.04, you asked me to execute the commands. "unzip ~/Downloads/commandlinetools-linux-*.zip -d ~/android-sdk/cmdline-tools" and "Expand-Archive "$env:USERPROFILE\Downloads\commandlinetools-win-*.zip" -DestinationPath "$sdk\cmdline-tools"". But you didn't tell me from where to download the commandlinetools zip file.

### Short answer
**Correct, and worse than you found.** Step 2 *did* name the page, but far too vaguely to follow — and the **Fast-Track Summary had no download step at all**, so a 🏃 Path C reader hits your wall with no recourse. Both fixed, plus two stale errors I found while in there.

**Where to get it:** <https://developer.android.com/studio> → **scroll to the very bottom** → heading **"Command line tools only"** → the row for your OS. Not the big green button at the top; that is Android Studio.

### Full answer

**What was actually wrong — three things, in order of severity.**

1. **The Fast-Track Summary had no download step whatsoever.** It opened with `sudo apt install openjdk-17-jdk` and went straight to `unzip ~/Downloads/commandlinetools-linux-*.zip`, silently assuming the file already existed. [ADR-024](Decisions.md#adr-024) says 🏃 Path C reads *only* the summary and the cheat sheet — so for that reader the chapter was simply broken. **The summary now opens with the download.**
2. **Step 2 named the page but not how to find the link on it.** *"Scroll past the big Android Studio button and find 'Command line tools only' near the bottom"* is not a procedure. That page is long, is redesigned periodically, and the section sits below release notes and system-requirement tables. It now has numbered navigation, the expected filename pattern, the expected size, and an explicit statement of what the **wrong** file looks like.
3. **No way to confirm you got the right file.** Added a check that reads the archive listing and looks for `cmdline-tools/bin/sdkmanager` before you extract anything.

**Two stale errors found while fixing it** — worth recording because neither was reported:

- The Fast-Track bullet said *"you are on Linux and will never open the IDE"*, which contradicted [ADR-036](Decisions.md#adr-036) — Windows became a first-class workshop earlier the same day, and this line was not updated with the rest. **A renumber or a policy change needs a grep for prose that assumed the old policy**, not just for the things that obviously reference it.
- It also said the command-line tools were **~1 GB**, while Step 2 said ~100 MB. The zip is **~100–150 MB**; the ~1 GB figure is what `sdkmanager` downloads *afterwards*. Two numbers for the same thing in one chapter is a defect regardless of which is right.

**The pattern across D-014 and D-015.** Both are the same failure in different clothes: **I wrote the reference material and the fast path separately, and the fast path silently lost a prerequisite.** The mandatory template ([`../chapters/README.md`](../chapters/README.md)) requires a 🏃 Fast-Track Summary that stands alone, and neither 0.4's summary nor 0.3's Step 2 was checked against that requirement. Going forward, the summary gets read as if it were the only thing on the page — because for one of the three paths, it is.

### Related
[ADR-024](Decisions.md#adr-024) · [ADR-036](Decisions.md#adr-036) · [D-014](#d-014) · [chapter 0.4](../chapters/Chapter_00.04_AndroidToolchain.md) · [Setup 04](../guides/Setup_04_Android_And_Device.md)

### Action taken
Chapter 0.4: download step added to the Fast-Track Summary; Step 2 rewritten with numbered navigation, filename pattern, expected size, wrong-file warning, direct-URL form and an archive verification; the stale Linux-only bullet and the 1 GB/100 MB contradiction fixed; *Before you start* and the cheat sheet both gained the download. Setup 04 corrected to match.

### In my own words
*(yours to fill in)*

---

## D-016

**Date:** 2026-09-02 · **Context:** Chapter 0.4, Step 6, on Windows · **Category:** Setup/Install · **Status:** ✅ Answered — **one setup issue, and one harmful command of mine**

### Question *(verbatim)*
> I have performed all these steps in curly braces {$sdk = "C:\D\ProgramFiles\android\sdk" … sdkmanager --licenses} and then I am getting below error {… keytool : The term 'keytool' is not recognized as the name of a cmdlet, function, script file, or operable program …}. I even tried reopening powershell

### Short answer
`keytool` lives in the **JDK's `bin` directory**, and nothing put that directory on your `PATH` — Temurin's installer does not reliably do it, and **my Step 4 never added it**. Immediate fix: call it by full path. But there is a second, worse problem: **the `setx PATH "$env:PATH;..."` command I gave you is harmful** and may have truncated your user `PATH`. Check and repair it.

### Full answer

**Part 1 — why `keytool` was not found.**

`keytool` ships with the JDK at `<JDK>\bin\keytool.exe`. Two things had to be true and neither was guaranteed: Temurin's *"Add to PATH"* feature does not reliably apply when installed via `winget` `[UNVERIFIED]`, and **my Step 4 added only the Android SDK's two directories** — the JDK was simply omitted.

**The diagnostic detail worth keeping:** `sdkmanager` worked and `keytool` did not, from the same shell. Not a contradiction — `sdkmanager.bat` finds Java through **`JAVA_HOME`** (or a bundled JRE); `keytool` is only ever found through **`PATH`**. **A working `sdkmanager` does not prove `keytool` is reachable.**

**Immediate unblock** — full path never depends on `PATH`:

```powershell
$jdk = (Get-Item "C:\Program Files\Eclipse Adoptium\jdk-17*").FullName
$jdk    # if empty, no JDK is installed — go back to Step 1

& "$jdk\bin\keytool.exe" -keyalg RSA -genkeypair -alias androiddebugkey -keypass android `
    -keystore "C:\D\ProgramFiles\android\debug.keystore" -storepass android `
    -dname "CN=Android Debug,O=Android,C=US" -validity 9999 -deststoretype pkcs12
```

**Part 2 — 🚨 my `setx PATH` command was harmful, and you ran it.**

```powershell
setx PATH "$env:PATH;$sdk\cmdline-tools\latest\bin;$sdk\platform-tools"    # ← what I told you to run
```

Two defects that compound:

1. **`setx` truncates at 1024 characters.** A typical Windows `PATH` exceeds that, so the write silently drops whatever falls off the end.
2. **`$env:PATH` is the *merged* Machine + User path, but `setx` writes only to *User*.** It copies the entire system path into your user path — duplicating everything and pushing the length past 1024 even if it was not before.

Together, your **User** `PATH` may now hold a truncated copy of the system path. **Your Machine `PATH` is untouched** — `setx` without `/M` cannot write to it — which is the one piece of good news.

**Check:**

```powershell
$u = [Environment]::GetEnvironmentVariable("Path","User"); $u.Length
$u -split ';'
```

Length at or near **1024**, a last entry cut off mid-word, or `C:\Windows\system32` appearing in your *User* path all indicate damage.

**Repair** — drop anything already present in the Machine path, then re-add your own:

```powershell
$machine = [Environment]::GetEnvironmentVariable("Path","Machine") -split ';'
$clean = ([Environment]::GetEnvironmentVariable("Path","User") -split ';' |
          Where-Object { $_ -and ($machine -notcontains $_) } | Select-Object -Unique) -join ';'
[Environment]::SetEnvironmentVariable("Path", $clean, "User")
```

**The correct method, now in the chapter** — User path only, idempotent, no length limit, JDK included:

```powershell
$sdk = "C:\D\ProgramFiles\android\sdk"
$jdk = (Get-Item "C:\Program Files\Eclipse Adoptium\jdk-17*").FullName

[Environment]::SetEnvironmentVariable("ANDROID_HOME", $sdk, "User")
[Environment]::SetEnvironmentVariable("JAVA_HOME",    $jdk, "User")

$user = [Environment]::GetEnvironmentVariable("Path","User")
foreach ($p in @("$sdk\cmdline-tools\latest\bin", "$sdk\platform-tools", "$jdk\bin")) {
    if ($user -notlike "*$p*") { $user = "$user;$p" }
}
[Environment]::SetEnvironmentVariable("Path", $user, "User")
```

Reopen PowerShell; all four must return something: `$env:ANDROID_HOME`, `$env:JAVA_HOME`, `Get-Command sdkmanager.bat`, `Get-Command keytool`.

**Part 3 — the finding that matters beyond this chapter.**

**Chapter 0.2 already did this correctly.** Its Godot PATH step reads `[Environment]::GetEnvironmentVariable('Path','User')` and writes back with `SetEnvironmentVariable`. Chapter 0.4, written in the same session, used `setx` with the merged path instead.

So this was not ignorance of the right method — it was **inconsistency between two chapters written hours apart**. A different failure from [D-014](#d-014) and [D-015](#d-015), and it argues for something neither of those did: **a shared snippet for any operation appearing in more than one chapter.** Environment variables, archive extraction and version checks now appear in three or four chapters each, and every duplicate is a chance to diverge. Recorded as [T-027](ToDos.md).

⚠️ **This is also the first defect in this course capable of damaging your machine rather than merely wasting your time.** Commands that modify system state deserve a different standard of care from commands that print things — and `[UNVERIFIED]` does not cover it, because I was not uncertain here. **I was wrong.**

### Related
[D-014](#d-014) · [D-015](#d-015) · [chapter 0.4](../chapters/Chapter_00.04_AndroidToolchain.md) · [chapter 0.2](../chapters/Chapter_00.02_GodotAndDotNet.md) *(which had it right)* · [Setup 04](../guides/Setup_04_Android_And_Device.md) · [T-027](ToDos.md)

### Action taken
Chapter 0.4: Fast-Track and Step 4 rewritten to use `[Environment]::SetEnvironmentVariable` with an idempotent User-path append; `JAVA_HOME` and `$jdk\bin` added; a 🚨 box explaining both `setx` defects; a collapsed check-and-repair procedure; Step 6 gained a full-path `keytool` fallback and the *"sdkmanager working does not prove keytool is reachable"* note; two troubleshooting rows. Setup 04 gained a matching §2b. [T-027](ToDos.md) opened for shared snippets.

### In my own words
*(yours to fill in)*

---

## D-017

**Date:** 2026-09-03 · **Context:** Chapter 0.13 Step 5, in the committed `projects/P00_HelloPhone` · **Category:** Godot/C# · **Status:** ✅ Answered — **authoring error, fixed**

### Question *(verbatim)*
> In Chapter 0.13, Step 5: I am getting "if (mesh.MaterialOverride is ShaderMaterial shaderMat)" condition false. Can you please review projects/P00_HelloPhone project source code (I kept in this repo) and figure out what is wrong and tell me?

### Short answer
**My chapter's fault.** A `MeshInstance3D` has **two** material slots in two different Inspector sections. Your `Main.tscn` shows the material in **`surface_material_override/0`**; the code checks **`MaterialOverride`**, a different property, which is `null`. Step 1's instruction named the wrong parent section and led you to the slot the Step 5 code does not read.

### Full answer

**The evidence, from your committed scene:**

```text
[node name="CubeGDShader" type="MeshInstance3D" ...]
mesh = SubResource("BoxMesh_q6c6o")
surface_material_override/0 = SubResource("ShaderMaterial_0u86m")   ← the material is here
```

**The two slots, and why the instruction misled:**

| Inspector section | Property in `.tscn` | Scope |
|---|---|---|
| **`MeshInstance3D`** → Surface Material Override → `0` | `surface_material_override/0` | One surface |
| **`GeometryInstance3D`** → Geometry → Material Override | `material_override` | The whole mesh |

The chapter said *"Inspector → `MeshInstance3D` → **Material Override**"*. **`Material Override` is not under `MeshInstance3D`** — it lives under `GeometryInstance3D`. And expanding `MeshInstance3D` shows **Surface Material Override**, which is the nearest match. The instruction pointed at a heading that does not contain the thing it named, so the reasonable interpretation was the one that broke the code.

**The fix — three fallbacks rather than one guess:**

```csharp
ShaderMaterial shaderMat =
    MaterialOverride as ShaderMaterial                  // whole-mesh override
    ?? GetSurfaceOverrideMaterial(0) as ShaderMaterial  // per-surface override  ← yours
    ?? GetActiveMaterial(0) as ShaderMaterial;          // whatever is actually in use

if (shaderMat is null)
{
    GD.PushError($"{Name}: no ShaderMaterial. MaterialOverride={MaterialOverride}, " +
                 $"SurfaceOverride0={GetSurfaceOverrideMaterial(0)}");
    return;
}
```

`GetActiveMaterial(0)` resolves the whole chain and returns whatever is genuinely in use — the right call when you do not control how a scene was authored. ⚠️ It can return a **shared** resource, so setting a parameter on it affects every mesh using it; that matters in [6.14](../TableOfContents.md), not here.

**Two things you did better than the chapter, worth keeping.**

1. You declared `public partial class CubeGdShader : MeshInstance3D`, so `this` **is** the mesh — `GetNode<MeshInstance3D>(".")` was never needed. My chapters used that idiom in both [0.11](../chapters/Chapter_00.11_CSharpFirstContact.md) and 0.13; both are now corrected to match what you did.
2. You added an `else` that printed `mesh.MaterialOverride`. **That is why this was diagnosable at all.** The chapter's version had no failure path, so a wrong slot produced silence — no error, no tint, no clue.

**The lesson I have written into the chapter**, because it generalises well beyond materials:

> **Any code that looks something up should say what it found when it fails.**

An `if` with no `else` around a lookup converts a five-second diagnosis into an open-ended hunt. Your instinct to add one is the correct one, and 0.13 now ships with a `PushError` that names both slots and their contents.

**Also spotted, minor:** your `ShaderTint` default is `new Color(.5f, 1f, 2.5f)`. Blue at `2.5` is outside the 0–1 range — legal in Godot as an HDR colour, but it will clamp or oversaturate once it reaches `ALBEDO`. Probably not what you intended.

**Why `[UNVERIFIED]` did not catch this.** The Inspector path carried no marker, because I did not think of it as an uncertain claim — I thought of it as a menu path I knew. That is precisely the failure [D-014](#d-014) already identified and I repeated it: **GUI navigation is exactly as unverifiable from my environment as an error string.** Recorded again in [`DecisionsLog.md`](DecisionsLog.md), because twice is a pattern rather than an accident.

### Related
[D-014](#d-014) · [chapter 0.13](../chapters/Chapter_00.13_GDShaderFirstContact.md) · [chapter 0.11](../chapters/Chapter_00.11_CSharpFirstContact.md) · [ADR-016](Decisions.md#adr-016)

### Action taken
Chapter 0.13 Step 1 rewritten with both slots named and a comparison table; Step 5 rewritten with the three-fallback lookup and a mandatory `PushError` failure path. Chapter 0.11 corrected to declare `: MeshInstance3D` and drop `GetNode(".")`. Run-it checklist updated.

### In my own words
*(yours to fill in)*

---

## ⏸️ Parked

*Questions consciously postponed, with a named chapter to revisit them at.*

| ID | Question | Revisit at | Why parked |
|----|----------|-----------|------------|
| — | | | |

---

## Recurring themes

Every ~20 doubts, come back and look for patterns. If four of your questions were about coordinate spaces, that isn't four gaps — it's **one** gap, and it deserves a deliberate re-read of 1.7–1.9 rather than four patches.

| Theme | Doubt IDs | What I did about it |
|-------|-----------|---------------------|
| | | |

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception. Table format. |
| 3.1 | 2026-09-03 | D-017 — `MaterialOverride` vs `surface_material_override/0`; chapter 0.13 named the wrong Inspector section. |
| 3.0 | 2026-09-02 | D-016 — `keytool` not on PATH, and the `setx PATH` command in 0.4 was harmful. First defect capable of damaging the learner\'s machine. |
| 2.9 | 2026-09-02 | D-015 — chapter 0.4 never said where to download the command-line tools; Fast-Track had no download step at all. |
| 2.8 | 2026-09-02 | D-014 — three authoring errors in chapter 0.3 found by the learner and fixed. |
| 2.7 | 2026-09-02 | D-013 added — Windows 11 + Linux both supported; WSL2 excluded as a workshop. D-001 revised. |
| 2.6 | 2026-09-02 | D-012 added — staged release model. |
| 2.5 | 2026-09-02 | D-011 added — vertical slice explained; capstone reaffirmed at four levels. |
| 2.4 | 2026-09-02 | D-010 added — external review triaged. |
| 2.3 | 2026-09-02 | D-009 added — four-language restructure and full library adoption. |
| 2.2 | 2026-09-02 | D-008 added — language ecosystems compared, and multi-language development confirmed. |
| 2.1 | 2026-09-02 | D-007 added — free Blender/Godot libraries, the build-then-adopt pattern, and an honest answer on "AAA". |
| 2.0 | 2026-09-02 | Rebuilt in the full entry format (Context / Question verbatim / Short answer / Full answer / Related / Action taken) after [D-006](#d-006) found the old format had nowhere to record the author's answer. D-005 back-filled; all six entries given full answers. |
