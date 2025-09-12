#!/usr/bin/env bash
set -e
OUT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/../mosquitto/certs" && pwd)"
cd "$OUT_DIR"

echo "Generating demo CA and server certificates into: $OUT_DIR"
openssl genrsa -out ca.key 4096
openssl req -x509 -new -nodes -key ca.key -sha256 -days 365 -out ca.crt -subj "/CN=Demo IoT CA"
openssl genrsa -out server.key 2048
openssl req -new -key server.key -out server.csr -subj "/CN=localhost"
openssl x509 -req -in server.csr -CA ca.crt -CAkey ca.key -CAcreateserial -out server.crt -days 365 -sha256

echo "Done. Copy paths into mosquitto.conf if you use a different location."
