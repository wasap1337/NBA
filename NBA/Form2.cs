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
    public partial class Form2 : Form
    {
        // Переменная для хранения ссылки на главную форму
        private Form parentForm;
        public Form2()
        {
            InitializeComponent();
        }
        // Модифицированный конструктор
        public Form2(Form mainForm)
        {
            InitializeComponent();
            parentForm = mainForm; // Сохраняем ссылку
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            // Показываем старую форму обратно
            parentForm.Show();
            // Полностью закрываем текущую форму Vadmin Menu, чтобы освободить память
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если первая (главная) форма сейчас скрыта, значит мы закрыли админку на крестик.
            // В этом случае полностью тушим всё приложение, чтобы процесс не висел.
            if (parentForm != null && !parentForm.Visible)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

