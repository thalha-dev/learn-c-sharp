namespace core_1
{
    class Strings
    {
        public void MyMethod()
        {
            string txt = "A string in C# is actually an object";
            System.Console.WriteLine("length : " + txt.Length);
            System.Console.WriteLine("Upper Case : " + txt.ToUpper());
            System.Console.WriteLine("Lower Case : " + txt.ToLower());
            // concatination
            string a = "a";
            string b = "b";
            System.Console.WriteLine(" a + b : " + a + b);
            System.Console.WriteLine(" a + b : " + string.Concat(a, b));
            // interpolation
            string firstName = "Thalha";
            string lastName = "S";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            // accessing char
            System.Console.WriteLine(lastName[0]);
            // string methods
            System.Console.WriteLine(firstName.IndexOf("a"));
            System.Console.WriteLine(txt.Substring(txt.IndexOf("C")));
        }
    }
}
