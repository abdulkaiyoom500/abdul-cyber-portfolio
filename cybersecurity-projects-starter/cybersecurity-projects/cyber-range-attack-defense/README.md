# Cyber Range – Kali Linux & Ubuntu Attack‑Defense Lab

## Overview
Red‑blue lab simulating brute force, DoS, SQLi, XSS, MITM attacks and blue‑team defenses with Snort and firewall hardening.

## Tools & Skills
- Kali Linux (Hydra, sqlmap, hping3, arpspoof)
- Ubuntu Server
- Snort IDS
- UFW/iptables

## Environment / Setup
VMware / VirtualBox with host‑only + NAT networks. One Kali attacker VM, one Ubuntu server VM.

## Steps
1. Build lab network; install Kali and Ubuntu; document IPs and segments.
2. Run selected attacks from Kali; capture PCAPs; tune Snort rules for detections.
3. Harden Ubuntu (UFW, services, configs); verify detections and blocked traffic.

## Key Artifacts
- `configs/` – Snort rules, UFW policies
- `pcaps/` – redacted sample traffic (optional)

## Screenshots
> Place redacted images in `./screenshots/` and reference them:
![Screenshot](screenshots/example.png)

## Outcome / What I Learned
Demonstrated end‑to‑end detection and mitigation of common attack vectors.

## How to Reproduce (Optional)
Follow README; use provided configs and synthetic traffic.

---
**Disclaimer:** No proprietary or personal data is shared. All evidence is demo/test data only.
