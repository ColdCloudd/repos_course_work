namespace Simple_Table_Permutation
{
    partial class TablePermutation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablePermutation));
            this.buttonEncryptMsg = new System.Windows.Forms.Button();
            this.textBoxMsgInput = new System.Windows.Forms.TextBox();
            this.textBoxMsgOutput = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDecryptMsg = new System.Windows.Forms.Button();
            this.errorProviderKey = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInputMsg = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.buttonSaveInDB = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonLoadFromDB = new System.Windows.Forms.Button();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputMsg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncryptMsg
            // 
            resources.ApplyResources(this.buttonEncryptMsg, "buttonEncryptMsg");
            this.buttonEncryptMsg.Name = "buttonEncryptMsg";
            this.buttonEncryptMsg.UseVisualStyleBackColor = true;
            this.buttonEncryptMsg.Click += new System.EventHandler(this.buttonEncryptMsg_Click);
            // 
            // textBoxMsgInput
            // 
            resources.ApplyResources(this.textBoxMsgInput, "textBoxMsgInput");
            this.textBoxMsgInput.Name = "textBoxMsgInput";
            this.textBoxMsgInput.TextChanged += new System.EventHandler(this.textBoxMsgInput_TextChanged);
            // 
            // textBoxMsgOutput
            // 
            resources.ApplyResources(this.textBoxMsgOutput, "textBoxMsgOutput");
            this.textBoxMsgOutput.Name = "textBoxMsgOutput";
            this.textBoxMsgOutput.ReadOnly = true;
            // 
            // textBoxKey
            // 
            resources.ApplyResources(this.textBoxKey, "textBoxKey");
            this.textBoxKey.Name = "textBoxKey";
     
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // buttonDecryptMsg
            // 
            resources.ApplyResources(this.buttonDecryptMsg, "buttonDecryptMsg");
            this.buttonDecryptMsg.Name = "buttonDecryptMsg";
            this.buttonDecryptMsg.UseVisualStyleBackColor = true;
            this.buttonDecryptMsg.Click += new System.EventHandler(this.buttonDecryptMsg_Click);
            // 
            // errorProviderKey
            // 
            this.errorProviderKey.ContainerControl = this;
            // 
            // errorProviderInputMsg
            // 
            this.errorProviderInputMsg.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderInputMsg.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.личныйКабинетToolStripMenuItem,
            this.AboutProgramToolStripMenuItem,
            this.справкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            resources.ApplyResources(this.личныйКабинетToolStripMenuItem, "личныйКабинетToolStripMenuItem");
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            resources.ApplyResources(this.AboutProgramToolStripMenuItem, "AboutProgramToolStripMenuItem");
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonSaveInFile
            // 
            resources.ApplyResources(this.buttonSaveInFile, "buttonSaveInFile");
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.UseVisualStyleBackColor = true;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // buttonSaveInDB
            // 
            resources.ApplyResources(this.buttonSaveInDB, "buttonSaveInDB");
            this.buttonSaveInDB.Name = "buttonSaveInDB";
            this.buttonSaveInDB.UseVisualStyleBackColor = true;
            this.buttonSaveInDB.Click += new System.EventHandler(this.buttonSaveInDB_Click);
            // 
            // buttonLoadFromFile
            // 
            resources.ApplyResources(this.buttonLoadFromFile, "buttonLoadFromFile");
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonLoadFromDB
            // 
            resources.ApplyResources(this.buttonLoadFromDB, "buttonLoadFromDB");
            this.buttonLoadFromDB.Name = "buttonLoadFromDB";
            this.buttonLoadFromDB.UseVisualStyleBackColor = true;
            this.buttonLoadFromDB.Click += new System.EventHandler(this.buttonLoadFromDB_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // TablePermutation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.buttonLoadFromDB);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSaveInDB);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.buttonDecryptMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxMsgOutput);
            this.Controls.Add(this.textBoxMsgInput);
            this.Controls.Add(this.buttonEncryptMsg);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TablePermutation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TablePermutation_FormClosed);
            this.Load += new System.EventHandler(this.TablePermutation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInputMsg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncryptMsg;
        private System.Windows.Forms.TextBox textBoxMsgInput;
        private System.Windows.Forms.TextBox textBoxMsgOutput;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDecryptMsg;
        private System.Windows.Forms.ErrorProvider errorProviderKey;
        private System.Windows.Forms.ErrorProvider errorProviderInputMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveInFile;
        private System.Windows.Forms.Button buttonSaveInDB;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonLoadFromDB;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

