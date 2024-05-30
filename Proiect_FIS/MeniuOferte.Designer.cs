namespace Proiect_FIS
{
    partial class MeniuOferte
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
            this.label1 = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstOffers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AcceptOffer_btn = new System.Windows.Forms.Button();
            this.DeclineOffer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meniu Oferte";
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(744, 174);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(75, 23);
            this.Return_btn.TabIndex = 34;
            this.Return_btn.Text = "RETURN";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click_1);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(41, 82);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(302, 277);
            this.lstProducts.TabIndex = 35;
            // 
            // lstOffers
            // 
            this.lstOffers.FormattingEnabled = true;
            this.lstOffers.Location = new System.Drawing.Point(386, 82);
            this.lstOffers.Name = "lstOffers";
            this.lstOffers.Size = new System.Drawing.Size(304, 277);
            this.lstOffers.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Produse cu pret negociabil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Lista Oferte disponibile:";
            // 
            // AcceptOffer_btn
            // 
            this.AcceptOffer_btn.Location = new System.Drawing.Point(389, 381);
            this.AcceptOffer_btn.Name = "AcceptOffer_btn";
            this.AcceptOffer_btn.Size = new System.Drawing.Size(116, 44);
            this.AcceptOffer_btn.TabIndex = 39;
            this.AcceptOffer_btn.Text = "Accepta Oferta";
            this.AcceptOffer_btn.UseVisualStyleBackColor = true;
            this.AcceptOffer_btn.Click += new System.EventHandler(this.AcceptOffer_btn_Click_1);
            // 
            // DeclineOffer_btn
            // 
            this.DeclineOffer_btn.Location = new System.Drawing.Point(589, 381);
            this.DeclineOffer_btn.Name = "DeclineOffer_btn";
            this.DeclineOffer_btn.Size = new System.Drawing.Size(101, 44);
            this.DeclineOffer_btn.TabIndex = 40;
            this.DeclineOffer_btn.Text = "Respinge Oferta";
            this.DeclineOffer_btn.UseVisualStyleBackColor = true;
            this.DeclineOffer_btn.Click += new System.EventHandler(this.DeclineOffer_btn_Click_1);
            // 
            // MeniuOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 523);
            this.Controls.Add(this.DeclineOffer_btn);
            this.Controls.Add(this.AcceptOffer_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstOffers);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.label1);
            this.Name = "MeniuOferte";
            this.Text = "MeniuOferte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstOffers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AcceptOffer_btn;
        private System.Windows.Forms.Button DeclineOffer_btn;
    }
}