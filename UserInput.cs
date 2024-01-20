namespace core_1
{
    class UserInput
    {
        public void MyMethod()
        {
            System.Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine() ?? String.Empty;
            System.Console.WriteLine("Your name is : " + name);
            System.Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Your age is : " + age);

        }
    }
}
