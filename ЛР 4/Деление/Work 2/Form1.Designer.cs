namespace Work_2
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
            this.buttonDivide = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxNumerator = new System.Windows.Forms.TextBox();
            this.textBoxDenominator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(12, 64);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(160, 23);
            this.buttonDivide.TabIndex = 0;
            this.buttonDivide.Text = "Деление";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(178, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(160, 20);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "label1";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(178, 38);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(160, 20);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "label1";
            // 
            // textBoxNumerator
            // 
            this.textBoxNumerator.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumerator.Name = "textBoxNumerator";
            this.textBoxNumerator.Size = new System.Drawing.Size(160, 20);
            this.textBoxNumerator.TabIndex = 2;
            // 
            // textBoxDenominator
            // 
            this.textBoxDenominator.Location = new System.Drawing.Point(12, 38);
            this.textBoxDenominator.Name = "textBoxDenominator";
            this.textBoxDenominator.Size = new System.Drawing.Size(160, 20);
            this.textBoxDenominator.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 107);
            this.Controls.Add(this.textBoxDenominator);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxNumerator);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonDivide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxNumerator;
        private System.Windows.Forms.TextBox textBoxDenominator;
    }
}

