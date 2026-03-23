using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtLastName.Text) ||
            string.IsNullOrWhiteSpace(txtGroup.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі текстові поля!", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBirthYear.Text, out int birthYear) || birthYear < 1900 || birthYear > DateTime.Now.Year)
            {
                MessageBox.Show("Введіть коректний рік народження (число).", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCourse.Text, out int course) || course < 1 || course > 6)
            {
                MessageBox.Show("Курс має бути числом від 1 до 6.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Прізвище: {txtLastName.Text}");
            sb.AppendLine($"Ім'я: {txtFirstName.Text}");
            sb.AppendLine($"Рік народження: {birthYear}");
            sb.AppendLine($"Група: {txtGroup.Text}");
            sb.AppendLine($"Курс: {course}");
            sb.AppendLine($"Дата реєстрації: {DateTime.Now:dd.MM.yyyy HH:mm}");
            sb.AppendLine("-----------------------");

            txtOutput.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
