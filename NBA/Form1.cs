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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Form2 AdminWindow = new Form2(this);

            // 2. Отображаем новую форму
            AdminWindow.Show();
            this.Hide();




        }

        private void VisitorBtn_Click(object sender, EventArgs e)
        {
           Form3 visitorWindow = new Form3(this);

            // 2. Отображаем новую форму
            visitorWindow.Show();

            // 3. (Опционально) Скрываем текущую главную форму
            this.Hide(); 
        }
    }
}
