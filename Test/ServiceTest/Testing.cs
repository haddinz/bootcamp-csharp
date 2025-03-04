using System.Text;
using Microsoft.VisualBasic;

class Testing
{

    public void GetManyLetter(string param)
    {
        Dictionary<char, int> dictionary = new();

        char[] chars = param.ToCharArray();

        foreach (char c in chars)
        {
            if (!char.IsWhiteSpace(c))
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] += 1;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }
        }

        int sum = 0;
        char letter = ' ';

        foreach (KeyValuePair<char, int> keyValue in dictionary)
        {
            if (keyValue.Value > sum) {
                sum = keyValue.Value;
                letter = keyValue.Key;
            }
        }

        string result = "The most repeated letter is " + letter + " with " + sum + " times repeated.";
        Console.WriteLine(result);
    }

    public void GetPassCorrectFormat(string value) {
        // Pass must have Uppercase, Lowecase, Number, and Special Character
        int uppercase = 0;
        int lowercase = 0;
        int number = 0;
        int specialCharacter = 0;

        char[] chars = value.ToCharArray();

        for(int i = 0; i < chars.Length; i++) {
            if (char.IsUpper(chars[i])){uppercase =+ 1;}
            if (char.IsLower(chars[i])){lowercase =+ 1;}
            if (char.IsNumber(chars[i])){number =+ 1;}
            if (char.IsPunctuation(chars[i])){specialCharacter =+ 1;}
        }

        bool result = (uppercase > 0 && lowercase > 0 && number > 0 && specialCharacter > 0);
        Console.WriteLine(result ? "Password have correct format" : "Password doesn't have correct format");
    }

    public void GetBreakCamelCase(string value) {
        char[] chars = value.ToCharArray();
        StringBuilder result = new();

        for(int i = 0; i < chars.Length; i++) {
            if (char.IsUpper(chars[i]) && i != 0) {
                result.Append(" ");
            }

            result.Append(chars[i]);
        }

        Console.WriteLine(result.ToString());
    }

    public void GetFollowAddress(Dictionary<string, string> address) {
        
        foreach(KeyValuePair<string, string> keyValue in address) {
            Console.WriteLine(keyValue.Key + keyValue.Value);
        }

        List<string> addressList = new();

        foreach(KeyValuePair<string, string> addressName in address) {
            HashSet<string> origin = new HashSet<string>();
            HashSet<string> destination = new HashSet<string>();

            if(!origin.Contains(addressName.Key)) {origin.Add(addressName.Key);}
            if(!destination.Contains(addressName.Value)) {destination.Add(addressName.Value);}
        }

        foreach(string s in addressList) {
            Console.WriteLine(s);
        }
        
    }
}