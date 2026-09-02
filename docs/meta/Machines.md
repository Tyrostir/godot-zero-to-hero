---
title: "Machines — the three devices this course runs on"
document_id: MACHINES
version: 1.0
status: Template — fill this in during chapter 0.1
created: 2026-09-02
last_updated: 2026-09-02
update_trigger: "Chapter 0.1, then whenever a machine changes or a tool version is installed"
---

# 🖥️📱🐧 Machines

> **This file is yours to fill in.** Chapter [0.1](../chapters/Chapter_00.01_MachinesAndTheirRoles.md) populates the hardware; [0.2](../chapters/Chapter_00.02_GodotAndDotNet.md)–[0.4](../chapters/Chapter_00.04_AndroidToolchain.md) add the tool versions.
>
> Mark a field `?` if you genuinely could not find it. **Never guess** — a wrong number here is worse than a missing one, because you will trust it later.

---

## Roles ([ADR-004](Decisions.md#adr-004))

| Role | Machine | Runs here | Must never happen here |
|------|---------|-----------|------------------------|
| 🖥️ Workshop | | Godot, Blender, .NET SDK, Android SDK, editor | Performance judgements |
| 📱 Target | | The game. Every build. Every measurement | Authoring |
| 🐧 Notebook | Termux | Docs, git, planning, questions | Builds of any kind |

---

## Workshop — desktop *(chapter 0.1)*

| Field | Value |
|-------|-------|
| OS / version | |
| Kernel | |
| CPU model | |
| Cores / threads | |
| RAM | |
| Free disk (home) | |
| GPU | |
| Vulkan working? | |
| Data cable verified? | |

---

## Target — phone (Tier: **Mid**) *(chapter 0.1)*

| Field | Value |
|-------|-------|
| Model | |
| Android version | |
| RAM | |
| Chipset | |
| GPU | |
| Resolution | |
| Refresh rate | |
| Notch / cutout | |
| Free storage | |
| Vulkan? | |
| ⇒ **Renderer implied** | Mobile / Compatibility |

---

## Second target — phone (Tier: **Low**) *(optional — chapter 0.1, P3)*

| Field | Value |
|-------|-------|
| Model | |
| Chipset / GPU | |
| RAM | |
| ⇒ This is my **performance truth** | |

---

## Ratios *(chapter 0.1, Observe)*

| | Desktop | Phone | Ratio |
|---|---|---|---|
| RAM | | | × |
| Cores | | | × |
| Free storage | | | × |

---

## Tool versions

*Filled in as you install each one. **Never write "latest"** ([ADR-013](Decisions.md#adr-013) — a build you cannot reproduce in six months is not a release).*

| Tool | Version | Chapter | Notes |
|------|---------|---------|-------|
| Godot (**.NET** build) | | 0.2 | must be the .NET/mono download |
| Godot export templates | | 0.2 | must match the editor exactly |
| .NET SDK | | 0.2 | `dotnet --list-sdks` |
| `<TargetFramework>` in `.csproj` | | 0.2 | the authoritative SDK requirement |
| Blender | | 0.3 | |
| Units verified (3 m cube → Godot) | ✅ / ❌ | 0.3 | |
| JDK | | 0.4 | `java -version` |
| Android build-tools | | 0.4 | |
| Android platform (API level) | | 0.4 | |
| platform-tools (`adb`) | | 0.4 | `adb version` |
| `ANDROID_HOME` | | 0.4 | |
| Debug keystore path | | 0.4 | |
| Code editor | | 0.2 | |
| Git | | 0.1 | |

---

## Prediction *(chapter 0.1, P4)*

> On `<date>`, I predict the first thing to limit me on the phone will be **____**, because ____.

*Checked in Module 6. Being wrong is more instructive than being right — do not edit the original.*

---

## 📝 Changelog

| Version | Date | Change |
|---|---|---|
| 1.0 | 2026-09-02 | Template created alongside chapter 0.1. |
