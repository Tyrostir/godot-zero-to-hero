---
title: "Asset Licence Ledger — every third-party asset, tracked"
document_id: LICENCES
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "The moment any asset is downloaded — before it is used"
---

# 📜 AssetLicenses.md

> 🚨 **The rule ([ADR-008](../meta/Decisions.md#adr-008)): every asset gets a row here the moment you download it. Not later. Not "when I ship".**

---

## Why this is the most boring important file in the repo

Three reasons:

1. **Attribution obligations are legal, and they are cheap now and expensive later.** CC-BY requires visible credit. Six months from now you will not remember which of 200 textures came from where, and "I can't prove I'm allowed to use this" is how finished games fail to ship.
2. **Chapter 8.19 generates your in-game credits roll directly from this table.** If the ledger is complete, your credits screen is free. If it isn't, you will spend a miserable weekend reconstructing it from browser history.
3. **It forces you to read the licence at download time**, which is the only moment you can still cheaply choose a different asset.

---

## Licence quick-reference

| Licence | Sellable? | Credit? | Notes |
|---|---|---|---|
| **CC0** / Public Domain | ✅ | Not required | **Prefer this. Nearly everything this course needs exists as CC0.** |
| **CC-BY** | ✅ | **Required, visibly** | A credits screen satisfies it |
| **CC-BY-SA** | ⚠️ | Required | ShareAlike may infect derivative *assets*. Avoid where you can |
| **CC-BY-NC** | ❌ | — | **Rejected by [ADR-008](../meta/Decisions.md#adr-008).** Even donations arguably make a game commercial |
| **CC-BY-ND** | ❌ | — | **Rejected.** Re-compressing and re-rigging are derivatives |
| **OGA-BY** | ✅ | Required | OpenGameArt's own attribution licence; behaves like CC-BY |
| **MIT / BSD / Apache-2.0** | ✅ | Licence text | Normal for code and shaders. Keep the text in the repo |
| **GPL / AGPL** | ⚠️ | Required | Viral for *code*. A GPL shader or plugin can obligate you to release source |
| **SIL OFL** | ✅ | Usually not | Standard font licence. Don't sell the font itself |
| **Custom / "royalty-free"** | Read it | Depends | Mixamo, Sonniss etc. Usually generous, but often forbid redistributing the raw asset |

---

## The ledger

Add a row **at download time**. Never delete a row — if you stop using an asset, set **Used?** to `no` and keep it, so you can prove what is and isn't in the build.

| # | Asset | Type | Source (URL) | Author | Licence | Attribution string required | Downloaded | Used in | Used? |
|---|-------|------|--------------|--------|---------|------------------------------|-----------|---------|-------|
| 001 | | | | | | | | | |
| 002 | | | | | | | | | |
| 003 | | | | | | | | | |

**Column notes**

- **Type** — model · texture · material · HDRI · animation · SFX · music · font · icon · shader · VFX · tool
- **Attribution string required** — paste the *exact* wording the source asks for. Incompetech, for instance, specifies its own. Leave blank for CC0.
- **Used in** — which project(s): `P01`, `P04`, `P10`…
- **Used?** — `yes` / `no` / `placeholder`. Placeholders must be resolved before P10 ships.

---

## Your own work

Also log what **you** made, so the credits roll is complete and so you can find the source file later.

| # | Asset | Type | Source `.blend` / file | Made in | Project |
|---|-------|------|------------------------|---------|---------|
| S01 | Foundry Kit (14 pieces) | model set | `assets-staging/foundry-kit/` | Blender | P02, P04, P10 |
| S02 | The Warden | character | `assets-staging/warden/` | Blender | P08, P10 |

---

## Pre-release audit

Before P10 ships (chapter 11.19), work through this:

- [ ] Every asset in the build has a row here
- [ ] No row has licence `CC-BY-NC`, `CC-BY-ND`, or blank
- [ ] Every CC-BY / OGA-BY row's attribution string appears in the in-game credits
- [ ] Every `placeholder` is resolved
- [ ] The generated credits roll (ch 8.19) matches this table exactly
- [ ] Licence texts for MIT/Apache code are in the repo
- [ ] Fonts are licensed for embedding in an application
- [ ] Music licences allow use in a *video* (some allow game use but not streaming/trailer use)

> ⚠️ **That last one catches people.** A track you may use in your game may not be usable in the trailer you upload to YouTube, whose Content ID system does not read licences. Check before you edit the trailer, not after.
