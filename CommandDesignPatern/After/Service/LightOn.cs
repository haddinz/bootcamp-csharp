using CommandDesignPatern.After.Interface;
using CommandDesignPatern.After.Models;

namespace CommandDesignPatern.After.Service;

public class LightOn : ICommand {
    private Light _light;

    public LightOn(Light light) {
        _light = light;
    }

    public void execute() {
        _light.TurnOn();
    }
    public void undo() {
        _light.TurnOff();
    }
}