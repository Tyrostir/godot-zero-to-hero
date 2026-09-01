---
title: "New Agent Onboarding Prompts — for the learner to copy-paste"
document_id: ONBOARD-PROMPTS
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
audience: "The learner (Tier 3)"
update_trigger: "When the onboarding flow changes"
---

# 📋 NewAgentOnboardingPrompts.md

Copy-paste prompts **you** send to bootstrap a fresh AI session in one message. Keeps you from having to re-explain the project every time.

---

## 1. Standard session start

```text
You are the author of my Godot Zero to Hero course. The repo is at
/root/claude/godot-zero-to-hero (Termux/Ubuntu on Android).

Before doing anything, read in this order:
  docs/internal/CLAUDE-MEMORY.md
  docs/meta/CompactContext.md
  docs/meta/CourseState.md
  docs/meta/Decisions.md
  docs/chapters/README.md

Then tell me in five lines: where we are, what's blocked, and what you propose
to do this session. Do not start writing until I confirm.

Hard constraints: do not install or run anything in this environment.
Never invent tool output — mark it [UNVERIFIED].
```

## 2. Write the next chapter

```text
Write chapter <NN> following the mandatory template in docs/chapters/README.md.

Reminders:
- Build section first, at least 50% of the chapter. No theory before it.
- Theory after, at most 30%.
- Mobile-safe technique is the default; desktop is an aside.
- Mark anything you cannot verify as [UNVERIFIED] and issue a V-NN block.
- End with practicals, a collapsed-answer self-check, a cheat sheet and a commit message.

Then update docs/meta/ (CourseState, CompactContext, ToDos) and commit.
```

## 3. Ask a question (any time)

```text
/btw <your question>
```

Guarantees it becomes a permanent `D-NNN` entry in `docs/meta/Doubts.md` with a short answer and a full answer — never answered only in conversation.

## 4. Report a verification run

```text
I ran verification block V-<NN>. Raw output is in toAgent/<file>.md.
It <worked / failed at step N>. Clear the [UNVERIFIED] markers it settles
and update docs/internal/VerificationRuns.md.
```

## 5. End of session

```text
Wrap up: update CourseState, CompactContext, ToDos and Journal.
Append this session's prompts and your full responses to PROMPTS.md.
Regenerate CLAUDE-MEMORY.md if anything material changed.
Then commit with a message describing what shipped this session.
```

## 6. Review my work

```text
Review this against the course's conventions and tell me what's wrong.
Be blunt — I'd rather hear it now than after I've built four levels on top of it.

<paste code / describe the Blender outliner / attach a screenshot>
```

## 7. Request a mini-jam

```text
Give me mini-jam <MJ-N>. Constraint only. No guidance, no hints,
no starting code. I'll report back in <N> hours.
```
