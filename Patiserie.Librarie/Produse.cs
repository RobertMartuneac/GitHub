using System;


namespace Patiserie.Librarie
{
    public class Produse
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public static int NrUltimProdus { get; set; } = 0;
        public int NrProdus { get; set; }
        public string Nume { get; set; }
        public string Pret { get; set; }
        public string Ingrediente { get; set; }
        public string Valabilitate { get; set; }
        public int Cantitate { get; set; }
        public TipProdus TipP { get; set; }

        //constructor implicit
        public Produse()
        {
            Nume = Pret = Ingrediente = Valabilitate = string.Empty;
            Cantitate = 0;
            NrUltimProdus++;
            NrProdus=NrUltimProdus;
        }
        //constructor
        //public Produse(string text)
        //{
        //    string[] produse = text.Split(',');

        //    if (produse.Length != 5)
        //    {
        //        Nume = Pret = Ingrediente = Valabilitate = string.Empty;
        //        Cantitate = 0;
        //        Console.WriteLine("NU S-AU INTRODUS TOATE DATELE NECESARE PENTRU ACEST PRODUS");
        //    }
        //    else
        //    {
        //        Nume = produse[0];
        //        Pret = produse[1];
        //        Ingrediente = produse[2];
        //        Valabilitate = produse[3];
        //        Cantitate = Convert.ToInt32(produse[4]);
        //        NrUltimProdus++;
        //        NrProdus = NrUltimProdus;
        //    }
        //}
        public Produse(string nume, string pret, string ingrediante, string valabilitate, int cantitate)
        {
            Nume = nume;
            Pret = pret;
            Ingrediente = ingrediante;
            Valabilitate = valabilitate;
            Cantitate = cantitate;
            NrUltimProdus++;
            NrProdus = NrUltimProdus;
        }

        //constructor linie fisier
        public Produse(string linie)
        {
            string[] file_data = linie.Split(SEPARATOR_PRINCIPAL_FISIER);

            NrProdus = Convert.ToInt32(file_data[(int)CampuriProdus.ID]);
            Nume = file_data[(int)CampuriProdus.Nume];
            Pret = file_data[(int)CampuriProdus.Pret];
            Ingrediente = file_data[(int)CampuriProdus.Ingrediente];
            Valabilitate = file_data[(int)CampuriProdus.Valabilitate];
            Cantitate = Convert.ToInt32(file_data[(int)CampuriProdus.Cantitate]);
            TipP = (TipProdus)Convert.ToInt32(file_data[(int)CampuriProdus.Tip]);
            NrUltimProdus = NrProdus;
            //NrUltimProdus++;
            //NrProdus = NrUltimProdus;

        }
        public string ConversieLaSir()
        {
            string aux;
            if (string.IsNullOrEmpty(Nume))
            {
                aux = "Warning! Nu sunt produse de afisat!";
            }
            else
            {
                aux = $"Nume produs: {Nume}\n" +
                $"Pret produs: {Pret}\n" +
                $"Ingrediente: {Ingrediente}\n" +
                $"Valabilitate: {Valabilitate}\n" +
                $"Cantitate: {Cantitate} bucati\n";
            }

            return aux;
        }
        public string ConversieLaSir_Afisare()
        {
            string aux;

            if ((int)TipP == 2)
            {
                aux = $"[{NrProdus}] Nume: {Nume} -> Pret: {Pret}\n" +
                $"Valabilitate: {Valabilitate}\n" +
                $"Cantitate: {Cantitate} bucati\n" +
                $"Tip produs: {TipP}\n";
            }
            else
            {
                aux = $"[{NrProdus}] Nume: {Nume} -> Pret: {Pret}\n" +
                $"Ingrediente: {Ingrediente};\n" +
                $"Valabilitate: {Valabilitate}\n" +
                $"Cantitate: {Cantitate} bucati\n" +
                $"Tip produs: {TipP}\n";
            }

            return aux;
        }
        public string ConversieLaSir_Fisier()
        {
            string aux;

            aux = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER, NrProdus.ToString(), (Nume ?? " Necunoscut "), (Pret ?? " Necunoscut "), (Ingrediente ?? " Necunoscut "), (Valabilitate ?? " Necunoscut "), Cantitate.ToString(), (int)TipP);
            return aux;
        }

        //comparare a doua produse pretul
        public void Compare(Produse pr1)
        {
            if (this.Cantitate > pr1.Cantitate)
            {
                Console.WriteLine($"Sunt mai multe produse de tipul {this.Nume} decat {pr1.Nume}");
            }
            else
            {
                if (this.Cantitate < pr1.Cantitate)
                    Console.WriteLine($"Sunt mai multe produse de tipul {pr1.Nume} decat {this.Nume}");
                else
                    Console.WriteLine("Produsele sunt in cantitati egale");
            }
        }
    }
}
