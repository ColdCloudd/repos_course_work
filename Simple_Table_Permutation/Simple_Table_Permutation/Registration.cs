using System;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class Registration : Form
    {
        private Database DB;
        private bool passwordContainsSpace, passwordContainsEnoughChar;
        
        public Registration()
        {
            InitializeComponent();
            DB = new Database("Data Source=MyDB.db; Version=3");
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPassRep.UseSystemPasswordChar = true;
            passwordContainsSpace = false;
            passwordContainsEnoughChar = false;

            comboBoxRole.Items.Add("Студент");
            comboBoxRole.Items.Add("Преподаватель");
            comboBoxRole.SelectedIndex = 0;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass.TextLength < 8)
            {
                errorProviderPass.SetError(textBoxPass, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderPass.Clear();
            }

            for (int i = 0; i < textBoxPass.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxPass.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderPass.SetError(textBoxPass, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderPass.Clear();
                    }
                }
            }
        }

        private void textBoxPassRep_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassRep.TextLength < 8)
            {
                errorProviderPassRep.SetError(textBoxPassRep, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderPassRep.Clear();
            }

            for (int i = 0; i < textBoxPassRep.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxPassRep.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderPassRep.SetError(textBoxPassRep, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderPassRep.Clear();
                    }
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() != "" && textBoxLogin.Text.Trim() != "" && textBoxPass.Text.Trim() != "" && textBoxPassRep.Text.Trim() != "" && comboBoxRole.Text.Trim() != "")
            {
                if (!passwordContainsSpace)
                {
                    if (passwordContainsEnoughChar)
                    {
                        if (textBoxPass.Text == textBoxPassRep.Text)
                        {
                            if (!DB.GetLoginState(textBoxLogin.Text))
                            {
                                MessageBox.Show("Пользователь с таким логином уже существует!");
                            }
                            else if (DB.AddUser(textBoxUsername.Text, textBoxLogin.Text, User.GetHash(textBoxPass.Text), comboBoxRole.SelectedItem.ToString()))
                            {
                                MessageBox.Show("Пользователь успешно добавлен!");
                                Authorization authorizationForm = new Authorization();
                                authorizationForm.FormClosed += formClosed;
                                this.Hide();
                                authorizationForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Добавить пользователя не удалось!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введенные вами пароли не совпадают!");        
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен содержать не менее 8 символов!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не должен содержать пробелов!");
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
        }

        private void buttonCancelRegistration_Click(object sender, EventArgs e)
        {

            Authorization authorizationForm = new Authorization();
            authorizationForm.FormClosed += formClosed;
            this.Hide();
            authorizationForm.Show();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHidePass.Checked)
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPassRep.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPassRep.UseSystemPasswordChar = false;
            }
        }

    }
}
