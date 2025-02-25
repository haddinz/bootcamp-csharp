// See https://aka.ms/new-console-template for more information

using System.Text;

Action<object> cw = Console.WriteLine;

cw("Count length of String without white space");

String letter = "Hello World";
StringBuilder sb = new StringBuilder();

foreach (Char c in letter.ToCharArray()) {
    if(!string.IsNullOrWhiteSpace(Convert.ToString(c))){
        sb.Append(c);
    }
}

cw(sb.Length);


cw("Compare between Letters that have good spacing or not");

String letterSpacing = "Good morning everybody";

Boolean result = false;
result = letterSpacing.Trim().Replace("  ", " ").Equals(letterSpacing);

cw(result);
