using System;
using System.Windows.Forms;


namespace Simple_Table_Permutation
{
    public partial class Authorization : Form
    {
        private Database DB;
        private bool passwordContainsSpace, passwordContainsEnoughChar;

        public Authorization()
        {
            InitializeComponent();
            DB = new Database("Data Source=MyDB.db; Version=3");
            
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;

            if (DB.UsersCount() > 0) 
            {
                buttonAuth.Enabled = true;
            }
            else
            {
                buttonAuth.Enabled = false;
                MessageBox.Show("Ни один пользователь не зарегистрирован!");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
       {
            if (textBoxPassword.TextLength < 8)
            {
                errorProviderPassword.SetError(textBoxPassword, "Пароль должен содержать не менее 8 символов!");
                passwordContainsEnoughChar = false;
            }
            else
            {
                passwordContainsEnoughChar = true;
                errorProviderPassword.Clear();
            }

            for (int i = 0; i < textBoxPassword.TextLength; i++)
            {
                char ch = Convert.ToChar(textBoxPassword.Text.Substring(i, 1));
                if (ch == ' ')
                {
                    errorProviderPassword.SetError(textBoxPassword, "Пароль не должен содержать пробелов!");
                    passwordContainsSpace = true;
                }
                else
                {
                    passwordContainsSpace = false;
                    if (passwordContainsEnoughChar)
                    {
                        errorProviderPassword.Clear();
                    }
                }
            }
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                if (!passwordContainsSpace)
                {
                    if (passwordContainsEnoughChar)
                    {
                        if (new User(null,null, textBoxLogin.Text, User.GetHash(textBoxPassword.Text), null).CheckUser())
                        {
                            User user = DB.GetUserData(textBoxLogin.Text, User.GetHash(textBoxPassword.Text));
                            if (user.username != null)
                            {
                                var tablePermutationForm = new TablePermutation(user);
                                this.Hide();
                                tablePermutationForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при работе с БД!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Логин или пароль введены неверно!");
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
