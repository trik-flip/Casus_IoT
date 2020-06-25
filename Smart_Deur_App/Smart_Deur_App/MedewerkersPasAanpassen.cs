using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Deur_App
{
    public partial class MedewerkersPasAanpassen : Form
    {
        private PictureBox pb_Barcode;
        private Button btn_Annuleren;
        private Button btn_Aanpassen;
        private Button btn_ScanBarcode;
        private Button btn_KamerToevoegen;
        private Button btn_NaamZoeken;
        private TextBox tb_Telefoonnummer;
        private TextBox tb_Functie;
        private TextBox tb_Adres;
        private TextBox tb_Kamernummers;
        private Button btn_Uitloggen;
        private TextBox tb_NaamMedewerker;
        private Label lb_ScanBarcode;
        private Label lb_Kamernummers;
        private Label lb_Telefoonnummer;
        private Label lb_Adres;
        private Label lb_Functie;
        private Label lb_NaamMedewerker;
        private Label lb_PasAanpassen;

        public MedewerkersPasAanpassen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pb_Barcode = new System.Windows.Forms.PictureBox();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Aanpassen = new System.Windows.Forms.Button();
            this.btn_ScanBarcode = new System.Windows.Forms.Button();
            this.btn_KamerToevoegen = new System.Windows.Forms.Button();
            this.btn_NaamZoeken = new System.Windows.Forms.Button();
            this.tb_Telefoonnummer = new System.Windows.Forms.TextBox();
            this.tb_Functie = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.tb_Kamernummers = new System.Windows.Forms.TextBox();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.lb_ScanBarcode = new System.Windows.Forms.Label();
            this.lb_Kamernummers = new System.Windows.Forms.Label();
            this.lb_Telefoonnummer = new System.Windows.Forms.Label();
            this.lb_Adres = new System.Windows.Forms.Label();
            this.lb_Functie = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_PasAanpassen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(207, 270);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 39;
            this.pb_Barcode.TabStop = false;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(291, 341);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 38;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Aanpassen
            // 
            this.btn_Aanpassen.Location = new System.Drawing.Point(176, 341);
            this.btn_Aanpassen.Name = "btn_Aanpassen";
            this.btn_Aanpassen.Size = new System.Drawing.Size(75, 23);
            this.btn_Aanpassen.TabIndex = 37;
            this.btn_Aanpassen.Text = "Aanpassen";
            this.btn_Aanpassen.UseVisualStyleBackColor = true;
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(348, 270);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 36;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_KamerToevoegen
            // 
            this.btn_KamerToevoegen.Location = new System.Drawing.Point(348, 227);
            this.btn_KamerToevoegen.Name = "btn_KamerToevoegen";
            this.btn_KamerToevoegen.Size = new System.Drawing.Size(127, 23);
            this.btn_KamerToevoegen.TabIndex = 35;
            this.btn_KamerToevoegen.Text = "Nog een toevoegen";
            this.btn_KamerToevoegen.UseVisualStyleBackColor = true;
            // 
            // btn_NaamZoeken
            // 
            this.btn_NaamZoeken.Location = new System.Drawing.Point(348, 79);
            this.btn_NaamZoeken.Name = "btn_NaamZoeken";
            this.btn_NaamZoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_NaamZoeken.TabIndex = 34;
            this.btn_NaamZoeken.Text = "Zoeken";
            this.btn_NaamZoeken.UseVisualStyleBackColor = true;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(207, 188);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 33;
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(207, 112);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 32;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(207, 152);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 31;
            // 
            // tb_Kamernummers
            // 
            this.tb_Kamernummers.Location = new System.Drawing.Point(207, 229);
            this.tb_Kamernummers.Name = "tb_Kamernummers";
            this.tb_Kamernummers.Size = new System.Drawing.Size(118, 20);
            this.tb_Kamernummers.TabIndex = 30;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(417, 20);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 29;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(207, 79);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 28;
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(76, 270);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 27;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // lb_Kamernummers
            // 
            this.lb_Kamernummers.AutoSize = true;
            this.lb_Kamernummers.Location = new System.Drawing.Point(76, 232);
            this.lb_Kamernummers.Name = "lb_Kamernummers";
            this.lb_Kamernummers.Size = new System.Drawing.Size(82, 13);
            this.lb_Kamernummers.TabIndex = 26;
            this.lb_Kamernummers.Text = "Kamernummers:";
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(76, 195);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 25;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(76, 152);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 24;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(76, 115);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 23;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(76, 79);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 22;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_PasAanpassen
            // 
            this.lb_PasAanpassen.AutoSize = true;
            this.lb_PasAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasAanpassen.Location = new System.Drawing.Point(71, 20);
            this.lb_PasAanpassen.Name = "lb_PasAanpassen";
            this.lb_PasAanpassen.Size = new System.Drawing.Size(288, 25);
            this.lb_PasAanpassen.TabIndex = 21;
            this.lb_PasAanpassen.Text = "Medewerkerspas aanpassen";
            // 
            // MedewerkersPasAanpassen
            // 
            this.ClientSize = new System.Drawing.Size(529, 516);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Aanpassen);
            this.Controls.Add(this.btn_ScanBarcode);
            this.Controls.Add(this.btn_KamerToevoegen);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.tb_Telefoonnummer);
            this.Controls.Add(this.tb_Functie);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_Kamernummers);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_ScanBarcode);
            this.Controls.Add(this.lb_Kamernummers);
            this.Controls.Add(this.lb_Telefoonnummer);
            this.Controls.Add(this.lb_Adres);
            this.Controls.Add(this.lb_Functie);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_PasAanpassen);
            this.Name = "MedewerkersPasAanpassen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
