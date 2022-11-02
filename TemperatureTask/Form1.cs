using TemperatureTask.Model;

namespace TemperatureTask
{
    public partial class TemperaturesForm : Form
    {
        private readonly ITemperatureConvertable convertTemperature;

        public TemperaturesForm(ITemperatureConvertable converter)
        {
            InitializeComponent();

            convertTemperature = converter;

            inputTemperatureComboBox.SelectedIndex = 0;
            outputTemperatureComboBox.SelectedIndex = 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double temperature = Convert.ToDouble(inputTemperatureTextBox.Text);

                outputTemperatureValueLabel.Text = Task.FromResult(convertTemperature.GetTemperature
                    (temperature, inputTemperatureComboBox.SelectedIndex, outputTemperatureComboBox.SelectedIndex))
                    .Result.ToString("0.00");
            }
            catch (FormatException)
            {
                inputTemperatureTextBox.Text = null;

                MessageBox.Show("Введите числовое значение.");

                return;
            }
        }
    }
}