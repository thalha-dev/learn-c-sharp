namespace core_1
{
    class Arrays
    {
        public void MyMethod()
        {
            int[] weekNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            System.Console.WriteLine(weekNumbers.Length);
            System.Console.WriteLine(weekNumbers[2]);
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            System.Console.WriteLine(days[2]);
            days[2] = days[2].ToUpper();
            System.Console.WriteLine(days[2]);
            days[2] = days[2].ToLower();
            // other ways to declare array
            int[] arr = new int[] { 1, 2 };
            int[] arr2 = new int[2] { 1, 2 };
            int[] arr3 = new int[2];
            arr3[0] = 1;
            arr3[1] = 2;
            //loop
            foreach (string ele in days)
            {
                System.Console.Write(ele + " ");
            }

            // multi dimensional arrays
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);
            numbers[0, 0] = 5;
            Console.WriteLine(numbers[0, 0]);


            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            // array methods
            Array.Sort(days);
            System.Console.WriteLine();
            foreach (string ele in days)
            {
                System.Console.Write(ele + " ");
            }

            System.Console.WriteLine(weekNumbers.Min());
            System.Console.WriteLine(weekNumbers.Max());
            System.Console.WriteLine(weekNumbers.Sum());


        }
    }
}
