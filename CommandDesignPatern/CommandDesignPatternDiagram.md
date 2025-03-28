```mermaid
classDiagram
    class ICommand {
        <<interface>>
        + Execute() void
        + Undo() void
    }

    class Light {
        + TurnOn() void
        + TurnOff() void
    }

    class LightOn {
        + Execute() void
        + Undo() void
    }

    class LightOff {
        + Execute() void
        + Undo() void
    }

    class LightController {
        + SetLightController(ICommand) void
        + PressButtonOn() void
        + PressButtonOff() void
    }

    ICommand <|.. LightOn
    ICommand <|.. LightOff
    LightOn --> Light : "calls TurnOn()"
    LightOff --> Light : "calls TurnOff()"
    LightController --> ICommand : "uses"
```
