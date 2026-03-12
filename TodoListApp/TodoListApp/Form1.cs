using System;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class Form1 : Form
    {
        private readonly TodoList _todoList;

        public Form1()
        {
            InitializeComponent();
            _todoList = new TodoList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _todoList.AddTask(txtTask.Text);
                UpdateTaskList();
                txtTask.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTasks.SelectedItem != null)
                {
                    _todoList.RemoveTask(listBoxTasks.SelectedItem.ToString());
                    UpdateTaskList();
                }
                else
                {
                    MessageBox.Show("Выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            var tasks = _todoList.GetTasks();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task);
            }
        }
    }
}