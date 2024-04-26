using CourseProject.core;
using System.Drawing.Imaging;

namespace CourseProject
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        AppDesign design = new AppDesign();

        private void mainForm_Load(object sender, EventArgs e)
        {
            headerPanel.BackColor = design.HeaderColor;
            mainPanel.BackColor = design.BackgroundColor;

            headerLabel.ForeColor = design.TextColor;
            headerLabel.Font = design.HeaderFont;

            Button[] buttons = { dataBaseButton, addEmployeeButton };

            foreach (Button button in buttons)
            {
                button.BackColor = design.ButtonColor;
                button.ForeColor = design.TextColor;
                button.Font = design.HeaderFont;

                button.FlatAppearance.BorderSize = 0;
                button.Cursor = Cursors.Hand;
            }

            dataBaseButton.Text = "Открыть базу данных";
            addEmployeeButton.Text = "Добавить сотрудника";

            HeaderAnimaton();
        }

        private async void HeaderAnimaton()
        {
            int height = 0;

            while (height <= 63)
            {
                height += 3;
                headerPanel.Height = height;
                await Task.Delay(1);
            }
        }

        private void dataBaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataForm form = new dataForm();
            form.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addEmpForm form = new addEmpForm();
            form.Show();
        }
    }
}
