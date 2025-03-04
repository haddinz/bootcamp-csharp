class FrameFundamental {
    public void StringAndText() {
        string text = "Hello, World!";
        Console.WriteLine(text);

        char c = 'a';
        Console.WriteLine(char.ToUpper(c));

        foreach(char cs in "wak") {
            Console.WriteLine(cs + ",");
        }

        string stringManipulation = "Hello, World!";
        string stringSubString = stringManipulation.Substring(0, 5);
        Console.WriteLine(stringSubString);

        string stringInsert = stringManipulation.Insert(5, " beautiful ");
        Console.WriteLine(stringInsert);
    }

    public void DateAndTime() {
        TimeSpan timeSpan = new(1, 20, 30);
        Console.WriteLine(timeSpan);
    }

    public void FormatParse() {
        string s = true.ToString();
        Console.WriteLine(s);

        bool b = bool.Parse(s);
        Console.WriteLine(b);
    }

    
}