// See https://aka.ms/new-console-template for more information
class Program {

    static void Main() {
        Testing testing = new();
        testing.GetManyLetter("Hello World");
        testing.GetPassCorrectFormat("P@s5w0rd!");
        testing.GetBreakCamelCase("KingOfTheSea");

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
