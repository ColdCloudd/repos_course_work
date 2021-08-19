using System;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class TablePermutation : Form
    {
        private string inputText = "";
        private User user;

        public TablePermutation(User user)
        {
            InitializeComponent();
            if (user != null)
            {
                this.user = user;
            }
            else
            {
                MessageBox.Show("Ошибка при получении данных пользователя!");
                this.Close();
            }
        }

        private void TablePermutation_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать " + user.username + "!");

            textBoxMsgInput.TextChanged += textBoxMsgInput_TextChanged;

            ToolTip toolTipInputMsg = new ToolTip();
            toolTipInputMsg.SetToolTip(textBoxMsgInput, "Поле ввода текста, который необходимо зашифровать или расшифровать");

            ToolTip toolTipOutputMsg = new ToolTip();
            toolTipOutputMsg.SetToolTip(textBoxMsgOutput, "Поле вывода зашифрованного или расшифрованного текста");

            ToolTip toolTipKey = new ToolTip();
            toolTipKey.SetToolTip(textBoxKey, "Поле ввода/вывода ключа в формате: Х-Х");

        }

        private void textBoxMsgInput_TextChanged(object sender, EventArgs e)
        {
            inputText = textBoxMsgInput.Text;
            textBoxKey.Clear();
            textBoxMsgOutput.Clear();
        }

        private void buttonEncryptMsg_Click(object sender, EventArgs e)
        {
            if (inputText.Length > 10)
            {
                var pair = Table_Permutation.TextEncryption(inputText);
                textBoxMsgOutput.Text = pair.Text;
                textBoxKey.Text = pair.Key;
            }
            else
            {
                errorProviderInputMsg.SetError(textBoxMsgInput, "Введено меньше 10 символов!");
            }
        }

        private void buttonDecryptMsg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                errorProviderKey.SetError(textBoxKey, "Введите ключ!");
            }
            else
            {
                textBoxMsgOutput.Text = Table_Permutation.TextDecryption(inputText, textBoxKey.Text);       // передача зашифрованного текста и 

            }

        }

        private void TablePermutation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            aboutBox.ShowDialog();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalAccountBox personalAccountBox = new PersonalAccountBox(user);
            personalAccountBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            personalAccountBox.ShowDialog();
        }
    }
}
