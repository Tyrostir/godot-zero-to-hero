---
title: "Platforms — which workshop configurations this course supports"
document_id: PLATFORMS
version: 1.0
status: Active
created: 2026-09-02
last_updated: 2026-09-02
update_trigger: "When a supported configuration changes, or a WSL limitation is resolved"
---

# 🖥️ Platforms

> **The course supports Windows 11 and Linux as the workshop, and every chapter gives commands for both.**
>
> **WSL2 is supported as a companion shell, not as the workshop.** That distinction is not pedantry — it is the difference between a working device-deploy loop and three weeks of fighting your environment. This page explains exactly why.

---

## 1. The three configurations

| | Config A — **Windows 11 native** | Config B — **Linux native** | Config C — **inside WSL2** |
|---|---|---|---|
| Godot editor | ✅ First-class | ✅ First-class | ⚠️ Runs via WSLg; Vulkan is a translation layer |
| Blender | ✅ First-class | ✅ First-class | ⚠️ GPU rendering unreliable |
| .NET SDK / MSBuild | ✅ | ✅ | ✅ |
| Android SDK / `sdkmanager` | ✅ | ✅ | ✅ |
| **`adb` over USB** | ✅ Needs OEM driver | ✅ Needs `udev` rule | ❌ **No USB passthrough** |
| `adb` wireless | ✅ | ✅ | ⚠️ Needs mirrored networking |
| Shell, scripting, `ffmpeg`, `git` | ⚠️ Via PowerShell / Git Bash | ✅ Native | ✅ Best of the three |
| **Verdict** | ✅ **Supported** | ✅ **Supported** | ❌ **Not supported as the workshop** |

**If your machine runs Windows 11: use Config A, and add WSL as a companion shell if you like it.** That is the recommended setup, and §3 describes it.

---

## 2. ⚠️ Why WSL2 cannot be the workshop

Three hard blockers, in order of severity.

### 2.1 No USB passthrough — this is the fatal one

**WSL2 is a virtual machine with no direct access to USB devices.** `adb` running inside WSL2 cannot see a phone plugged into your PC. There is no setting for this; it is architectural.

That matters more here than in most courses, because **deploying to a real device is this course's core loop** ([ADR-005](../meta/Decisions.md#adr-005), [ADR-034](../meta/Decisions.md#adr-034)). You will do it thousands of times. An environment where it needs a workaround is the wrong environment.

> 🔬 **The workarounds, and why they are not good enough for daily use.**
> - **`usbipd-win`** forwards USB over IP into WSL. It works, and it requires an elevated PowerShell `usbipd attach` after every replug, every reboot, and every time the phone's USB mode changes. `[UNVERIFIED]`
> - **Run `adb` on Windows, connect from WSL** by pointing `ADB_SERVER_SOCKET` at the Windows host. Also works, and now you are debugging two `adb` installations that must stay version-matched.
> - **Wireless `adb`** avoids USB entirely, but needs Windows 11's mirrored networking mode, and you still need one USB pairing to start.
>
> Each is a real solution to a problem you can avoid by not creating it.

### 2.2 Graphics go through a translation layer

Godot 4's renderers want Vulkan. WSLg provides GPU access through a Direct3D translation layer rather than your vendor's native Vulkan driver. Godot may run; it may also be slow, or hit driver paths nobody tests.

Blender is worse: GPU rendering (Cycles) is unreliable under WSL, and you will use it for bakes and cinematics from Module 3 onward.

**You are going to spend 500+ hours in these two editors.** Neither should be running through a compatibility shim.

### 2.3 The filesystem boundary is slow in the direction that matters

Windows files accessed from WSL (`/mnt/c/...`) go through a translation layer and are markedly slower than native. Linux files accessed from Windows (`\\wsl$\...`) likewise.

For **git and text**, that penalty is irrelevant. For an **engine importing a thousand assets** it is not.

---

