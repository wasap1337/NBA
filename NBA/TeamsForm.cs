using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NBA
{
    public partial class TeamsForm : Form
    {
        private Form parentForm;

        // Строка подключения к вашему серверу SQLEXPRESS
        private string connectionString = @"Server=DESKTOP-T1PU471\SQLEXPRESS;Database=NBADatabase;Trusted_Connection=True;TrustServerCertificate=True;";

        public TeamsForm()
        {
            InitializeComponent();
        }

        public TeamsForm(Form mainForm)
        {
            InitializeComponent();
            parentForm = mainForm;
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            // Проверка: создана ли папка вообще
            if (!System.IO.Directory.Exists(@"C:\nba\Teams"))
            {
                MessageBox.Show("Критическая ошибка! Папка C:\\nba не найдена на диске.", "Ошибка путей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadTeamsToPanels();
        }

        private void LoadTeamsToPanels()
        {
            // Замораживаем отрисовку элементов для плавной загрузки графики
            flowAtlantic.SuspendLayout();
            flowCentral.SuspendLayout();
            flowSoutheast.SuspendLayout();

            flowAtlantic.Controls.Clear();
            flowCentral.Controls.Clear();
            flowSoutheast.Controls.Clear();

            string query = "SELECT TeamId, TeamNam, DivisionId, Logo FROM Teams WHERE DivisionId IN (1, 2, 3)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["TeamId"]);
                        string name = reader["TeamNam"].ToString();
                        int divisionId = Convert.ToInt32(reader["DivisionId"]);
                        string logoName = reader["Logo"].ToString();

                        // Собираем точный путь к картинке: C:\nba\1.jpg
                        string fullLogoPath = $@"C:\nba\Teams\{logoName}";

                        TeamCard card = new TeamCard();

                        // Инициализируем карточку данными
                        card.InitCard(id, name, fullLogoPath, this);

                        // Распределяем карточки по вашим панелям
                        if (divisionId == 1) flowAtlantic.Controls.Add(card);
                        else if (divisionId == 2) flowCentral.Controls.Add(card);
                        else if (divisionId == 3) flowSoutheast.Controls.Add(card);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при работе с БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Размораживаем отрисовку — все карточки с картинками появятся разом
            flowAtlantic.ResumeLayout(true);
            flowCentral.ResumeLayout(true);
            flowSoutheast.ResumeLayout(true);
        }
       
        private void TeamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                // Показываем старую форму обратно
                parentForm.Show();
            }
            // Полностью закрываем текущую  чтобы освободить память
            this.Close();
        }
    }
}
