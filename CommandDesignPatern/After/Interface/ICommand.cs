namespace CommandDesignPatern.After.Interface;

public interface ICommand {
    void execute();
    void undo();
    // void flicker();
}