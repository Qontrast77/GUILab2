using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Проверка на то, что значение n введено правильно
            if (int.TryParse(txtN.Text, out int n))
            {
                string[] input = txtSequence.Text.Split();
                List<int> sequence = new List<int>();

                // Преобразуем строковые значения в числа и добавляем в список
                foreach (var item in input)
                {
                    if (int.TryParse(item, out int number))
                    {
                        sequence.Add(number);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: Введите только числа.");
                        return;
                    }
                }

                // Вызываем метод для поиска последовательности
                string result = Logic.FindNeighbourNumbers(sequence, n);

                // Выводим результат на форму
                lblResult.Text = result;
            }
            else
            {
                MessageBox.Show("Ошибка: Введите правильное значение для n.");
            }
        }
    }

    // Логика поиска последовательности одинаковых чисел
    public class Logic
    {
        public static string FindNeighbourNumbers(List<int> sequence, int n)
        {
            // Проверка на отрицательные или нулевые значения
            if (n <= 0)
            {
                return "Ошибка: Число n должно быть больше 0.";
            }

            // Поиск последовательности одинаковых чисел
            for (int i = 0; i <= sequence.Count - n; i++)
            {
                bool found = true;

                for (int j = i + 1; j < i + n; j++)
                {
                    if (sequence[j] != sequence[i])
                    {
                        found = false;
                        break;
                    }
                }

                // Если найдена последовательность одинаковых чисел
                if (found)
                {
                    return $"Найдена последовательность из {n} одинаковых чисел, начиная с позиции {i + 1}.";
                }
            }

            // Если последовательность не найдена
            return "Не найдено последовательности из одинаковых соседних чисел.";
        }
    }
}
