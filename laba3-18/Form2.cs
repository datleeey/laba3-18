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
    public partial class Form2 : Form
    {
        private int[] array; // Одновимірний масив
        private int N; // Розмір масиву

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Перевірка, чи введено коректне число
            if (int.TryParse(textBox1.Text, out int result))
            {
                N = result;
            }
            else
            {
                MessageBox.Show("Введіть ціле число для розміру масиву.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Генерація масиву випадкових чисел
            Random random = new Random();
            array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(1, 100); // Випадкові числа від 1 до 100
            }
            DisplayArray(array); // Виведення масиву
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Збільшення елементів масиву в 2 рази
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив.");
                return;
            }

            for (int i = 0; i < N; i++)
            {
                array[i] *= 2;
            }
            DisplayArray(array); // Виведення оновленого масиву
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Виведення масиву у зворотному порядку
            if (array == null)
            {
                MessageBox.Show("Спочатку згенеруйте масив.");
                return;
            }

            int[] reversedArray = array.Reverse().ToArray();
            DisplayArray(reversedArray); // Виведення зворотного масиву
        }

        private void DisplayArray(int[] arr)
        {
            // Метод для відображення масиву в DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = arr.Length;
            dataGridView1.RowCount = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView1[i, 0].Value = arr[i];
            }
        }
    }
}
