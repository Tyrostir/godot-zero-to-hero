---
title: "Game Design Document — Ember Hollow (working title)"
document_id: GDD
version: 0.1
status: Draft (skeleton — filled in during Module 8)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Chapter 8.6, and whenever a design decision is made thereafter"
---

# 🎮 Game Design Document — *Ember Hollow*

> **Status: a skeleton.** You fill this in during **[chapter 8.6](TableOfContents.md#module-7--story-narrative--cinematics)**, after you have built enough of the game to have opinions. Writing a GDD before you can build anything is how projects acquire ideas nobody can implement.
>
> Working title per [ADR-023](meta/Decisions.md#adr-023) — you rename it in chapter 7.1.

---

## 1. The one-page pitch

| Field | |
|-------|--|
| **Title** | *Ember Hollow* (working) |
| **Logline** | *(one sentence — the whole game)* |
| **Genre** | 3D third-person action-traversal |
| **Platform** | Android (phone, portrait-agnostic — decide and record) |
| **Playtime** | ~25 minutes, 4 levels + boss |
| **Audience** | |
| **Price** | Free |
| **Comparable to** | *(2–3 games, and how yours differs)* |

**The elevator paragraph** *(≤80 words — if you can't, the scope isn't clear yet)*:

> …

---

## 2. Story

| Field | |
|-------|--|
| **Premise** | *(the situation, in one sentence)* |
| **Theme** | *(what it's actually about — one abstract noun and a claim about it)* |
| **Setting** | |
| **Protagonist — want** | *(what they say they want)* |
| **Protagonist — need** | *(what they actually need — usually the opposite)* |
| **Arc** | *(who they are at the start → at the end)* |
| **Antagonist / opposing force** | |

### Three beats

| Beat | What happens | What the player *does* |
|------|--------------|------------------------|
| 1 | | |
| 2 | | |
| 3 | | |

> ⚠️ **The right-hand column is the important one.** If a story beat has no corresponding player verb, it is a cutscene rather than game design. Chapter 8.5 (ludonarrative harmony) is about closing that gap.

---

## 3. Verbs — the whole game, mechanically

**Core verb:** *(the thing you do most)*
**Traversal verb:** *(how you move through space)*

That is the complete list. [ADR-019](meta/Decisions.md#adr-019) locks it. Anything else goes to §9.

| Verb | Input | Feedback (visual / audio / haptic) | Introduced in |
|------|-------|-----------------------------------|---------------|
| | | | |

---

## 4. Levels

| # | Name | Length | Teaches | Landmark | Story beat |
|---|------|--------|---------|----------|-----------|
| 1 | | ~6 min | | | |
| 2 | | ~6 min | | | |
| 3 | | ~6 min | | | |
| 4 | | ~6 min | | | |
| B | Boss | ~5 min | | | |

**Difficulty curve** — sketch it, don't guess it:

```text
        │
 diff.  │
        │
        └───────────────────────────────
         L1    L2    L3    L4    Boss
```

---

## 5. Enemies

| Enemy | Variant of | Behaviour | Telegraph | Counter |
|-------|-----------|-----------|-----------|---------|
| | | | | |

**Boss — three phases**

| Phase | Trigger | New behaviour | What the player must learn |
|-------|---------|---------------|---------------------------|
| 1 | start | | |
| 2 | 66% HP | | |
| 3 | 33% HP | | |

---

## 6. Art direction

| Field | |
|-------|--|
| **One-sentence look** | |
| **Palette** | *(5 swatches, and what each is reserved for — one colour must mean "interactive")* |
| **Lighting mood** | |
| **Reference board** | `assets/images/reference/` |
| **Poly budget** | Character ≤20k · kit total ≤12k · scene target … |
| **Texture budget** | |

---

## 7. Audio direction

| Field | |
|-------|--|
| **Music style** | |
| **Adaptive layers** | |
| **The sound the game is remembered for** | |

---

## 8. Accessibility

Chapter 10.13. Each of these is cheap; skipping them is a choice.

- [ ] Text size option
- [ ] Colourblind-safe critical colours (never colour alone as a signal)
- [ ] Remappable / repositionable touch controls
- [ ] Difficulty options
- [ ] Screenshake toggle
- [ ] Haptics toggle
- [ ] Subtitles for all speech
- [ ] No essential information conveyed by audio alone

---

## 9. 🚫 Post-launch — the parking lot

> **Every idea that arrives after scope lock goes here, immediately, and is not discussed further.**
>
> This section is not a consolation prize. It is the mechanism by which the game gets finished. Writing an idea down satisfies most of the urge to build it, and preserves it if it turns out to be good.

| Idea | Date | Why it's tempting | Why it's out of scope |
|------|------|-------------------|----------------------|
| | | | |

---

## 10. Release

| Field | |
|-------|--|
| **Store name** | |
| **Icon concept** | |
| **First screenshot** | *(the one that matters most — chapter 11.19)* |
| **Trailer length** | ≤60 s |
| **itch.io URL** | |
| **Play Console package** | |
| **Privacy policy URL** | |

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 0.1 | 2026-09-01 | Skeleton created. Filled in during Module 8. |
