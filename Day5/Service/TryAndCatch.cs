class TryCatchElement {

    private int[] IntNumber;

    public TryCatchElement(int[] intNumber) {
        this.IntNumber = intNumber;
    }

    public string TryCatchService() {
        try {
            int[] myNumbers = IntNumber;
            Console.WriteLine(myNumbers[0]);
            return $"try catch is active {myNumbers[1]}";
        } catch(Exception e) {
            return e.Message;
        }
    }

}