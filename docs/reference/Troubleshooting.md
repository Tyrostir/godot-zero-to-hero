---
title: "Troubleshooting — Errors You Will Hit, and Their Fixes"
document_id: TROUBLE
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Every time an error is encountered and solved — by either of us"
---

# 🔧 Troubleshooting.md

> **This file grows as you break things.** When you hit an error and solve it, add it here with the **exact error text** — that's what makes it searchable when it recurs in eight months.
>
> ⚠️ Entries marked `[UNVERIFIED]` describe the *expected* error text, written from documentation rather than observation ([ADR-016](../meta/Decisions.md#adr-016)). When you hit the real one, replace it with the actual wording and drop the marker.

---

## How to add an entry

| Field | |
|---|---|
| **Symptom** | The exact message, or the exact visible behaviour |
| **Cause** | What was actually wrong |
| **Fix** | The steps |
| **Why it happens** | So you recognise the *class* of problem next time |

---

## 1. Godot — C# and building

### C# scripts do nothing / no Build button
**Symptom:** `[UNVERIFIED]` a message to the effect of *"C# support is not enabled"*, or no hammer icon in the toolbar.
**Cause:** You are running the standard Godot build, not the .NET build.
**Fix:** Download the **.NET** build from <https://godotengine.org/download>. Confirm in `Help → About`.
**Why:** Godot ships two separate binaries. Only one contains the .NET runtime.

### "Attached script is invalid" after editing
**Cause:** C# needs compiling; the last edit hasn't been built.
**Fix:** Press **Build** (hammer icon). Godot usually builds on F5, but not in every case.
**Why:** GDScript is interpreted, C# is compiled. Edit → **Build** → run.

### Script attaches but nothing happens
**Cause:** Class name doesn't match the file name, or the class isn't `public partial`.
**Fix:** `public partial class Foo : Node` must live in `Foo.cs`.

### Build fails with an MSBuild / SDK error
**Cause:** .NET SDK missing, or a version mismatch with the project's `<TargetFramework>`.
**Fix:** `dotnet --list-sdks`; install the SDK matching the TFM in the generated `.csproj`.

---

## 2. Android export

### Missing export templates
**Symptom:** `[UNVERIFIED]` an export error naming the expected template version.
**Cause:** Templates absent, or the wrong version, or the non-.NET variant.
**Fix:** `Editor → Manage Export Templates → Download and Install`. Must match the editor version **exactly**, including the release suffix and the .NET variant.
**Why:** The template *is* the engine binary for that platform; a version mismatch means engine and project disagree about the data format.

### Invalid package name
**Cause:** No dot, a leading digit in a segment, or a Java keyword as a segment.
**Fix:** Use reverse-domain form: `com.yourname.yourgame`.

### Keystore errors
**Symptom:** `[UNVERIFIED]` an export failure referring to the debug keystore.
**Cause:** Path wrong in `Editor Settings → Export → Android`, or the file was never created.
**Fix:** Re-run the `keytool` command in [Setup 04 §3](../guides/Setup_04_Android_And_Device.md) and re-point the setting.

### APK installs but crashes instantly
**Causes, in order of likelihood:** template/editor version mismatch · a missing .NET dependency for Android · an unhandled exception in `_Ready`.
**Fix:** `adb logcat | grep -i -E "godot|mono|AndroidRuntime"` immediately after launch. The stack trace is there.

---

## 3. Device connection

### `adb devices` shows `unauthorized`
**Cause:** The RSA prompt was not accepted, or the screen was locked when you plugged in.
**Fix:** Unlock the phone, replug, accept, tick *Always allow*. If no prompt appears: Developer Options → *Revoke USB debugging authorisations*, then retry.

### `adb devices` list is empty
**Windows:** missing OEM USB driver.
**Linux:** missing `udev` rule for your vendor ID, or `no permissions`.
**Both:** a charge-only USB cable. Try another cable before anything else — this catches more people than it should.

### Wireless adb keeps dropping
**Cause:** The phone changed IP, or Wi-Fi power saving suspended the connection.
**Fix:** Re-run `adb connect <ip>:5555`. Give the phone a static DHCP lease. Disable Wi-Fi power saving in Developer Options.

---

## 4. Blender → Godot

### Model arrives at 1/100th (or 100×) the expected size
**Diagnostic order:** object scale in the N-panel (and was `Ctrl+A → Apply` done?) → scene Unit Scale → was the asset authored in centimetres → glTF export options → Godot's import-dock scale.
**Fix it at the earliest wrong point.** Scaling the node in Godot leaves broken physics, lighting and rigging later.

### Model is inside-out or lit wrongly
**Cause:** Flipped normals.
**Fix:** Blender edit mode → select all → `Alt+N → Recalculate Outside`. Enable the *Face Orientation* overlay to see it.

### Shading looks faceted or blotchy
**Causes:** unapplied non-uniform scale · missing Shade Smooth / auto-smooth angle · duplicate vertices (`M → By Distance`) · a normal map with the wrong green-channel convention.

### Materials come in wrong or get overwritten on re-import
**Cause:** Godot re-imports the whole file by default.
**Fix:** Use the inherited-scene pattern, or extract materials as separate resources (chapter B19).

### Animations missing after export
**Cause:** Actions not stashed / no fake user; or the glTF export panel's animation options unticked.
**Fix:** Chapter B28.

---

## 5. Performance on device

### Runs fine on desktop, terrible on the phone
**Diagnostic order:** (1) which renderer is the export using — Forward+ on a phone is often the whole answer, try **Mobile**; (2) split CPU vs GPU frame time on-device before changing anything; (3) if GPU-bound: overdraw, transparency, texture sizes and compression, real-time shadows, real-time GI; (4) if CPU-bound: draw calls, physics bodies, per-frame allocations.
**Rule:** change one thing, measure, write it down. Optimisation without measurement is superstition.

### Framerate is fine for 30 seconds then collapses
**Cause:** Thermal throttling. This is normal and expected on phones.
**Fix:** Benchmark over **five minutes**, not thirty seconds. Reduce sustained GPU load, not peak load.

### A brief freeze the first time an effect appears
**Cause:** Shader compilation stutter.
**Fix:** Prewarm materials during loading (chapter 6.12).

---

## 6. Your entries

Add yours below. Exact error text, please.

### `[template]`
**Symptom:**
**Cause:**
**Fix:**
**Why it happens:**
