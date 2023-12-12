using ConsoleAppSprint10DI.Models;

namespace ConsoleAppSprint10DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ninja n = new Ninja(new Sword());
            Samuri s = new Samuri(new Katana());
        }
    }
}