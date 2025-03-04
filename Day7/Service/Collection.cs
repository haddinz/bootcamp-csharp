using System.Collections;
using System.Text;

class Collection {

    public void Arrays() {
        StringBuilder[] builders = new StringBuilder[3];
        builders[0] = new("Hello");
        builders[1] = new("World");
        builders[2] = new("! cuy");

        StringBuilder[] buildersClone = (StringBuilder[]) builders.Clone();

        foreach (StringBuilder builder in builders) {
            Console.WriteLine(builder.ToString());
        }

        foreach (StringBuilder builder in buildersClone) {
            Console.WriteLine(builder.ToString());
        }
    }

    public void ListsQueuesStacksDictionariesSets() {
        List<string> strings = new();
        strings.Add("Hello");
        strings.Add("World");

        ArrayList arrayList = new();
        arrayList.Add("Hello");
        arrayList.Add(3);
        
        Queue<string> queue = new();    
        queue.Enqueue("Hello");
        queue.Enqueue("World");
        queue.Dequeue();

        Stack<string> stacks = new();
        stacks.Push("Hello");
        stacks.Push("World");
        stacks.Pop();

        HashSet<string> hashSet = new();
        hashSet.Add("Hello Set");
        hashSet.Add("World Set");
        hashSet.Add("Hello Set");

        foreach (string s in strings) {
            Console.WriteLine(s);
        }

        foreach (object a in arrayList) {
            Console.WriteLine(a);
        }

        foreach (string s in queue) {
            Console.WriteLine(s);
        }

        foreach (string s in stacks) {
            Console.WriteLine(s);
        }

        foreach (string s in hashSet) {
            Console.WriteLine(s);
        }
    }

    public void Dictionary() {
        Console.WriteLine("\n");

        Dictionary<int, string> dictionary = new();
        dictionary.Add(1, "Hello");
        dictionary.Add(2, "World");
        dictionary.Add(3, "King");
        dictionary.Add(4, "Of The Sea");

        Console.WriteLine(dictionary[4]);
        Console.WriteLine(dictionary.ContainsKey(8));
        Console.WriteLine(dictionary.ContainsValue("King"));
        Console.WriteLine(dictionary.Count);
    }

}