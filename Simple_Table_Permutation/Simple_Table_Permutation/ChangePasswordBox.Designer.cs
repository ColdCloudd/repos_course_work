namespace Simple_Table_Permutation
{
    partial class ChangePasswordBox
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
            this.components = new System.ComponentModel.Container();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPassRep = new System.Windows.Forms.TextBox();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderNewPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNewPassRep = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOldPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPass)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldPass.Location = new System.Drawing.Point(41, 57);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(300, 30);
            this.textBoxOldPass.TabIndex = 0;
            this.textBoxOldPass.TextChanged += new System.EventHandler(this.textBoxOldPass_TextChanged);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPass.Location = new System.Drawing.Point(41, 125);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(300, 30);
            this.textBoxNewPass.TabIndex = 1;
            this.textBoxNewPass.TextChanged += new System.EventHandler(this.textBoxNewPass_TextChanged);
            // 
            // textBoxNewPassRep
            // 
            this.textBoxNewPassRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassRep.Location = new System.Drawing.Point(41, 192);
            this.textBoxNewPassRep.Name = "textBoxNewPassRep";
            this.textBoxNewPassRep.Size = new System.Drawing.Size(300, 30);
            this.textBoxNewPassRep.TabIndex = 2;
            this.textBoxNewPassRep.TextChanged += new System.EventHandler(this.textBoxNewPassRep_TextChanged);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePass.Location = new System.Drawing.Point(91, 245);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(194, 34);
            this.buttonChangePass.TabIndex = 3;
            this.buttonChangePass.Text = "Изменить пароль";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущий пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторить пароль";
            // 
            // errorProviderNewPass
            // 
            this.errorProviderNewPass.ContainerControl = this;
            // 
            // errorProviderNewPassRep
            // 
            this.errorProviderNewPassRep.ContainerControl = this;
            // 
            // errorProviderOldPass
            // 
            this.errorProviderOldPass.ContainerControl = this;
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHidePass.Location = new System.Drawing.Point(368, 131);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.Size = new System.Drawing.Size(126, 54);
            this.checkBoxHidePass.TabIndex = 7;
            this.checkBoxHidePass.Text = "Показать\r\nпароль";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.checkBoxHidePass_CheckedChanged);
            // 
            // ChangePasswordBox
            // 
            this.AcceptButton = this.buttonChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 309);
            this.Controls.Add(this.checkBoxHidePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.textBoxNewPassRep);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxOldPass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена пароля";
            this.Load += new System.EventHandler(this.ChangePasswordBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxNewPassRep;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderNewPass;
        private System.Windows.Forms.ErrorProvider errorProviderNewPassRep;
        private System.Windows.Forms.ErrorProvider errorProviderOldPass;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
    }
}