using CommandDesignPatern.After.Interface;
using CommandDesignPatern.After.Models;

namespace CommandDesignPatern.After.Service;

public class LightOff : ICommand {
    private Light _light;

    public LightOff(Light light) {
        _light = light;
    }

    public void execute() {
        _light.TurnOff();
    }
    public void undo() {
        _light.TurnOn();
    }
}