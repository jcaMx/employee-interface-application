using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string department = textBoxDepartment.Text;
            //double basicSalary = double.Parse(textBoxBasicSalary.Text);
            double hoursWorked = double.Parse(textBox6.Text);
            double ratePerHour = double.Parse(textBoxRatePerHour.Text);


            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, jobTitle, department);

            double computedSalary = employee.ComputeSalary(hoursWorked, ratePerHour);

            label8.Text = firstName;
            label10.Text = lastName;
            label12.Text = $" {computedSalary} PHP";
            
        }
    }
}
