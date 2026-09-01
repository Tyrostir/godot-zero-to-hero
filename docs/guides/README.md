---
title: "Setup Guides — Index"
document_id: GUIDES
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a guide is added or a tool's install procedure changes"
---

# 🛠️ docs/guides/

Everything you install, in the order you install it. Do them in sequence — each one assumes the previous is finished.

| # | Guide | Time | Produces |
|---|-------|------|----------|
| 01 | [Prerequisites — machines, roles and hardware](Setup_01_Prerequisites.md) | 20 m | A decision about which machine you build on, and a filled-in version log |
| 02 | [Godot 4 (.NET) and the .NET SDK](Setup_02_Godot_And_DotNet.md) | 40 m | A Godot editor that compiles C# |
| 03 | [Blender, configured once](Setup_03_Blender.md) | 30 m | A Blender you won't have to fight |
| 04 | [JDK, Android SDK and your device](Setup_04_Android_And_Device.md) | 60 m | `adb devices` showing your phone |
| 05 | [Git, the repo, and your first deploy](Setup_05_Git_And_FirstDeploy.md) | 45 m | ⭐ **P00 running on your phone** |

> ⚠️ **Version numbers rot.** Every version in these guides is a *known-good starting point*, and every section links the official page that is always current. When they disagree, the official page wins — and you log the difference in [Setup_01's version table](Setup_01_Prerequisites.md#3-your-version-log).

> 🔍 **`[UNVERIFIED]` markers.** I write these guides but I cannot run Godot, Blender or `adb` — see [../internal/VerificationRuns.md](../internal/VerificationRuns.md). Any claim I could not verify carries an `[UNVERIFIED]` marker. When you run it on your desktop and paste the result into [`toAgent/`](../../toAgent/), the marker gets cleared and the guide becomes fact.
