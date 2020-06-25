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
    public partial class BezoekersPasAanpassen : Form
    {
        private TextBox tb_Kamernummer;
        private Label lb_Kamernummer;
        private PictureBox pb_Barcode;
        private Button btn_Annuleren;
        private Button btn_Aanmaken;
        private Button btn_ScanBarcode;
        private Button btn_KamerToevoegen;
        private TextBox tb_Telefoonnummer;
        private TextBox tb_Adres;
        private TextBox tb_NaamKind;
        private Button btn_Uitloggen;
        private TextBox tb_NaamOuder;
        private Label lb_ScanBarcode;
        private Label lb_NaamKind;
        private Label lb_Telefoonnummer;
        private Label lb_Adres;
        private Label lb_NaamOuder;
        private Label lb_PasAanpassen;
        private Button bt_ZoekOuder;

        public BezoekersPasAanpassen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tb_Kamernummer = new System.Windows.Forms.TextBox();
            this.lb_Kamernummer = new System.Windows.Forms.Label();
            this.pb_Barcode = new System.Windows.Forms.PictureBox();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Aanmaken = new System.Windows.Forms.Button();
            this.btn_ScanBarcode = new System.Windows.Forms.Button();
            this.btn_KamerToevoegen = new System.Windows.Forms.Button();
            this.tb_Telefoonnummer = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.tb_NaamKind = new System.Windows.Forms.TextBox();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamOuder = new System.Windows.Forms.TextBox();
            this.lb_ScanBarcode = new System.Windows.Forms.Label();
            this.lb_NaamKind = new System.Windows.Forms.Label();
            this.lb_Telefoonnummer = new System.Windows.Forms.Label();
            this.lb_Adres = new System.Windows.Forms.Label();
            this.lb_NaamOuder = new System.Windows.Forms.Label();
            this.lb_PasAanpassen = new System.Windows.Forms.Label();
            this.bt_ZoekOuder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Kamernummer
            // 
            this.tb_Kamernummer.Location = new System.Drawing.Point(188, 224);
            this.tb_Kamernummer.Name = "tb_Kamernummer";
            this.tb_Kamernummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Kamernummer.TabIndex = 59;
            // 
            // lb_Kamernummer
            // 
            this.lb_Kamernummer.AutoSize = true;
            this.lb_Kamernummer.Location = new System.Drawing.Point(57, 224);
            this.lb_Kamernummer.Name = "lb_Kamernummer";
            this.lb_Kamernummer.Size = new System.Drawing.Size(77, 13);
            this.lb_Kamernummer.TabIndex = 58;
            this.lb_Kamernummer.Text = "Kamernummer:";
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(188, 267);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 57;
            this.pb_Barcode.TabStop = false;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(272, 338);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 56;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Aanmaken
            // 
            this.btn_Aanmaken.Location = new System.Drawing.Point(157, 338);
            this.btn_Aanmaken.Name = "btn_Aanmaken";
            this.btn_Aanmaken.Size = new System.Drawing.Size(75, 23);
            this.btn_Aanmaken.TabIndex = 55;
            this.btn_Aanmaken.Text = "Aanmaken";
            this.btn_Aanmaken.UseVisualStyleBackColor = true;
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(329, 267);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 54;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_KamerToevoegen
            // 
            this.btn_KamerToevoegen.Location = new System.Drawing.Point(329, 224);
            this.btn_KamerToevoegen.Name = "btn_KamerToevoegen";
            this.btn_KamerToevoegen.Size = new System.Drawing.Size(127, 23);
            this.btn_KamerToevoegen.TabIndex = 53;
            this.btn_KamerToevoegen.Text = "Nog een toevoegen";
            this.btn_KamerToevoegen.UseVisualStyleBackColor = true;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(188, 151);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 52;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(188, 114);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 51;
            // 
            // tb_NaamKind
            // 
            this.tb_NaamKind.Location = new System.Drawing.Point(188, 186);
            this.tb_NaamKind.Name = "tb_NaamKind";
            this.tb_NaamKind.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamKind.TabIndex = 50;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(398, 17);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 49;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamOuder
            // 
            this.tb_NaamOuder.Location = new System.Drawing.Point(188, 76);
            this.tb_NaamOuder.Name = "tb_NaamOuder";
            this.tb_NaamOuder.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamOuder.TabIndex = 48;
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(57, 267);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 47;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // lb_NaamKind
            // 
            this.lb_NaamKind.AutoSize = true;
            this.lb_NaamKind.Location = new System.Drawing.Point(57, 186);
            this.lb_NaamKind.Name = "lb_NaamKind";
            this.lb_NaamKind.Size = new System.Drawing.Size(61, 13);
            this.lb_NaamKind.TabIndex = 46;
            this.lb_NaamKind.Text = "Naam kind:";
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(54, 151);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 45;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(57, 114);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 44;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_NaamOuder
            // 
            this.lb_NaamOuder.AutoSize = true;
            this.lb_NaamOuder.Location = new System.Drawing.Point(57, 76);
            this.lb_NaamOuder.Name = "lb_NaamOuder";
            this.lb_NaamOuder.Size = new System.Drawing.Size(68, 13);
            this.lb_NaamOuder.TabIndex = 43;
            this.lb_NaamOuder.Text = "Naam ouder:";
            // 
            // lb_PasAanpassen
            // 
            this.lb_PasAanpassen.AutoSize = true;
            this.lb_PasAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasAanpassen.Location = new System.Drawing.Point(52, 17);
            this.lb_PasAanpassen.Name = "lb_PasAanpassen";
            this.lb_PasAanpassen.Size = new System.Drawing.Size(261, 25);
            this.lb_PasAanpassen.TabIndex = 42;
            this.lb_PasAanpassen.Text = "Bezoekerspas aanpassen";
            // 
            // bt_ZoekOuder
            // 
            this.bt_ZoekOuder.Location = new System.Drawing.Point(329, 76);
            this.bt_ZoekOuder.Name = "bt_ZoekOuder";
            this.bt_ZoekOuder.Size = new System.Drawing.Size(75, 23);
            this.bt_ZoekOuder.TabIndex = 60;
            this.bt_ZoekOuder.Text = "Zoek";
            this.bt_ZoekOuder.UseVisualStyleBackColor = true;
            // 
            // BezoekersPasAanpassen
            // 
            this.ClientSize = new System.Drawing.Size(524, 379);
            this.Controls.Add(this.bt_ZoekOuder);
            this.Controls.Add(this.tb_Kamernummer);
            this.Controls.Add(this.lb_Kamernummer);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Aanmaken);
            this.Controls.Add(this.btn_ScanBarcode);
            this.Controls.Add(this.btn_KamerToevoegen);
            this.Controls.Add(this.tb_Telefoonnummer);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_NaamKind);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamOuder);
            this.Controls.Add(this.lb_ScanBarcode);
            this.Controls.Add(this.lb_NaamKind);
            this.Controls.Add(this.lb_Telefoonnummer);
            this.Controls.Add(this.lb_Adres);
            this.Controls.Add(this.lb_NaamOuder);
            this.Controls.Add(this.lb_PasAanpassen);
            this.Name = "BezoekersPasAanpassen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
