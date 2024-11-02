using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Обробляємо рядки, щоб знайти мінімальні елементи та замінити значення рядків
            ProcessRows();
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
                    array[i, j] = rand.Next(1, 100); // Випадкові значення від 1 до 100
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

        private void ProcessRows()
        {
            // Знаходження мінімального елемента в кожному рядку та заміна всіх елементів на мінімальний
            for (int i = 0; i < rows; i++)
            {
                int min = array[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                }
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = min;
                }
            }
        }
    }
}
