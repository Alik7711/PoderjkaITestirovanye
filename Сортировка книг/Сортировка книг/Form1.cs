using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SortirovkaKnig
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks;

        public Form1()
        {
            tasks = new List<TaskItem>();
            InitializeComponent();
        }

        private void TextBoxTask_Enter(object sender, EventArgs e)
        {
            if (textBoxTask.Text == "Введите название книги...")
            {
                textBoxTask.Text = "";
                textBoxTask.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBoxTask_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                textBoxTask.Text = "Введите название книги...";
                textBoxTask.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string taskText = textBoxTask.Text.Trim();

            if (string.IsNullOrEmpty(taskText) || taskText == "Введите название книги...")
            {
                MessageBox.Show("Пожалуйста, введите название книги!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (taskText.Length > 100)
            {
                MessageBox.Show("Название книги не должно превышать 100 символов!",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            TaskItem newTask = new TaskItem(taskText);
            tasks.Add(newTask);

            textBoxTask.Text = "Введите название книги...";
            textBoxTask.ForeColor = System.Drawing.Color.Gray;

            RefreshTaskList();

            labelStatus.Text = "Книга \"" + taskText + "\" добавлена! Всего книг: " + tasks.Count;
            labelStatus.ForeColor = System.Drawing.Color.Green;

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) => {
                labelStatus.ForeColor = System.Drawing.Color.Black;
                labelStatus.Text = "Готово к работе. Книг в списке: " + tasks.Count;
                timer.Stop();
            };
            timer.Start();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;

            DialogResult result = MessageBox.Show("Удалить книгу \"" + selectedTask.Name + "\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tasks.Remove(selectedTask);
                RefreshTaskList();
                labelStatus.Text = "Книга удалена! Осталось книг: " + tasks.Count;
                labelStatus.ForeColor = System.Drawing.Color.Orange;

                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) => {
                    labelStatus.ForeColor = System.Drawing.Color.Black;
                    labelStatus.Text = "Готово к работе. Книг в списке: " + tasks.Count;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для отметки о прочтении!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;
            selectedTask.IsCompleted = !selectedTask.IsCompleted;

            RefreshTaskList();

            string status = selectedTask.IsCompleted ? "прочитана" : "не прочитана";
            labelStatus.Text = "Книга отмечена как " + status + "!";
            labelStatus.ForeColor = System.Drawing.Color.Blue;

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) => {
                labelStatus.ForeColor = System.Drawing.Color.Black;
                labelStatus.Text = "Готово к работе. Книг в списке: " + tasks.Count;
                timer.Stop();
            };
            timer.Start();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            string sortOption = comboBoxSort.SelectedItem.ToString();

            switch (sortOption)
            {
                case "По названию (А-Я)":
                    tasks = tasks.OrderBy(t => t.Name).ToList();
                    break;
                case "По названию (Я-А)":
                    tasks = tasks.OrderByDescending(t => t.Name).ToList();
                    break;
                case "Сначала прочитанные":
                    tasks = tasks.OrderByDescending(t => t.IsCompleted).ThenBy(t => t.Name).ToList();
                    break;
                case "Сначала непрочитанные":
                    tasks = tasks.OrderBy(t => t.IsCompleted).ThenBy(t => t.Name).ToList();
                    break;
                default:
                    tasks = tasks.OrderBy(t => t.CreatedDate).ToList();
                    break;
            }

            RefreshTaskList();

            labelStatus.Text = "Применена сортировка: " + sortOption;
            labelStatus.ForeColor = System.Drawing.Color.Purple;

            MessageBox.Show("Сортировка выполнена!\n\nВыбранный вариант: " + sortOption + "\n\nКниг в списке: " + tasks.Count,
                "Сортировка завершена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) => {
                labelStatus.ForeColor = System.Drawing.Color.Black;
                labelStatus.Text = "Готово к работе. Книг в списке: " + tasks.Count;
                timer.Stop();
            };
            timer.Start();
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task);
            }
            listBoxTasks.Invalidate();
        }

        private void ListBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            TaskItem task = (TaskItem)listBoxTasks.Items[e.Index];

            e.DrawBackground();

            if (task.IsCompleted)
            {
                using (Brush brush = new SolidBrush(System.Drawing.Color.Gray))
                using (Font strikeFont = new Font(e.Font, FontStyle.Strikeout))
                {
                    e.Graphics.DrawString(task.Name, strikeFont, brush, e.Bounds);
                }
            }
            else
            {
                using (Brush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(task.Name, e.Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }

    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public TaskItem(string name)
        {
            Name = name;
            IsCompleted = false;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return IsCompleted ? "[X] " + Name : "[ ] " + Name;
        }
    }
}