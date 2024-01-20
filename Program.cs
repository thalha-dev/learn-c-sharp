using Interfaces;

namespace core_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myPig = new Pig(); 
            myPig.animalSound();
        }
    }
}
