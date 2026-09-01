---
title: "Setup 04 — JDK, Android SDK and Your Device"
document_id: SETUP-04
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When Android tooling versions or Godot's Android export requirements change"
---

# 🤖 Setup 04 — JDK, Android SDK and Your Device

> **By the end of this guide** `adb devices` will list your phone, and Godot will know where every Android tool lives.

> 📎 **The authoritative page, always current:** <https://docs.godotengine.org/en/stable/tutorials/export/exporting_for_android.html>
> Read it alongside this guide. Where they disagree, it wins — and log the difference.

---

## 1. Java (JDK)

Android's build tooling needs a JDK. **OpenJDK 17** is the well-trodden choice for current Android tooling.

**Download:** <https://adoptium.net/> (Temurin 17), or your package manager.

```bash
java -version    # expect 17.x
```

---

## 2. Android SDK — two routes

### Route A — Android Studio (easier, ~8 GB)

Install <https://developer.android.com/studio>. Open **SDK Manager** and install:

- SDK Platform (current API level)
- SDK Build-Tools
- SDK Platform-Tools
- Command-line Tools

You never need to open Android Studio again after this.

### Route B — command-line tools only (leaner, ~1 GB)

Download *"Command line tools only"* from the bottom of <https://developer.android.com/studio>, unzip to `~/android-sdk/cmdline-tools/latest/`, then:

```bash
export ANDROID_HOME=~/android-sdk
$ANDROID_HOME/cmdline-tools/latest/bin/sdkmanager --sdk_root=$ANDROID_HOME \
  "platform-tools" "build-tools;34.0.0" "platforms;android-34" "cmdline-tools;latest"

$ANDROID_HOME/cmdline-tools/latest/bin/sdkmanager --licenses
```

`[UNVERIFIED]` — the exact API level and build-tools version your Godot release expects. The official export page above states it; paste what it says into [`toAgent/`](../../toAgent/) and this marker clears.

---

## 3. The debug keystore

Android refuses to install an unsigned package. Development builds are signed with a throwaway certificate with well-known credentials:

```bash
keytool -keyalg RSA -genkeypair -alias androiddebugkey -keypass android \
  -keystore debug.keystore -storepass android \
  -dname "CN=Android Debug,O=Android,C=US" -validity 9999 -deststoretype pkcs12
```

Put the resulting `debug.keystore` somewhere permanent.

> 🔒 **Release keystores are different and precious.** You'll make one in chapter 10.14. **Losing a release keystore means you can never publish an update to that app listing again** — Google cannot recover it for you. Back it up in two places the day you create it.

---

## 4. Tell Godot where everything is

`Editor → Editor Settings → Export → Android`:

| Setting | Value |
|---|---|
| Java SDK Path | your JDK root |
| Android SDK Path | your SDK root |
| Debug Keystore | the `debug.keystore` you just made |
| Debug Keystore User | `androiddebugkey` |
| Debug Keystore Pass | `android` |

---

## 5. Connect the phone

1. **Phone:** `Settings → About phone` → tap **Build number** seven times. Developer Options unlocks.
2. **Phone:** `Settings → Developer options` → enable **USB debugging**. Also enable **Stay awake** while charging — you'll thank yourself.
3. Plug in via USB. **Accept the RSA fingerprint prompt on the phone**, ticking *Always allow from this computer*.
4. **Desktop:**

```bash
adb devices
```

You want a line ending in `device`.

| Output | Meaning | Fix |
|---|---|---|
| `<serial>  device` | ✅ Working | — |
| `<serial>  unauthorized` | Prompt not accepted, or screen was locked | Unlock, replug, accept. If no prompt: revoke USB debugging authorisations in Developer Options and retry |
| Empty list (Windows) | Missing OEM USB driver | Install your phone manufacturer's ADB driver |
| Empty list (Linux) | Missing `udev` rule | Add a rule for your vendor ID, then `sudo udevadm control --reload` |
| `no permissions` (Linux) | Same as above | Same |

### Wireless debugging (Android 11+) — set this up now

Once paired over USB:

```bash
adb tcpip 5555
adb connect <phone-ip>:5555
```

Unplug. Deploy over Wi-Fi. **You will do this thousands of times over this course** — the 10 minutes spent here pays back within the week.

---

## 6. Smoke test

```bash
adb devices          # your phone, ending in "device"
adb shell getprop ro.product.model     # your phone's model name
adb logcat -c && adb logcat | head -5  # log stream works
```

`adb logcat` is how you read crashes and `GD.Print` output from the device (chapter 0.9). Learn to filter it early:

```bash
adb logcat | grep -i godot
```

➡️ **Next:** [Setup 05 — Git and your first deploy](Setup_05_Git_And_FirstDeploy.md)
