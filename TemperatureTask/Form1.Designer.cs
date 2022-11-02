namespace TemperatureTask
{
    partial class TemperaturesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperaturesForm));
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputTemperatureValueLabel = new System.Windows.Forms.Label();
            this.inputTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.outputTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.inputTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculateButton.BackColor = System.Drawing.SystemColors.Window;
            this.calculateButton.BackgroundImage = global::TemperatureTask.Properties.Resources.free_icon_forward_6998832;
            this.calculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(313, 82);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // outputTemperatureValueLabel
            // 
            this.outputTemperatureValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputTemperatureValueLabel.BackColor = System.Drawing.SystemColors.Window;
            this.outputTemperatureValueLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.outputTemperatureValueLabel.Location = new System.Drawing.Point(529, 79);
            this.outputTemperatureValueLabel.Name = "outputTemperatureValueLabel";
            this.outputTemperatureValueLabel.Size = new System.Drawing.Size(160, 22);
            this.outputTemperatureValueLabel.TabIndex = 14;
            // 
            // inputTemperatureTextBox
            // 
            this.inputTemperatureTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTemperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTemperatureTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.inputTemperatureTextBox.Location = new System.Drawing.Point(41, 79);
            this.inputTemperatureTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.inputTemperatureTextBox.Name = "inputTemperatureTextBox";
            this.inputTemperatureTextBox.PlaceholderText = "Введите значение";
            this.inputTemperatureTextBox.Size = new System.Drawing.Size(160, 20);
            this.inputTemperatureTextBox.TabIndex = 13;
            // 
            // outputTemperatureComboBox
            // 
            this.outputTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTemperatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTemperatureComboBox.FormattingEnabled = true;
            this.outputTemperatureComboBox.Items.AddRange(new object[] {
            "Цельсия",
            "Фаренгейта",
            "Кельвина"});
            this.outputTemperatureComboBox.Location = new System.Drawing.Point(499, 28);
            this.outputTemperatureComboBox.Name = "outputTemperatureComboBox";
            this.outputTemperatureComboBox.Size = new System.Drawing.Size(221, 22);
            this.outputTemperatureComboBox.TabIndex = 7;
            // 
            // inputTemperatureComboBox
            // 
            this.inputTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTemperatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputTemperatureComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.inputTemperatureComboBox.FormattingEnabled = true;
            this.inputTemperatureComboBox.Items.AddRange(new object[] {
            "Цельсия",
            "Фаренгейта",
            "Кельвина"});
            this.inputTemperatureComboBox.Location = new System.Drawing.Point(11, 28);
            this.inputTemperatureComboBox.Name = "inputTemperatureComboBox";
            this.inputTemperatureComboBox.Size = new System.Drawing.Size(221, 22);
            this.inputTemperatureComboBox.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.inputTemperatureComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTemperatureComboBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputTemperatureTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputTemperatureValueLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 159);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // TemperaturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(732, 159);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "TemperaturesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Температуры";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculateButton;
        private Label outputTemperatureValueLabel;
        private TextBox inputTemperatureTextBox;
        private ComboBox outputTemperatureComboBox;
        private ComboBox inputTemperatureComboBox;
        private TableLayoutPanel tableLayoutPanel1;

        public EventHandler Form1_Load { get; private set; }
    }
}