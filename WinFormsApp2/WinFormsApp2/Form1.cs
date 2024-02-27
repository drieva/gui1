using System;
using System.Windows.Forms;

namespace MoveEstimatorGUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateEstimateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double hours = double.Parse(hoursTextBox.Text);
                double miles = double.Parse(milesTextBox.Text);
                double totalFee = CalculateTotalFee(hours, miles);
                resultLabel.Text = $"For a move taking {hours} hours and going {miles} miles the estimate is ${totalFee:F2}";
            }
            catch (FormatException)
            {
                resultLabel.Text = "Please enter valid numbers for hours and miles.";
            }
        }

        private double CalculateTotalFee(double hours, double miles)
        {
            return 200 + 150 * hours + 2 * miles;
        }
    }
}
