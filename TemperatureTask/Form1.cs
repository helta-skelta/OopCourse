using TemperatureTask.Model;

namespace TemperatureTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            inputTemperatureValueTextBox.Text = "������� ��������.";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (inputTemperatureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("�������� �� ����� ����� ����� ��������� �����������.");

                return;
            }

            if (outputTemperatureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("�������� � ����� ����� ����� ��������� �����������.");

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

                MessageBox.Show("������� �������� ��������.");

                return;
            }
        }

        private void inputTemperatureValueTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            inputTemperatureValueTextBox.Text = null;
        }
    }
}