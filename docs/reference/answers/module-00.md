# Answers — Module 0: Toolchain

**1. Why the .NET build specifically?**
Godot ships two binaries per platform: the standard build and the **.NET (Mono)** build. Only the .NET build contains the C# scripting runtime and the tooling that invokes MSBuild. With the standard build, adding a C# script gives you a message along the lines of *"C# support is not enabled"* / the build button is absent. Check **Help → About** — the .NET build says so.

**2. Export templates and versions.**
Export templates must match your editor version **exactly**, including the release suffix (`4.x.y.stable` vs `4.x.y.rc1`, and the `.mono`/`.NET` variant). A mismatch produces an export error naming the expected version, or — worse — an APK that installs and immediately crashes. When you upgrade Godot, re-download templates in the same sitting.

**3. Three devices, three jobs.**
Desktop = the workshop (Godot, Blender, .NET SDK, Android SDK — all real work). Phone = the target (the only honest judge of performance and touch controls). Termux session = the notebook (planning, docs, git, questions).

**4. Why not the Android editor build?**
Godot's Android editor exists and works, but it has **no C#/.NET support** — the .NET runtime and MSBuild toolchain aren't part of it. C# requires a desktop .NET SDK. If you were writing GDScript, developing on the phone would be viable.

**5. The debug keystore.**
Android refuses to install an unsigned package. Every APK must be signed with a certificate; the "debug keystore" is a throwaway certificate with well-known credentials (`androiddebugkey` / `android`) used for development builds. Release builds need your own keystore, which you must **back up** — losing it means you can never publish an update to that app listing again (ch 11.14).

**6. `adb devices` says `unauthorized`.**
The phone showed an *"Allow USB debugging?"* dialog and it wasn't accepted (or the screen was locked when you plugged in). Unlock the phone, unplug/replug, and tick *Always allow from this computer*. If no dialog appears, revoke USB debugging authorisations in Developer Options and try again.

**7. Six tools in the chain.**
Godot editor → .NET SDK/MSBuild (compiles your C#) → Godot export templates (the engine binary for Android) → JDK (runs the Android build tooling) → Android SDK build-tools (packages and signs) → adb/platform-tools (installs onto the device). Each can fail independently, which is exactly why you test the chain on day one.

**8. Why deploy in Module 0?**
Because toolchain failures and game-code failures are completely different problems, and debugging them simultaneously is miserable. With one spinning cube, any failure is *definitely* the pipeline. Later, when something breaks, you'll know the pipeline works — so it's your code. That certainty is worth several days.
