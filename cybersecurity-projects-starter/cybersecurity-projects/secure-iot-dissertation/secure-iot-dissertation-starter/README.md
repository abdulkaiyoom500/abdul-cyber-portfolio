# Secure IoT Communication Framework (MQTT over TLS + OMNeT++)

Containerised IoT devices publish/subscribe through a **Mosquitto MQTT broker secured with TLS 1.2**.
An **OMNeT++** model simulates device↔server messaging to observe latency/throughput and security posture.
Traffic encryption is validated with **Wireshark**. This folder is a clean, upload‑ready subset of my MSc project.

## Structure

```
secure-iot-dissertation/
├─ docker/                 # MQTT device container (Python + paho-mqtt)
│  ├─ Dockerfile
│  └─ device_simulation.py
├─ mosquitto/              # Broker configuration (no secrets included)
│  ├─ mosquitto.conf      # TLS listener 8883
│  ├─ conf.d/README
│  └─ certs/.gitkeep      # Put ca.crt, server.crt, server.key here (local only)
├─ omnet/                  # OMNeT++ model
│  ├─ src/IoTSimulation.cc
│  └─ simulations/
│     ├─ IoTSimulation.ned
│     ├─ IoTDevice.ned
│     ├─ Server.ned
│     ├─ package.ned
│     └─ omnetpp.ini
├─ scripts/
│  └─ generate-certs.sh   # Demo self-signed cert generator (do NOT commit outputs)
├─ docker-compose.yml
├─ .gitignore
└─ README.md
```

## Quick start

### 1) Generate demo certs (local only)
```bash
bash scripts/generate-certs.sh
# This writes ca.crt, server.crt, server.key into mosquitto/certs/
# Never commit real keys/certs. .gitignore already excludes them.
```

### 2) Launch broker + a sample device
```bash
docker compose up --build
```
- Broker: TLS on **8883** (and 1883 open for plain MQTT by default).
- Device: publishes every 5s to `test/topic` over TLS using `/certs/{ca.crt,server.crt,server.key}`.

### 3) Try mosquitto-clients (optional)
```bash
mosquitto_sub -h localhost -p 8883 -t "test/topic" --cafile mosquitto/certs/ca.crt   --cert mosquitto/certs/server.crt --key mosquitto/certs/server.key

mosquitto_pub -h localhost -p 8883 -t "test/topic" -m "hello over TLS"   --cafile mosquitto/certs/ca.crt --cert mosquitto/certs/server.crt --key mosquitto/certs/server.key
```

### 4) Run the OMNeT++ simulation
Open `omnet/` in OMNeT++ and run the `IoTSimulation` network (`sim-time-limit = 100s` in `omnetpp.ini`).

## Notes
- **Do not** commit private keys or real certificates.
- For production-style demos, set `allow_anonymous false` and consider mutual TLS (`require_certificate true`) in `mosquitto.conf`.
- The Docker device uses paho-mqtt over TLS 1.2; adjust `MQTT_HOST` and `MQTT_PORT` in `docker-compose.yml` if needed.

## License
Copyright (c) 2025 Mohamed Abdul Kaiyoom. All rights reserved.
This repository is provided for portfolio/demo purposes. No reuse without permission.