## 3. ✅ The recommended Windows setup: native + WSL as companion

This gets you the best of both, with no fighting.

```text
🪟 Windows 11 (the workshop)          🐧 WSL2 / Ubuntu (the companion shell)
   ├── Godot 4 .NET editor              ├── git operations you prefer in bash
   ├── Blender                          ├── ffmpeg / ImageMagick batch work
   ├── .NET SDK                         ├── shell scripts
   ├── JDK + Android SDK                └── reading and editing docs
   ├── adb (USB, native driver)
   └── your project files ──────────► reachable from WSL at /mnt/c/...
```

**The rules that keep it clean:**

1. **The project lives on the Windows filesystem.** Godot, Blender and the Android SDK all read it natively and fast.
2. **WSL reaches it at `/mnt/c/Users/<you>/...`.** Slower, and completely fine for git, grep and scripts.
3. **`adb` runs on Windows only.** One installation, no version-matching games.
4. **Never run the Godot or Blender editor inside WSL.** If you find yourself doing it, you have drifted into Config C.

> 💡 **Why keep WSL at all?** Because `ffmpeg`, `ImageMagick`, `sed`, `find` and a real shell are genuinely nicer than the PowerShell equivalents, and this course uses all of them (chapters **B12b**, **6.18b**). Use it for what it is good at.

---

## 4. Command conventions in the chapters

Every chapter that runs commands gives both. Look for these markers:

> 🪟 **Windows (PowerShell)** — run in PowerShell, not Command Prompt
> 🐧 **Linux / WSL** — bash

Where a step is identical on both, it appears once with no marker. Where a step exists on **only one** platform, it says so plainly.

**Paths in prose** are written Linux-style (`~/android-sdk`). The Windows equivalent is normally `%USERPROFILE%\android-sdk`, and chapters give it explicitly wherever it matters.

---

## 5. Platform-specific gotchas you will meet

| Chapter | 🪟 Windows | 🐧 Linux |
|---|---|---|
| [0.2](../chapters/Chapter_00.02_GodotAndDotNet.md) | Unblock the downloaded zip (`Properties → Unblock`) or Defender may quarantine `GodotSharp` | `chmod +x` the binary |
| [0.2](../chapters/Chapter_00.02_GodotAndDotNet.md) | Templates at `%APPDATA%\Godot\export_templates\` | `~/.local/share/godot/export_templates/` |
| [0.3](../chapters/Chapter_00.03_Blender.md) | Installer or `winget`; both fine | Tarball, **not snap** — sandbox restricts file access |
| [0.4](../chapters/Chapter_00.04_AndroidToolchain.md) | `setx` for environment variables; **reopen the terminal** for them to apply | `~/.bashrc` and `source` |
| [0.5](../TableOfContents.md) | **OEM USB driver required** — the commonest reason `adb devices` is empty | **`udev` rule required** — the commonest reason it says `no permissions` |
| Everywhere | Long-path limits can bite deep asset trees; keep the project near the drive root | Case-sensitive filesystem — `Player.tscn` ≠ `player.tscn`, and Android is case-sensitive too |

> ⚠️ **The case-sensitivity difference is a real trap for Windows users.** Windows will happily load `res://Textures/rock.png` when the file is `res://textures/Rock.png`. **Android will not.** A game that runs on your desktop and fails on device with missing textures is almost always this. Be strict about case from chapter one — [`Conventions.md`](Conventions.md) has the naming rules.

---

## 6. If you switch machines mid-course

Entirely fine, and worth doing deliberately rather than by accident:

1. Record both machines in [`../meta/Machines.md`](../meta/Machines.md) — the template has room.
2. Re-run the verification commands on the new machine and update the version table. **Do not assume versions carried over.**
3. Watch for the case-sensitivity trap in both directions.
4. Re-check `adb devices` — the driver/rule situation is per-machine.

The repository is the source of truth, and it is in git. Nothing else needs to move.
