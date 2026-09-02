---
title: "Setup 01 — Prerequisites: Machines, Roles and Hardware"
document_id: SETUP-01
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When hardware requirements or the machine split change"
---

# 🖥️ Setup 01 — Prerequisites

> **By the end of this guide** you will have decided which machine you build on, confirmed it can do the job, and started the version log that every later guide writes into.

---

## 1. Three devices, three jobs

Getting this straight now prevents a great deal of frustration later.

| Device | Role | What runs here |
|---|---|---|
| 💻 **Desktop / laptop** (Windows, Linux or macOS) | **The workshop** | Godot editor, Blender, .NET SDK, Android SDK, your code editor. **All real work happens here.** |
| 📱 **Android phone** | **The target** | Your game. You deploy to it constantly, and it is the only honest judge of performance and touch controls. |
| 🐧 **Termux session** (this one) | **The notebook** | Planning, docs, git, asking me questions. No builds. |

### ⚠️ Why you cannot do this course on the phone alone

Godot ships an Android editor build, and it is genuinely impressive — but it has **no C#/.NET support**. Godot's C# scripting needs a desktop .NET SDK and MSBuild, neither of which exists in the Android editor. If you were writing GDScript, developing entirely on the phone would be viable. You are writing C#, so it is not.

This is recorded as **[ADR-004](../meta/Decisions.md#adr-004)**.

---

## 2. Minimum realistic desktop spec

| Component | Minimum | Comfortable | Why |
|---|---|---|---|
| RAM | 8 GB | **16 GB** | Blender and Godot open simultaneously is the normal working state from Module 3 onward |
| GPU | Vulkan-capable | Anything from the last 6 years | Godot 4's Forward+ renderer requires Vulkan; lightmap baking uses the GPU |
| Disk | 40 GB free | 100 GB | Godot ~1 GB, Blender ~1 GB, Android SDK ~8 GB, and your own assets grow fast |
| CPU | 4 cores | 8 cores | Lightmap baking and Blender simulation are the two things that will punish a weak CPU |
| OS | **Linux** — your choice ([D-001](../meta/Doubts.md)) | — | Win 10+ and macOS 12+ also work; the guides lead with Linux |

**The two operations that will expose a weak machine** are sculpting in Blender (Module 9) and baking lightmaps (Module 5). Everything else is comfortable on modest hardware.

---

## 3. Your version log

Fill each row as you complete guides 02–05. When something in this course doesn't match your editor, **this table is the first place to look**.

| Tool | Version installed | Date | Path / notes |
|---|---|---|---|
| Desktop OS | | | |
| Godot (**.NET build**) | | | must be the .NET download, not the standard one |
| Godot export templates | | | must match the editor version *exactly* |
| .NET SDK | | | `dotnet --version` |
| Blender | | | |
| JDK (OpenJDK) | | | `java -version` |
| Android SDK build-tools | | | |
| Android SDK platform (API level) | | | |
| Android platform-tools (`adb`) | | | `adb version` |
| Code editor | | | VS Code + C# Dev Kit, or Rider |
| Git | | | `git --version` |

### Your test device

| Field | Value | How to find it |
|---|---|---|
| Phone model | | Settings → About phone |
| Android version | | Settings → About phone |
| Chipset / GPU | | Settings → About phone, or an app like *Device Info HW* |
| RAM | | |
| Screen resolution & refresh rate | | Determines your frame budget |
| Has a notch / cutout? | | Decides how much ch 1.29 (safe area) matters to you |
| Vulkan supported? | | *Vulkan Hardware Capability Viewer* on the Play Store |

> 💡 **Why the device details matter.** Vulkan support decides whether you can use Godot's **Mobile** renderer or must fall back to **Compatibility** (ch 5.13). The GPU decides your realistic triangle and shader budget. Answer [D-003](../meta/Doubts.md) with this table.

---

## 4. A second test device, if you can

Your daily phone is probably better than your median player's. If you can borrow an older or cheaper Android device — even a 5-year-old one — it becomes your **performance truth**. Build for that one; the good phone will look after itself.

Not essential. Genuinely valuable.

---

## 5. Before you continue

- [ ] Desktop machine chosen and it meets the minimum spec
- [ ] Phone has a USB cable that carries **data**, not just power (this catches more people than you'd think)
- [ ] ~40 GB free on the desktop
- [ ] Version log table above is present and empty, ready to fill

➡️ **Next:** [Setup 02 — Godot and .NET](Setup_02_Godot_And_DotNet.md)
