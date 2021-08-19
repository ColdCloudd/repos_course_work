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
            int row = 0, column = 0;

            while (true)
            {
                if (inputText.Length > row * column)
                {
                    row++;
                }
                else
                    break;

                if (inputText.Length > row * column)
                {
                    column++;
                }
                else
                    break;
            }

            char[,] strArray = new char[row, column];
            int k = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
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

            string[] strOutputArr = new string[row * column];
            int l = 0;
            for (int i = column - 1; i >= 0; i--)
            {
                for (int j = 0; j < row; j++)
                {
                    strOutputArr[l] = strArray[j, i].ToString();
                    l++;
                }
            }
            string outputText = string.Join("", strOutputArr);
            string key = row.ToString() + "-" + column.ToString();
            MyPair pair = new MyPair(outputText, key);
            return pair;
        }

        public static string TextDecryption(string inputText, string key)
        {
            int row = int.Parse(key.Substring(0, key.IndexOf('-')));
            int column = int.Parse(key.Substring(key.IndexOf('-') + 1));
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
    }
}
