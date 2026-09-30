using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Form3 : Form
    {
       

        // Переменная для хранения ссылки на главную форму
        private Form parentForm;

     
        // Модифицированный конструктор для вызова из кода
        public Form3(Form mainForm)
        {
            InitializeComponent();
            parentForm = mainForm; // Сохраняем ссылку
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

        


        private void btnTeams_Click(object sender, EventArgs e)
        {
            TeamsForm teamsWindow = new TeamsForm(this); // передаем текущую форму (VisitorMenuForm)
            teamsWindow.Show();
            this.Hide();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersWindow = new PlayersForm(this); // передаем текущую форму (VisitorMenuForm)
            playersWindow.Show();
            this.Hide();
        }

        private void btnMatchups_Click(object sender, EventArgs e)
        {
            MatchupsForm MatchupsWindow = new MatchupsForm(this); // передаем текущую форму (VisitorMenuForm)
            MatchupsWindow.Show();
            this.Hide();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            PhotosForm PhotosWindow = new PhotosForm(this); // передаем текущую форму (VisitorMenuForm)
            PhotosWindow.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если главная форма скрыта и мы закрываем это окно, полностью тушим весь процесс приложения
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }

        }
}
}
