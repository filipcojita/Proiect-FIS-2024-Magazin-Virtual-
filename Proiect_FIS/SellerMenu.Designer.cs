namespace Proiect_FIS
{
    partial class SellerMenu
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
            this.Adaugare_btn = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Anulare_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Oferte_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(295, 30);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(233, 13);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to SELLER MENU, nume@email.com";
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(716, 30);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(75, 23);
            this.Return_btn.TabIndex = 4;
            this.Return_btn.Text = "RETURN";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click_1);
            // 
            // Adaugare_btn
            // 
            this.Adaugare_btn.Location = new System.Drawing.Point(91, 369);
            this.Adaugare_btn.Name = "Adaugare_btn";
            this.Adaugare_btn.Size = new System.Drawing.Size(157, 39);
            this.Adaugare_btn.TabIndex = 5;
            this.Adaugare_btn.Text = "Adaugare Produs Nou";
            this.Adaugare_btn.UseVisualStyleBackColor = true;
            this.Adaugare_btn.Click += new System.EventHandler(this.Adaugare_btn_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(36, 92);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(758, 238);
            this.lstProducts.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produse pe care le aveti la vanzare:";
            // 
            // Anulare_btn
            // 
            this.Anulare_btn.Location = new System.Drawing.Point(334, 369);
            this.Anulare_btn.Name = "Anulare_btn";
            this.Anulare_btn.Size = new System.Drawing.Size(150, 39);
            this.Anulare_btn.TabIndex = 8;
            this.Anulare_btn.Text = "Anulare Vanzare";
            this.Anulare_btn.UseVisualStyleBackColor = true;
            this.Anulare_btn.Click += new System.EventHandler(this.Anulare_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecteaza un produs pentru a-l sterge";
            // 
            // Oferte_btn
            // 
            this.Oferte_btn.Location = new System.Drawing.Point(581, 369);
            this.Oferte_btn.Name = "Oferte_btn";
            this.Oferte_btn.Size = new System.Drawing.Size(136, 39);
            this.Oferte_btn.TabIndex = 10;
            this.Oferte_btn.Text = "Vezi Oferte";
            this.Oferte_btn.UseVisualStyleBackColor = true;
            this.Oferte_btn.Click += new System.EventHandler(this.Oferte_btn_Click);
            // 
            // SellerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.Oferte_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Anulare_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.Adaugare_btn);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.welcome_label);
            this.Name = "SellerMenu";
            this.Text = "SellerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Adaugare_btn;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Anulare_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Oferte_btn;
    }
}