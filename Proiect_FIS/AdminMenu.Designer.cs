namespace Proiect_FIS
{
    partial class AdminMenu
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.Aprobare_btn = new System.Windows.Forms.Button();
            this.Respinge_btn = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lstApplicants = new System.Windows.Forms.ListBox();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ANULEAZA_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(312, 40);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(117, 13);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome back, Admin!";
            // 
            // Aprobare_btn
            // 
            this.Aprobare_btn.Location = new System.Drawing.Point(335, 384);
            this.Aprobare_btn.Name = "Aprobare_btn";
            this.Aprobare_btn.Size = new System.Drawing.Size(113, 31);
            this.Aprobare_btn.TabIndex = 1;
            this.Aprobare_btn.Text = "APROBA Cont";
            this.Aprobare_btn.UseVisualStyleBackColor = true;
            this.Aprobare_btn.Click += new System.EventHandler(this.Aprobare_btn_Click);
            // 
            // Respinge_btn
            // 
            this.Respinge_btn.Location = new System.Drawing.Point(511, 384);
            this.Respinge_btn.Name = "Respinge_btn";
            this.Respinge_btn.Size = new System.Drawing.Size(121, 31);
            this.Respinge_btn.TabIndex = 2;
            this.Respinge_btn.Text = "RESPINGE Cont";
            this.Respinge_btn.UseVisualStyleBackColor = true;
            this.Respinge_btn.Click += new System.EventHandler(this.Respinge_btn_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(160, 101);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(207, 199);
            this.lstUsers.TabIndex = 3;
            // 
            // lstApplicants
            // 
            this.lstApplicants.FormattingEnabled = true;
            this.lstApplicants.Location = new System.Drawing.Point(426, 101);
            this.lstApplicants.Name = "lstApplicants";
            this.lstApplicants.Size = new System.Drawing.Size(206, 199);
            this.lstApplicants.TabIndex = 4;
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(316, 340);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(172, 20);
            this.txtApplicantName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume User / Aplicant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "USERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "APPLICANTS";
            // 
            // ANULEAZA_btn
            // 
            this.ANULEAZA_btn.Location = new System.Drawing.Point(165, 384);
            this.ANULEAZA_btn.Name = "ANULEAZA_btn";
            this.ANULEAZA_btn.Size = new System.Drawing.Size(109, 31);
            this.ANULEAZA_btn.TabIndex = 9;
            this.ANULEAZA_btn.Text = "ANULEAZA Cont";
            this.ANULEAZA_btn.UseVisualStyleBackColor = true;
            this.ANULEAZA_btn.Click += new System.EventHandler(this.ANULEAZA_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(699, 202);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 10;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(699, 173);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(75, 23);
            this.Return_btn.TabIndex = 11;
            this.Return_btn.Text = "RETURN";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.ANULEAZA_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApplicantName);
            this.Controls.Add(this.lstApplicants);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.Respinge_btn);
            this.Controls.Add(this.Aprobare_btn);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button Aprobare_btn;
        private System.Windows.Forms.Button Respinge_btn;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstApplicants;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ANULEAZA_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Return_btn;
    }
}