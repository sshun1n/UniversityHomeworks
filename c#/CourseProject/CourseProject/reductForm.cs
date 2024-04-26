using CourseProject.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class reductForm : Form
    {
        public reductForm(Employee employee)
        {
            InitializeComponent();

            TextBox[] temp = { firstNameBox, lastNameBox, middleNameBox, roleBox, salaryBox, hoursWorkedBox };

            this.boxes = temp;
            this.employee = employee;
        }

        private DB database = new DB();
        private AppDesign design = new AppDesign();
        private TextBox[] boxes;
        private Employee employee;

        private void reductForm_Load(object sender, EventArgs e)
        {
            HeaderAnimaton();

            headerPanel.BackColor = design.HeaderColor;
            mainPanel.BackColor = design.BackgroundColor;

            headerLabel.ForeColor = design.TextColor;
            headerLabel.Font = design.HeaderFont;

            backButton.BackColor = design.AccentColor;
            backButton.ForeColor = design.TextColor;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Width = 25;
            backButton.Height = 30;
            backButton.TextAlign = ContentAlignment.TopCenter;
            backButton.Text = "<";
            backButton.Font = new Font("Bahnschrift", 15, FontStyle.Bold);
            backButton.Cursor = Cursors.Hand;

            firstNameLabel.Font = design.RegularFont;
            lastNameLabel.Font = design.RegularFont;
            middleNameLabel.Font = design.RegularFont;
            roleLabel.Font = design.RegularFont;
            salaryLabel.Font = design.RegularFont;
            hoursWorkedLabel.Font = design.RegularFont;

            foreach (TextBox box in boxes)
            {
                box.Font = design.RegularFont;
                box.TextAlign = HorizontalAlignment.Center;
            }

            saveButton.Font = design.RegularFont;
            saveButton.Height = 30;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.BackColor = design.ButtonColor;
            saveButton.ForeColor = design.TextColor;
            saveButton.TextAlign = ContentAlignment.TopCenter;
            saveButton.Cursor = Cursors.Hand;

            firstNameBox.Text = this.employee.FirstName;
            lastNameBox.Text = this.employee.LastName;
            middleNameBox.Text = this.employee.MiddleName;
            salaryBox.Text = this.employee.Salary.ToString();
            hoursWorkedBox.Text = this.employee.HoursWorked.ToString();
            roleBox.Text = this.employee.Role;
        }

        private async void HeaderAnimaton()
        {
            int height = 0;
            int y = -48;

            while (height <= 63)
            {
                height += 3;
                y += 3;
                backButton.Location = new System.Drawing.Point(0, y);
                headerPanel.Height = height;
                await Task.Delay(1);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataForm form = new dataForm();
            form.Show();
        }

        private void addEmpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isFilled = true;

            foreach (TextBox box in boxes)
            {
                if (box.Text == String.Empty) isFilled = false;
            }

            if (isFilled)
            {
                database.Commit($"update employees set first_name = '{firstNameBox.Text}', last_name = '{lastNameBox.Text}', middle_name = '{middleNameBox.Text}', salary = {salaryBox.Text}, hours_worked = {hoursWorkedBox.Text}, to_pay = {Convert.ToInt32(salaryBox.Text) * Convert.ToInt32(hoursWorkedBox.Text)}, emp_role = '{roleBox.Text}'"
                    + $" where id={employee.Id}");

                backButton_Click(sender, e);
            }
            else MessageBox.Show("ОШИБКА: Не все поля заполнены");
        }
    }
}

