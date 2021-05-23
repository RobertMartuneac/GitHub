
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbPret = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.rbMancare = new System.Windows.Forms.RadioButton();
            this.rbBautura = new System.Windows.Forms.RadioButton();
            this.tbIngrediente = new System.Windows.Forms.TextBox();
            this.lbIngrediente = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.lbValabilitate = new System.Windows.Forms.Label();
            this.tbValabilitate = new System.Windows.Forms.TextBox();
            this.lbCantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAccesDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Location = new System.Drawing.Point(57, 17);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(102, 20);
            this.lbNume.TabIndex = 0;
            this.lbNume.Text = "Nume produs:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(179, 14);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(134, 27);
            this.tbNume.TabIndex = 1;
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Location = new System.Drawing.Point(57, 74);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(115, 20);
            this.lbPret.TabIndex = 2;
            this.lbPret.Text = "Pret (EX. 3.5 lei):";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(179, 71);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(134, 27);
            this.tbPret.TabIndex = 3;
            // 
            // rbMancare
            // 
            this.rbMancare.AutoSize = true;
            this.rbMancare.Location = new System.Drawing.Point(57, 131);
            this.rbMancare.Name = "rbMancare";
            this.rbMancare.Size = new System.Drawing.Size(87, 24);
            this.rbMancare.TabIndex = 4;
            this.rbMancare.TabStop = true;
            this.rbMancare.Text = "Mancare";
            this.rbMancare.UseVisualStyleBackColor = true;
            // 
            // rbBautura
            // 
            this.rbBautura.AutoSize = true;
            this.rbBautura.Location = new System.Drawing.Point(223, 131);
            this.rbBautura.Name = "rbBautura";
            this.rbBautura.Size = new System.Drawing.Size(81, 24);
            this.rbBautura.TabIndex = 5;
            this.rbBautura.TabStop = true;
            this.rbBautura.Text = "Bautura";
            this.rbBautura.UseVisualStyleBackColor = true;
            // 
            // tbIngrediente
            // 
            this.tbIngrediente.Location = new System.Drawing.Point(57, 216);
            this.tbIngrediente.Multiline = true;
            this.tbIngrediente.Name = "tbIngrediente";
            this.tbIngrediente.Size = new System.Drawing.Size(256, 84);
            this.tbIngrediente.TabIndex = 7;
            // 
            // lbIngrediente
            // 
            this.lbIngrediente.AutoSize = true;
            this.lbIngrediente.Location = new System.Drawing.Point(57, 177);
            this.lbIngrediente.Name = "lbIngrediente";
            this.lbIngrediente.Size = new System.Drawing.Size(350, 20);
            this.lbIngrediente.TabIndex = 8;
            this.lbIngrediente.Text = "Ingrediente (fiecare ingredient separat prin spatiu) :";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(57, 328);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(130, 24);
            this.cb1.TabIndex = 9;
            this.cb1.Text = "Produs de post";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(57, 372);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(253, 24);
            this.cb2.TabIndex = 10;
            this.cb2.Text = "Nu contine aditivi sau conservanti";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(57, 414);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(102, 24);
            this.cb3.TabIndex = 11;
            this.cb3.Text = "Produs Bio";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // lbValabilitate
            // 
            this.lbValabilitate.AutoSize = true;
            this.lbValabilitate.Location = new System.Drawing.Point(57, 468);
            this.lbValabilitate.Name = "lbValabilitate";
            this.lbValabilitate.Size = new System.Drawing.Size(304, 20);
            this.lbValabilitate.TabIndex = 12;
            this.lbValabilitate.Text = "Valabilitate (Ex. 1 zi, 2 luni, 2 saptamani etc.):";
            // 
            // tbValabilitate
            // 
            this.tbValabilitate.Location = new System.Drawing.Point(57, 503);
            this.tbValabilitate.Name = "tbValabilitate";
            this.tbValabilitate.Size = new System.Drawing.Size(209, 27);
            this.tbValabilitate.TabIndex = 13;
            // 
            // lbCantitate
            // 
            this.lbCantitate.AutoSize = true;
            this.lbCantitate.Location = new System.Drawing.Point(57, 554);
            this.lbCantitate.Name = "lbCantitate";
            this.lbCantitate.Size = new System.Drawing.Size(166, 20);
            this.lbCantitate.TabIndex = 14;
            this.lbCantitate.Text = "Cantitate (Ex. 5, 10 etc.):";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(229, 551);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(132, 27);
            this.tbCantitate.TabIndex = 15;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWarning.ForeColor = System.Drawing.Color.Black;
            this.lbWarning.Location = new System.Drawing.Point(427, 21);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(32, 23);
            this.lbWarning.TabIndex = 16;
            this.lbWarning.Text = "=>";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(502, 529);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(130, 52);
            this.btnADD.TabIndex = 17;
            this.btnADD.Text = "Adauga";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(681, 529);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(130, 52);
            this.btnAfisare.TabIndex = 18;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(502, 600);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(130, 52);
            this.btnCauta.TabIndex = 19;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(681, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 52);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Editeaza";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(427, 74);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(449, 364);
            this.rtbAfisare.TabIndex = 21;
            this.rtbAfisare.Text = "";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(427, 453);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(132, 50);
            this.tbID.TabIndex = 23;
            // 
            // btnAccesDate
            // 
            this.btnAccesDate.Location = new System.Drawing.Point(582, 453);
            this.btnAccesDate.Name = "btnAccesDate";
            this.btnAccesDate.Size = new System.Drawing.Size(294, 50);
            this.btnAccesDate.TabIndex = 24;
            this.btnAccesDate.Text = "Accesare date despre produs dupa id";
            this.btnAccesDate.UseVisualStyleBackColor = true;
            this.btnAccesDate.Click += new System.EventHandler(this.btnAccesDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 664);
            this.Controls.Add(this.btnAccesDate);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.lbCantitate);
            this.Controls.Add(this.tbValabilitate);
            this.Controls.Add(this.lbValabilitate);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lbIngrediente);
            this.Controls.Add(this.tbIngrediente);
            this.Controls.Add(this.rbBautura);
            this.Controls.Add(this.rbMancare);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.lbPret);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbNume);
            this.Name = "Form1";
            this.Text = "Patiseria La Robica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.RadioButton rbMancare;
        private System.Windows.Forms.RadioButton rbBautura;
        private System.Windows.Forms.TextBox tbIngrediente;
        private System.Windows.Forms.Label lbIngrediente;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Label lbValabilitate;
        private System.Windows.Forms.TextBox tbValabilitate;
        private System.Windows.Forms.Label lbCantitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RichTextBox rtbAfisare;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAccesDate;
    }
}

