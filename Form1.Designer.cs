namespace Paladyn
{
    partial class frmMain
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
            this.bAddThread = new System.Windows.Forms.Button();
            this.lbThread = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAddThread
            // 
            this.bAddThread.Location = new System.Drawing.Point(12, 12);
            this.bAddThread.Name = "bAddThread";
            this.bAddThread.Size = new System.Drawing.Size(235, 44);
            this.bAddThread.TabIndex = 1;
            this.bAddThread.Text = "New thread";
            this.bAddThread.UseVisualStyleBackColor = true;
            // 
            // lbThread
            // 
            this.lbThread.FormattingEnabled = true;
            this.lbThread.Location = new System.Drawing.Point(12, 62);
            this.lbThread.Name = "lbThread";
            this.lbThread.Size = new System.Drawing.Size(235, 342);
            this.lbThread.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.lbThread);
            this.Controls.Add(this.bAddThread);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paladyn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddThread;
        private System.Windows.Forms.ListBox lbThread;
    }
}

