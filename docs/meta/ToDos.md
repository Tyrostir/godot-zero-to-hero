---
title: "ToDos — Open Work Items"
document_id: TODO
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Continuously"
---

# ✅ ToDos.md

> Every open work item for this course. Items are never deleted — they move to [§4 Completed](#4-completed).

**Priority:** 🔴 Blocker · 🟠 High · 🟡 Normal · 🔵 Low · ⚪ Someday
**Owner:** 👤 You (learner) · 🤖 Me (author) · 🤝 Both
**Status:** ⬜ Open · 🔄 In progress · ⏸️ Blocked · ✅ Done

---

## 1. 👤 Your action items

| ID | Pri | Task | Status | Depends on | Notes |
|----|-----|------|--------|-----------|-------|
| T-002 | 🔴 | ⭐ **Review [`../PLAN.md`](../PLAN.md) and come back with amendments** | ⬜ | — | **You asked for this before any chapter is written.** Read §1 (philosophy), **§1b (the three paths)**, **§3b (the Presentation Spine — new)**, §3 (the 11 projects) and §5 (honest constraints). Also skim [`../TableOfContents.md`](../TableOfContents.md) and [`../PresentationSpine.md`](../PresentationSpine.md). |
| T-003 | — | ~~Decide the build machine~~ | ✅ | — | Done 2026-09-01: **Linux**. Guides now lead with the Linux route. [D-001](Doubts.md) resolved. |
| T-004 | 🟠 | **Record your phone's specs** — model, Android version, chipset/GPU, RAM, Vulkan support, notch? | ⬜ | — | Answers [D-003](Doubts.md). Decides Mobile vs Compatibility renderer in ch 4.13, and your whole performance budget. |
| T-005 | — | ~~Decide ADR-024 — learning paths~~ | ✅ | — | Done 2026-09-01: **yes, all three authored in full.** Chapter template and PLAN §1b updated. |
| T-006 | 🟠 | Run **Setup 02** — install Godot .NET + .NET SDK, and paste the `<TargetFramework>` line from a generated `.csproj` into [`toAgent/`](../../toAgent/) | ⬜ | T-003 | Clears the `[UNVERIFIED]` in [Setup 02 §2](../guides/Setup_02_Godot_And_DotNet.md). |
| T-007 | 🟠 | Run **Setup 03** — install Blender, do the 2 m cube round-trip test | ⬜ | T-003 | If the cube isn't exactly 2 units in Godot, stop and fix before Module 2. |
| T-008 | 🟠 | Run **Setup 04** — JDK + Android SDK + keystore, paste `adb devices` output into `toAgent/` | ⬜ | T-003 | Also paste the API level / build-tools version the official export page currently names. |
| T-009 | 🔴 | ⭐ **Run Setup 05 — ship P00 to your phone** | ⬜ | T-006, T-008 | **Milestone M1.** The single most important 45 minutes in the course. |
| T-010 | 🟡 | **Exercise C0.1** — break the pipeline three ways and write the exact errors into [`../reference/Troubleshooting.md`](../reference/Troubleshooting.md) | ⬜ | T-009 | Not optional. Converts three future mysteries into recognised-on-sight failures. |
| T-011 | 🟡 | Download the four starter assets named in [ResourcesMeta §10](../reference/ResourcesMeta.md) and log all four in [`AssetLicenses.md`](../reference/AssetLicenses.md) | ⬜ | — | Practises the ledger habit before it matters. |
| T-012 | 🔵 | Find a second, **lower-spec** Android test device if you can borrow one | ⬜ | — | Optional but genuinely valuable — it becomes your performance truth. |

---

## 2. 🤖 My action items

| ID | Pri | Task | Status | Depends on | Notes |
|----|-----|------|--------|-----------|-------|
| T-001 | — | ~~Create the GitHub repo~~ | ✅ | — | Done 2026-09-01. First attempt was denied by the auto-mode permission classifier; the retry succeeded. Repo is live and the scaffold is pushed (commit `6219e4b`). |
| T-013 | 🟠 | Write **Chapter 0.1**, for all three paths | ⏸️ | T-002 | First chapter. Held pending your plan review. |
| T-014 | 🟡 | Write a **sample chapter (1.4)** if you want to see the format in the flesh | ⬜ | — | Optional. 1.4 is the most representative of the Build→Why→Break→Practical→Check shape, and would show how the three paths sit in one document. |
| T-015 | 🟡 | Populate `docs/reference/cheatsheets/` — Blender hotkeys, GDShader built-ins, Godot C# API, `adb` | ⬜ | — | One page each. Best written alongside the chapters that introduce them. |
| T-016 | 🟡 | Fill `docs/reference/answers/module-03.md` … `module-10.md` | ⬜ | module progress | Written as each module is reached ([ADR-007](Decisions.md#adr-007)). |
| T-017 | 🔵 | Add a **Practicals Index** — every hands-on unit in one table | ✅ | — | Done: [`../Practicals.md`](../Practicals.md) |
| T-022 | — | ~~Rebuild `Doubts.md` so the author's answers have somewhere to live~~ | ✅ | — | Done 2026-09-02. v1.0 had a column for *your* own-words answer and no field for mine, so my answers drifted into `PROMPTS.md`. v2.0 uses the full QNX entry format; [D-005](Doubts.md#d-005) back-filled; [ADR-011](Decisions.md#adr-011) amended. |
| T-021 | 🟠 | ~~Audit the plan for story / narration / screens / walkthrough coverage~~ | ✅ | — | Done 2026-09-02. Found three real gaps; fixed with [ADR-026](Decisions.md#adr-026), [ADR-027](Decisions.md#adr-027) and [`../PresentationSpine.md`](../PresentationSpine.md). 43 chapters added. |
| T-018 | 🔵 | Consider a PDF export toolchain, as in the QNX course | ⬜ | — | Only worth it once several modules exist. `tools/pdf/` would mirror QNX. |
| T-019 | 🟡 | Source or write the **music** for P01 — one seamless loop | ⬜ | T-002 | Chapter 1.37 walks it. CC0 first; composing your own is a Module 6 option. |
| T-023 | 🟡 | At each 🧰 adoption chapter, **record the evaluation result** in [`DecisionsLog.md`](DecisionsLog.md) as a dated 🔍 VERIFIED entry | ⬜ | per chapter | Licence, last commit, C# ergonomics, measured mobile cost. Over the course this builds an evidence-based picture of the Godot **C#** ecosystem, which barely exists in public. |
| T-020 | 🟡 | Decide whether *you* narrate *Ember Hollow*, or it uses TTS, or it has no narrator | ⬜ | — | Not urgent, but it shapes chapter 7.6. Chapters 6.9 and 6.13 give you both paths before you have to choose. |

---

## 3. ⏸️ Blocked

| ID | Blocked on | Unblocks when |
|----|-----------|---------------|
| T-013 | [T-002](#1--your-action-items) plan approval | You approve `../PLAN.md` |
| Everything in Module 0 | [T-002](#1--your-action-items) plan review | You come back with amendments, or approve as-is |

---

## 4. Completed

| ID | Task | Done |
|----|------|------|
| T-000 | Inspect the authoring environment; verify GitHub identity | 2026-09-01 |
| T-001 | Create the GitHub repo `godot-zero-to-hero` and push the scaffold | 2026-09-01 |
| T-003 | Decide the build machine — **Linux** | 2026-09-01 |
| T-005 | Decide ADR-024 — **three paths, all authored in full** | 2026-09-01 |
| T-017 | Practicals index | 2026-09-01 |
| — | Draft PLAN, TableOfContents, BlenderTrack, projects, Exercises, QuestionBank + answers M0–M2, 5 setup guides, 25 ADRs, meta + internal scaffolding | 2026-09-01 |
