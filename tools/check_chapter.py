#!/usr/bin/env python3
"""Verify a chapter against ADR-002's doing/theory ratios.

Doing  = 🔨 Build + ▶️ Run it + 👀 Observe        must be >= 50%
Theory = 🧠 Why it works + 🗺️ Mental model        must be <= 30%

The denominator is the INSTRUCTIONAL BODY only. Framing sections (Goal,
Fast-Track, Practicals, Cheat sheet, ...) are excluded because they scale
with a chapter's audience, not with how much of it is hands-on.

🔑 Complete Solutions is excluded too (ADR-038). It is reference material
the learner consults when stuck -- counting it as "doing" would let a long
solutions appendix inflate the ratio and quietly make ADR-002 meaningless.

Usage:  python3 tools/check_chapter.py docs/chapters/module1/1B/1.10_*.md
"""
import io, re, sys

DOING  = ['🔨 Build', '▶️ Run it', '👀 Observe']
THEORY = ['🧠 Why it works', '🗺️ Mental model']
INSTRUCTIONAL = DOING + THEORY + ['💥 Break it', '🔎 Diagnose']

# Framing and reference material -- excluded from the denominator entirely.
ANCILLARY = ['', '🎯 Goal', '🏃 Fast-Track Summary', '🧭 Before you start',
             '🏋️ Practicals', '✅ Check yourself', '📎 Cheat sheet',
             '🔗 Further reading', '💾 Commit', "➡️ What's next",
             '🪞 Reflection', '📝 Chapter changelog',
             '🔑 Complete Solutions']          # ADR-038


def measure(path):
    body = io.open(path, encoding='utf-8').read().split('---\n', 2)[2]
    sizes = {}
    for sec in re.split(r'\n## ', body):
        sizes[sec.split('\n')[0].strip()] = len(sec.split('\n'))

    unknown = {k: v for k, v in sizes.items()
               if k not in INSTRUCTIONAL and k not in ANCILLARY}
    extra = sum(unknown.values())
    denom = sum(sizes.get(k, 0) for k in INSTRUCTIONAL) + extra
    if not denom:
        return None
    doing  = 100.0 * (sum(sizes.get(k, 0) for k in DOING) + extra) / denom
    theory = 100.0 * sum(sizes.get(k, 0) for k in THEORY) / denom
    return doing, theory, unknown


def main(paths):
    failed = False
    for p in paths:
        r = measure(p)
        if r is None:
            print(f"?? {p}: no front matter"); failed = True; continue
        doing, theory, unknown = r
        ok = doing >= 50 and theory <= 30
        failed |= not ok
        print(f"{'PASS' if ok else 'FAIL'}  {doing:5.1f}% doing  "
              f"{theory:5.1f}% theory  {p.split('/')[-1]}")
        for k in unknown:
            print(f"        note: unrecognised section '{k}' counted as doing")
    return 1 if failed else 0


if __name__ == '__main__':
    sys.exit(main(sys.argv[1:]))
