using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            gvPhones.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Diagonal";
            column.Name = "Діагональ";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cores";
            column.Name = "Ядра";
            column.Width = 80;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Platform";
            column.Name = "Платформа";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SimQuantity";
            column.Name = "Кількість сім-карт";
            column.Width = 80;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasAI";
            column.Name = "ШІ";
            column.Width = 60;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasTypeC";
            column.Name = "TypeC";
            column.Width = 60;
            gvPhones.Columns.Add(column);

            bindSrcPhones.Add(new Phone("Samsung Gal. S23", "2340x1080", 8, "Android", 2, true, true));
            bindSrcPhones.Add(new Phone("Apple iPhone 15 Pro Max", "2796x1290", 10, "iOS 17", 3, true, false));
            bindSrcPhones.Add(new Phone("Xiaomi 14 Ultra", "3200x1440", 16, "Android", 3, true, true));
            bindSrcPhones.Add(new Phone("HUAWEI P60 Pro", "2340x1080", 8, "Android", 2, false, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();

            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK) 
            {
                bindSrcPhones.Add(phone);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)bindSrcPhones.List[bindSrcPhones.Position];

            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK) 
            {
                bindSrcPhones.List[bindSrcPhones.Position] = phone;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPhones.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення данних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPhones.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
