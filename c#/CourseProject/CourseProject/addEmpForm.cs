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
    public partial class addEmpForm : Form
    {
        public addEmpForm()
        {
            InitializeComponent();

            TextBox[] temp = { firstNameBox, lastNameBox, middleNameBox, roleBox, salaryBox, hoursWorkedBox };
            this.boxes = temp;
        }

        private DB database = new DB();
        private AppDesign design = new AppDesign();
        private TextBox[] boxes;

        private void addEmpForm_Load(object sender, EventArgs e)
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

            addButton.Font = design.RegularFont;
            addButton.Height = 30;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.BackColor = design.ButtonColor;
            addButton.ForeColor = design.TextColor;
            addButton.TextAlign = ContentAlignment.TopCenter;
            addButton.Cursor = Cursors.Hand;
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
            mainForm form = new mainForm();
            form.Show();
        }

        private void addEmpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isFilled = true;

            foreach(TextBox box in boxes)
            {
                if (box.Text == String.Empty) isFilled = false;
            }

            if (isFilled)
            {
                database.Commit("insert into employees (first_name, last_name, middle_name, salary, hours_worked, to_pay, emp_role)"
                    + $" values ('{firstNameBox.Text}', '{lastNameBox.Text}', '{middleNameBox.Text}', {salaryBox.Text}, {hoursWorkedBox.Text}, {Convert.ToInt32(salaryBox.Text) * Convert.ToInt32(hoursWorkedBox.Text)}, '{roleBox.Text}')");

                backButton_Click(sender, e);
            }
            else MessageBox.Show("ОШИБКА: Не все поля заполнены");
        }
    }
}
