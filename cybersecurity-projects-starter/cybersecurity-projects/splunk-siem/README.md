# SIEM & Threat Monitoring (Splunk) – Home Lab

## Overview
Forwarded Linux logs to Splunk; built dashboards for anomalies, brute force attempts, and unauthorized access; created correlation searches.

## Tools & Skills
- Splunk Enterprise
- Linux (syslog, journald)
- Sysmon (Windows) – optional

## Environment / Setup
Install Splunk locally; configure universal forwarder(s); add data inputs; import/clone dashboards.

## Steps
1. Configure data inputs and forwarders to ingest auth and system logs.
2. Create searches/correlation rules for brute force and anomaly patterns.
3. Build a dashboard with panels (failed logins, geo anomalies, privileged actions).

## Key Artifacts
- `dashboards.json` – sample dashboard definition
- `searches/` – saved searches / correlation rules

## Screenshots
> Place redacted images in `./screenshots/` and reference them:
![Screenshot](screenshots/example.png)

## Outcome / What I Learned
Demonstrated SOC workflows: visibility → detection → triage.

## How to Reproduce (Optional)
Import JSON into Splunk; point to your indexes.

---
**Disclaimer:** No proprietary or personal data is shared. All evidence is demo/test data only.
