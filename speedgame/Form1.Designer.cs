namespace speedgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mazdarx7 = new System.Windows.Forms.PictureBox();
            this.toyotaae86 = new System.Windows.Forms.PictureBox();
            this.timercars = new System.Windows.Forms.Timer(this.components);
            this.buttonfinish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mazdarx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toyotaae86)).BeginInit();
            this.SuspendLayout();
            // 
            // mazdarx7
            // 
            this.mazdarx7.BackColor = System.Drawing.Color.Transparent;
            this.mazdarx7.Image = ((System.Drawing.Image)(resources.GetObject("mazdarx7.Image")));
            this.mazdarx7.Location = new System.Drawing.Point(-9, 341);
            this.mazdarx7.Name = "mazdarx7";
            this.mazdarx7.Size = new System.Drawing.Size(207, 134);
            this.mazdarx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mazdarx7.TabIndex = 0;
            this.mazdarx7.TabStop = false;
            this.mazdarx7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toyotaae86
            // 
            this.toyotaae86.BackColor = System.Drawing.Color.Transparent;
            this.toyotaae86.Image = ((System.Drawing.Image)(resources.GetObject("toyotaae86.Image")));
            this.toyotaae86.Location = new System.Drawing.Point(-9, 247);
            this.toyotaae86.Name = "toyotaae86";
            this.toyotaae86.Size = new System.Drawing.Size(207, 133);
            this.toyotaae86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toyotaae86.TabIndex = 1;
            this.toyotaae86.TabStop = false;
            this.toyotaae86.Click += new System.EventHandler(this.toyotaae86_Click);
            // 
            // timercars
            // 
            this.timercars.Tick += new System.EventHandler(this.timercars_Tick);
            // 
            // buttonfinish
            // 
            this.buttonfinish.Enabled = false;
            this.buttonfinish.Location = new System.Drawing.Point(775, 0);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(10, 448);
            this.buttonfinish.TabIndex = 2;
            this.buttonfinish.Text = "button1";
            this.buttonfinish.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toyotaae86);
            this.Controls.Add(this.mazdarx7);
            this.Controls.Add(this.buttonfinish);
            this.Name = "Form1";
            this.Text = "NFC JDM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mazdarx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toyotaae86)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mazdarx7;
        private System.Windows.Forms.PictureBox toyotaae86;
        private System.Windows.Forms.Timer timercars;
        private System.Windows.Forms.Button buttonfinish;
        private System.Windows.Forms.Button button1;
    }
}

