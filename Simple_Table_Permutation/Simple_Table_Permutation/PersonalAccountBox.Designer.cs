namespace Simple_Table_Permutation
{
    partial class PersonalAccountBox
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.linkLabelChangePass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Роль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Личный идентификатор(id):";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsername.Location = new System.Drawing.Point(328, 38);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 25);
            this.labelUsername.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLogin.Location = new System.Drawing.Point(328, 74);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 25);
            this.labelLogin.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRole.Location = new System.Drawing.Point(328, 110);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 25);
            this.labelRole.TabIndex = 6;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelId.Location = new System.Drawing.Point(328, 146);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 25);
            this.labelId.TabIndex = 7;
            // 
            // linkLabelChangePass
            // 
            this.linkLabelChangePass.AutoSize = true;
            this.linkLabelChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabelChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelChangePass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelChangePass.Location = new System.Drawing.Point(32, 179);
            this.linkLabelChangePass.Name = "linkLabelChangePass";
            this.linkLabelChangePass.Size = new System.Drawing.Size(179, 25);
            this.linkLabelChangePass.TabIndex = 8;
            this.linkLabelChangePass.TabStop = true;
            this.linkLabelChangePass.Text = "Изменить пароль";
            this.linkLabelChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePass_LinkClicked);
            // 
            // PersonalAccountBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.linkLabelChangePass);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalAccountBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.PersonalAccountBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.LinkLabel linkLabelChangePass;
    }
}