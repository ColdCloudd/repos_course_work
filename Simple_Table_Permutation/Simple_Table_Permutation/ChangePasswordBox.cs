using System;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class ChangePasswordBox : Form
    {
        private Database DB;
        private User user;
        private bool passwordContainsSpace, passwordContainsEnoughChar;
        public ChangePasswordBox(ref User user)
        {
            InitializeComponent();
            DB = new Database("Data Source=MyDB.db; Version=3");
            this.user = user;
        }

        private void ChangePasswordBox_Load(object sender, EventArgs e)
        {
            textBoxNewPass.UseSystemPasswordChar = true;
            textBoxNewPassRep.UseSystemPasswordChar = true;
            passwordContainsSpace = false;
            passwordContainsEnoughChar = false;
        }

        private void textBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPass.TextLength < 8)
            {
                errorProviderNewPass.SetError(textBoxNewPass, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderNewPass.Clear();
            }

            for (int i = 0; i < textBoxNewPass.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxNewPass.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderNewPass.SetError(textBoxNewPass, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderNewPass.Clear();
                    }
                }
            }
        }

        private void textBoxNewPassRep_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassRep.TextLength < 8)
            {
                errorProviderNewPassRep.SetError(textBoxNewPassRep, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderNewPassRep.Clear();
            }

            for (int i = 0; i < textBoxNewPassRep.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxNewPassRep.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderNewPassRep.SetError(textBoxNewPassRep, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderNewPassRep.Clear();
                    }
                }
            }
        }

        private void textBoxOldPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOldPass.TextLength < 8)
            {
                errorProviderOldPass.SetError(textBoxOldPass, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderOldPass.Clear();
            }

            for (int i = 0; i < textBoxOldPass.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxOldPass.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderOldPass.SetError(textBoxOldPass, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderOldPass.Clear();
                    }
                }
            }
        }

        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHidePass.Checked)
            {
                textBoxNewPass.UseSystemPasswordChar = true;
                textBoxNewPassRep.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxNewPass.UseSystemPasswordChar = false;
                textBoxNewPassRep.UseSystemPasswordChar = false;
            }
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text.Trim() != "" && textBoxNewPassRep.Text.Trim() != "" && textBoxOldPass.Text.Trim() != "")
            {
                if (!passwordContainsSpace)
                {
                    if (passwordContainsEnoughChar)
                    {
                        if (textBoxNewPass.Text == textBoxNewPassRep.Text)
                        {
                            if (user.password == User.GetHash(textBoxOldPass.Text)) //////
                            {
                                string passwordHash = User.GetHash(textBoxNewPass.Text);
                                if (DB.UpdateUserPassword(user.login, passwordHash))
                                {
                                    user.password = passwordHash;
                                    MessageBox.Show("Пароль успешно изменен!");
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Изменить пароль не удалось!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверно введен старый пароль!");
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
    }
}
