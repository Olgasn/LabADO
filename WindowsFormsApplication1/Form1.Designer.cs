﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFill = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(129, 215);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(163, 23);
            this.buttonFill.TabIndex = 1;
            this.buttonFill.Text = "Выполнить и отобразить";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(12, 22);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCommand.Size = new System.Drawing.Size(474, 187);
            this.textBoxCommand.TabIndex = 2;
            this.textBoxCommand.Text = resources.GetString("textBoxCommand.Text");
            this.textBoxCommand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(289, 311);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(555, 260);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(306, 311);
            this.dataGridView3.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(491, 101);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(408, 107);
            this.labelInfo.TabIndex = 5;
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(494, 39);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(367, 20);
            this.textBoxConnectionString.TabIndex = 6;
            this.textBoxConnectionString.Text = "Data Source=.\\sqlexpress;Initial Catalog=toplivo;Integrated Security=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "строка подключения к базе данных:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(888, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnectionString);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Топливо";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label1;
    }
}

