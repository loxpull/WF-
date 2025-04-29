using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Проверка на пустоту
            if (string.IsNullOrWhiteSpace(textBoxOre.Text) ||
                string.IsNullOrWhiteSpace(textBoxManganese.Text) ||
                string.IsNullOrWhiteSpace(textBoxChromium.Text) ||
                string.IsNullOrWhiteSpace(textBoxNickel.Text) ||
                string.IsNullOrWhiteSpace(textBoxBlastFurnaceTime.Text) ||
                string.IsNullOrWhiteSpace(textBoxConverterTime.Text) ||
                string.IsNullOrWhiteSpace(textBoxRollingMillTime.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, "111.txt");
            try
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine("Руда: " + textBoxOre.Text);
                        writer.WriteLine("Марганец: " + textBoxManganese.Text);
                        writer.WriteLine("Хром: " + textBoxChromium.Text);
                        writer.WriteLine("Никель: " + textBoxNickel.Text);
                        writer.WriteLine("Время работы ДП: " + textBoxBlastFurnaceTime.Text);
                        writer.WriteLine("Время работы конвертера: " + textBoxConverterTime.Text);
                        writer.WriteLine("Время работы ПС: " + textBoxRollingMillTime.Text);
                    }
                    MessageBox.Show("Данные успешно сохранены в файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

