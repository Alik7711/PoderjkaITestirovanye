using System;
using System.Windows.Forms;

namespace SimpleCalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 + num2, "+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 - num2, "-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) => num1 * num2, "*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation((num1, num2) =>
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Ошибка: деление на ноль.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new DivideByZeroException();
                }
                return num1 / num2;
            }, "/");
        }

        private void PerformOperation(Func<double, double, double> operation, string operationSymbol)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNum1.Text);
                double num2 = Convert.ToDouble(textBoxNum2.Text);
                double result = operation(num1, num2);

                labelResult.Text = $"Результат: {num1} {operationSymbol} {num2} = {result}";
                DebugInfo($"Выполнена операция: {num1} {operationSymbol} {num2} = {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DebugInfo("Ошибка: неверный формат числа");
            }
            catch (DivideByZeroException)
            {
                labelResult.Text = "Результат: Ошибка деления на ноль";
                DebugInfo("Попытка деления на ноль");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DebugInfo($"Исключение: {ex.GetType().Name} - {ex.Message}");
            }
        }

        private void DebugInfo(string message)
        {
            Console.WriteLine($"[Debug] {DateTime.Now:HH:mm:ss}: {message}");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
            labelResult.Text = "Результат: ";
            DebugInfo("Поля очищены");
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                DebugInfo($"textBoxNum1 изменен: {textBoxNum1.Text}");
            }
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                DebugInfo($"textBoxNum2 изменен: {textBoxNum2.Text}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClear_Click(sender, e);
        }
    }
}