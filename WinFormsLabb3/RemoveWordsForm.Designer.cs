namespace WinFormsLabb3
{
    partial class RemoveWordsForm
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
            this.numericupdownLanguage = new System.Windows.Forms.NumericUpDown();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelListLanguages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // numericupdownLanguage
            // 
            this.numericupdownLanguage.Location = new System.Drawing.Point(86, 126);
            this.numericupdownLanguage.Name = "numericupdownLanguage";
            this.numericupdownLanguage.Size = new System.Drawing.Size(180, 31);
            this.numericupdownLanguage.TabIndex = 0;
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(353, 126);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(375, 31);
            this.textBoxWord.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(458, 364);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 34);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(616, 364);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelListLanguages
            // 
            this.labelListLanguages.AutoSize = true;
            this.labelListLanguages.Location = new System.Drawing.Point(86, 61);
            this.labelListLanguages.Name = "labelListLanguages";
            this.labelListLanguages.Size = new System.Drawing.Size(205, 25);
            this.labelListLanguages.TabIndex = 4;
            this.labelListLanguages.Text = "Remove words from list:";
            // 
            // RemoveWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelListLanguages);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.numericupdownLanguage);
            this.Name = "RemoveWordsForm";
            this.Text = "RemoveWordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericupdownLanguage;
        private TextBox textBoxWord;
        private Button buttonRemove;
        private Button buttonCancel;
        private Label labelListLanguages;
    }
}