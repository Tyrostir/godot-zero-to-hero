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

> ✅ **You are on Linux ([D-001](../meta/Doubts.md)), so take Route B.** It is a tenth of the size and you never need to open an IDE you won't use. Route A is documented for other readers.

### Route A — Android Studio (easier, ~8 GB)

Install <https://developer.android.com/studio>. Open **SDK Manager** and install:

- SDK Platform (current API level)
- SDK Build-Tools
- SDK Platform-Tools
- Command-line Tools

You never need to open Android Studio again after this.

### ⭐ Route B — command-line tools only (leaner, ~1 GB) — **your route**

**Download page:** <https://developer.android.com/studio> → **scroll to the very bottom** → heading **"Command line tools only"** → the row for your OS.

⚠️ **Not the big green button** at the top — that is Android Studio. You want `commandlinetools-<os>-<build>_latest.zip`, **~100–150 MB**. Anything named `android-studio-*` is the wrong file.

Unzip so the final path is `~/android-sdk/cmdline-tools/`**`latest`**`/bin/sdkmanager` — the archive extracts to `cmdline-tools/`, so you must rename that folder to `latest`. Then:

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
| Empty list (Linux) | Missing `udev` rule | ⭐ **This will be you.** See §5b below |
| `no permissions` (Linux) | Same as above | Same |

### 5b. The `udev` rule (Linux) ⭐

Without this, `adb` either shows nothing or reports `no permissions`, and the usual "fix" people reach for is running `adb` as root — which then fights with the user-owned adb server. Do it properly instead.

Find your phone's vendor ID:

```bash
lsusb
```

Look for your phone's manufacturer; the ID is the four hex digits before the colon in `ID 18d1:4ee7`. Then:

```bash
echo 'SUBSYSTEM=="usb", ATTR{idVendor}=="18d1", MODE="0666", GROUP="plugdev"' \
  | sudo tee /etc/udev/rules.d/51-android.rules
sudo udevadm control --reload-rules
sudo udevadm trigger
sudo usermod -aG plugdev "$USER"
```

Replace `18d1` with your vendor ID. Log out and back in for the group change to apply, then replug the phone.

`[UNVERIFIED]` — your phone's actual vendor ID. Paste `lsusb` output into [`toAgent/`](../../toAgent/) and this becomes concrete.

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
