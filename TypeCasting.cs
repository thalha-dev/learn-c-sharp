namespace core_1
{
    class TypeCasting
    {
        public void MyMethod()
        {
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;

            Console.WriteLine(myDouble1);
            Console.WriteLine(myInt1);

            myInt = 98;
            myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToChar(myInt));
        }
    }
}
