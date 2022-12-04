using System.Collections;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(23);
            liste.Add(true);
            liste.Add('A');

            System.Console.WriteLine(liste[1]);

            foreach (var n in liste)
            {
                System.Console.WriteLine(n);
            }
            
            string[] renkler = {"kırmızı","mavi","domates"};

            List<int> sayılar = new List<int>(){2,3,4,5,6,7,92};

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var n in liste)
            {
                System.Console.WriteLine(n);
            }



        }
    }
}