using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int floor = (int)numFloor.Value;
                decimal hourlyRate = numHourlyRate.Value;
                string elevatorType = cmbElevator.SelectedItem.ToString();

                decimal baseWorkCost = hourlyRate * 2;
                decimal floorSurcharge = 0;
                string details = "";

                if (elevatorType == "Відсутній")
                {
                    if (floor > 1)
                    {
                        floorSurcharge = (floor - 1) * (hourlyRate * 0.20m);
                        details = $"Доплата за ручний підйом ({floor - 1} пов.): {floorSurcharge:F2} грн";
                    }
                    else
                    {
                        details = "Підйом на 1-й поверх включено";
                    }
                }
                else if (elevatorType == "Звичайний")
                {
                    decimal elevatorFee = 50; 
                    floorSurcharge = elevatorFee + (floor * (hourlyRate * 0.05m));
                    details = $"Використання звичайного ліфта: {floorSurcharge:F2} грн";
                }
                else if (elevatorType == "Вантажний")
                {
                    floorSurcharge = 150;
                    details = "Використання вантажного ліфта (фіксовано): 150.00 грн";
                }

                decimal totalCost = baseWorkCost + floorSurcharge;

                lblResult.Text = $"Вартість: {totalCost:F2} грн";
                lblResult.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при розрахунку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
