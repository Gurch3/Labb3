namespace WinFormsLabb3
{
    partial class sortForm
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
            this.components = new System.ComponentModel.Container();
            this.labelListLanguages = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownLanguage = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListLanguages
            // 
            this.labelListLanguages.AutoSize = true;
            this.labelListLanguages.Location = new System.Drawing.Point(77, 47);
            this.labelListLanguages.Name = "labelListLanguages";
            this.labelListLanguages.Size = new System.Drawing.Size(291, 25);
            this.labelListLanguages.TabIndex = 0;
            this.labelListLanguages.Text = "Sort list by one of these languages:";
            // 
            // buttonSort
            // 
            this.buttonSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSort.Location = new System.Drawing.Point(623, 561);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(112, 34);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(763, 561);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownLanguage
            // 
            this.numericUpDownLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownLanguage.Location = new System.Drawing.Point(77, 564);
            this.numericUpDownLanguage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLanguage.Name = "numericUpDownLanguage";
            this.numericUpDownLanguage.Size = new System.Drawing.Size(180, 31);
            this.numericUpDownLanguage.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(624, 389);
            this.textBox1.TabIndex = 4;
            // 
            // sortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDownLanguage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelListLanguages);
            this.Name = "sortForm";
            this.Text = "Sort";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelListLanguages;
        private Button buttonSort;
        private BindingSource bindingSource1;
        private Button buttonCancel;
        private NumericUpDown numericUpDownLanguage;
        private TextBox textBox1;
    }
}