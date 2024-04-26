using CourseProject.core;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }

        AppDesign design = new AppDesign();
        DB database = new DB();

        private void dataForm_Load(object sender, EventArgs e)
        {
            HeaderAnimaton();

            headerPanel.BackColor = design.HeaderColor;
            mainPanel.BackColor = design.BackgroundColor;
            toolsPanel.BackColor = design.AccentColor;

            headerLabel.ForeColor = design.TextColor;
            headerLabel.Font = design.HeaderFont;
            searchLabel.ForeColor = design.TextColor;
            searchLabel.Font = design.HeaderFont;
            errorLabel.BackColor = Color.White;
            errorLabel.ForeColor = Color.Black;
            errorLabel.Font = design.HeaderFont;

            searchBox.Font = design.RegularFont;

            backButton.BackColor = design.AccentColor;
            backButton.ForeColor = design.TextColor;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Width = 25;
            backButton.Height = 30;
            backButton.TextAlign = ContentAlignment.TopCenter;
            backButton.Text = "<";
            backButton.Font = new Font("Bahnschrift", 15, FontStyle.Bold);
            backButton.Cursor = Cursors.Hand;

            gridPanel.BackColor = design.AccentColor;
            dataGrid.BackgroundColor = design.TextColor;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.Font = design.RegularFont;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;

            dataGrid.DataSource = database.GetData("select *from employees");

            FillDataGrid(dataGrid);
        }

        private void FillDataGrid(DataGridView dataGrid)
        {
            errorLabel.Hide();

            dataGrid.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Resource.editicon,
            });

            dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGrid.Columns[0].HeaderText = "ID";
            dataGrid.Columns[1].HeaderText = "Имя";
            dataGrid.Columns[2].HeaderText = "Фамилия";
            dataGrid.Columns[3].HeaderText = "Отчество";
            dataGrid.Columns[4].HeaderText = "З/П";
            dataGrid.Columns[5].HeaderText = "Часов";
            dataGrid.Columns[6].HeaderText = "Выплата";
            dataGrid.Columns[7].HeaderText = "Должность";

            dataGrid.Columns[0].Width = 35;
            dataGrid.Columns[1].Width = 125;
            dataGrid.Columns[2].Width = 138;
            dataGrid.Columns[3].Width = 150;
            dataGrid.Columns[4].Width = 70;
            dataGrid.Columns[5].Width = 70;
            dataGrid.Columns[6].Width = 100;
            dataGrid.Columns[7].Width = 140;
            dataGrid.Columns[8].Width = 35;
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

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 8)
            {
                int rowId = (int)e.RowIndex;

                Employee employee = new Employee();

#pragma warning disable CS8601

                employee.Id = Convert.ToInt32(dataGrid.Rows[rowId].Cells[0].Value);
                employee.FirstName = Convert.ToString(dataGrid.Rows[rowId].Cells[1].Value);
                employee.LastName = Convert.ToString(dataGrid.Rows[rowId].Cells[2].Value);
                employee.MiddleName = Convert.ToString(dataGrid.Rows[rowId].Cells[3].Value);
                employee.Salary = Convert.ToInt32(dataGrid.Rows[rowId].Cells[4].Value);
                employee.HoursWorked = Convert.ToInt32(dataGrid.Rows[rowId].Cells[5].Value);
                employee.ToPay = Convert.ToInt32(dataGrid.Rows[rowId].Cells[6].Value);
                employee.Role = Convert.ToString(dataGrid.Rows[rowId].Cells[7].Value);

#pragma warning restore CS8601

                this.Hide();
                reductForm form = new reductForm(employee);
                form.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm form = new mainForm();
            form.Show();
        }

        private void dataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Columns.Clear();

            if (searchBox.Text == string.Empty) 
            {
                dataGrid.DataSource = database.GetData("select *from employees");
                FillDataGrid(dataGrid); 
                return; 
            }

            bool isEmpty = true;

            DataTable table = new DataTable();
            DataTable dt = new DataTable();

            string[] strColumns = { "first_name", "last_name", "middle_name", "emp_role" };
            string[] intColumns = { "id", "salary", "hours_worked", "to_pay" };

            if (!int.TryParse(searchBox.Text, out int temp))
            {
                string request = searchBox.Text;

                foreach (string column in strColumns)
                {
                    dt = database.GetData($"select *from employees where {column}='{request}'");
                    if (dt.Rows.Count > 0) { table = dt; isEmpty = false; }
                }

                if (isEmpty)
                {
                    errorLabel.Text = $"По запросу '{request}'\n ничего не найдено"; errorLabel.Show();
                    return;
                }
            } 
            else
            {
                int request = temp;

                foreach (string column in intColumns)
                {
                    dt = database.GetData($"select *from employees where {column}={request}");
                    if (dt.Rows.Count > 0) { table = dt; isEmpty = false; }
                }

                if (isEmpty)
                {
                    errorLabel.Text = $"По запросу '{request}'\n ничего не найдено"; errorLabel.Show();
                    return;
                }
            }

            dataGrid.DataSource = table;
            FillDataGrid(dataGrid);
        }
    }
}
