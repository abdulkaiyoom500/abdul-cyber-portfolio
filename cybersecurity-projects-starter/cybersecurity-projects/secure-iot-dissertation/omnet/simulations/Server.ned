package iotsecuritysimulation.simulations;

simple Server
{
    parameters:
        @display("i=block/server");
    gates:
        input in[2];  // Vector gate with 2 inputs
        output out[2]; // Vector gate with 2 outputs
}

