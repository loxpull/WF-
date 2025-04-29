using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        private void ButtonExecuteOrder_Click(object sender, EventArgs e)
        {
            // Проверка на пустоту
            if (string.IsNullOrWhiteSpace(textBoxSteelGrade.Text) ||
                string.IsNullOrWhiteSpace(textBoxRawMaterial.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeBlastFurnace.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeConverter.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeRollingMill.Text) ||
                string.IsNullOrWhiteSpace(textBoxPricePerTon.Text) ||
                string.IsNullOrWhiteSpace(textBoxTargetVolume.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Логика выполнения заказа
            // Здесь можно добавить логику проверки ресурсов и выполнения заказа
            MessageBox.Show("Заказ выполнен.");
        }
}
