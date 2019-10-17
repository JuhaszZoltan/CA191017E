using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191017E
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tömbök
            //int[] tomb01 = new int[5];
            //tomb01[0] = 11;
            //tomb01[1] = 32;
            //tomb01[2] = 42;
            //tomb01[3] = 69;
            //tomb01[4] = 101;

            //int[] tomb02 = { 22, 33, 44, 55, 66 };

            //string[] nevek = { "Zsuzsa", "Renata", "Zsófi", "Emese", "Judit" };
            //double[] szamok = { 3.14, 2.1415, 4.12 };
            //bool[] valaszok = { false, true, true, false };

            //nevek[4] = "Veronika";

            //for(int i = 0; i < nevek.Length; i++)
            //{
            //    Console.Write(nevek[i] + " ");
            //}

            //int[] magassagok = new int[nevek.Length];

            //for (int i = 0; i < nevek.Length; i++)
            //{
            //    Console.Write(nevek[i] + ": ");
            //    magassagok[i] = int.Parse(Console.ReadLine());
            //}

            //bool[] bin = { false, true, true, false, false, false, false, true };

            //int szam = 0;

            //for (int i = 0; i < bin.Length; i++)
            //{
            //    if (bin[i]) szam += (int)Math.Pow(2, 7 - i);
            //}

            //Console.WriteLine("----------");
            //Console.WriteLine((char)szam);
            //Console.WriteLine("----------");
            #endregion

            //PROGRAMOZÁSI TÉTELEK
            //"ajánlott" "olvasmány": http://info.nytta.hu/temak/prog/Programozasi_tetelek.pdf
            #region sorozatszámítás(ok)
            ////INPUT: sorozat
            ////OUTPUT: egy a sorozathoz rendelt érték

            ////összegzés (számhalmaz --> számok összege)
            //int[] t = { 11, 42, 39, 7, 71 };
            //int sum = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    sum += t[i];
            //}
            //Console.WriteLine($"szamok osszege: {sum}");

            ////az átlag számítás (AVG) NEM tétel, de közvetlenül következik az összegzésből
            //Console.WriteLine($"tomb elemeinek atlaga: {sum / (float)t.Length}");

            ////szorzatszámítás: (számhalmaz -> lin. szorzat)
            //float[] szorzok = { 1.01F, 2.2F, 1.3F };
            //float tet = 200;
            //for (int i = 0; i < szorzok.Length; i++)
            //{
            //    tet *= szorzok[i];
            //}
            //Console.WriteLine($"ossznyeremeny: {tet}");

            ////iterativ konkatenáció (összefűzés)
            //string[] szavak = { "alma", "a", "fa", "alatt" };
            //string mondat = "";
            //for (int i = 0; i < szavak.Length; i++)
            //{
            //    mondat += szavak[i] + " ";
            //}
            //Console.WriteLine(mondat);
            #endregion
            #region másolás tétele
            ////INPUT: sorozat
            ////OUTPUT: sorozat (aminek az elemei ugyan azok)
            //char[] hangok = { 'd', 'r', 'm', 'f', 's', 'l', 't' };
            //char[] masolat = new char[hangok.Length];

            //Console.WriteLine("másolás előtt: " + new string(masolat));

            //for (int i = 0; i < hangok.Length; i++)
            //{
            //    masolat[i] = hangok[i];
            //}

            //Console.WriteLine("eredeti:      " + new string(hangok));
            //Console.WriteLine("másolás után: " + new string(masolat));
            #endregion
            #region megszámlálás tétele
            ////INPUT: sorozat
            ////OUTPUT: egész szám

            //int[] t = { 11, 42, 39, 7, 71 };
            //int db = 0;
            ////tuljdonság: 3mal osztható

            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] % 3 == 0) db++;
            //}
            //Console.WriteLine($"{db} db 3mal oszthao szam van a tombben");

            //string[] nevek = { "Zsuzsa", "Renata", "Zsófi", "Emese", "Judit",
            //"Kriszti", "Béla", "Norbi" };
            //int db2 = 0;

            //for (int i = 0; i < nevek.Length; i++)
            //{
            //    if (nevek[i][nevek[i].Length - 1] == 'i') db2++;
            //}

            ////char[] ct = nevek[0].ToCharArray();
            ////ct[2] = 'á';
            ////nevek[0] = new string(ct);
            ////Console.WriteLine(nevek[0]);

            //Console.WriteLine($"{db2} név végződik 'i' betűvel");

            #endregion
            #region szélsőérték tételek
            ////minimum és maximum
            ////érték, hely, index
            ////INPUT: sorozat
            ////OUTPUT: a sorozat egy indexe

            ////maximum kiválasztás
            //int[] t = { 11, 42, 39, 71, 7 };
            //int maxi = 0;
            ////!!!NEM 0-nál kezd, hanem 1-nél!!!
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[maxi] < t[i]) maxi = i;
            //}
            //Console.WriteLine($"maximum érték: {t[maxi]}");
            //Console.WriteLine($"maximum index: {maxi}");
            //Console.WriteLine($"maximum hely:  {maxi + 1}");

            ////max value "tétel" bénán:
            //int max = t[0];
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (max < t[i]) max = t[i];
            //}
            //Console.WriteLine($"legnagyobb elem: {max}");
            ////index pedig bukta

            ////csiga: _._@/"

            ////minimum kiválasztás:
            //int mini = 0;
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[mini] > t[i]) mini = i;
            //}
            //Console.WriteLine($"minimum érték: {t[mini]}");
            //Console.WriteLine($"minimum index: {mini}");
            //Console.WriteLine($"minimum hely:  {mini + 1}");
            #endregion

            #region kiválogatás
            //adott tulajdonságú elemek kiválogatáűsa egy másik sorozatba
            //INPUT: sorozat
            //OUTPUT: sorozat

            int[] t = { 13, 5, 20, 17, 15, 3, 2, 5 };
            int[] v = new int[t.Length];
            int si = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if(t[i] % 5 == 0)
                {
                    v[si] = t[i];
                    si++;
                }
            }
            Console.WriteLine("5-el osztható elemek: ");
            for (int i = 0; i < si; i++)
            {
                Console.Write($"{v[i]} ");
            }

            //újraméretezés:
            Array.Resize(ref v, si);
            Console.Write("\n");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }

            //ROSSZ MEGOLDÁS
            int[] t2 = { 1, 5, 3, 15, 9 };
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
            {
                if (t2[i] % 5 == 0)
                {
                    v2[i] = t2[i];
                }
            }
            Console.WriteLine("--------------");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }
            Console.WriteLine("\n-------------");
            //ROSSZ VÉGE
            #endregion
            Console.ReadKey();
        }
    }
}
