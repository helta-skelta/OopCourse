using TemperatureTask.Model;

namespace TemperatureTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            inputTemperatureValueTextBox.Text = "Введите значение.";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (inputTemperatureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите из какой шкалы нужно перевести температуру.");

                return;
            }

            if (outputTemperatureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите в какую шкалу нужно перевести температуру.");

                return;
            }

            try
            {
                double temperature = Convert.ToDouble(inputTemperatureValueTextBox.Text);

                Func<double, double> convertType = Converter.GetConvertType(inputTemperatureComboBox.SelectedIndex, outputTemperatureComboBox.SelectedIndex);

                outputTemperatureValueLabel.Text = convertType(temperature).ToString("0.00");
            }
            catch (FormatException)
            {
                inputTemperatureValueTextBox.Text = null;

                MessageBox.Show("Введите числовое значение.");

                return;
            }
        }

        private void inputTemperatureValueTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            inputTemperatureValueTextBox.Text = null;
        }
    }
}