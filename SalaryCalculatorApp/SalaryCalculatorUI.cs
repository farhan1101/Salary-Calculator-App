using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        SalaryCalculator salaryCalc = new SalaryCalculator();
        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {

            string name = employeeNameTextBox.Text;

            double amount = Convert.ToDouble(basicAmountTextBox.Text);
            double houseRent = Convert.ToDouble(houseRentTextBox.Text);
            double medAllow = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double salary = salaryCalc.GetSalary(amount, houseRent, medAllow);

            MessageBox.Show(name + " ,your salary is: " + salary + " taka");

        }
    }
}

