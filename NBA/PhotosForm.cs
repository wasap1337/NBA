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
    public partial class PhotosForm : Form
    {
        // Переменная для хранения ссылки на главную форму
        private Form parentForm;


        // Модифицированный конструктор для вызова из кода
        public PhotosForm(Form mainForm)
        {
            InitializeComponent();
            parentForm = mainForm; // Сохраняем ссылку
        }

        private void PhotosForm_Load(object sender, EventArgs e)
        {

        }

        private void TeamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если главная форма скрыта и мы закрываем это окно, полностью тушим весь процесс приложения
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }

        private void PhotosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если главная форма скрыта и мы закрываем это окно, полностью тушим весь процесс приложения
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }
    }
}
