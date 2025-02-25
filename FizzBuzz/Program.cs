// See https://aka.ms/new-console-template for more information

using System.Text;

int number = 20;
StringBuilder sb = new StringBuilder();

for (int i = 1; i <= number; i++) {
    if ( i % 15 == 0) {
        sb.Append("foobar");
    } else if ( i % 5 == 0) {
        sb.Append("bar, ");
    } else if (i % 3 == 0) {
        sb.Append("foo, ");
    } else {
        sb.Append(i.ToString() + ", ");
    }
}

Console.WriteLine("Hello, World!");
Console.WriteLine(sb);

