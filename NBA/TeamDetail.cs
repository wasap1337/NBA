using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NBA
{
    public partial class TeamDetail : Form
    {
        private Form parentForm;
        private int teamId;
        private bool startWithMatchups = false;

        // ОБЯЗАТЕЛЬНО ДОБАВЬТЕ ЭТУ СТРОКУ СЮДА:
        private string connectionString = @"Server=DESKTOP-T1PU471\SQLEXPRESS;Database=NBADatabase;Trusted_Connection=True;TrustServerCertificate=True;";
        public TeamDetail()
        {
            InitializeComponent();
        }

        // Измененный конструктор: теперь принимает ТРИ параметра
        public TeamDetail(Form mainForm, int selectedTeamId, bool openMatchups = false)
        {
            InitializeComponent();
            parentForm = mainForm;
            teamId = selectedTeamId;
            this.startWithMatchups = openMatchups;
        }


        private void TeamDetail_Load(object sender, EventArgs e)
        {
            LoadTeamInfo(); // Всегда загружаем шапку и логотип команды сверху

            // Проверяем, на какую ссылку нажал пользователь в карточке
            if (startWithMatchups)
            {
                LoadTeamMatchups(); // Если нажали Matchup — сразу грузим матчи
            }
            else
            {
                LoadPlayerRoster(); // Если нажали Roster — грузим игроков (старое поведение)
            }
        }


       

        // 1. Загрузка шапки (Название команды, Дивизион и Логотип из новой папки)
        private void LoadTeamInfo()
        {
            string query = "SELECT TeamNam, DivisionId, Logo FROM Teams WHERE TeamId = @TeamId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeamId", teamId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["TeamNam"].ToString().Trim();
                        string divId = reader["DivisionId"].ToString().Trim();
                        string logoName = reader["Logo"].ToString().Trim();

                        lblTeamHeader.Text = $"{name} | Division {divId}";

                        
                        string logoPath = $@"C:\nba\Teams\{logoName}";

                        if (System.IO.File.Exists(logoPath))
                        {
                            if (pbTeamLogo.Image != null) pbTeamLogo.Image.Dispose();
                            pbTeamLogo.SizeMode = PictureBoxSizeMode.Zoom;
                            pbTeamLogo.Image = Image.FromFile(logoPath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки информации о команде: " + ex.Message);
                }
            }
        }

        // 2. Загрузка состава игроков в DataGridView
        private void LoadPlayerRoster()
        {
            // Строго выверенные имена колонок под созданную нами таблицу
            string query = @"
        SELECT 
            ShirtNumber AS [No.], 
            FullName AS [Name], 
            Position AS [Position], 
            CONVERT(VARCHAR(10), DateOfBirth, 104) AS [DateofBirth], -- Формат ДД.ММ.ГГГГ как на скрине
            College AS [College], 
            Experience AS [Experience], 
            FORMAT(Salary, 'C0', 'en-US') AS [Salary] -- Делает красивый вид $26,540,100
        FROM Players 
        WHERE TeamId = @TeamId"; // Фильтруем игроков только для выбранной команды

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TeamId", teamId);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // dgvRoster — имя вашего DataGridView на форме
                    dgvRoster.DataSource = dataTable;

                    // Настройки внешнего вида, чтобы сетка смотрелась аккуратно
                    dgvRoster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvRoster.AllowUserToAddRows = false;
                    dgvRoster.ReadOnly = true;
                    dgvRoster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки состава игроков: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (parentForm != null) parentForm.Show();
            this.Close();
        }

        private void TeamDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }
        // 1. Клик по кнопке Roster (перезагружает игроков)
        private void btnRoster_Click(object sender, EventArgs e)
        {
            LoadPlayerRoster();
        }

        // 2. Клик по кнопке Matchup (загружает матчи из новой таблицы)
        private void btnMatchup_Click(object sender, EventArgs e)
        {
            LoadTeamMatchups();
        }

        // 3. Сам метод загрузки матчей из базы данных
        private void LoadTeamMatchups()
        {
            // SQL-запрос выбирает колонки строго под шапку вашего нового скриншота
            string query = @"
        SELECT 
            CONVERT(VARCHAR(10), MatchDate, 111) AS [Date], -- Формат ГГГГ/ММ/ДД как на макете
            MatchupType AS [Matchup Type], 
            OpponentName AS [Opponent], 
            StartTime AS [Start Time], 
            Result AS [Result], 
            MatchLocation AS [Location], 
            MatchStatus AS [Status]
        FROM Matchups 
        WHERE TeamId = @TeamId"; // Показываем матчи только выбранной команды

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@TeamId", teamId);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Перепривязываем эту же таблицу DataGridView на новые данные матчей
                    dgvRoster.DataSource = dataTable;
                    dgvRoster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки матчей: " + ex.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
}
