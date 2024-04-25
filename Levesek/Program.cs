using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levesek
{
    internal class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Levesek> levesek1;
        static void Main(string[] args)
        {
            levesek1 = db.getAllleves();
            feladat01();
            feladat02();
            Console.WriteLine("Program Vége");
            Console.ReadLine();
        }
        private static void feladat01()
        {
            Console.WriteLine("*** 1. Feladat! ***");
            Console.WriteLine($"\t Levesek száma : {levesek1.Count} db");

        }
        private static void feladat02()
        {
            Console.WriteLine("*** 2. Feladat! ***");
            double maxKaloria = levesek1.Max(a => a.kaloria);
            Levesek levesek = levesek1.Find(a => a.kaloria == maxKaloria);
            Console.WriteLine($"\t Legtöbb kalóriát érő leves : {levesek.megnevezes}");
        }
    }
}
