using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class PlayersForm : Form
    {
        // Переменная для хранения ссылки на главную форму
        private Form parentForm;


     
        public PlayersForm(Form mainForm)
        {
            InitializeComponent();
            parentForm = mainForm; 
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
           
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            string connectionString = @"Server=DESKTOP-T1PU471\SQLEXPRESS;Database=NBADatabase;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "SELECT PlayerId, FullName, ShirtNumber, Position FROM Players";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt); 

                   
                    dgvPlayers.DataSource = dt;

                    

                    if (dgvPlayers.Columns["PlayerId"] != null)
                    {
                        dgvPlayers.Columns["PlayerId"].Visible = false;
                    }
                }//TEST
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке списка игроков: " + ex.Message);
                }
            }
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если главная форма скрыта и мы закрываем это окно, полностью тушим весь процесс приложения
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }
        private void dgvPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Защита от клика по шапке
            if (e.RowIndex >= 0)
            {
                // Берем значение из самой первой ячейки строки (индекс 0), где гарантированно лежит PlayerId
                int playerId = Convert.ToInt32(dgvPlayers.Rows[e.RowIndex].Cells[0].Value);

                // Открываем форму деталей и передаем туда настоящий системный ID
                PlayerDetailForm detailForm = new PlayerDetailForm(playerId);
                detailForm.ShowDialog();
            }
        }


        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
