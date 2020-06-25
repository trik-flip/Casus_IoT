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
    public partial class BezoekersPasMaken : Form
    {
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
        private Label lb_Kamernummer;
        private TextBox tb_Kamernummer;
        private Label lb_PasMaken;

        public BezoekersPasMaken()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
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
            this.lb_PasMaken = new System.Windows.Forms.Label();
            this.lb_Kamernummer = new System.Windows.Forms.Label();
            this.tb_Kamernummer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(164, 259);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 39;
            this.pb_Barcode.TabStop = false;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(248, 330);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 38;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Aanmaken
            // 
            this.btn_Aanmaken.Location = new System.Drawing.Point(133, 330);
            this.btn_Aanmaken.Name = "btn_Aanmaken";
            this.btn_Aanmaken.Size = new System.Drawing.Size(75, 23);
            this.btn_Aanmaken.TabIndex = 37;
            this.btn_Aanmaken.Text = "Aanmaken";
            this.btn_Aanmaken.UseVisualStyleBackColor = true;
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(305, 259);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 36;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_KamerToevoegen
            // 
            this.btn_KamerToevoegen.Location = new System.Drawing.Point(305, 216);
            this.btn_KamerToevoegen.Name = "btn_KamerToevoegen";
            this.btn_KamerToevoegen.Size = new System.Drawing.Size(127, 23);
            this.btn_KamerToevoegen.TabIndex = 35;
            this.btn_KamerToevoegen.Text = "Nog een toevoegen";
            this.btn_KamerToevoegen.UseVisualStyleBackColor = true;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(164, 143);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 33;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(164, 106);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 31;
            // 
            // tb_NaamKind
            // 
            this.tb_NaamKind.Location = new System.Drawing.Point(164, 178);
            this.tb_NaamKind.Name = "tb_NaamKind";
            this.tb_NaamKind.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamKind.TabIndex = 30;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(374, 9);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 29;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamOuder
            // 
            this.tb_NaamOuder.Location = new System.Drawing.Point(164, 68);
            this.tb_NaamOuder.Name = "tb_NaamOuder";
            this.tb_NaamOuder.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamOuder.TabIndex = 28;
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(33, 259);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 27;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // lb_NaamKind
            // 
            this.lb_NaamKind.AutoSize = true;
            this.lb_NaamKind.Location = new System.Drawing.Point(33, 178);
            this.lb_NaamKind.Name = "lb_NaamKind";
            this.lb_NaamKind.Size = new System.Drawing.Size(61, 13);
            this.lb_NaamKind.TabIndex = 26;
            this.lb_NaamKind.Text = "Naam kind:";
            this.lb_NaamKind.Click += new System.EventHandler(this.lb_Kamernummers_Click);
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(30, 143);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 25;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(33, 106);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 24;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_NaamOuder
            // 
            this.lb_NaamOuder.AutoSize = true;
            this.lb_NaamOuder.Location = new System.Drawing.Point(33, 68);
            this.lb_NaamOuder.Name = "lb_NaamOuder";
            this.lb_NaamOuder.Size = new System.Drawing.Size(68, 13);
            this.lb_NaamOuder.TabIndex = 22;
            this.lb_NaamOuder.Text = "Naam ouder:";
            // 
            // lb_PasMaken
            // 
            this.lb_PasMaken.AutoSize = true;
            this.lb_PasMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasMaken.Location = new System.Drawing.Point(28, 9);
            this.lb_PasMaken.Name = "lb_PasMaken";
            this.lb_PasMaken.Size = new System.Drawing.Size(219, 25);
            this.lb_PasMaken.TabIndex = 21;
            this.lb_PasMaken.Text = "Bezoekerspas maken";
            // 
            // lb_Kamernummer
            // 
            this.lb_Kamernummer.AutoSize = true;
            this.lb_Kamernummer.Location = new System.Drawing.Point(33, 216);
            this.lb_Kamernummer.Name = "lb_Kamernummer";
            this.lb_Kamernummer.Size = new System.Drawing.Size(77, 13);
            this.lb_Kamernummer.TabIndex = 40;
            this.lb_Kamernummer.Text = "Kamernummer:";
            // 
            // tb_Kamernummer
            // 
            this.tb_Kamernummer.Location = new System.Drawing.Point(164, 216);
            this.tb_Kamernummer.Name = "tb_Kamernummer";
            this.tb_Kamernummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Kamernummer.TabIndex = 41;
            // 
            // BezoekersPasMaken
            // 
            this.ClientSize = new System.Drawing.Size(523, 455);
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
            this.Controls.Add(this.lb_PasMaken);
            this.Name = "BezoekersPasMaken";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lb_Kamernummers_Click(object sender, EventArgs e)
        {

        }
    }
}
