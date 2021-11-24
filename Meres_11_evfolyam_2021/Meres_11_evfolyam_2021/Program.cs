using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meres_11_evfolyam_2021
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Meseorszag_Soma(); Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Veletlenek_Soma(); Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ReadKey();
        }

        private static void Veletlenek_Soma()
        {
            Console.WriteLine("Veletlenek");
            Console.WriteLine("a) Kérd be a felhasználótól, hogy hány egész számot szeretne generálni!\n" +
                "b) Kérd be a felhasználótól, hogy milyen határértékek között legyenek a számok!\n" +
                "c) Hozz létre egy tömböt, melyet a paramétereknek megfelelően feltöltesz!\n" +
                "d) Írasd ki a tömb elemeit egymás mellé szóközzel elválasztva!");
            int N;
            Console.Write("\tKérem adja meg hány elemet szeretne generálni: ");
            N = int.Parse(Console.ReadLine());
            int[] GenearaltTMB = new int[N];
            Console.Write("\tAdja meg a minimum határértéket: ");
            int Min= int.Parse(Console.ReadLine());
            Console.Write("\tAdja meg a maximum határértéket: ");            
            int Max = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                GenearaltTMB[i] = rnd.Next(Min, Max);
               
            }
            Console.WriteLine("\n");
            for (int i = 0; i < N; i++)
            {
                Console.Write("\t{0} ,",GenearaltTMB[i]);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Keresd meg az első 15-tel osztható számot és írasd ki, hogy hányadik eleme a tömbnek, ha\nnincs ilyen szám, akkor azt írasd ki, hogy „Nincs 15 - tel osztható szám.”!");
            int Szamlalo = 0;
            while(Szamlalo<N && GenearaltTMB[Szamlalo]%15!=0)
            { Szamlalo++; }
            if (Szamlalo == N) { Console.WriteLine("\tNincs 15-el osztható elem a tömbben"); }
            else { Console.WriteLine("\tAz első 15-el osztható elem: {0} -dik a tömbben",Szamlalo); }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Válogasd ki egy listába a páratlan számokat, majd írasd ki a mintának megfelelően!");
            List<int> ParatlaList = new List<int>();
            foreach (var g in GenearaltTMB)
            {
                if(g%2==1)
                {
                    ParatlaList.Add(g);
                }
            }
            foreach (var p in ParatlaList)
            {
                Console.Write("\t{0} , ",p);
            }
        }

        private static void Meseorszag_Soma()
        {
            Console.WriteLine("Meseország ingatlaniroda");
            string[] EladoTMB = new string[7] { "Hófehérke", "Csipkerózsika", "Herceg", "Mostoha", "Morgó", "Hamupipőke", "Vadász" };
            int[] IngatlanMereteTMB = new int[7];
            double[] HirdetesAraTMB = new double[]  {52.6, 32.7, 64.2, 48.5, 22.3, 55.7, 28.4};
            for (int i = 0; i < IngatlanMereteTMB.Length; i++)
            {
                IngatlanMereteTMB[i] = rnd.Next(43, 68);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Írasd ki az adatokat a mintának megfelelően!");
            for (int i = 0; i < EladoTMB.Length; i++)
            {
                Console.WriteLine("{0,-15} ; {1,-3}nm ; {2} MFt",EladoTMB[i],IngatlanMereteTMB[i],HirdetesAraTMB[i]);
            }
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Írasd ki, hogy Meseország eladói összesen mennyi pénzt fognak keresni, ha a hirdetési áron\n sikerül eladniuk az ingatlanokat!");
            double OSszbevetel = 0;
            for (int i = 0; i < HirdetesAraTMB.Length; i++)
            {
                OSszbevetel += HirdetesAraTMB[i];
            }
            Console.WriteLine("\tMeseország Ingatlan iroda össz keresete: {0} MFt",OSszbevetel);
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Hány darab 55 nm-nél nagyobb ingatlan került meghirdetésre? Az eredményt a minta szerint\nírasd ki(a darabszámban lehet eltérés a véletlen számok miatt)!");
            int db = 0;
            for (int i = 0; i < IngatlanMereteTMB.Length; i++)
            {
                if(IngatlanMereteTMB[i]>55)
                { db++; }
            }
            Console.WriteLine("\tEnnyi 55nM-nél nagyobb ingalan van: {0}",db);
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Írasd ki a legkisebb méretű ingatlan tulajdonosának nevét!");
            int MinMeret = int.MaxValue;
            string MinTulaj = "";
            for (int i = 0; i < IngatlanMereteTMB.Length; i++)
            {
                if(MinMeret>IngatlanMereteTMB[i])
                {
                    MinMeret = IngatlanMereteTMB[i];
                    MinTulaj = EladoTMB[i];
                }
            }
            Console.WriteLine("\tA LEgkisebb ingatlan mérete: {0}nM, tulajdonosa: {1}", MinMeret, MinTulaj);
            Console.WriteLine("\n----------------------------------------------------------------------------\n");
            Console.WriteLine("Írasd ki Herceg ingatlanjának méretét!");
            int Szamlalo = 0;
            string Keresett = "Herceg";
            while(Szamlalo<EladoTMB.Length && Keresett!=EladoTMB[Szamlalo])
            { Szamlalo++; }
            if (Szamlalo == EladoTMB.Length) { Console.WriteLine("\tNincs ilyen ingatlan"); }
            else { Console.WriteLine("\tHerceg ingatlanjának mérete: {0} nM", IngatlanMereteTMB[Szamlalo]); }
        }
    }
}
