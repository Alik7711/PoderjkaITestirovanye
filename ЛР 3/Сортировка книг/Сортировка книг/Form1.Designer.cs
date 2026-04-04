namespace SortirovkaKnig
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.White;
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 25;
            this.listBoxTasks.Location = new System.Drawing.Point(0, 89);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(513, 269);
            this.listBoxTasks.TabIndex = 2;
            this.listBoxTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxTasks_DrawItem);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTask.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTask.Location = new System.Drawing.Point(9, 49);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(361, 26);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Введите название книги...";
            this.textBoxTask.Enter += new System.EventHandler(this.TextBoxTask_Enter);
            this.textBoxTask.Leave += new System.EventHandler(this.TextBoxTask_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(374, 46);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить книгу";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Location = new System.Drawing.Point(10, 16);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 25);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonComplete
            // 
            this.buttonComplete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonComplete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonComplete.Location = new System.Drawing.Point(119, 16);
            this.buttonComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(135, 25);
            this.buttonComplete.TabIndex = 1;
            this.buttonComplete.Text = "Отметить как прочитано";
            this.buttonComplete.UseVisualStyleBackColor = false;
            this.buttonComplete.Click += new System.EventHandler(this.ButtonComplete_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSort.Location = new System.Drawing.Point(398, 15);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(105, 26);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSort.Items.AddRange(new object[] {
            "По умолчанию",
            "По названию (А-Я)",
            "По названию (Я-А)",
            "Сначала прочитанные",
            "Сначала непрочитанные"});
            this.comboBoxSort.Location = new System.Drawing.Point(258, 16);
            this.comboBoxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(136, 24);
            this.comboBoxSort.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelStatus.Location = new System.Drawing.Point(9, 53);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(201, 15);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Готово к работе. Книг в списке: 0";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(9, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(225, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Сортировка книг";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.textBoxTask);
            this.panelTop.Controls.Add(this.buttonAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(513, 89);
            this.panelTop.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.comboBoxSort);
            this.panelBottom.Controls.Add(this.buttonSort);
            this.panelBottom.Controls.Add(this.buttonComplete);
            this.panelBottom.Controls.Add(this.buttonDelete);
            this.panelBottom.Controls.Add(this.labelStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 358);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(513, 98);
            this.panelBottom.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 456);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(529, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка книг";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
    }
}