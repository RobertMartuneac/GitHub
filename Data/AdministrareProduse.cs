using System;
using System.Collections;
using Patiserie.Librarie;
using System.IO;
using System.Collections.Generic;


namespace Data
{
    public class AdministrareProduse : IStocareData
    {
        string NumeFisier { get; set; }

        public AdministrareProduse()
        {
            this.NumeFisier = "Produse.txt";
            Stream FisierText = File.Open(NumeFisier, FileMode.OpenOrCreate);
            FisierText.Close();

            //creaza sau deschide fisierul text
        }
        public void AddProdus(Produse p)
        {
            this.NumeFisier = "Produse.txt";
            try
            {
                //scriere in fisier a unui produs
                using(StreamWriter scriereFisier=new StreamWriter(NumeFisier, true))
                {
                    scriereFisier.WriteLine(p.ConversieLaSir_Fisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public ArrayList GetInfoProduse()
        {
            ArrayList a_produse = new ArrayList();
            this.NumeFisier = "Produse.txt";

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader f = new StreamReader(NumeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = f.ReadLine()) != null)
                    {
                        Produse ProduseDinFisier = new Produse(line);
                        a_produse.Add(ProduseDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return a_produse;
        }
        public List<Produse> GetInfoProduseList()
        {
            List<Produse> a_produse = new List<Produse>();
            this.NumeFisier = "Produse.txt";

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader f = new StreamReader(NumeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = f.ReadLine()) != null)
                    {
                        Produse ProduseDinFisier = new Produse(line);
                        a_produse.Add(ProduseDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return a_produse;
        }
        public Produse GetProdus(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader f = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = f.ReadLine()) != null)
                    {
                        Produse PrFisier = new Produse(line);
                        if (PrFisier.Nume.ToLower() == nume)
                            return PrFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return null;
        }
        public Produse GetProdusId(int id)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader f = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = f.ReadLine()) != null)
                    {
                        Produse PrFisier = new Produse(line);
                        if (PrFisier.NrProdus == id)
                            return PrFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return null;
        }
        public bool UpdateProdus(string _id, string _pret)
        {
            this.NumeFisier = "Produse.txt";
            bool verificare = false;
            ArrayList prod = new ArrayList();

            using (StreamReader s = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = s.ReadLine()) != null)
                {
                    Produse produsDinFisier = new Produse(line);
                    if (produsDinFisier.NrProdus == Convert.ToInt32(_id))
                    { produsDinFisier.Pret = _pret; verificare = true; }

                    prod.Add(produsDinFisier);
                }
            }
            if (verificare == true)
            {
                File.Delete(NumeFisier);
                IStocareData stocareprodus = new AdministrareProduse();
                for (int i = 0; i < prod.Count; i++)
                {
                    stocareprodus.AddProdus((Produse)prod[i]);
                }
                return true;
            }
            else
                return false;
        }

    }
}
