using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;




namespace NBA
{
    public partial class PlayerDetailForm : Form
    {
        private int _playerId;
        // Строка подключения к вашей локальной базе данных SQL Express
        private string _connectionString = @"Server=DESKTOP-T1PU471\SQLEXPRESS;Database=NBADatabase;Trusted_Connection=True;TrustServerCertificate=True;";
        private string _currentStatType = "Points"; // По умолчанию отображаем Очки

        // Конструктор формы принимает ID выбранного игрока
        public PlayerDetailForm(int playerId)
        {
            InitializeComponent();
            _playerId = playerId;
        }

        // Событие загрузки формы
        private void PlayerDetailForm_Load(object sender, EventArgs e)
        {
            LoadPlayerProfile();
            LoadChartData();
        }

        // 1. Загрузка профиля игрока и расчет средних показателей
        private void LoadPlayerProfile()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT p.*, t.TeamNam,
                           (SELECT AVG(CAST(Points AS DECIMAL(4,2))) FROM PlayerStats WHERE PlayerId = p.PlayerId) AS CareerPPG,
                           (SELECT AVG(CAST(Assists AS DECIMAL(4,2))) FROM PlayerStats WHERE PlayerId = p.PlayerId) AS CareerAPG,
                           (SELECT AVG(CAST(Rebounds AS DECIMAL(4,2))) FROM PlayerStats WHERE PlayerId = p.PlayerId) AS CareerRPG
                    FROM Players p
                    LEFT JOIN Teams t ON p.TeamId = t.TeamId
                    WHERE p.PlayerId = @PlayerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PlayerId", _playerId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Заполнение текстовых меток данными из БД
                        lblPlayerName.Text = reader["FullName"].ToString();
                        lblNumber.Text = $"#{reader["ShirtNumber"]}";
                        lblTeam.Text = reader["TeamNam"].ToString();
                        lblBirthDate.Text = Convert.ToDateTime(reader["DateOfBirth"]).ToString("yyyy-MM-dd");
                        lblCollege.Text = reader["College"].ToString();
                        lblCollege.Text = $"{reader["Experience"]} Years";
                        lblSalary.Text = $"${reader["Salary"]}";

                        // Вывод карьерной статистики
                        lblCareerPPG.Text = reader["CareerPPG"] != DBNull.Value ? Convert.ToDecimal(reader["CareerPPG"]).ToString("F2") : "0.00";
                        lblCareerAPG.Text = reader["CareerAPG"] != DBNull.Value ? Convert.ToDecimal(reader["CareerAPG"]).ToString("F2") : "0.00";
                        lblCareerRPG.Text = reader["CareerRPG"] != DBNull.Value ? Convert.ToDecimal(reader["CareerRPG"]).ToString("F2") : "0.00";

                        // Статистику за сезон делаем равной карьерной, так как период фиксированный
                        lblSeasonPPG.Text = lblCareerPPG.Text;
                        lblSeasonAPG.Text = lblCareerAPG.Text;
                        lblSeasonRPG.Text = lblCareerRPG.Text;

                        lblHeight.Text = reader["Position"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки профиля: " + ex.Message);
                }
            }
        }

        // 2. Отрисовка графика динамики за фиксированный период времени
        private void LoadChartData()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {

                // Идеальный индивидуальный запрос: вытягивает данные строго для кликнутого игрока
                // Старый запрос, который ничего не находит из-за несовпадения дат
                // Новый запрос: берет последние 10 матчей игрока по порядку, игнорируя жесткие даты
                string query = $@"SELECT TOP 10 GameDate, {_currentStatType} FROM PlayerStats 
                  WHERE PlayerId = @PlayerId 
                  ORDER BY GameDate ASC";




                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PlayerId", _playerId);

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    


                    // === КРИТИЧЕСКАЯ НАСТРОЙКА ГРАФИКА ДЛЯ ОТОБРАЖЕНИЯ ===
                    chartStats.Series.Clear();
                    chartStats.ChartAreas.Clear();

                    // 1. Создаем и добавляем область отображения (без нее график всегда пустой!)
                    ChartArea area = new ChartArea("MainArea");

                    // Настройка сеток (сделаем их тонкими и серыми, как на макете)
                    area.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                    area.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                    chartStats.ChartAreas.Add(area);

                    // 2. Создаем новую линию данных
                    Series series = chartStats.Series.Add(_currentStatType);
                    series.ChartType = SeriesChartType.Line; // Линейный график
                    series.BorderWidth = 3;                  // Толщина линии
                    series.Color = System.Drawing.Color.DodgerBlue; // Синий цвет линии как на скрине
                    series.MarkerStyle = MarkerStyle.Circle; // Добавим точки-кружочки на изгибах
                    series.MarkerSize = 8;

                    double sum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime date = Convert.ToDateTime(row["GameDate"]);
                        int value = Convert.ToInt32(row[_currentStatType]);

                        // X — дата (День/Месяц), Y — статистика
                        series.Points.AddXY(date.ToString("d/M"), value);
                        sum += value;
                    }

                    // Считаем и выводим среднее значение
                    double average = dt.Rows.Count > 0 ? sum / dt.Rows.Count : 0;
                    lblAverage.Text = $"The average of {_currentStatType.ToLower()}: {average:F2}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка построения графика: " + ex.Message);
                }
            }
        }

        // Обработчики кликов по кнопкам вкладок
        private void btnPoints_Click(object sender, EventArgs e) { _currentStatType = "Points"; LoadChartData(); }
        private void btnRebounds_Click(object sender, EventArgs e) { _currentStatType = "Rebounds"; LoadChartData(); }
        private void btnAssists_Click(object sender, EventArgs e) { _currentStatType = "Assists"; LoadChartData(); }
        private void btnSteals_Click(object sender, EventArgs e) { _currentStatType = "Steals"; LoadChartData(); }
        private void btnBlocks_Click(object sender, EventArgs e) { _currentStatType = "Blocks"; LoadChartData(); }

        // Кнопка Back для закрытия формы
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
