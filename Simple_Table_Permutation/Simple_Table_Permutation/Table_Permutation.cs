using System;
namespace Simple_Table_Permutation
{
    public class MyPair
    {
        public string Text { get; set; }
        public string Key { get; set; }

        public MyPair(string text, string key)
        {
            Text = text;
            Key = key;
        }

        public override bool Equals(object obj)      // переопределенный метод, вызываемый NUnit
        {
            if (obj == null)
                return false;

            MyPair myPair = obj as MyPair;
            if (myPair == null)
                return false;

            return myPair.Key == this.Key && myPair.Text == this.Text;
        }
    }
    public class Table_Permutation
    {
        public static MyPair TextEncryption(string inputText)
        {
            int x;
            int mult = inputText.Length;
            Random rnd = new Random();
            if (mult < 50)
                x = rnd.Next((int)(0.25 * mult), (int)(0.5 * mult));
            else
                x = rnd.Next((int)(0.01 * mult), (int)(0.15 * mult));
            int newRow = mult / x;
            int newCol = mult / newRow;
            _ = newRow >= newCol ? newRow++ : newCol++;

            char[,] strArray = new char[newRow, newCol];
            int k = 0;
            for (int i = 0; i < newRow; i++)
            {
                for (int j = 0; j < newCol; j++)
                {
                    if (inputText.Length > k)
                    {
                        strArray[i, j] = inputText[k];
                    }
                    else
                        strArray[i, j] = ' ';
                    k++;
                }
            }

            string[] strOutputArr = new string[newRow * newCol];
            int l = 0;
            for (int i = newCol - 1; i >= 0; i--)
            {
                for (int j = 0; j < newRow; j++)
                {
                    strOutputArr[l] = strArray[j, i].ToString();
                    l++;
                }
            }
            string outputText = string.Join("", strOutputArr);
            string key = newRow.ToString() + "-" + newCol.ToString();
            return new MyPair(outputText, key);
        }

        public static string TextDecryption(string inputText, string key)
        {
            try
            {
                int row = int.Parse(key.Substring(0, key.IndexOf('-')));
                int column = int.Parse(key.Substring(key.IndexOf('-') + 1));
                if (row * column > inputText.Length)
                    return string.Empty;

                int k = 0;
                char[,] strArray = new char[row, column];
                for (int i = 0; i < column; i++)
                {
                    for (int j = row - 1; j >= 0; j--)
                    {
                        strArray[j, i] = (char)inputText[k];
                        k++;
                    }
                }

                string[] strOutputArr = new string[row * column];
                int l = 0;
                for (int i = row - 1; i >= 0; i--)
                {
                    for (int j = column - 1; j >= 0; j--)
                    {
                        strOutputArr[l] = strArray[i, j].ToString();
                        l++;
                    }
                }

                string outputText = string.Join("", strOutputArr).Trim();
                return outputText;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
