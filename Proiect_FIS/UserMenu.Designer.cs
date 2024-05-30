namespace Proiect_FIS
{
    partial class UserMenu
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.MeniuVanzator_btn = new System.Windows.Forms.Button();
            this.approvalStatusLabel = new System.Windows.Forms.Label();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.Cumpara_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Oferta_btn = new System.Windows.Forms.Button();
            this.Oferta_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Solicitare_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(295, 66);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(158, 13);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Bine ai venit in \'Magazin Virtual\'!";
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(789, 161);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(75, 23);
            this.Return_btn.TabIndex = 2;
            this.Return_btn.Text = "RETURN";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click_1);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(789, 211);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click_1);
            // 
            // MeniuVanzator_btn
            // 
            this.MeniuVanzator_btn.Location = new System.Drawing.Point(761, 54);
            this.MeniuVanzator_btn.Name = "MeniuVanzator_btn";
            this.MeniuVanzator_btn.Size = new System.Drawing.Size(103, 36);
            this.MeniuVanzator_btn.TabIndex = 4;
            this.MeniuVanzator_btn.Text = "MENIU VANZATOR";
            this.MeniuVanzator_btn.UseVisualStyleBackColor = true;
            this.MeniuVanzator_btn.Click += new System.EventHandler(this.MeniuVanzator_btn_Click);
            // 
            // approvalStatusLabel
            // 
            this.approvalStatusLabel.AutoSize = true;
            this.approvalStatusLabel.Location = new System.Drawing.Point(661, 28);
            this.approvalStatusLabel.Name = "approvalStatusLabel";
            this.approvalStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.approvalStatusLabel.TabIndex = 6;
            this.approvalStatusLabel.Text = "approval status";
            // 
            // lstProduse
            // 
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.Location = new System.Drawing.Point(35, 97);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(705, 303);
            this.lstProduse.TabIndex = 7;
            // 
            // Cumpara_btn
            // 
            this.Cumpara_btn.Location = new System.Drawing.Point(216, 439);
            this.Cumpara_btn.Name = "Cumpara_btn";
            this.Cumpara_btn.Size = new System.Drawing.Size(118, 38);
            this.Cumpara_btn.TabIndex = 8;
            this.Cumpara_btn.Text = "CUMPARA";
            this.Cumpara_btn.UseVisualStyleBackColor = true;
            this.Cumpara_btn.Click += new System.EventHandler(this.Cumpara_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "selecteaza un produs pentru a-l cumpara sau pentru a-i face o oferta";
            // 
            // Oferta_btn
            // 
            this.Oferta_btn.Location = new System.Drawing.Point(434, 439);
            this.Oferta_btn.Name = "Oferta_btn";
            this.Oferta_btn.Size = new System.Drawing.Size(140, 38);
            this.Oferta_btn.TabIndex = 10;
            this.Oferta_btn.Text = "Propune o OFERTA";
            this.Oferta_btn.UseVisualStyleBackColor = true;
            this.Oferta_btn.Click += new System.EventHandler(this.Oferta_btn_Click);
            // 
            // Oferta_txt
            // 
            this.Oferta_txt.Location = new System.Drawing.Point(580, 457);
            this.Oferta_txt.Name = "Oferta_txt";
            this.Oferta_txt.Size = new System.Drawing.Size(122, 20);
            this.Oferta_txt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valoare oferta";
            // 
            // Solicitare_btn
            // 
            this.Solicitare_btn.Location = new System.Drawing.Point(771, 97);
            this.Solicitare_btn.Name = "Solicitare_btn";
            this.Solicitare_btn.Size = new System.Drawing.Size(93, 22);
            this.Solicitare_btn.TabIndex = 13;
            this.Solicitare_btn.Text = "Solicita cont";
            this.Solicitare_btn.UseVisualStyleBackColor = true;
            this.Solicitare_btn.Click += new System.EventHandler(this.Solicitare_btn_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 565);
            this.Controls.Add(this.Solicitare_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Oferta_txt);
            this.Controls.Add(this.Oferta_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cumpara_btn);
            this.Controls.Add(this.lstProduse);
            this.Controls.Add(this.approvalStatusLabel);
            this.Controls.Add(this.MeniuVanzator_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.welcome_label);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button MeniuVanzator_btn;
        private System.Windows.Forms.Label approvalStatusLabel;
        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Button Cumpara_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Oferta_btn;
        private System.Windows.Forms.TextBox Oferta_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Solicitare_btn;
    }
}