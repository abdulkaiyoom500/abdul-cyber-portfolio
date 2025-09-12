package iotsecuritysimulation.simulations;

network IoTSimulation
{
    submodules:
        device1: IoTDevice;
        device2: IoTDevice;
        server: Server;
    connections allowunconnected:
        device1.out --> server.in[0];  // Connect to server's first input gate
        device2.out --> server.in[1];  // Connect to server's second input gate
        server.out[0] --> device1.in;  // Connect server's first output to device1
        server.out[1] --> device2.in;  // Connect server's second output to device2
}
