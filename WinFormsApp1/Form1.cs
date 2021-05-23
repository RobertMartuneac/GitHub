using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Patiserie.Librarie;
using System.Collections;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        IStocareData s_produse = new AdministrareProduse();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ArrayList pr = s_produse.GetInfoProduse();
            int nrp = pr.Count;
            Produse.NrUltimProdus = nrp;
            int c=0;
            if(String.IsNullOrEmpty(tbNume.Text))
            {
                lbNume.ForeColor = Color.Red;
                return;
            }
            if(!ValidareDateChar(tbNume.Text))
            {
                tbNume.ForeColor = Color.Red;
                return;
            }
            if(!ValidareDateNumber(tbCantitate.Text))
            {
                tbCantitate.ForeColor = Color.Red;
                return;
            }

            if (!String.IsNullOrEmpty(tbCantitate.Text))
                c = Convert.ToInt32(tbCantitate.Text);

            Produse prd = new Produse(tbNume.Text, AutoFill(tbPret.Text), AutoFill(tbIngrediente.Text), AutoFill(tbValabilitate.Text), c);

            if (rbMancare.Checked)
                prd.TipP = TipProdus.Mancare;
            else
            {
                if (rbBautura.Checked)
                    prd.TipP = TipProdus.Bautura;
            }
            
            s_produse.AddProdus(prd);

            lbWarning.ForeColor = Color.Green;
            lbWarning.Text = "=> Produs inregistrat cu succes";
            tbID.Text = string.Empty;
            FieldReset();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            rtbAfisare.Clear();
            rtbAfisare.AppendText("Produsele sunt:\n");
            rtbAfisare.AppendText(Environment.NewLine);
            
            if((s_produse.GetInfoProduse()).Count==0)
            {
                rtbAfisare.AppendText("Nu sunt produse de afisat!");
                rtbAfisare.AppendText(Environment.NewLine);
            }
            else
            {
                foreach (Produse p in s_produse.GetInfoProduse())
                {
                    rtbAfisare.AppendText(p.ConversieLaSir_Afisare());
                    rtbAfisare.AppendText(Environment.NewLine);
                }
            }

            lbWarning.ForeColor = Color.Black;
            lbWarning.Text = "=>";
            tbID.Text = string.Empty;
            FieldReset();

        }
        private void FieldReset()
        {
            tbNume.Text = tbPret.Text = tbIngrediente.Text = tbValabilitate.Text = tbCantitate.Text = string.Empty;
            rbMancare.Checked = false;
            rbBautura.Checked = false;
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            lbNume.ForeColor = Color.Black;
            tbNume.ForeColor = Color.Black;
            tbCantitate.ForeColor = Color.Black;
            
            
        }
        private bool ValidareDateChar(string aux)
        {
            for(int i=0;i<aux.Length;i++)
            {
                if (char.IsDigit(aux[i]))
                    return false;
            }

            return true;
        }
        private bool ValidareDateNumber(string aux)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                if (char.IsDigit(aux[i])==false)
                    return false;
            }

            return true;
        }
        private string AutoFill(string aux)
        {
            string a = "N/A";

            if (String.IsNullOrEmpty(aux))
                return a;

            return aux;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Produse pr;

            if (String.IsNullOrEmpty(tbNume.Text))
            {
                lbNume.ForeColor = Color.Red;
                return;
            }
            if (!ValidareDateChar(tbNume.Text))
            {
                tbNume.ForeColor = Color.Red;
                return;
            }
            
            pr = s_produse.GetProdus(tbNume.Text.ToLower());

            if(pr!=null)
            {
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Produsul cautat este:\n");
                rtbAfisare.AppendText(Environment.NewLine);
                rtbAfisare.AppendText(pr.ConversieLaSir_Afisare());
                rtbAfisare.AppendText(Environment.NewLine);
            }
            else
            {
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Produsul cautat nu exista in patiserie!");
                rtbAfisare.AppendText(Environment.NewLine);
            }

            lbWarning.ForeColor = Color.Black;
            lbWarning.Text = "=>";
            tbID.Text = string.Empty;
            FieldReset();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool aux;
            Produse produs_afisare;
            if (String.IsNullOrEmpty(tbID.Text))
            {
                lbWarning.Text = "Eroare ID incorect!";
                lbWarning.ForeColor=Color.Red;
                return;
            }
            if(String.IsNullOrEmpty(tbID.Text))
            {
                lbWarning.Text = "Eroare Lipseste Pret!";
                lbWarning.ForeColor = Color.Red;
                return;
            }
            if (!ValidareDateNumber(tbID.Text))
            {
                tbID.ForeColor = Color.Red;
                return;
            }

            aux = s_produse.UpdateProdus(tbID.Text, tbPret.Text);

            if(aux)
            {
                produs_afisare = s_produse.GetProdusId(Convert.ToInt32(tbID.Text));
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Produsul editat este:\n");
                rtbAfisare.AppendText(Environment.NewLine);
                rtbAfisare.AppendText(produs_afisare.ConversieLaSir_Afisare());
                rtbAfisare.AppendText(Environment.NewLine);
            }
            else
            {
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Eroare la modificare!\n");
                rtbAfisare.AppendText(Environment.NewLine);
            }

            lbWarning.ForeColor = Color.Black;
            lbWarning.Text = "=>";
            tbID.Text = string.Empty;
            FieldReset();
        }

        private void btnAccesDate_Click(object sender, EventArgs e)
        {
            int id=0;
            Produse produs_cautat;

            if (!ValidareDateNumber(tbID.Text))
            {
                tbID.ForeColor = Color.Red;
                return;
            }
            if (!String.IsNullOrEmpty(tbID.Text))
                id = Convert.ToInt32(tbID.Text);

            produs_cautat = s_produse.GetProdusId(id);

            if (produs_cautat != null)
            {
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Produsul cautat este:\n");
                rtbAfisare.AppendText(Environment.NewLine);
                rtbAfisare.AppendText(produs_cautat.ConversieLaSir_Afisare());
                rtbAfisare.AppendText(Environment.NewLine);
                tbNume.Text = produs_cautat.Nume;
                tbPret.Text = produs_cautat.Pret;
                lbWarning.ForeColor = Color.Black;
                lbWarning.Text = "=> Editati pretul produsului";
            }
            else
            {
                rtbAfisare.Clear();
                rtbAfisare.AppendText("Produsul cautat nu exista in patiserie!");
                rtbAfisare.AppendText(Environment.NewLine);
            }
            lbNume.ForeColor = Color.Black;
        }
    }
}
