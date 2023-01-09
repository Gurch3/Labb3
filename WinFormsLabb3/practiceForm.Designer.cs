namespace WinFormsLabb3
{
    partial class practiceForm
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
            this.labelTranslate = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Location = new System.Drawing.Point(71, 57);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(89, 25);
            this.labelTranslate.TabIndex = 0;
            this.labelTranslate.Text = "Translate: ";
            this.labelTranslate.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(71, 103);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(150, 31);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(408, 197);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(112, 34);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(554, 197);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelGuesses
            // 
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.Location = new System.Drawing.Point(71, 197);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(0, 25);
            this.labelGuesses.TabIndex = 4;
            // 
            // practiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 256);
            this.Controls.Add(this.labelGuesses);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelTranslate);
            this.Name = "practiceForm";
            this.Text = "practiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTranslate;
        private TextBox textBoxAnswer;
        private Button buttonSubmit;
        private Button buttonCancel;
        private Label labelGuesses;
    }
}