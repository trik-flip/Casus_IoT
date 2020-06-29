namespace Smart_Deur_App
{
    partial class Inloggen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Inloggen = new System.Windows.Forms.Button();
            this.lb_Gebruikersnaam = new System.Windows.Forms.Label();
            this.lb_Wachtwoord = new System.Windows.Forms.Label();
            this.tb_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inloggen.Location = new System.Drawing.Point(241, 275);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(103, 29);
            this.btn_Inloggen.TabIndex = 0;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = true;
            this.btn_Inloggen.Click += new System.EventHandler(this.btn_Inloggen_Click);
            // 
            // lb_Gebruikersnaam
            // 
            this.lb_Gebruikersnaam.AutoSize = true;
            this.lb_Gebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gebruikersnaam.Location = new System.Drawing.Point(125, 173);
            this.lb_Gebruikersnaam.Name = "lb_Gebruikersnaam";
            this.lb_Gebruikersnaam.Size = new System.Drawing.Size(111, 16);
            this.lb_Gebruikersnaam.TabIndex = 1;
            this.lb_Gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lb_Wachtwoord
            // 
            this.lb_Wachtwoord.AutoSize = true;
            this.lb_Wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Wachtwoord.Location = new System.Drawing.Point(125, 217);
            this.lb_Wachtwoord.Name = "lb_Wachtwoord";
            this.lb_Wachtwoord.Size = new System.Drawing.Size(86, 16);
            this.lb_Wachtwoord.TabIndex = 2;
            this.lb_Wachtwoord.Text = "Wachtwoord:";
            // 
            // tb_Gebruikersnaam
            // 
            this.tb_Gebruikersnaam.Location = new System.Drawing.Point(244, 170);
            this.tb_Gebruikersnaam.Name = "tb_Gebruikersnaam";
            this.tb_Gebruikersnaam.Size = new System.Drawing.Size(100, 21);
            this.tb_Gebruikersnaam.TabIndex = 3;
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(244, 214);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(100, 21);
            this.tb_Wachtwoord.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welkom bij het ziekenhuis systeem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "U kunt inloggen met uw credentials";
            // 
            // Inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Wachtwoord);
            this.Controls.Add(this.tb_Gebruikersnaam);
            this.Controls.Add(this.lb_Wachtwoord);
            this.Controls.Add(this.lb_Gebruikersnaam);
            this.Controls.Add(this.btn_Inloggen);
            this.Font = new System.Drawing.Font("Zilla Slab", 8.25F);
            this.Name = "Inloggen";
            this.Text = "Inloggen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inloggen_FormClosing);
            this.Load += new System.EventHandler(this.Inloggen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inloggen;
        private System.Windows.Forms.Label lb_Gebruikersnaam;
        private System.Windows.Forms.Label lb_Wachtwoord;
        private System.Windows.Forms.TextBox tb_Gebruikersnaam;
        private System.Windows.Forms.TextBox tb_Wachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}