# P2 Engine Flow

```mermaid
flowchart LR
  Input[EngineInputs] --> Manager[P2Manager.Step]
  Manager --> Rms[RMS Calculator]
  Manager --> Events[Simple Event Checker]
  Rms --> Output[EngineOutputs]
  Events --> Output
```
