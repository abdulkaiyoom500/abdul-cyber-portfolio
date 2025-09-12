FROM python:3.8-slim
RUN apt-get update && apt-get install -y mosquitto-clients
RUN pip install paho-mqtt requests
COPY device_simulation.py /device_simulation.py
COPY certs /certs
CMD ["python", "/device_simulation.py"]

