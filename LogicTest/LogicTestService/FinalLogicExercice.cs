class FinalLogicExercise {
    public FinalLogicExercise(int input, string output) {
        int length = 100;
        List<object> listData = new();

        for (int i = 0; i < length; i++) {
            if (i % input == 0) {
                listData.Add(output);
            } else {
                listData.Add(i);
            }
        }

        foreach(var result in listData) {
            Console.WriteLine(result);
        }
    }
}