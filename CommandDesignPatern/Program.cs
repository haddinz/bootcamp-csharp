using CommandDesignPatern.Before.Models;
using CommandDesignPatern.Before.Controller;

using CommandDesignPatern.After.Controller;
using CommandDesignPatern.After.Interface;
using CommandDesignPatern.After.Models;
using CommandDesignPatern.After.Service;


public class Program {
    static void Main() {
        //before implementation
        LightBefore lightBefore = new LightBefore();

        LightControllerBefore lightControllerBefore = new LightControllerBefore(lightBefore);
        lightControllerBefore.PressLightOn();
        lightControllerBefore.PressLightOff();

        //after implementation
        Light lightAfter = new Light();

        ICommand lightOn = new LightOn(lightAfter);
        ICommand lightOff = new LightOff(lightAfter);
        ICommand lightFlicker = new LightOff(lightAfter);

        LightController lightController = new LightController();
        lightController.SetLightController(lightOn);
        lightController.PressButtonOn();
        lightController.PressButtonOff();

        lightController.SetLightController(lightOff);
        lightController.PressButtonOn();
        lightController.PressButtonOff();

        lightController.SetLightController(lightFlicker);
        lightController.PressButtonOn();
    }
}