class FooBar
{

    public FooBar(int number)
    {
        List<string> numberTemp = new List<string>();

        for (int i = 1; i <= number; i++)
        {
            if (i % 15 == 0)
            {
                numberTemp.Add("foobar");
            }
            else if (i % 5 == 0)
            {
                numberTemp.Add("bar");
            }
            else if (i % 3 == 0)
            {
                numberTemp.Add("foo");
            }
            else
            {
                numberTemp.Add(i.ToString());
            }
        }

        Console.WriteLine("How to render foo bar");

        foreach (string s in numberTemp)
        {
            Console.WriteLine(s);
        }
    }

}