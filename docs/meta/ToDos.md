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
| T-002 | 🔴 | **Approve or amend [`../PLAN.md`](../PLAN.md)** | ⬜ | — | Nothing gets written until this lands. Read §1 (philosophy), §3 (the 11 projects) and §5 (honest constraints) at minimum. |
| T-003 | 🔴 | **Decide the build machine** and record its specs | ⬜ | — | Answers [D-001](Doubts.md). Blocks all of Module 0. See [Setup 01 §2](../guides/Setup_01_Prerequisites.md) for the minimum spec. |
| T-004 | 🟠 | **Record your phone's specs** — model, Android version, chipset/GPU, RAM, Vulkan support, notch? | ⬜ | — | Answers [D-003](Doubts.md). Decides Mobile vs Compatibility renderer in ch 4.13, and your whole performance budget. |
| T-005 | 🟠 | **Decide [ADR-024](Decisions.md#adr-024)** — do you want the three 🐣🚶🏃 learning paths from the QNX course? | ⬜ | — | My recommendation is **no** — use ⭐/🔬 markers instead. ~2× authoring cost for the full version. |
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
| T-013 | 🟠 | Write **Chapter 0.1** | ⏸️ | T-002 | First chapter. Blocked on plan approval. |
| T-014 | 🟡 | Write a **sample chapter (1.4)** early if you want to see the format before approving | ⬜ | — | Ask for it. 1.4 is the most representative of the Build→Why→Break→Practical→Check shape. |
| T-015 | 🟡 | Populate `docs/reference/cheatsheets/` — Blender hotkeys, GDShader built-ins, Godot C# API, `adb` | ⬜ | — | One page each. Best written alongside the chapters that introduce them. |
| T-016 | 🟡 | Fill `docs/reference/answers/module-03.md` … `module-10.md` | ⬜ | module progress | Written as each module is reached ([ADR-007](Decisions.md#adr-007)). |
| T-017 | 🔵 | Add a **Practicals Index** — every hands-on unit in one table | ✅ | — | Done: [`../Practicals.md`](../Practicals.md) |
| T-018 | 🔵 | Consider a PDF export toolchain, as in the QNX course | ⬜ | — | Only worth it once several modules exist. `tools/pdf/` would mirror QNX. |

---

## 3. ⏸️ Blocked

| ID | Blocked on | Unblocks when |
|----|-----------|---------------|
| T-013 | [T-002](#1--your-action-items) plan approval | You approve `../PLAN.md` |
| Everything in Module 0 | [T-003](#1--your-action-items) build machine | You choose the desktop |

---

## 4. Completed

| ID | Task | Done |
|----|------|------|
| T-000 | Inspect the authoring environment; verify GitHub identity | 2026-09-01 |
| T-001 | Create the GitHub repo `godot-zero-to-hero` and push the scaffold | 2026-09-01 |
| T-017 | Practicals index | 2026-09-01 |
| — | Draft PLAN, TableOfContents, BlenderTrack, projects, Exercises, QuestionBank + answers M0–M2, 5 setup guides, 25 ADRs, meta + internal scaffolding | 2026-09-01 |
