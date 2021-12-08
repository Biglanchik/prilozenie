
namespace zametki
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
            this.dobavit = new System.Windows.Forms.Button();
            this.zagr = new System.Windows.Forms.Button();
            this.sohr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dobavit
            // 
            this.dobavit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dobavit.Location = new System.Drawing.Point(713, 24);
            this.dobavit.Name = "dobavit";
            this.dobavit.Size = new System.Drawing.Size(75, 23);
            this.dobavit.TabIndex = 0;
            this.dobavit.Text = "Добавить";
            this.dobavit.UseVisualStyleBackColor = true;
            this.dobavit.Click += new System.EventHandler(this.dobavit_Click);
            // 
            // zagr
            // 
            this.zagr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zagr.Location = new System.Drawing.Point(713, 105);
            this.zagr.Name = "zagr";
            this.zagr.Size = new System.Drawing.Size(75, 23);
            this.zagr.TabIndex = 1;
            this.zagr.Text = "Загрузить";
            this.zagr.UseVisualStyleBackColor = true;
            // 
            // sohr
            // 
            this.sohr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sohr.Location = new System.Drawing.Point(713, 64);
            this.sohr.Name = "sohr";
            this.sohr.Size = new System.Drawing.Size(75, 23);
            this.sohr.TabIndex = 2;
            this.sohr.Text = "Сохранить";
            this.sohr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sohr);
            this.Controls.Add(this.zagr);
            this.Controls.Add(this.dobavit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dobavit;
        private System.Windows.Forms.Button zagr;
        private System.Windows.Forms.Button sohr;
    }
}

