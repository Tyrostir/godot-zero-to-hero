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
| [D-001](#d-001) | 2026-09-01 | Setup/Install | Which desktop machine will I build on? | ✅ |
| [D-002](#d-002) | 2026-09-01 | Setup/Install | Which exact Godot .NET version, and does it have known Android C# issues? | ⬜ |
| [D-003](#d-003) | 2026-09-01 | Performance | What are my test phone's GPU, RAM, Android version and Vulkan support? | ⬜ |
| [D-004](#d-004) | 2026-09-01 | Course logistics | One learning path, or three? | ✅ |
| [D-005](#d-005) | 2026-09-02 | Design/Narrative | Is story, narration, walkthrough, first/end-page animation and music planned across **all** projects? | ✅ |
| [D-006](#d-006) | 2026-09-02 | Course logistics | Will you keep documenting my `/btw` questions **and your answers**? | ✅ |
| [D-007](#d-007) | 2026-09-02 | Course logistics | Which free Blender and Godot libraries exist, can we adopt them, and can I reach AAA? | ✅ |

---

## D-001

**Date:** 2026-09-01 · **Context:** Course inception, before any chapter could be scoped · **Category:** Setup/Install · **Status:** ✅ Answered

### Question
> *(Asked of you rather than by you — but it blocked everything, so it is logged the same way.)*
> Which desktop machine will you actually use for Godot + Blender, and does it meet the requirements?

### Short answer
**A Linux desktop.** That settles the entire setup route and unblocked Module 0.

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

**Date:** 2026-09-01 · **Context:** [Setup 01](../guides/Setup_01_Prerequisites.md), and it governs Module 4's entire budget · **Category:** Performance · **Status:** ⬜ Open — **needs your device**

### Question
> What is my test phone's GPU, RAM, Android version and Vulkan support?

### Short answer
Unknown, and it decides more than it looks like it does: **Vulkan support chooses your renderer**, and the GPU sets your realistic triangle, texture and shader budget for the whole course.

### Full answer
Three separate decisions hang on this:

1. **Renderer** (chapter 4.13). Godot 4 offers Forward+, **Mobile** and **Compatibility**. Vulkan-capable devices can use Mobile — the intended phone path. A device without usable Vulkan drops you to Compatibility, which changes what shaders and lighting features are available, and therefore changes several chapters in Modules 4 and 5.
2. **Performance budget** (4.12–4.18). A mid-range phone has roughly the GPU budget of a 2013 laptop and a **thermal budget of about ten minutes**. Triangle counts, texture resolution, shadow settings and post-processing all get set against your actual hardware, not a generic target.
3. **UI** (1.29). Screen resolution, aspect ratio, refresh rate and whether you have a notch decide how much the safe-area work matters to you.

**How to get the numbers:** Settings → About phone for model, Android version and RAM. An app like *Device Info HW* for the chipset. *Vulkan Hardware Capability Viewer* for Vulkan. Fill the table in [Setup 01 §3](../guides/Setup_01_Prerequisites.md#3-your-version-log).

**Worth doing if you can:** borrow an older or cheaper Android device. Your daily phone is probably better than your median player's; a five-year-old handset becomes your *performance truth*. Build for that one and the good phone looks after itself.

### Related
[Setup 01 §3](../guides/Setup_01_Prerequisites.md) · [ADR-010](Decisions.md#adr-010) · chapters 1.29, 4.12–4.18

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

**Why the audit was worth running rather than answering "yes".** Two of the three gaps were invisible from the module titles. Module 7 is called *Story, Narrative & Cinematics* and Module 6 *Audio & Game Feel*. A glance at those names would have produced a confident and wrong "yes, it's all covered." The ToC had to be read line by line against your list.

**The fix.**

- **[ADR-026 — The Presentation Spine].** Presentation runs through **every project from P01**, escalating. From P01 a project is not shipped without an animated first page, an ending screen, music, ambience, a narrative frame and a walkthrough — as **done-criteria**, not suggestions. You build a title screen **four times**: crude tween (1.35) → live 3D character (3.12) → your own shaders (5.22) → directed, scored, narrated opening (7.16–7.18). Same escalation for the ending, music, and the walkthrough.
- **[ADR-027 — Narration].** Eleven chapters, record-before-theorise, built around a phone and a wardrobe of soft furnishings — **no purchase required**. TTS treated as a legitimate option with its licensing trap stated. **Subtitles mandatory**: a phone gets played on mute, on a bus, by someone who is deaf, and by someone at 4% battery, and all four are the same requirement.

**Rejected:** the cheap fix — bolting narration chapters onto Module 7 and leaving the rest. That would have closed gap 1 and left the pedagogy broken.

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

Two further responses to that same problem are now taught: **wrap any GDScript addon behind a C# interface** (9.6b — one ugly file, the rest of your codebase stays typed), and **NuGet** (0.11), which is a large compensation GDScript users simply do not have.

**3 — Adopting them without breaking learn-by-doing.** This was the real design problem, and the answer is [ADR-028](Decisions.md#adr-028):

> **1️⃣ Hand-build it** → you understand the problem, not an API, and can debug anything built on it.
> **2️⃣ Compare** → install it, **read its source**, find what it does better *and worse*.
> **3️⃣ Decide** → adopt or keep yours, and **record why** in `DecisionsLog.md`.

Adoption chapters are numbered `N.Mb` and marked 🧰, so the pairing is visible and existing numbering stays stable. Rigify comes *after* you hand-rig a biped (B24b). Phantom Camera *after* you write a follow camera (1.24b). LogicBlocks *after* your own FSM has silently got hierarchical states wrong (3.7b). RetopoFlow *after* hand retopology (B34b).

**Step 3 is mandatory, and "a tutorial used it" is not a rationale.** Chapter **0.10** teaches the six evaluation questions — licence · maintenance · **does it work from C#** · mobile cost *measured on device* · abandonment risk · could you write it in a day. Choosing and rejecting dependencies is a larger part of professional work than writing code is, and the Godot 3→4 break orphaned enough addons to make the point concrete.

**Rejections are recorded too** ([`../Toolchain.md` §8](../Toolchain.md)): FMOD/Wwise (community integration + C# + Android is three compounding risks — awareness only, 6.2b, no install), every paid Blender addon that has a free equivalent taught here, GPL addons in shipped code, and anything abandoned since Godot 4.0.

**4 — On "AAA", honestly.** You asked for *AAA standard — professional — industry grade*. Two of those three are achievable through this course. One is not, and saying so is more useful than agreeing ([ADR-030](Decisions.md#adr-030)).

**AAA is a description of budget and headcount, not of quality**: 100–300 people, $50–200 M, three to five years, with marketing that often exceeds production. No course produces that and no solo developer achieves it — not for want of skill, but because it is a claim about organisational scale.

**Professional and industry-grade craft is entirely achievable, and the course now targets it in full.** The gaps I found and closed: **industry milestones** (first playable, vertical slice, alpha, beta, content lock, gold — 10.1b) · **production tracking with Kitsu**, an open-source tool used in real studios (10.3b) · **code standards** — `.editorconfig`, .NET analyzers, `dotnet format`, XML doc comments, warnings-as-errors (9.2b) · **structured logging** with Serilog rather than `GD.Print` (9.11b) · **unit-testable scene code** (9.9b) · **storyboarding and previz** (7.2b) · **colour management** (7.24b) · **the post-mortem**, written honestly and published (10.11b) · and **a portfolio and breakdown reel** for studio applications (10.20b).

What is deliberately *not* attempted, and why that is right: large content volume (scope kills solo projects — [ADR-019](Decisions.md#adr-019)), photoreal fidelity (wrong target for a phone — [ADR-010](Decisions.md#adr-010)), multiplayer infrastructure (an entire discipline; awareness only), and marketing at scale.

**The honest summary:** at the end you will not have made a AAA game. You will have the craft, the pipeline discipline and the shipped evidence to work on one — or to make something small and excellent on your own, which is the harder and rarer achievement.

**5 — Cost.** 32 chapters added, **258 → 290**. Pacing ~430–480 h → **~470–530 h**. Module 9 grew most (13 → 19) because that is where professional practice concentrates.

**6 — One caveat I cannot remove.** [`[UNVERIFIED]`](../internal/VerificationRuns.md) applies to this whole document. I cannot install or run any of these libraries ([ADR-016](Decisions.md#adr-016)). Versions, current maintenance status, real C# ergonomics and actual mobile cost must be checked **by you at the point of adoption** — which is exactly the exercise in step 2 anyway, so the constraint and the pedagogy happen to point the same way.

### Related
[ADR-028](Decisions.md#adr-028) · [ADR-029](Decisions.md#adr-029) · [ADR-030](Decisions.md#adr-030) · [`../Toolchain.md`](../Toolchain.md) · [PLAN §3c, §3d](../PLAN.md) · [PROMPT#7](../../PROMPTS.md)

### Action taken
New document [`../Toolchain.md`](../Toolchain.md). Three ADRs added. ToC gained 32 chapters including 28 🧰 adoption chapters and 6 professional-practice chapters. `PLAN.md` gained §3c and §3d. `Practicals.md`, `CourseState.md`, `CompactContext.md`, `CLAUDE-MEMORY.md`, `README.md` and `ToDos.md` (T-023) updated.

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
| 2.1 | 2026-09-02 | D-007 added — free Blender/Godot libraries, the build-then-adopt pattern, and an honest answer on "AAA". |
| 2.0 | 2026-09-02 | Rebuilt in the full entry format (Context / Question verbatim / Short answer / Full answer / Related / Action taken) after [D-006](#d-006) found the old format had nowhere to record the author's answer. D-005 back-filled; all six entries given full answers. |
