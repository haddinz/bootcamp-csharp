using CommandDesignPatern.Before.Models;

namespace CommandDesignPatern.Before.Controller;

public class LightControllerBefore {
    private LightBefore _light;

    public LightControllerBefore(LightBefore light) {
        _light = light;
    }

    public void PressLightOn() {
        _light.TurnOn();
    }

    public void PressLightOff() {
        _light.TurnOff();
    }
}