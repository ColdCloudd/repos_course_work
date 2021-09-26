namespace Simple_Table_Permutation
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxPassRep = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordRepeat = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonCancelRegistration = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.checkBoxHidePass = new System.Windows.Forms.CheckBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.errorProviderPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassRep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassRep)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.Location = new System.Drawing.Point(55, 43);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(398, 30);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(55, 166);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(398, 30);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(55, 227);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(398, 30);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxPassRep
            // 
            this.textBoxPassRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassRep.Location = new System.Drawing.Point(55, 290);
            this.textBoxPassRep.Name = "textBoxPassRep";
            this.textBoxPassRep.Size = new System.Drawing.Size(398, 30);
            this.textBoxPassRep.TabIndex = 3;
            this.textBoxPassRep.TextChanged += new System.EventHandler(this.textBoxPassRep_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(55, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(191, 25);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Имя пользователя";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(55, 140);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 25);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(55, 199);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 25);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordRepeat.Location = new System.Drawing.Point(55, 262);
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(152, 25);
            this.labelPasswordRepeat.TabIndex = 8;
            this.labelPasswordRepeat.Text = "Повтор пароля";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(55, 339);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(214, 34);
            this.buttonRegistration.TabIndex = 9;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonCancelRegistration
            // 
            this.buttonCancelRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelRegistration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelRegistration.Location = new System.Drawing.Point(298, 339);
            this.buttonCancelRegistration.Name = "buttonCancelRegistration";
            this.buttonCancelRegistration.Size = new System.Drawing.Size(155, 34);
            this.buttonCancelRegistration.TabIndex = 10;
            this.buttonCancelRegistration.Text = "Отмена";
            this.buttonCancelRegistration.UseVisualStyleBackColor = true;
            this.buttonCancelRegistration.Click += new System.EventHandler(this.buttonCancelRegistration_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(55, 76);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(57, 25);
            this.labelRole.TabIndex = 12;
            this.labelRole.Text = "Роль";
            // 
            // checkBoxHidePass
            // 
            this.checkBoxHidePass.AutoSize = true;
            this.checkBoxHidePass.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxHidePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHidePass.Location = new System.Drawing.Point(479, 225);
            this.checkBoxHidePass.Name = "checkBoxHidePass";
            this.checkBoxHidePass.Size = new System.Drawing.Size(126, 54);
            this.checkBoxHidePass.TabIndex = 13;
            this.checkBoxHidePass.Text = "Показать\r\nпароль";
            this.checkBoxHidePass.UseVisualStyleBackColor = true;
            this.checkBoxHidePass.CheckedChanged += new System.EventHandler(this.checkBoxHidePass_CheckedChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(55, 104);
            this.comboBoxRole.MaxDropDownItems = 2;
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(214, 33);
            this.comboBoxRole.TabIndex = 14;
            // 
            // errorProviderPass
            // 
            this.errorProviderPass.ContainerControl = this;
            // 
            // errorProviderPassRep
            // 
            this.errorProviderPassRep.ContainerControl = this;
            // 
            // Registration
            // 
            this.AcceptButton = this.buttonRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.buttonCancelRegistration;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.checkBoxHidePass);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.buttonCancelRegistration);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassRep);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxPassRep;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordRepeat;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonCancelRegistration;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.CheckBox checkBoxHidePass;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ErrorProvider errorProviderPass;
        private System.Windows.Forms.ErrorProvider errorProviderPassRep;
    }
}