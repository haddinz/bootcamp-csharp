using CommandDesignPatern.After.Interface;

namespace CommandDesignPatern.After.Controller;

public class LightController {
    private ICommand _command;

    public void SetLightController(ICommand command) {
        _command = command;
    }

    public void PressButtonOn() {
        _command.execute();
    }

    public void PressButtonOff() {
        _command.undo();
    }
}