namespace HostsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1 = new System.Windows.Forms.RichTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.defaultTb = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(12, 5);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(250, 600);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "";
            // 
            // savebtn
            // 
            this.savebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebtn.Location = new System.Drawing.Point(268, 233);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(98, 70);
            this.savebtn.TabIndex = 1;
            this.savebtn.Text = "Save Changes";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(268, 81);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(98, 70);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset Changes";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // tb2
            // 
            this.tb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2.Location = new System.Drawing.Point(372, 5);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(450, 600);
            this.tb2.TabIndex = 3;
            this.tb2.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(268, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(98, 70);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add To Hosts-->>";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // defaultTb
            // 
            this.defaultTb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.defaultTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultTb.Location = new System.Drawing.Point(268, 157);
            this.defaultTb.Name = "defaultTb";
            this.defaultTb.Size = new System.Drawing.Size(98, 70);
            this.defaultTb.TabIndex = 5;
            this.defaultTb.Text = "Load Default Hosts";
            this.defaultTb.UseVisualStyleBackColor = true;
            this.defaultTb.Click += new System.EventHandler(this.defaultTb_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBtn.Location = new System.Drawing.Point(268, 530);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(98, 70);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.defaultTb);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.tb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostsEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RichTextBox tb2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button defaultTb;
        private System.Windows.Forms.Button aboutBtn;
    }
}

