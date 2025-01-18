using System;
namespace assignment2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //setting to only allow user to pick one date
            maturityDate.MaxSelectionCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //formula to get the simple interest of principal
            int Years = maturityDate.SelectionStart.Year - todaysDate.Value.Year;
            int PrincipalAmount = Convert.ToInt32(DepositAmount.Text);
            decimal InterestRateCon = InterestRate.Value;
            decimal returnAmount = (PrincipalAmount * InterestRateCon * Years) / 100;
            returnAmount = returnAmount + PrincipalAmount;
            //funny if statement
            if (Years >= 150)
            {
                ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure we will still be using this money? " + Convert.ToString(returnAmount);
            }
            //another funny if statement
            else if (Years >= 80)
            {
                ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure you can spend that? Whatever the return amount will be! " + Convert.ToString(returnAmount);
            }
            //standard return
            else
            {
                ReturnAmount.Text = Convert.ToString(returnAmount);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
