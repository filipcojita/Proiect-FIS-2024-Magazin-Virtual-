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
            this.label1 = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.MeniuVanzator_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.approvalStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ai venit in \'Magazin Virtual\'!";
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(681, 171);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(75, 23);
            this.Return_btn.TabIndex = 2;
            this.Return_btn.Text = "RETURN";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click_1);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(681, 200);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click_1);
            // 
            // MeniuVanzator_btn
            // 
            this.MeniuVanzator_btn.Location = new System.Drawing.Point(601, 54);
            this.MeniuVanzator_btn.Name = "MeniuVanzator_btn";
            this.MeniuVanzator_btn.Size = new System.Drawing.Size(103, 36);
            this.MeniuVanzator_btn.TabIndex = 4;
            this.MeniuVanzator_btn.Text = "MENIU VANZATOR";
            this.MeniuVanzator_btn.UseVisualStyleBackColor = true;
            this.MeniuVanzator_btn.Click += new System.EventHandler(this.MeniuVanzator_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "functionalitati regular user: buyer";
            // 
            // approvalStatusLabel
            // 
            this.approvalStatusLabel.AutoSize = true;
            this.approvalStatusLabel.Location = new System.Drawing.Point(520, 30);
            this.approvalStatusLabel.Name = "approvalStatusLabel";
            this.approvalStatusLabel.Size = new System.Drawing.Size(79, 13);
            this.approvalStatusLabel.TabIndex = 6;
            this.approvalStatusLabel.Text = "approval status";
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.approvalStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MeniuVanzator_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.label1);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button MeniuVanzator_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label approvalStatusLabel;
    }
}