﻿namespace WindowsFormsADO
{
    partial class FormOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewOperations = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFindFuelType = new System.Windows.Forms.Label();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.groupBoxForChange = new System.Windows.Forms.GroupBox();
            this.c4 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.labelFuelDensity = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelOperationId = new System.Windows.Forms.Label();
            this.c0 = new System.Windows.Forms.TextBox();
            this.c3 = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).BeginInit();
            this.groupBoxForChange.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 445);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(479, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(222, 229);
            this.labelInfo.TabIndex = 5;
            // 
            // dataGridViewOperations
            // 
            this.dataGridViewOperations.AllowUserToAddRows = false;
            this.dataGridViewOperations.AllowUserToOrderColumns = true;
            this.dataGridViewOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperations.Location = new System.Drawing.Point(0, 72);
            this.dataGridViewOperations.Name = "dataGridViewOperations";
            this.dataGridViewOperations.Size = new System.Drawing.Size(473, 367);
            this.dataGridViewOperations.TabIndex = 0;
            this.dataGridViewOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOperations_CellClick);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(308, 44);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(117, 23);
            this.buttonDisplay.TabIndex = 8;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(98, 46);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(204, 20);
            this.textBoxFind.TabIndex = 11;
            // 
            // labelFindFuelType
            // 
            this.labelFindFuelType.AutoSize = true;
            this.labelFindFuelType.Location = new System.Drawing.Point(22, 46);
            this.labelFindFuelType.Name = "labelFindFuelType";
            this.labelFindFuelType.Size = new System.Drawing.Size(70, 13);
            this.labelFindFuelType.TabIndex = 12;
            this.labelFindFuelType.Text = "Вид топлива";
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(9, 197);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(109, 23);
            this.buttonAddRecord.TabIndex = 13;
            this.buttonAddRecord.Text = "Добавить";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxForChange
            // 
            this.groupBoxForChange.Controls.Add(this.c4);
            this.groupBoxForChange.Controls.Add(this.label2);
            this.groupBoxForChange.Controls.Add(this.c2);
            this.groupBoxForChange.Controls.Add(this.label1);
            this.groupBoxForChange.Controls.Add(this.c1);
            this.groupBoxForChange.Controls.Add(this.buttonUpdateRecord);
            this.groupBoxForChange.Controls.Add(this.buttonAddRecord);
            this.groupBoxForChange.Controls.Add(this.labelFuelDensity);
            this.groupBoxForChange.Controls.Add(this.labelFuelType);
            this.groupBoxForChange.Controls.Add(this.labelOperationId);
            this.groupBoxForChange.Controls.Add(this.c0);
            this.groupBoxForChange.Controls.Add(this.c3);
            this.groupBoxForChange.Location = new System.Drawing.Point(479, 242);
            this.groupBoxForChange.Name = "groupBoxForChange";
            this.groupBoxForChange.Size = new System.Drawing.Size(245, 226);
            this.groupBoxForChange.TabIndex = 20;
            this.groupBoxForChange.TabStop = false;
            this.groupBoxForChange.Text = "Изменить данные";
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(117, 171);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(114, 20);
            this.c4.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Дата";
            // 
            // c2
            // 
            this.c2.FormattingEnabled = true;
            this.c2.Location = new System.Drawing.Point(117, 98);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(114, 21);
            this.c2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Емкость";
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Location = new System.Drawing.Point(115, 62);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(114, 21);
            this.c1.TabIndex = 36;
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Location = new System.Drawing.Point(125, 197);
            this.buttonUpdateRecord.Name = "buttonUpdateRecord";
            this.buttonUpdateRecord.Size = new System.Drawing.Size(104, 23);
            this.buttonUpdateRecord.TabIndex = 35;
            this.buttonUpdateRecord.Text = "Обновить";
            this.buttonUpdateRecord.UseVisualStyleBackColor = true;
            this.buttonUpdateRecord.Click += new System.EventHandler(this.buttonUpdateRecord_Click);
            // 
            // labelFuelDensity
            // 
            this.labelFuelDensity.AutoSize = true;
            this.labelFuelDensity.Location = new System.Drawing.Point(6, 134);
            this.labelFuelDensity.Name = "labelFuelDensity";
            this.labelFuelDensity.Size = new System.Drawing.Size(105, 13);
            this.labelFuelDensity.TabIndex = 34;
            this.labelFuelDensity.Text = "Плотность топлива";
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(4, 62);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(101, 13);
            this.labelFuelType.TabIndex = 33;
            this.labelFuelType.Text = "Название топлива";
            // 
            // labelOperationId
            // 
            this.labelOperationId.AutoSize = true;
            this.labelOperationId.Location = new System.Drawing.Point(6, 26);
            this.labelOperationId.Name = "labelOperationId";
            this.labelOperationId.Size = new System.Drawing.Size(77, 13);
            this.labelOperationId.TabIndex = 32;
            this.labelOperationId.Text = "Код операции";
            this.labelOperationId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // c0
            // 
            this.c0.Enabled = false;
            this.c0.Location = new System.Drawing.Point(115, 26);
            this.c0.Name = "c0";
            this.c0.Size = new System.Drawing.Size(114, 20);
            this.c0.TabIndex = 31;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(117, 134);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(114, 20);
            this.c3.TabIndex = 24;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "Топливо";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Емкости";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelFindFuelType);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewOperations);
            this.Controls.Add(this.groupBoxForChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOperation";
            this.Text = "Операции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).EndInit();
            this.groupBoxForChange.ResumeLayout(false);
            this.groupBoxForChange.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewOperations;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFindFuelType;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.GroupBox groupBoxForChange;
        private System.Windows.Forms.TextBox c3;
        private System.Windows.Forms.TextBox c0;
        private System.Windows.Forms.Label labelFuelDensity;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelOperationId;
        private System.Windows.Forms.Button buttonUpdateRecord;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.ComboBox c2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker c4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

