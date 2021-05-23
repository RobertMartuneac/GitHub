using System;
using System.Collections;
using Patiserie.Librarie;
using Data;
using System.Collections.Generic;

namespace Patiserie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produse produs1 = new Produse("Savarina", "4 lei", "zahar lapte", "5 zile", 15);
            //Produse produs2 = new Produse("Ecler", "4,5 lei", "zahar lapte", "6 zile", 10);
            //Produse produs3 = new Produse("Bezea", "3,5 lei", "zahar lapte", "6 zile", 10);

            //string st1, st2, st3;
            //st1 = produs1.ConversieLaSir();
            //st2 = produs2.ConversieLaSir();
            //st3 = produs3.ConversieLaSir();
            //Console.WriteLine(st1);
            //Console.WriteLine(st2);
            //Console.WriteLine(st3);

            //produs1.Compare(produs2);
            //produs2.Compare(produs3);

            ArrayList produse;
            List<Produse> prodl;

            IStocareData stocare_produse = new AdministrareProduse();

            produse = stocare_produse.GetInfoProduse();
            prodl = stocare_produse.GetInfoProduseList();
            int nrprod = produse.Count;
            Produse.NrUltimProdus = nrprod;

            string opt;

            do
            {
                Console.Clear();
                Console.WriteLine("A. Afisare produse");
                Console.WriteLine("D. Adaugare produs");
                Console.WriteLine("C. Cautare produs");
                Console.WriteLine("U. Updateaza pretul unui produs dupa id");
                Console.WriteLine("X. Exit");
                Console.Write("Alegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "A":
                        AfisareProduse(produse);
                        AfisareProduseList(prodl);
                        break;
                    case "D":
                        Produse pTastatura = CitireProdus();
                        produse.Add(pTastatura);
                        //adaugare in fisier;
                        stocare_produse.AddProdus(pTastatura);
                        break;
                    case "C":
                        string _nume;
                        Console.Write("Numele produsului este este: ");
                        _nume = Console.ReadLine();
                        Produse p1;
                        p1 = stocare_produse.GetProdus(_nume.ToLower());
                        if (p1 != null)
                            Console.WriteLine("Produsul cautat:" + p1.ConversieLaSir_Afisare());
                        else
                            Console.WriteLine("Produsul cautat nu exista in baza noastra de date!");
                        break;
                    case "U":
                        string id, pret;
                        Console.WriteLine("ID-ul produsului este: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Noul pret este: ");
                        pret = Console.ReadLine();
                        bool aux;
                        aux = stocare_produse.UpdateProdus(id, pret);
                        if(aux)
                        {
                            produse = stocare_produse.GetInfoProduse();
                            AfisareProduse(produse);
                        }
                        else
                            Console.WriteLine("Produsul cautat nu exista in baza de date!");
                        break;
                    case "X":
                        Console.WriteLine("\nEXIT");
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;

                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            } while (opt.ToUpper() != "X");

        }

        public static void AfisareProduse(ArrayList produse)
        {
            if(produse.Count==0)
            {
                Console.WriteLine("\nNu sunt produse de afisat!\n");
            }
            else
            {
                Console.WriteLine("\nProdusele sunt:\n");
                for (int i=0; i< produse.Count; i++)
                {
                    Console.WriteLine(((Produse)produse[i]).ConversieLaSir_Afisare());
                }
            }
        }
        public static void AfisareProduseList(List<Produse> produse)
        {
            if (produse.Count == 0)
            {
                Console.WriteLine("\nNu sunt produse de afisat!\n");
            }
            else
            {
                Console.WriteLine("\nProdusele sunt:\n");
                for (int i = 0; i < produse.Count; i++)
                {
                    Console.WriteLine((produse[i]).ConversieLaSir_Afisare());
                }
            }
        }

        public static Produse CitireProdus()
        {
            string i;
            Console.Write("\nIntroduceti numele produsului: ");
            string n = Console.ReadLine();
            Console.Write("Introduceti pretul (Ex: 3,55 ron): ");
            string p = Console.ReadLine();
            Console.WriteLine($"Introduceti tipul produsului:\n" +
                $"1->Mancare\n" +
                $"2->Bautura");
            Console.Write("=> ");
            int tip = Int32.Parse(Console.ReadLine());
            if(tip==1)
            {
                Console.Write("Introduceti ingredentele separate prin spatiu: ");
                i = Console.ReadLine();
            }
            else
            {
                i = "-";
            }
            Console.Write("Introduceti valabilitatea (Ex: 3 zile/ 1 saptamana etc.): ");
            string v = Console.ReadLine();
            Console.Write("Introduceti cantitatea: ");
            int c = Int32.Parse(Console.ReadLine());
            

            Produse pr = new Produse(n, p, i, v, c);
            pr.TipP = (TipProdus)tip;

            return pr;
        }
        
    }
}
