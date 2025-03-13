class FooBazBarJazzHuzz {

    public FooBazBarJazzHuzz(int number) {
        List<string> numberTemp = new();

        for(int i = 0; i < number; i++) {
            if (i % 9 == 0) {
                numberTemp.Add("huzz");
            } else if (i % 7 == 0) {
                numberTemp.Add("jazz");
            } else if (i % 5 == 0) {
                numberTemp.Add("bar");
            } else if (i % 4 == 0) {
                numberTemp.Add("baz");
            } else if (i % 3 == 0) {
                numberTemp.Add("foo");
            } else {
                numberTemp.Add(i.ToString());
            }
        }

        foreach (string s in numberTemp)
        {
            Console.WriteLine(s);
        }
    }

}