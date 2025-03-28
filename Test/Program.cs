// See https://aka.ms/new-console-template for more information
class Program {

    static void Main() {
        Action<object> cw = Console.WriteLine;
        
        Testing testing = new();
        testing.GetManyLetter("Hello World");
        cw("");
        testing.GetPassCorrectFormat("P@s5w0rd!");
        cw("");
        testing.GetBreakCamelCase("KingOfTheSea");
        cw("");

        Dictionary<string, string> address = new Dictionary<string, string>();

        // result Jakarta -> Bandung -> Semarang -> Surabaya -> Makassar -> Kendari

        address.Add("Jakarta", "Bandung");
        address.Add("Surabaya", "Makassar");
        address.Add("Semarang", "Surabaya");
        address.Add("Bandung", "Semarang");
        address.Add("Makassar", "Kendari");

        testing.GetFollowAddress(address);
    }

}
