using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testübungArray
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Bitte Anzahl der Schüler eingeben: ");
            int eingabe;


            eingabe = Convert.ToInt16(Console.ReadLine());


            double[] punkte = new double[eingabe];

            for (int i = 0; i < punkte.Length; i++)

            {
                Console.Write(String.Format("Punkte des {0}.Schüler: ", i + 1));
                punkte[i] = Convert.ToDouble(Console.ReadLine());
            }


            Console.Write("Bitte Maximale Punkte eingeben: ");
            int max;
            max = Convert.ToInt16(Console.ReadLine());

            double[] Pprozent = new double[punkte.Length];

            for (int i = 0; i < punkte.Length; i++)
            {
                Pprozent[i] = (punkte[i] / (double)max); //wieso double?
            }

            Console.WriteLine(String.Format("Punkte (max.{0}) \t     in Prozent", max));
            for (int i = 0; i < punkte.Length; i++)
            {
                Console.WriteLine(String.Format("{0,4} \t\t\t  {1:0%}", punkte[i], Pprozent[i]));
            }

            #region Kleinter Wert
            double kleinsterwert = punkte[Array.IndexOf(punkte, punkte.Min())];
            double kleinsterwertprozent = Pprozent[Array.IndexOf(Pprozent, Pprozent.Min())];
            Console.WriteLine(String.Format("Kleinster Wert:\t{0} ({1:0%})", kleinsterwert, kleinsterwertprozent));
            #endregion
            #region Größter Wert
            double Grosterwert = punkte[Array.IndexOf(punkte, punkte.Max())];
            double Grosterwertprozent = Pprozent[Array.IndexOf(Pprozent, Pprozent.Max())];
            Console.WriteLine(String.Format("Größter Wert :\t{0} ({1:0%})", Grosterwert, Grosterwertprozent));

            int bestanden = 0;
            for (int i = 0; i < punkte.Length; i++)
            {
                if (punkte[i] * 100 >= 50)
                {
                    bestanden++;
                }
            }
            double bestandenprozent = (double)bestanden / (double)punkte.Length;
            Console.WriteLine(String.Format("Test Bestanden:\t{0} ({1:0%})", bestanden, bestandenprozent));
            #endregion

            Console.ReadKey();



        }
    }
}