namespace ex2_game.fly_
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
            this.components = new System.ComponentModel.Container();
            this.fly = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fly
            // 
            this.fly.Location = new System.Drawing.Point(363, 185);
            this.fly.Name = "fly";
            this.fly.Size = new System.Drawing.Size(62, 52);
            this.fly.TabIndex = 0;
            this.fly.UseVisualStyleBackColor = true;
            this.fly.Click += new System.EventHandler(this.fly_Click);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(3, 9);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(59, 13);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "your score:";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(712, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(49, 13);
            this.timelabel.TabIndex = 2;
            this.timelabel.Text = "time left: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.fly);
            this.Name = "Form1";
            this.Text = "Game of fly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fly;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label timelabel;
    }
}

