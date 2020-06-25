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
        private Label lb_NaamOuder;
        private Label lb_AdresOuders;
        private TextBox tb_NaamOuder;
        private TextBox tb_AdresOuders;
        private TextBox tb_NaamKind;
        private TextBox tb_TelefoonnummerOuders;
        private Label lb_NaamKind;
        private Label lb_TelefoonnummerOuders;
        private Label lb_KamernummerKind;
        private TextBox textBox1;
        private Button btn_Uitloggen;

        public BezoekersPasAanpassen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lb_NaamOuder = new System.Windows.Forms.Label();
            this.lb_AdresOuders = new System.Windows.Forms.Label();
            this.tb_NaamOuder = new System.Windows.Forms.TextBox();
            this.tb_AdresOuders = new System.Windows.Forms.TextBox();
            this.tb_NaamKind = new System.Windows.Forms.TextBox();
            this.tb_TelefoonnummerOuders = new System.Windows.Forms.TextBox();
            this.lb_NaamKind = new System.Windows.Forms.Label();
            this.lb_TelefoonnummerOuders = new System.Windows.Forms.Label();
            this.lb_KamernummerKind = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NaamOuder
            // 
            this.lb_NaamOuder.AutoSize = true;
            this.lb_NaamOuder.Location = new System.Drawing.Point(48, 58);
            this.lb_NaamOuder.Name = "lb_NaamOuder";
            this.lb_NaamOuder.Size = new System.Drawing.Size(70, 13);
            this.lb_NaamOuder.TabIndex = 0;
            this.lb_NaamOuder.Text = "Naam Ouder:";
            // 
            // lb_AdresOuders
            // 
            this.lb_AdresOuders.AutoSize = true;
            this.lb_AdresOuders.Location = new System.Drawing.Point(81, 92);
            this.lb_AdresOuders.Name = "lb_AdresOuders";
            this.lb_AdresOuders.Size = new System.Drawing.Size(37, 13);
            this.lb_AdresOuders.TabIndex = 1;
            this.lb_AdresOuders.Text = "Adres:";
            // 
            // tb_NaamOuder
            // 
            this.tb_NaamOuder.Location = new System.Drawing.Point(142, 58);
            this.tb_NaamOuder.Name = "tb_NaamOuder";
            this.tb_NaamOuder.Size = new System.Drawing.Size(100, 20);
            this.tb_NaamOuder.TabIndex = 2;
            // 
            // tb_AdresOuders
            // 
            this.tb_AdresOuders.Location = new System.Drawing.Point(142, 89);
            this.tb_AdresOuders.Name = "tb_AdresOuders";
            this.tb_AdresOuders.Size = new System.Drawing.Size(100, 20);
            this.tb_AdresOuders.TabIndex = 3;
            // 
            // tb_NaamKind
            // 
            this.tb_NaamKind.Location = new System.Drawing.Point(142, 154);
            this.tb_NaamKind.Name = "tb_NaamKind";
            this.tb_NaamKind.Size = new System.Drawing.Size(100, 20);
            this.tb_NaamKind.TabIndex = 7;
            // 
            // tb_TelefoonnummerOuders
            // 
            this.tb_TelefoonnummerOuders.Location = new System.Drawing.Point(142, 123);
            this.tb_TelefoonnummerOuders.Name = "tb_TelefoonnummerOuders";
            this.tb_TelefoonnummerOuders.Size = new System.Drawing.Size(100, 20);
            this.tb_TelefoonnummerOuders.TabIndex = 6;
            // 
            // lb_NaamKind
            // 
            this.lb_NaamKind.AutoSize = true;
            this.lb_NaamKind.Location = new System.Drawing.Point(57, 154);
            this.lb_NaamKind.Name = "lb_NaamKind";
            this.lb_NaamKind.Size = new System.Drawing.Size(61, 13);
            this.lb_NaamKind.TabIndex = 5;
            this.lb_NaamKind.Text = "Naam kind:";
            // 
            // lb_TelefoonnummerOuders
            // 
            this.lb_TelefoonnummerOuders.AutoSize = true;
            this.lb_TelefoonnummerOuders.Location = new System.Drawing.Point(29, 123);
            this.lb_TelefoonnummerOuders.Name = "lb_TelefoonnummerOuders";
            this.lb_TelefoonnummerOuders.Size = new System.Drawing.Size(89, 13);
            this.lb_TelefoonnummerOuders.TabIndex = 4;
            this.lb_TelefoonnummerOuders.Text = "Telefoonnummer:";
            // 
            // lb_KamernummerKind
            // 
            this.lb_KamernummerKind.AutoSize = true;
            this.lb_KamernummerKind.Location = new System.Drawing.Point(41, 192);
            this.lb_KamernummerKind.Name = "lb_KamernummerKind";
            this.lb_KamernummerKind.Size = new System.Drawing.Size(77, 13);
            this.lb_KamernummerKind.TabIndex = 8;
            this.lb_KamernummerKind.Text = "Kamernummer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(402, 26);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 10;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // BezoekersPasAanpassen
            // 
            this.ClientSize = new System.Drawing.Size(524, 379);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_KamernummerKind);
            this.Controls.Add(this.tb_NaamKind);
            this.Controls.Add(this.tb_TelefoonnummerOuders);
            this.Controls.Add(this.lb_NaamKind);
            this.Controls.Add(this.lb_TelefoonnummerOuders);
            this.Controls.Add(this.tb_AdresOuders);
            this.Controls.Add(this.tb_NaamOuder);
            this.Controls.Add(this.lb_AdresOuders);
            this.Controls.Add(this.lb_NaamOuder);
            this.Name = "BezoekersPasAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
