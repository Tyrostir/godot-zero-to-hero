---
title: "The Presentation Spine — story, screens, narration and music, in every project"
document_id: SPINE
version: 1.0
status: Active
created: 2026-09-02
last_updated: 2026-09-02
update_trigger: "When a project's presentation requirements change"
---

# 🎬 The Presentation Spine

> **The problem this solves.** In most courses the title screen, the story, the music and the ending arrive in one lump near the end — by which point you have spent months building something that never once felt like a *game*. Worse, you learn presentation *once*, at the hardest possible difficulty, with no practice.
>
> **The fix.** Presentation is a **spine that runs through every project**, taught by doing, in three passes ([ADR-026](meta/Decisions.md#adr-026)). You build your first title screen in **Module 1**, not Module 7. It is crude. You rebuild it better twice.

---

## 1. What every project ships with

From **P01 onward**, no project is "done" until it has:

| | Requirement | Why it's non-negotiable |
|---|---|---|
| 🎬 | **A first-page animation** — an animated title/opening screen | It is the first thing anyone sees, and it is where you practise timing |
| 🏁 | **An end-page animation** — a results, completion or ending screen | Games that stop dead feel broken, regardless of how good the middle was |
| 🎵 | **Background music** — at least one loop, appropriate to the piece | Silence reads as "unfinished" faster than bad art does |
| 🔊 | **Ambience or a sound bed** where the piece has a place | |
| 📖 | **A narrative frame** — even one line of text | A premise changes how a player reads the same geometry |
| 🚶 | **A walkthrough** — the player is taught what to do without a wall of text | |

**Narration** joins from **Module 6** onward, once you can record and mix it.

> ⚠️ **This does not slow the course down.** Module 1's title screen is four chapters (1.35–1.38) and produces something crude. That crudeness is the point — you will rebuild it in Module 3 with a live 3D character, again in Module 5 with your own shaders, and finally in Module 7 as a directed, narrated, scored opening. Three passes: **naive → correct → professional** ([ADR-002](meta/Decisions.md#adr-002)).

---

## 2. The spine, project by project

| Project | Story | 🎬 First page | 🏁 End page | 🎵 Audio | 🚶 Walkthrough |
|---------|-------|--------------|------------|---------|---------------|
| **P00** Hello Phone | — | — | — | — | — *(toolchain only)* |
| **P01** Marble Runner | A one-line premise on the title card *(1.38)* | **Pass 1** — tween/`AnimationPlayer` title screen *(1.35)* | Results screen: time, collectibles, a payoff *(1.36)* | One music loop + 3 SFX *(1.37)* | Level 1 teaches by shape alone — no text |
| **P02** Foundry Kit | Environmental storytelling: a prop implies a place, a history, an owner *(2.22)* | Title re-skinned with **your own art** | — | — | — |
| **P03** Playground | Character identity — what the idle, silhouette and walk say about who this is *(3.11)* | **Pass 2** — live 3D character idling on the title *(3.12)* | — | Footsteps, landings, cloth | Teach the jump without a prompt |
| **P04** Hollow, Level 1 | The landmark as a story beat; what the ruins imply *(4.19)* | In-engine `Path3D` **level flythrough** as the menu backdrop *(4.20)* | Level-complete sequence | **Ambience bed** — the sound of a place *(4.22)* | ⭐ **The walkthrough designed in** — sightlines, affordance, critical path as narration *(4.21)* |
| **P05** VFX Lab | — | **Pass 3** — title driven by your own shaders: dissolve-in text, animated background *(5.22)* | — | — | — |
| **P06** Feel Pass | — | The title screen gets its audio and juice pass | End card with a stinger | ⭐ **Full audio pass** — buses, adaptive music, and **your first recorded narration** *(6.7–6.14)* | — |
| **P07** The Slice | ⭐ **The whole narrative module** *(7.1–7.8)* | ⭐ Splash → animated menu → **narrated cold open** *(7.16–7.18)* | ⭐ **Narrated ending** + credits over a theme *(7.21–7.22)* | ⭐ **Narration system** — cue-driven VO, synced subtitles, music ducking *(7.11)* | ⭐ **The guided walkthrough** — the first five minutes *(7.19)* |
| **P08** Warden | The character's story told through design | Menu character is now **yours**, idling | — | **Vocal identity** — barks, efforts, grunts, recorded by you *(8.2)* | — |
| **P09** Refactor | Narrative content becomes data a writer could edit *(9.5)* | — | — | Audio director refactor; music/SFX/narration sliders + subtitle toggle *(9.8)* | — |
| **P10** Ember Hollow | ⭐ Full arc across four levels and a boss | ⭐ Final polished intro | ⭐ Final ending + credits | ⭐ Full mix, narration, adaptive score | ⭐ **Player-facing walkthrough document** *(10.20)* + **trailer narration** *(10.18)* |

---

## 3. The three passes, spelled out

Presentation is the clearest example of the course's spiral ([ADR-002](meta/Decisions.md#adr-002)). You meet the title screen four times and it is a different lesson each time.

| Pass | Where | What you build | What you learn |
|------|-------|----------------|----------------|
| **1 — Naive** | 1.35 | A `Control` scene, a `Tween`, text that fades in, a button | That a title screen is just a scene — and that timing is everything and you are bad at it |
| **2 — Correct** | 3.12 | A live 3D character idling behind the UI, a slow camera drift | That a menu is a *place*, and that idle motion is what makes it feel alive |
| **3 — Better** | 5.22 | Your own shaders: dissolve-in title, animated background, a bloom pass | That mood is largely a rendering problem |
| **4 — Professional** | 7.16–7.18 | Logo sting → animated menu with its own theme → narrated cold open → title card → hand-off | That an opening is *directed* — pacing, camera language, sound design and restraint |

The same shape applies to the ending (1.36 → 7.21), to music (1.37 → 6.7 → 7.17), and to the walkthrough (level shape in 4.21 → directed onboarding in 7.19 → a written guide in 10.20).

---

## 4. Narration — the full path

You asked for narration specifically. It gets nine chapters, and it is taught the same way as everything else: you record before you theorise.

| Chapter | What you do |
|---------|-------------|
| **6.8** | **Writing for the ear** — a narration script is not a paragraph. Pacing, breath, sentence length, what to cut |
| **6.9** | ⭐ **Record it with what you already own** — a phone, a wardrobe full of clothes as a booth, Audacity. No purchase required |
| **6.10** | Clean the take: noise reduction, de-essing, compression, levelling — without making it sound processed |
| **6.11** | **The narration bus** — side-chain ducking music under voice; a mix that survives a phone speaker |
| **6.12** | **Synchronised subtitles**, and why they are not optional |
| **6.13** | **Text-to-speech** as a legitimate option — when it's right, which engines are free for commercial use, and the licensing trap |
| **6.14** | Drill: narrate your Level 1 opening three ways — plain, over-directed, silent. Pick one and defend it |
| **7.6** | **Directing narration** — who is speaking, to whom, in what tense, from what distance, and when silence is stronger |
| **7.11** | ⭐ **The narration system in C#** — cue-driven VO, synced subtitles, automatic ducking, a skip that doesn't break state |
| **8.2** | **Vocal identity** — the Warden's barks, efforts and grunts |
| **10.18** | **Trailer narration** — a 60-second script and the cut |

> 💡 **You do not need a microphone to start.** 6.9 is built around a phone's voice recorder and a room full of soft furnishings, because the fastest way to learn what makes a voice track bad is to make a bad one and fix it. If you later want a USB microphone, the chapter says what to look for — but nothing in this course requires you to buy one.

> ♿ **Subtitles are mandatory, not a stretch goal** ([ADR-027](meta/Decisions.md#adr-027)). Any narration you add must ship with synchronised captions and a toggle. A phone gets played on mute, on a bus, by someone who is deaf, and by someone whose battery is at 4%. All four are the same requirement.

---

## 5. Music and ambience — the full path

| Chapter | What you do |
|---------|-------------|
| **1.37** | One loop and three sounds — the minimum that stops a game feeling like a prototype |
| **6.3** | Sourcing free music and SFX legally — Sonniss, Freesound, Kenney, Pixabay, Incompetech, and the licences to refuse |
| **6.4** | Editing in Audacity: trim, normalise, fade, pitch variation, **loop points** |
| **6.6** | Adaptive music — loops, stingers, layered intensity |
| **6.7** | **Music that doesn't wear out** — variation, dynamic range, and the courage to use silence |
| **4.22** | **Ambience** — the sound of a place, and why silence reads as "unfinished" |
| **7.17** | The menu's own theme |
| **7.22** | An end-credits theme, under the generated credits roll |
| **9.8** | Separate music / SFX / narration volume sliders, and a subtitle toggle |

---

## 6. Where the theory lives

Consistent with [ADR-002](meta/Decisions.md#adr-002), none of the above opens with theory. In every case you build the crude version, hit the wall, and *then* get the explanation:

| You build… | …then you learn |
|---|---|
| A title screen that feels wrong (1.35) | Timing, easing, and why 200 ms reads as "snappy" and 800 ms as "sluggish" |
| A results screen nobody reads (1.36) | Pacing a payoff; why information needs a beat before it arrives |
| A level people get lost in (4.21) | Affordance, sightlines, gating, the critical path |
| A narration take that sounds amateur (6.9) | Proximity effect, room reflections, plosives, noise floor |
| Voice buried under music (6.11) | Side-chain ducking, frequency masking, mixing for a 3 cm speaker |
| An opening testers skip (7.18) | Shot language, the cold open, and earning attention before spending it |
| A guide you can't write clearly (10.20) | That an unexplainable design is usually an unclear one |

---

## 7. Tracking

Every item in §2 appears as a **done-criterion** on its project in [`../projects/README.md`](../projects/README.md). A project with a missing title screen, a missing ending or no music is not shipped, regardless of how good its gameplay is.
