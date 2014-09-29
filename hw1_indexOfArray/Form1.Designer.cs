namespace hw1_indexOfArray
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
            this.AddNameGroupBox = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.AddHereLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addCountCounterLabel = new System.Windows.Forms.Label();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showNameListBox = new System.Windows.Forms.ListBox();
            this.AddNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNameGroupBox
            // 
            this.AddNameGroupBox.Controls.Add(this.setButton);
            this.AddNameGroupBox.Controls.Add(this.employeeNumberTextBox);
            this.AddNameGroupBox.Controls.Add(this.employeeNumberLabel);
            this.AddNameGroupBox.Controls.Add(this.resetButton);
            this.AddNameGroupBox.Controls.Add(this.AddHereLabel);
            this.AddNameGroupBox.Controls.Add(this.addButton);
            this.AddNameGroupBox.Controls.Add(this.nameTextBox);
            this.AddNameGroupBox.Controls.Add(this.addCountCounterLabel);
            this.AddNameGroupBox.Controls.Add(this.addCountLabel);
            this.AddNameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddNameGroupBox.Name = "AddNameGroupBox";
            this.AddNameGroupBox.Size = new System.Drawing.Size(349, 150);
            this.AddNameGroupBox.TabIndex = 0;
            this.AddNameGroupBox.TabStop = false;
            this.AddNameGroupBox.Text = "Add Name";
            this.AddNameGroupBox.Enter += new System.EventHandler(this.AddNameGroupBox_Enter);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(219, 22);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 8;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(140, 22);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(67, 20);
            this.employeeNumberTextBox.TabIndex = 7;
            this.employeeNumberTextBox.TextChanged += new System.EventHandler(this.employeeNumberTextBox_TextChanged);
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Location = new System.Drawing.Point(18, 25);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(113, 13);
            this.employeeNumberLabel.TabIndex = 6;
            this.employeeNumberLabel.Text = "Number Of Employee :";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(219, 81);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddHereLabel
            // 
            this.AddHereLabel.AutoSize = true;
            this.AddHereLabel.Location = new System.Drawing.Point(18, 58);
            this.AddHereLabel.Name = "AddHereLabel";
            this.AddHereLabel.Size = new System.Drawing.Size(41, 13);
            this.AddHereLabel.TabIndex = 4;
            this.AddHereLabel.Text = "Name :";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(109, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(226, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addCountCounterLabel
            // 
            this.addCountCounterLabel.AutoSize = true;
            this.addCountCounterLabel.Location = new System.Drawing.Point(227, 130);
            this.addCountCounterLabel.Name = "addCountCounterLabel";
            this.addCountCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.addCountCounterLabel.TabIndex = 1;
            this.addCountCounterLabel.Text = "0";
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(80, 130);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(57, 13);
            this.addCountLabel.TabIndex = 0;
            this.addCountLabel.Text = "Add Count";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(286, 184);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 1;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // showNameListBox
            // 
            this.showNameListBox.FormattingEnabled = true;
            this.showNameListBox.Location = new System.Drawing.Point(12, 213);
            this.showNameListBox.Name = "showNameListBox";
            this.showNameListBox.Size = new System.Drawing.Size(349, 95);
            this.showNameListBox.TabIndex = 2;
            this.showNameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 321);
            this.Controls.Add(this.showNameListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.AddNameGroupBox);
            this.Name = "Form1";
            this.Text = "NameApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddNameGroupBox.ResumeLayout(false);
            this.AddNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddNameGroupBox;
        private System.Windows.Forms.Label AddHereLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addCountCounterLabel;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox showNameListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Button setButton;
    }
}

