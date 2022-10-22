namespace TemperatureTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputTemperatureValueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputTemperatureValueTextBox = new System.Windows.Forms.TextBox();
            this.outputTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.inputTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputTemperatureValueLabel
            // 
            this.outputTemperatureValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputTemperatureValueLabel.BackColor = System.Drawing.SystemColors.Window;
            this.outputTemperatureValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputTemperatureValueLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.outputTemperatureValueLabel.Location = new System.Drawing.Point(515, 77);
            this.outputTemperatureValueLabel.Name = "outputTemperatureValueLabel";
            this.outputTemperatureValueLabel.Size = new System.Drawing.Size(126, 22);
            this.outputTemperatureValueLabel.TabIndex = 14;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculateButton.BackColor = System.Drawing.SystemColors.Window;
            this.calculateButton.BackgroundImage = global::TemperatureTask.Properties.Resources.free_icon_forward_6998832;
            this.calculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(323, 80);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // inputTemperatureValueTextBox
            // 
            this.inputTemperatureValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTemperatureValueTextBox.Location = new System.Drawing.Point(97, 80);
            this.inputTemperatureValueTextBox.Name = "inputTemperatureValueTextBox";
            this.inputTemperatureValueTextBox.Size = new System.Drawing.Size(126, 22);
            this.inputTemperatureValueTextBox.TabIndex = 13;
            this.inputTemperatureValueTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputTemperatureValueTextBox_MouseClick);
            // 
            // outputTemperatureComboBox
            // 
            this.outputTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTemperatureComboBox.FormattingEnabled = true;
            this.outputTemperatureComboBox.Items.AddRange(new object[] {
            "Цельсия",
            "Фаренгейта",
            "Кельвина"});
            this.outputTemperatureComboBox.Location = new System.Drawing.Point(468, 27);
            this.outputTemperatureComboBox.Name = "outputTemperatureComboBox";
            this.outputTemperatureComboBox.Size = new System.Drawing.Size(221, 22);
            this.outputTemperatureComboBox.TabIndex = 7;
            this.outputTemperatureComboBox.Text = "Выберите шкалу температуры.";
            // 
            // inputTemperatureComboBox
            // 
            this.inputTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTemperatureComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.inputTemperatureComboBox.FormattingEnabled = true;
            this.inputTemperatureComboBox.Items.AddRange(new object[] {
            "Цельсия",
            "Фаренгейта",
            "Кельвина"});
            this.inputTemperatureComboBox.Location = new System.Drawing.Point(49, 27);
            this.inputTemperatureComboBox.Name = "inputTemperatureComboBox";
            this.inputTemperatureComboBox.Size = new System.Drawing.Size(221, 22);
            this.inputTemperatureComboBox.TabIndex = 6;
            this.inputTemperatureComboBox.Text = "Выберите шкалу температуры.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.10714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.89286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.Controls.Add(this.inputTemperatureComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTemperatureComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputTemperatureValueTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputTemperatureValueLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 154);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(732, 159);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label outputTemperatureValueLabel;
        private Button calculateButton;
        private TextBox inputTemperatureValueTextBox;
        private ComboBox outputTemperatureComboBox;
        private ComboBox inputTemperatureComboBox;
        private TableLayoutPanel tableLayoutPanel1;

        public EventHandler Form1_Load { get; private set; }
    }
}