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
            this.SuspendLayout();
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.Location = new System.Drawing.Point(244, 219);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(103, 23);
            this.btn_Inloggen.TabIndex = 0;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = true;
            this.btn_Inloggen.Click += new System.EventHandler(this.btn_Inloggen_Click);
            // 
            // lb_Gebruikersnaam
            // 
            this.lb_Gebruikersnaam.AutoSize = true;
            this.lb_Gebruikersnaam.Location = new System.Drawing.Point(125, 119);
            this.lb_Gebruikersnaam.Name = "lb_Gebruikersnaam";
            this.lb_Gebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lb_Gebruikersnaam.TabIndex = 1;
            this.lb_Gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lb_Wachtwoord
            // 
            this.lb_Wachtwoord.AutoSize = true;
            this.lb_Wachtwoord.Location = new System.Drawing.Point(128, 152);
            this.lb_Wachtwoord.Name = "lb_Wachtwoord";
            this.lb_Wachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lb_Wachtwoord.TabIndex = 2;
            this.lb_Wachtwoord.Text = "Wachtwoord:";
            // 
            // tb_Gebruikersnaam
            // 
            this.tb_Gebruikersnaam.Location = new System.Drawing.Point(244, 119);
            this.tb_Gebruikersnaam.Name = "tb_Gebruikersnaam";
            this.tb_Gebruikersnaam.Size = new System.Drawing.Size(100, 20);
            this.tb_Gebruikersnaam.TabIndex = 3;
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(244, 152);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(100, 20);
            this.tb_Wachtwoord.TabIndex = 4;
            // 
            // Inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Wachtwoord);
            this.Controls.Add(this.tb_Gebruikersnaam);
            this.Controls.Add(this.lb_Wachtwoord);
            this.Controls.Add(this.lb_Gebruikersnaam);
            this.Controls.Add(this.btn_Inloggen);
            this.Name = "Inloggen";
            this.Text = "Inloggen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inloggen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inloggen;
        private System.Windows.Forms.Label lb_Gebruikersnaam;
        private System.Windows.Forms.Label lb_Wachtwoord;
        private System.Windows.Forms.TextBox tb_Gebruikersnaam;
        private System.Windows.Forms.TextBox tb_Wachtwoord;
    }
}