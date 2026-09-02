---
title: "Review Triage — external review of 2026-09-02"
document_id: TRIAGE
version: 1.0
status: Active
created: 2026-09-02
last_updated: 2026-09-02
update_trigger: "When a review point is actioned, or a new external review arrives"
---

# 🔍 Review Triage — external review, 2026-09-02

Source: `godot-course-review.md` (ChatGPT), commissioned by the learner.
Scope reviewed: the course plan at roughly commit `b71dc66` (333 chapters).

**Verdict on the review: substantially correct, and worth acting on.** It found one live defect I had introduced, three real structural mistakes, and one systemic weakness that is the most valuable thing anyone has said about this plan. It also overreaches in three places and scores one thing unfairly. Point-by-point below.

**Key:** ✅ Adopt · 🔄 Adapt (right diagnosis, different fix) · ⏸️ Ask the learner first · ❌ Reject, with reason · ✔️ Already done

---

## 0. Claims I could verify, before assessing the arguments

| Claim | Verdict |
|---|---|
| "README claims 333 builds, another section gives 292" | ✅ **True and my bug.** `Practicals.md`'s per-module table still totalled 292/30 after the last restructure — I updated the summary rows and missed the breakdown. **Fixed.** |
| "README claims 63 adoptions, practicals list 30" | ✅ **Same bug. Fixed.** |
| "Blender numbering B0–B19 in one place, B42 in another" | ⚠️ **Was true; now stale.** The old README said `B0–B19`; it has said `B1–B42` since the restructure. Residual imprecision — there are actually 66 Blender chapters once variants and embedded `[B]` chapters are counted. Worth one clarifying line. |
| Forward+ → Mobile migration | ✅ **True and a real design error. Fixed** — P00 now starts on Mobile; 4.13 became a comparison, not a port. |
| No Android lifecycle coverage | ✅ **True.** `grep` for lifecycle/backgrounding/process-death/ANR/battery returns **nothing**. Largest content gap in the plan. |
| No git branching / bisect | ✅ **True.** Nothing beyond "commit after every chapter". |

---

## 1. The systemic point — and my own failure mode

> "Do not optimize for the number of chapters. Optimize for the number of capabilities you can demonstrate independently."

**This is the most valuable sentence in the review and it names something I got wrong.**

Across four consecutive turns the plan went **215 → 258 → 290 → 292 → 333** chapters. Every one of those turns was a response to a legitimate request, I stated the cost each time, and **not once did I propose removing anything.** A careful collaborator, somewhere around hour 500, should have said *"what comes out?"* I never did. That is a real failure of judgement, not a matter of taste.

