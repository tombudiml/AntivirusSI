namespace AntivirusSI
{
    partial class MainMenu
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
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.txtMapa = new System.Windows.Forms.TextBox();
            this.btnAnaliziraj = new System.Windows.Forms.Button();
            this.txtListaVirusa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUkupanBrojVirusa = new System.Windows.Forms.Label();
            this.lblUkupanBroj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(243, 12);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(137, 46);
            this.btnOdaberi.TabIndex = 0;
            this.btnOdaberi.Text = "Odaberi mapu";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // txtMapa
            // 
            this.txtMapa.Location = new System.Drawing.Point(26, 26);
            this.txtMapa.Name = "txtMapa";
            this.txtMapa.Size = new System.Drawing.Size(200, 20);
            this.txtMapa.TabIndex = 1;
            // 
            // btnAnaliziraj
            // 
            this.btnAnaliziraj.Location = new System.Drawing.Point(282, 305);
            this.btnAnaliziraj.Name = "btnAnaliziraj";
            this.btnAnaliziraj.Size = new System.Drawing.Size(98, 38);
            this.btnAnaliziraj.TabIndex = 2;
            this.btnAnaliziraj.Text = "Analiziraj";
            this.btnAnaliziraj.UseVisualStyleBackColor = true;
            this.btnAnaliziraj.Click += new System.EventHandler(this.btnAnaliziraj_Click);
            // 
            // txtListaVirusa
            // 
            this.txtListaVirusa.Location = new System.Drawing.Point(23, 82);
            this.txtListaVirusa.Multiline = true;
            this.txtListaVirusa.Name = "txtListaVirusa";
            this.txtListaVirusa.Size = new System.Drawing.Size(357, 209);
            this.txtListaVirusa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kompromitirane datoteke:";
            // 
            // lblUkupanBrojVirusa
            // 
            this.lblUkupanBrojVirusa.AutoSize = true;
            this.lblUkupanBrojVirusa.Location = new System.Drawing.Point(20, 318);
            this.lblUkupanBrojVirusa.Name = "lblUkupanBrojVirusa";
            this.lblUkupanBrojVirusa.Size = new System.Drawing.Size(102, 13);
            this.lblUkupanBrojVirusa.TabIndex = 6;
            this.lblUkupanBrojVirusa.Text = "Ukupan broj virusa: ";
            // 
            // lblUkupanBroj
            // 
            this.lblUkupanBroj.AutoSize = true;
            this.lblUkupanBroj.ForeColor = System.Drawing.Color.Red;
            this.lblUkupanBroj.Location = new System.Drawing.Point(162, 318);
            this.lblUkupanBroj.Name = "lblUkupanBroj";
            this.lblUkupanBroj.Size = new System.Drawing.Size(0, 13);
            this.lblUkupanBroj.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 355);
            this.Controls.Add(this.lblUkupanBroj);
            this.Controls.Add(this.lblUkupanBrojVirusa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListaVirusa);
            this.Controls.Add(this.btnAnaliziraj);
            this.Controls.Add(this.txtMapa);
            this.Controls.Add(this.btnOdaberi);
            this.Name = "MainMenu";
            this.Text = "Sigurnost internet - Antivirus";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.TextBox txtMapa;
        private System.Windows.Forms.Button btnAnaliziraj;
        private System.Windows.Forms.TextBox txtListaVirusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupanBrojVirusa;
        private System.Windows.Forms.Label lblUkupanBroj;
    }
}

