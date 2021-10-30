using System;
using System.Windows.Forms;

namespace Simple_Table_Permutation
{
    public partial class TablePermutation : Form
    {
        private string inputText = "";
        private User user;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        public TablePermutation( User user)
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
            this.Width = 940;
            this.Height = 700;
            MessageBox.Show(this, "Добро пожаловать " + user.username + "!");

            textBoxMsgInput.TextChanged += textBoxMsgInput_TextChanged;

            ToolTip toolTipInputMsg = new ToolTip();
            toolTipInputMsg.SetToolTip(textBoxMsgInput, "Поле ввода текста, который необходимо зашифровать или расшифровать");

            ToolTip toolTipOutputMsg = new ToolTip();
            toolTipOutputMsg.SetToolTip(textBoxMsgOutput, "Поле вывода зашифрованного или расшифрованного текста");

            ToolTip toolTipKey = new ToolTip();
            toolTipKey.SetToolTip(textBoxKey, "Поле ввода/вывода ключа в формате: Х-Х");

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }

        private void textBoxMsgInput_TextChanged(object sender, EventArgs e)
        {
            inputText = textBoxMsgInput.Text;
            textBoxKey.Clear();
            textBoxMsgOutput.Clear();
        }

        private void buttonEncryptMsg_Click(object sender, EventArgs e)
        {
            errorProviderKey.Clear();
            if (inputText.Length > 10)
            {
                var pair = Table_Permutation.TextEncryption(inputText);
                textBoxMsgOutput.Text = pair.Text;
                textBoxKey.Text = pair.Key;
            }
            else
                errorProviderInputMsg.SetError(textBoxMsgInput, "Введено меньше 10 символов!");
        }

        private void buttonDecryptMsg_Click(object sender, EventArgs e)
        {
            errorProviderKey.Clear();
            if (string.IsNullOrEmpty(textBoxKey.Text))
                errorProviderKey.SetError(textBoxKey, "Введите ключ!");
            else
            {
                string decryptedText = Table_Permutation.TextDecryption(inputText, textBoxKey.Text);
                if (string.IsNullOrEmpty(decryptedText))
                    errorProviderKey.SetError(textBoxKey, "Ключ введен неверно!");
                else
                    textBoxMsgOutput.Text = decryptedText;
            }

        }

        private void TablePermutation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            aboutBox.ShowDialog();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalAccountBox personalAccountBox = new PersonalAccountBox(ref user);
            personalAccountBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            personalAccountBox.ShowDialog();
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            if (textBoxMsgOutput.Text.Length > 10)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filename, textBoxMsgOutput.Text);
                MessageBox.Show("Файл сохранен.");
            }
            else
                MessageBox.Show("Необходимо ввести текст!");

        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            if (fileText != string.Empty)
            {
                textBoxMsgInput.Text = fileText;
                MessageBox.Show("Файл открыт.");
            }
            else
                MessageBox.Show("Ошибка чтения файла: файл пуст!");
        }

        private void buttonSaveInDB_Click(object sender, EventArgs e)
        {
            if (textBoxMsgOutput.Text.Length < 10)
                MessageBox.Show("Необходимо ввести текст!");
            else if (user.SaveData(textBoxMsgOutput.Text))
                MessageBox.Show("Текст успешно сохранен.");
            else
                MessageBox.Show("Ошибка: не удалось сохранить текст!");
        }

        private void buttonLoadFromDB_Click(object sender, EventArgs e)
        {
            string _data = user.ReadData();
            if (_data != string.Empty)
                textBoxMsgInput.Text = _data;
            else
                MessageBox.Show("Ошибка чтения данных: данные отсутствуют!");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            helpBox.ShowDialog();
        }

    }

}