The concrete expression of it is **[ADR-032](Decisions.md#adr-032)** — *"every catalogued library gets a chapter that uses it."* That was the wrong answer to "adopt all the libraries". The right answer was: **some tools warrant a chapter, some a paragraph, some only "this exists"** — which is precisely the review's §3. ADR-032 needs revising, and revising it **removes** chapters.

---

## 2. Adopt — the review is right

| § | Point | Verdict | Action |
|---|-------|---------|--------|
| **37** | **Progressive removal of assistance** — 90/10 guided → 10/90 independent | ✅ **The best idea in the review** | New ADR. A scaffolding gradient declared per module, in every chapter's front matter |
| **22** | **Blank-page builds** — every subsystem ends with *requirements only, no instructions* | ✅ Strong | Guided → Variation → **Blank-page** → Jam → Autopsy, per subsystem |
| **5** | **Android runtime engineering** — lifecycle, process death, interruption, resume, back gesture, controllers, fragmentation | ✅ **Biggest content gap** | A dedicated Android Engineering block, placed right after P01 ships |
| **31** | **Android chaos test** — home, lock, call, task-switch, process kill, reopen, load save | ✅ Excellent concrete exercise | Becomes a done-criterion on every project from P01 |
| **6–9** | Thermal soak (30 min), battery, memory-pressure torture test, **bottleneck taxonomy** (CPU / GPU / draw-call / fill-rate / bandwidth / shader-bound) | ✅ Right, and we only had a vague version | Explicit chapters with measurement tables |
| **24–25** | **Explicit performance budgets** (16.67 ms broken down) and a **device tier matrix** | ✅ Right | Budget table introduced in P01, enforced thereafter |
| **12** | Renderer choice — start on Mobile, don't migrate | ✅ Right | ✔️ **Done** |
| **13/27/28** | **Version matrix**, upgrade discipline, reproducible builds. "Never say *latest*" | ✅ Right | `ENGINE_VERSION.md` + an upgrade-discipline chapter |
| **15** | **Debugging as a taught skill** — conditional breakpoints, watch, call stacks, remote debug, minimal repro, **binary-search debugging**, bisect | ✅ Right, we were thin | Threaded from Module 1, not deferred |
| **16–19, 33** | **Git branching, CI, testing, playtesting, profiling — all start earlier**, tiny first, grown | ✅ **Right, and it is our own principle** | This is the three-pass spiral we failed to apply to engineering practice |
| **29–30** | Release engineering depth; **crash and ANR monitoring** | ✅ ANR was entirely missing | Added to Module 10 |
| **3** | **Priority tiers** — L1 must know · L2 must understand · L3 know it exists | ✅ Right, and it **corrects ADR-032** | Kitsu, MemoryPack, Serilog, USD, OCIO, Sverchok → L3 awareness. **Removes chapters** |
| **36** | Loop gains **Observe**, **Diagnose (learner first)**, **Reflection (explain it back)** | ✅ Genuine improvement | Chapter template revised — theory arrives only *after* the learner attempts diagnosis |

---

## 3. Adapt — right diagnosis, different fix

| § | Point | My adaptation |
|---|-------|---------------|
| **2** | **Too many languages too early. C++ in Module 0 is excessive.** | ✅ **Right, and this was my error.** But the fix is *resequencing*, not removal — the learner explicitly asked for all three ([D-009](Doubts.md#d-009)). **Keep** the GDScript-vs-C# measured comparison in Module 0 (both are trivial, no toolchain). **Move** the C++ leg (0.13–0.15) into Module 9 beside `9.1e`, the measured rewrite, where it already has an earned trigger. The "measure it yourself" pedagogy survives intact; the afternoon of SCons moves to where it is motivated. |
| **14** | C# foundations for a true beginner | 🔄 Right for 🐣 Path A, but our learner is a **C/C++-solid, Python-strong embedded engineer**. A micro-track on *variables and methods* would insult them. Scope it to **C#-specific** things they genuinely have not met: properties, `partial`, attributes, delegates/events, LINQ, generics, `async`, nullable references, records, `struct` vs `class` semantics. Threaded, never a standalone block. |
| **35** | The revised Phase 0–12 curriculum | 🔄 **Adopt the resequencing insight, not the structure.** Promoting **mobile engineering to immediately after the first shipped game** is right and I will do it. But the phase list itself is *less* specific than our modules — "Learn: modelling, UV, materials, baking, LOD" is what B10–B19 already are, in detail. Wholesale adoption would be a downgrade. |
| **34** | Capstone too large; prefer one excellent vertical slice | 🔄 Partly right. [ADR-019](Decisions.md#adr-019) already locks it to four ~6-minute levels. Proposal: **the vertical slice is the ship target; levels 2–4 become explicitly optional expansion.** Most solo projects die in content production, not in systems. ⏸️ Learner's call. |
| **26** | Android C# support must be version-checked | ✔️ Already [ADR-022](Decisions.md#adr-022) + `[UNVERIFIED]`. Strengthen the wording to require a check **before production commitment**, not just at install. |

---

## 4. Ask the learner — conflicts with an explicit instruction

| § | Point | Why I will not decide this alone |
|---|-------|--------------------------------|
| **20** | **Presentation scope too large.** Title screen + ending + music + ambience + narrative + walkthrough on every project is production overhead. Narration should be optional. | The review is **probably right** — P02 is an art kit and does not need a re-skinned title screen. But the learner asked for this **emphatically and specifically**, and [ADR-026](Decisions.md#adr-026) exists because of that instruction. Reversing it silently would be wrong. **Proposal:** keep the spine, mark each item ⭐ required / optional per project, and make narration required only where the design calls for it. ⏸️ |
| **34** | Capstone: 4 levels → 1 slice | ⏸️ As above. |

---

## 5. Reject — with reasons

| § | Point | Why I disagree |
|---|-------|----------------|
| **4** | *"Actual completeness of supplied course: 4/10"* and "the repository is a blueprint, not a course" | ❌ **This scores us on completeness of something we explicitly have not started.** [`CourseState.md`](CourseState.md) states *Phase 1 — planning · 0/333 chapters published · plan awaiting review*. It is a blueprint **by design and by declaration**, because the learner asked for the plan first and then asked to review it before any chapter was written. Folding a 4/10 into the headline verdict is unfair and misleading. The *observation* is correct; the *score* is a category error. |
| **2** | "GDShader should come later" | ❌ It already is — Module 5, twelve chapters. Only `0.16` is early, and it is one chapter that exists so shaders are not a surprise in Module 5. Cheap and useful; keeping it. |
| **35** | Phase list replacing our modules | ❌ See §3 above — less specific than what exists. |

---

## 6. Net effect on size

Contrary to expectation, acting on this review should make the course **smaller**, not larger.

| Change | Δ chapters |
|---|---|
| §3 priority tiers → demote L3 tools to awareness paragraphs (revises [ADR-032](Decisions.md#adr-032)) | **−12 to −18** |
| §2 move the C++ block from Module 0 to Module 9 | 0 (moved, not added) |
| §20 presentation scaling, *if approved* | **−6 to −10** |
| §34 capstone to a vertical slice, *if approved* | **−4 to −6** |
| §5 Android engineering block | **+10 to +14** |
| §6–9, 24–25 performance and measurement | **+6 to +8** |
| §15–19 debugging, git, CI, testing, playtesting moved earlier | **+4 to +6** *(mostly relocation)* |
| §13/27/28 version matrix and upgrade discipline | **+3** |
| §22/37 blank-page builds and the scaffolding gradient | **+0** — these are *structural*, applied inside existing chapters |
| §14 micro-C# track, threaded | **+4** |

**Estimated net: roughly 315–325 chapters, with a materially better shape.** The gain is not the count — it is that ~40 tool-tour chapters become ~30 chapters of Android engineering, measurement, debugging and independent building.

---

## 7. The one thing the review understates

It treats scaffolding removal (§37) as a delivery detail. **It is the load-bearing fix.** Every chapter in the current plan is guided. A course whose entire premise is learning by doing currently has **no gradient toward doing it alone** — the mini-jams are the only unscaffolded work, and there are four of them in 333 chapters.

Independent capability is not a by-product of finishing guided chapters. It has to be *built*, by removing help on a schedule. That deserves its own ADR and a declared percentage per module, exactly as [ADR-002](Decisions.md#adr-002) got numeric thresholds — for the same reason: a gradient you can check beats an intention you can drift away from.
