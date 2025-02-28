class IteratoService {

    public IEnumerable<int> SumList() {
        List<int> myList = new List<int>();
        myList.Add(0);
        myList.Add(20);
        myList.Add(30);
        myList.Add(13);

        foreach(int i in myList) {
            if (i %2 == 0) {
                yield return i;
            }
        }
    }
}