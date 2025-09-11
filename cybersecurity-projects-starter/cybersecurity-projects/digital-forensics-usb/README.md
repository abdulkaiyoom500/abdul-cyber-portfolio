# Digital Forensics – Workstation & USB Investigation

## Overview
Imaged a workstation and USB drive using a write‑blocker; verified integrity (MD5/SHA‑256); analyzed with Autopsy for recovery and timelines.

## Tools & Skills
- FTK Imager
- Autopsy
- Write‑blocker
- Hashing (md5/sha256)

## Environment / Setup
Workstation/USB evidence (test data), FTK Imager for acquisition, Autopsy for analysis.

## Steps
1. Acquire forensic image using FTK Imager with write‑blocker; compute and record hashes.
2. Load image into Autopsy; analyze deleted files, metadata, browser artifacts, and timeline.
3. Document findings and maintain chain of custody; produce final report.

## Key Artifacts
- `report/forensic-report.md` – final report
- `chain-of-custody.md` – template log

## Screenshots
> Place redacted images in `./screenshots/` and reference them:
![Screenshot](screenshots/example.png)

## Outcome / What I Learned
Produced a legally defensible report with validated evidence integrity.

## How to Reproduce (Optional)
Use provided templates with synthetic datasets.

---
**Disclaimer:** No proprietary or personal data is shared. All evidence is demo/test data only.
