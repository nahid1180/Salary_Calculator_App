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
    public partial class SalaryCaculatorUI : Form
    {
        
        public SalaryCaculatorUI()
        {
            InitializeComponent();
        }
        Amount salaryCalculator = new Amount();
        private void salaryButton_Click(object sender, EventArgs e)
        {
            salaryCalculator.name = nameTextBox.Text;
            salaryCalculator.salaryAmount = Convert.ToDouble(SalaryTextBox.Text);
            salaryCalculator.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            salaryCalculator.medicalAllowance = Convert.ToDouble(medicalTextBox.Text);

            MessageBox.Show(salaryCalculator.name + "Your Salary is " + salaryCalculator.salary());

        }
    }
}
