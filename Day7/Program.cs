// See https://aka.ms/new-console-template for more information
class Program {

    static Action<string>? OnAction;

    static void Main() {

        FrameFundamental frameFundamental = new();
        Collection collection = new();

        frameFundamental.StringAndText();
        frameFundamental.DateAndTime();
        frameFundamental.FormatParse();

        collection.Arrays();
        collection.ListsQueuesStacksDictionariesSets();
        collection.Dictionary();

        OnAction?.Invoke("Hello World!");

        // Action<string> action = (string message) => {
        //     Console.WriteLine(message);
        // };

        // action("Hello World!");

    }

}
