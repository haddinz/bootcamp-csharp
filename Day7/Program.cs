// See https://aka.ms/new-console-template for more information
class Program {

    static void Main() {

        FrameFundamental frameFundamental = new();
        Collection collection = new();

        frameFundamental.StringAndText();
        frameFundamental.DateAndTime();
        frameFundamental.FormatParse();

        collection.Arrays();
        collection.ListsQueuesStacksDictionariesSets();
        collection.Dictionary();

    }

}
