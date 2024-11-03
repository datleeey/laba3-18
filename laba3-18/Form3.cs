using System;
using System.Windows.Forms;

namespace laba3_18
{
    public partial class Form3 : Form
    {
        private int[,] array; // Двовимірний масив
        private int rows;
        private int columns;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Зчитуємо кількість рядків з текстового поля
            int.TryParse(textBox1.Text, out rows);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Зчитуємо кількість стовпців з текстового поля
            int.TryParse(textBox2.Text, out columns);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Генеруємо та відображаємо двовимірний масив
            GenerateArray();
            DisplayArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Обробляємо масив, щоб знайти максимальний за модулем елемент і додати його до всіх елементів
            ProcessArray();
            DisplayArray();
        }

        private void GenerateArray()
        {
            // Ініціалізуємо масив випадковими значеннями
            Random rand = new Random();
            array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(-100, 100); // Випадкові значення від -100 до 100
                }
            }
        }

        private void DisplayArray()
        {
            // Відображення масиву в DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void ProcessArray()
        {
            // Знаходження найбільшого за модулем елемента в масиві
            int maxAbsoluteValue = Math.Abs(array[0, 0]);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (Math.Abs(array[i, j]) > maxAbsoluteValue)
                        maxAbsoluteValue = Math.Abs(array[i, j]);
                }
            }

            // Додавання найбільшого за модулем елемента до кожного елемента масиву
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] += maxAbsoluteValue;
                }
            }
        }
    }
}
