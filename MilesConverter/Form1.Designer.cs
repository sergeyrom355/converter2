namespace MilesConverter
{
    partial class MainWindow
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
            this.MilesTextBox = new System.Windows.Forms.TextBox();
            this.MilesLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MilesTextBox
            // 
            this.MilesTextBox.Location = new System.Drawing.Point(25, 33);
            this.MilesTextBox.Name = "MilesTextBox";
            this.MilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MilesTextBox.TabIndex = 0;
            // 
            // MilesLabel
            // 
            this.MilesLabel.AutoSize = true;
            this.MilesLabel.Location = new System.Drawing.Point(131, 40);
            this.MilesLabel.Name = "MilesLabel";
            this.MilesLabel.Size = new System.Drawing.Size(33, 13);
            this.MilesLabel.TabIndex = 1;
            this.MilesLabel.Text = "миль";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(22, 144);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.AnswerLabel.TabIndex = 2;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(25, 87);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Перевести";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 293);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.MilesLabel);
            this.Controls.Add(this.MilesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Мили в километры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MilesTextBox;
        private System.Windows.Forms.Label MilesLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ConvertButton;
    }
}

