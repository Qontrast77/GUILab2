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

        // ���������� ��� ������
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // �������� �� ��, ��� �������� n ������� ���������
            if (int.TryParse(txtN.Text, out int n))
            {
                string[] input = txtSequence.Text.Split();
                List<int> sequence = new List<int>();

                // ����������� ��������� �������� � ����� � ��������� � ������
                foreach (var item in input)
                {
                    if (int.TryParse(item, out int number))
                    {
                        sequence.Add(number);
                    }
                    else
                    {
                        MessageBox.Show("������: ������� ������ �����.");
                        return;
                    }
                }

                // �������� ����� ��� ������ ������������������
                string result = Logic.FindNeighbourNumbers(sequence, n);

                // ������� ��������� �� �����
                lblResult.Text = result;
            }
            else
            {
                MessageBox.Show("������: ������� ���������� �������� ��� n.");
            }
        }
    }

    // ������ ������ ������������������ ���������� �����
    public class Logic
    {
        public static string FindNeighbourNumbers(List<int> sequence, int n)
        {
            // �������� �� ������������� ��� ������� ��������
            if (n <= 0)
            {
                return "������: ����� n ������ ���� ������ 0.";
            }

            // ����� ������������������ ���������� �����
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

                // ���� ������� ������������������ ���������� �����
                if (found)
                {
                    return $"������� ������������������ �� {n} ���������� �����, ������� � ������� {i + 1}.";
                }
            }

            // ���� ������������������ �� �������
            return "�� ������� ������������������ �� ���������� �������� �����.";
        }
    }
}
