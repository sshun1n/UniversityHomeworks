using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace registration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, this.loginField.Size.Height);
        }

        private void closeButton_Click(object sender, EventArgs e) { Application.Exit(); }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String UserLogin = loginField.Text, UserPassword = passwordField.Text;

            dataBase db = new dataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = UserPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else MessageBox.Show("Не удалось авторизовать.");

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm();
            reg.Show();
        }

        private void RegisterLabel_MouseHover(object sender, EventArgs e) { RegisterLabel.Font = new Font(RegisterLabel.Font.Name, RegisterLabel.Font.SizeInPoints, FontStyle.Underline); }
        private void RegisterLabel_MouseLeave(object sender, EventArgs e) { RegisterLabel.Font = new Font(RegisterLabel.Font.Name, RegisterLabel.Font.SizeInPoints, FontStyle.Bold); }

    }
}
