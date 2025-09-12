import paho.mqtt.client as mqtt
import ssl
import time
import logging

broker = "localhost"
port = 8883

logging.basicConfig(level=logging.INFO)

def on_connect(client, userdata, flags, rc):
    logging.info("Connected with result code " + str(rc))
    client.subscribe("test/topic")

def on_message(client, userdata, msg):
    logging.info(f"{msg.topic} {msg.payload.decode()}")

client = mqtt.Client()
client.tls_set(
    ca_certs="/certs/ca.crt",
    certfile="/certs/server.crt",
    keyfile="/certs/server.key",
    cert_reqs=ssl.CERT_REQUIRED,
    tls_version=ssl.PROTOCOL_TLSv1_2
)

client.on_connect = on_connect
client.on_message = on_message

while True:
    try:
        client.connect(broker, port, 60)
        break
    except Exception as e:
        logging.error(f"Connection failed: {e}. Retrying in 5 seconds...")
        time.sleep(5)

client.loop_start()

while True:
    client.publish("test/topic", "Secure message from Docker container")
    logging.info("Published message to test/topic")
    time.sleep(5)

