---
title: "Setup 05 — Git, the Repo, and Your First Deploy"
document_id: SETUP-05
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When the repo layout or the P00 procedure changes"
---

# 🚀 Setup 05 — Git, the Repo, and Your First Deploy

> **By the end of this guide** a game you built will be installed and running on your own Android phone, and its source will be committed to git.
>
> ⭐ **This is Project 00 — "Hello Phone".** It is the most important 45 minutes in the course.

---

## 1. Why this comes before anything else

The hardest part of Android game development is the toolchain, and it has nothing to do with game development. Getting a signed APK onto a device involves **six independent tools**:

```text
Godot editor
   └─ .NET SDK / MSBuild        compiles your C#
       └─ Godot export templates the engine binary for Android
           └─ JDK                runs the Android build tooling
               └─ Android build-tools  packages and signs
                   └─ adb        installs onto the device
```

Every one of them can fail on its own. Doing this on day one — when the game is a single cube and there is nothing to blame but the tooling — means you debug the pipeline **once**, in isolation. Afterwards, when something breaks, you know the pipeline works, so it's your code. That certainty is worth several days.

This is recorded as **[ADR-005](../meta/Decisions.md#adr-005)**.

---

## 2. Git

```bash
git config --global user.name  "Your Name"
git config --global user.email "you@example.com"
```

Clone this course repo onto your **desktop** (not just Termux — the desktop is where projects live):

```bash
git clone https://github.com/Tyrostir/godot-zero-to-hero.git
cd godot-zero-to-hero
```

The root `.gitignore` already covers Godot + .NET. Chapter **0.7** explains each line, and covers when Git LFS is worth the trouble (short version: `.blend` files and large textures yes; everything else no).

---

## 3. Build P00

1. **New Godot project** at `projects/P00_HelloPhone/`. Renderer: **Forward+** for now (you switch to Mobile in ch 4.13).
2. Scene: `Node3D` root named `Main`.
3. Add `MeshInstance3D` child → give it a `BoxMesh`.
4. Add `Camera3D` at `(0, 2, 4)`, rotated about −25° on X so it looks at the box.
5. Add a `DirectionalLight3D` so you can see it.
6. Attach `Spinner.cs` to the box:

```csharp
using Godot;

public partial class Spinner : Node3D
{
    [Export] public float DegreesPerSecond { get; set; } = 90f;

    public override void _Ready()
    {
        GD.Print("Hello Phone — Spinner ready.");
    }

    public override void _Process(double delta)
    {
        RotateY(Mathf.DegToRad(DegreesPerSecond) * (float)delta);
    }
}
```

7. Press **Build** (hammer icon). It must succeed.
8. Press **F5**. The cube spins on the desktop.

---

## 4. Export to Android

1. `Project → Export… → Add… → Android`.
2. Set **Package → Unique Name** to something unique and reverse-domain shaped, e.g. `com.tyrostir.hellophone`.
   > ⚠️ It must contain at least one dot, must not start with a digit, and no segment may be a Java keyword. Godot will tell you if it isn't valid.
3. Leave everything else default for now.
4. With the phone connected (`adb devices` showing it), press the **remote deploy** button — the small phone icon in the top-right toolbar.

**The cube spins on your phone.** 🎉

---

## 5. Verify the whole loop

- [ ] Change `DegreesPerSecond` to `360`, redeploy, confirm the change on the phone
- [ ] Run `adb logcat | grep -i godot` and find your `Hello Phone — Spinner ready.` line
- [ ] Rotate the phone — confirm the app handles orientation (or lock it in export settings)

That last step is the point: **your `GD.Print` output reaches the desktop from the device.** That is your debugging lifeline for the next 400 hours.

---

## 6. Commit

```bash
git add projects/P00_HelloPhone
git commit -m "P00: hello phone — spinning cube on device"
git push
```

---

## 7. Now break it on purpose — exercise C0.1

This is not optional. Do all three, and **write the exact error text into [../reference/Troubleshooting.md](../reference/Troubleshooting.md)**:

1. Rename `debug.keystore` to `debug.keystore.bak`. Deploy. Read the error. Restore.
2. Delete your export templates (`Editor → Manage Export Templates → Uninstall`). Deploy. Read the error. Reinstall.
3. Set the package name to `hellophone` (no dot). Try to export. Read the error. Fix it.

You now recognise the three most common Android export failures **on sight**, which is a skill you would otherwise acquire slowly and painfully over the next six months.

---

## ✅ Setup complete

Everything installed, everything verified, and a build of your own on your phone.

➡️ **Next:** [Module 1 — Godot Foundations](../TableOfContents.md#module-1--godot-foundations), starting with chapter 1.1. Ask me: *"start 1.1"*.
