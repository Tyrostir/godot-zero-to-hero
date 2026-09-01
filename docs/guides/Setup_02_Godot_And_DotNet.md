---
title: "Setup 02 — Godot 4 (.NET) and the .NET SDK"
document_id: SETUP-02
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When Godot's .NET requirements or download layout change"
---

# 🎮 Setup 02 — Godot 4 (.NET) and the .NET SDK

> **By the end of this guide** you will have a Godot editor that compiles C# successfully, with matching export templates installed.

---

## 1. Download the **.NET** build — not the standard one

**Download page:** <https://godotengine.org/download>

Godot ships **two separate binaries** per platform:

| Build | Contains | Use it? |
|---|---|---|
| Standard | GDScript only | ❌ No |
| **.NET** (sometimes labelled Mono) | GDScript **+ C#** | ✅ **This one** |

> ⚠️ **The single most common Module 0 mistake.** Download the standard build, write a C# script, and get *"C# support is not enabled"* or simply no Build button. Verify in **Help → About** — the .NET build says so explicitly.

Godot is portable — there is no installer. Unzip it somewhere **permanent** (not `Downloads`) and make a shortcut. Record the version in [Setup 01's version log](Setup_01_Prerequisites.md#3-your-version-log).

---

## 2. Install the .NET SDK

Godot's C# support needs the .NET **SDK** — not just the runtime, because it invokes MSBuild to compile your code.

**Download:** <https://dotnet.microsoft.com/download>

Install the **LTS SDK matching the target framework your Godot version generates**. Godot 4.2+ projects target `net8.0` by default. To check what yours wants: create a throwaway project, add a C# script, and open the generated `.csproj` — the `<TargetFramework>` line is authoritative.

**Verify:**

```bash
dotnet --version
dotnet --list-sdks
```

`[UNVERIFIED]` — the exact TFM your Godot version emits. Paste the `<TargetFramework>` line from your generated `.csproj` into [`toAgent/`](../../toAgent/) and this marker clears.

---

## 3. Point Godot at the SDK

`Editor → Editor Settings → Dotnet → Editor`

- **Editor Path** — usually auto-detected. If not, point it at your `dotnet` binary.
- **External Editor** — set to VS Code or Rider (see §5).

---

## 4. Export templates

`Editor → Manage Export Templates → Download and Install`

> ⚠️ Templates must match your editor version **exactly**, including the release suffix (`4.x.y.stable` vs `4.x.y.rc1`) **and** the .NET variant. A mismatch gives you either an export error naming the expected version, or — worse — an APK that installs and crashes instantly.
>
> **When you upgrade Godot, re-download templates in the same sitting.** Write it on a sticky note.

---

## 5. Code editor

Either works well:

| Editor | Cost | Notes |
|---|---|---|
| **VS Code** + *C# Dev Kit* extension | Free | Light, fine for everything in this course |
| **JetBrains Rider** | Free for non-commercial use | First-class Godot plugin: run configurations, attach-debugger, better refactoring. If you qualify, it's the better experience |

Set it in `Editor Settings → Dotnet → Editor → External Editor`.

---

## 6. Smoke test — does C# actually compile?

1. New project → any renderer → create.
2. Add a `Node3D` root, then a `MeshInstance3D` child with a `BoxMesh`.
3. Attach a **C#** script to the box named `Spinner.cs`:

```csharp
using Godot;

public partial class Spinner : Node3D
{
    [Export] public float DegreesPerSecond { get; set; } = 90f;

    public override void _Process(double delta)
    {
        RotateY(Mathf.DegToRad(DegreesPerSecond) * (float)delta);
    }
}
```

4. Press **Build** (the hammer icon, top right). **It must succeed before the game can run.**
5. Press **F5**. The cube spins.
6. While it runs, change `DegreesPerSecond` in the inspector. It should take effect immediately.

> 💡 **Note the two-step nature of C# in Godot:** edit → **build** → run. GDScript skips the build step. Forgetting to build after an edit — and wondering why nothing changed — is a rite of passage. Godot builds automatically on F5 in most cases, but not always.

---

## 7. If it failed

| Symptom | Cause | Fix |
|---|---|---|
| No Build button / "C# support is not enabled" | Standard build, not .NET | Re-download the .NET build |
| `MSB…` / "SDK not found" | .NET SDK missing or wrong version | Install the SDK matching your `.csproj` TFM |
| Build succeeds, script does nothing | Class name ≠ file name, or missing `partial` | Godot requires `public partial class X : Node` in `X.cs` |
| "Attached script is invalid" | Build has not run since the last edit | Press Build |

More in [../reference/Troubleshooting.md](../reference/Troubleshooting.md).

➡️ **Next:** [Setup 03 — Blender](Setup_03_Blender.md)
