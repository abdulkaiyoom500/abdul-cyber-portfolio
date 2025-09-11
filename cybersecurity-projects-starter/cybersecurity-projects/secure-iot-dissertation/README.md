# Secure IoT Communication Framework (Dissertation)

## Overview
Containerized IoT device simulations connecting to a Mosquitto MQTT broker over TLS 1.2; validated using Wireshark and OMNeT++ simulations.

## Tools & Skills
- Docker & Docker Compose
- Eclipse Mosquitto (MQTT)
- OpenSSL (cert generation)
- OMNeT++ (simulation)
- Wireshark

## Environment / Setup
Docker installed. Generate CA/server/client certs; configure Mosquitto for TLS; run `docker-compose up`.

## Steps
1. Generate a test CA and server/client certificates (OpenSSL).
2. Configure Mosquitto with TLS and mount certs/keys via volumes.
3. Run docker-compose; publish/subscribe test messages; verify TLS in Wireshark.

## Key Artifacts
- `docker-compose.yml` – broker + sample publisher/subscriber
- `omnet-simulations/` – latency/packet flow experiments (optional)

## Screenshots
> Place redacted images in `./screenshots/` and reference them:
![Screenshot](screenshots/example.png)

## Outcome / What I Learned
Validated secure IoT messaging over TLS and analyzed performance characteristics.

## How to Reproduce (Optional)
Use the compose file and sample clients; see comments inside.

---
**Disclaimer:** No proprietary or personal data is shared. All evidence is demo/test data only.
