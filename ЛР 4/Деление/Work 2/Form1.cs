using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double numerator = double.Parse(textBoxNumerator.Text);
                double denominator = double.Parse(textBoxDenominator.Text);

                if (denominator == 0)
                    throw new DivideByZeroException("Деление на ноль невозможно.");

                double result = numerator / denominator;
                labelResult.Text = $"Результат: {result:F4}";
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: Введите корректные числовые значения.";
            }
            catch (DivideByZeroException ex)
            {
                labelResult.Text = $"Ошибка: {ex.Message}";
            }
            finally
            {
                labelStatus.Text = "Операция деления завершена.";
            }
        }
    }
}
