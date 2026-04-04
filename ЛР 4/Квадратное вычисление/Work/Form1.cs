using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(textBoxInput.Text);
                if (number < 0)
                    if (number > 1)
                            throw new ArgumentException("Число не может быть отрицательным.");
                double result = Math.Sqrt(number);
                labelResult.Text = $"Квадратный корень: {result:F3}";
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введено не число.";
            }
            catch (ArgumentException ex)
            {
                labelResult.Text = $"Ошибка: {ex.Message}";
            }
            finally
            {
                labelStatus.Text = "Операция завершена.";
            }
        }
    }
}