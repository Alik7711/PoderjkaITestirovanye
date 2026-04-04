namespace Work
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqrt = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(12, 12);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(200, 20);
            this.sqrt.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(9, 44);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(203, 28);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "label1";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 103);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(200, 53);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "Вычислить";
            this.textBoxInput.UseVisualStyleBackColor = true;
            this.textBoxInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(9, 72);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(200, 28);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 171);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.sqrt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqrt;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button textBoxInput;
        private System.Windows.Forms.Label labelStatus;
    }
}

