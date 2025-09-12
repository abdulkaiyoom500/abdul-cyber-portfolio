#include <omnetpp.h>

using namespace omnetpp;

class IoTDevice : public cSimpleModule
{
protected:
    virtual void initialize() override;
    virtual void handleMessage(cMessage *msg) override;
};

Define_Module(IoTDevice);

void IoTDevice::initialize()
{
    if (strcmp("device1", getName()) == 0) {
        cMessage *msg = new cMessage("Hello from IoT device 1");
        send(msg, "out");
    }
    else if (strcmp("device2", getName()) == 0) {
        cMessage *msg = new cMessage("Hello from IoT device 2");
        send(msg, "out");
    }
}

void IoTDevice::handleMessage(cMessage *msg)
{
    send(msg, "out");
}

class Server : public cSimpleModule
{
protected:
    virtual void handleMessage(cMessage *msg) override;
};

Define_Module(Server);

void Server::handleMessage(cMessage *msg)
{
    EV << "Received message: " << msg->getName() << "\n";

    // Determine which input the message came from and send to the corresponding output
    if (strcmp("device1", msg->getSenderModule()->getName()) == 0) {
        send(msg, "out", 0);  // Send out to the first output gate
    } else if (strcmp("device2", msg->getSenderModule()->getName()) == 0) {
        send(msg, "out", 1);  // Send out to the second output gate
    }
}
