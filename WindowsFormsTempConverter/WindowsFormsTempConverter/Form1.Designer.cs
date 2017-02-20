namespace WindowsFormsTempConverter
{
    partial class Form1
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
            this.convertButton = new System.Windows.Forms.Button();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.convertedTempLabel = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(849, 119);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 36);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(245, 119);
            this.fromComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(226, 33);
            this.fromComboBox.TabIndex = 2;
            this.fromComboBox.Text = "From";
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(85, 122);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(130, 31);
            this.tempTextBox.TabIndex = 4;
            this.tempTextBox.Text = "Temperature";
            this.tempTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertedTempLabel
            // 
            this.convertedTempLabel.AutoSize = true;
            this.convertedTempLabel.Location = new System.Drawing.Point(735, 122);
            this.convertedTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertedTempLabel.Name = "convertedTempLabel";
            this.convertedTempLabel.Size = new System.Drawing.Size(0, 25);
            this.convertedTempLabel.TabIndex = 1;
            this.convertedTempLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celcius"});
            this.toComboBox.Location = new System.Drawing.Point(479, 120);
            this.toComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(226, 33);
            this.toComboBox.TabIndex = 5;
            this.toComboBox.Text = "To";
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 285);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.convertedTempLabel);
            this.Controls.Add(this.convertButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.Label convertedTempLabel;
        private System.Windows.Forms.ComboBox toComboBox;
    }
}

