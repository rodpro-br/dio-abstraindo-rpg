using dio_abstraindo_rpg.src.Entities;

namespace DioAbstraindoRpg
{
    class Program 
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine("-----------------");
            Console.WriteLine(jennica);
            Console.WriteLine(jennica.Attack(10));
        }
    }

}