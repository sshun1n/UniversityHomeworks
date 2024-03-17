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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            firstnameField.Text = "Введите имя"; firstnameField.ForeColor = Color.Gray;
            lastnameField.Text = "Введите фамилию"; lastnameField.ForeColor = Color.Gray;

        }

        private void closeButton_Click(object sender, EventArgs e) { Application.Exit(); }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }

        private void firstnameField_Enter(object sender, EventArgs e) { if (firstnameField.Text == "Введите имя") { firstnameField.Text = ""; firstnameField.ForeColor = Color.Black; } }
        private void firstnameField_Leave(object sender, EventArgs e) { if (firstnameField.Text == "") { firstnameField.Text = "Введите имя"; firstnameField.ForeColor = Color.Gray; } }
        private void lastnameField_Enter(object sender, EventArgs e) { if (lastnameField.Text == "Введите фамилию") { lastnameField.Text = ""; lastnameField.ForeColor = Color.Black; } }
        private void lastnameField_Leave(object sender, EventArgs e) { if (lastnameField.Text == "") { lastnameField.Text = "Введите фамилию"; lastnameField.ForeColor = Color.Gray; } }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            if (firstnameField.Text == "Введите имя") { MessageBox.Show("Введите имя"); return; }
            if (firstnameField.Text == "Введите фамилию") { MessageBox.Show("Введите фамилию"); return; }
            if (loginField.Text == "") { MessageBox.Show("Введите логин"); return; }
            if (passwordField.Text == "") { MessageBox.Show("Введите пароль"); return; }

            if (isUserExists()) return;

            dataBase db = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `firstName`, `lastName`) VALUES (@uL, @uP, @name, @lastname);", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = firstnameField.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1) MessageBox.Show("Успешно зарегистрирован пользователь.");
            else MessageBox.Show("Не удалось создать аккаунт.");

            db.closeConnection();

        }

        public Boolean isUserExists()
        {
            dataBase db = new dataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) { MessageBox.Show("Такой логин уже зарегистрирован."); return true; }
            else return false;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void LoginLabel_MouseHover(object sender, EventArgs e) { LoginLabel.Font = new Font(LoginLabel.Font.Name, LoginLabel.Font.SizeInPoints, FontStyle.Underline); }
        private void LoginLabel_MouseLeave(object sender, EventArgs e) { LoginLabel.Font = new Font(LoginLabel.Font.Name, LoginLabel.Font.SizeInPoints, FontStyle.Bold); }

    }
}
