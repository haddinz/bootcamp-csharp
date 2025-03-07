class FooBarJazz
{
    public FooBarJazz(int number)
    {
        List<string> numberTemp = new();

        for (int i = 1; i <= number; i++)
        {
            if (i % 105 == 0)
            {
                numberTemp.Add("foobarjazz");
            }
            else if (i % 35 == 0)
            {
                numberTemp.Add("barjazz");
            }
            else if (i % 21 == 0)
            {
                numberTemp.Add("foojazz");
            }
            else if (i % 15 == 0)
            {
                numberTemp.Add("foobar");
            }
            else if (i % 7 == 0)
            {
                numberTemp.Add("jazz");
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

        foreach (string s in numberTemp)
        {
            Console.WriteLine(s);
        }
    }
}