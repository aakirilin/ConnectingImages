namespace ConnectingImages
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
            this.openImgSeq = new System.Windows.Forms.Button();
            this.selectOutFile = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openImgSeq
            // 
            this.openImgSeq.Location = new System.Drawing.Point(217, 12);
            this.openImgSeq.Name = "openImgSeq";
            this.openImgSeq.Size = new System.Drawing.Size(199, 40);
            this.openImgSeq.TabIndex = 0;
            this.openImgSeq.Text = "2. Открыть последовательность изображений";
            this.openImgSeq.UseVisualStyleBackColor = true;
            this.openImgSeq.Click += new System.EventHandler(this.openImgSeq_Click);
            // 
            // selectOutFile
            // 
            this.selectOutFile.Location = new System.Drawing.Point(12, 12);
            this.selectOutFile.Name = "selectOutFile";
            this.selectOutFile.Size = new System.Drawing.Size(199, 40);
            this.selectOutFile.TabIndex = 1;
            this.selectOutFile.Text = "1. Выходной файл";
            this.selectOutFile.UseVisualStyleBackColor = true;
            this.selectOutFile.Click += new System.EventHandler(this.selectOutFile_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 58);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(404, 23);
            this.progressBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 91);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.selectOutFile);
            this.Controls.Add(this.openImgSeq);
            this.MaximumSize = new System.Drawing.Size(444, 130);
            this.MinimumSize = new System.Drawing.Size(444, 130);
            this.Name = "Form1";
            this.Text = "Соединить изображения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openImgSeq;
        private System.Windows.Forms.Button selectOutFile;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

