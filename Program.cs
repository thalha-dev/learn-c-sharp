using Abstraction;

namespace core_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myPig = new Pig();  // Create a Pig object

            myPig.animalSound();
            myPig.sleep();
        }
    }
}
