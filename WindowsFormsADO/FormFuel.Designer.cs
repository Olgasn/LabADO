namespace WindowsFormsADO
{
    partial class FormFuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuel));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewFuels = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFindFuelType = new System.Windows.Forms.Label();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.groupBoxForChange = new System.Windows.Forms.GroupBox();
            this.buttonUpdateRecord = new System.Windows.Forms.Button();
            this.labelFuelDensity = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelFuelId = new System.Windows.Forms.Label();
            this.c0 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).BeginInit();
            this.groupBoxForChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(49, 487);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(137, 28);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(236, 487);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(161, 28);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(639, 11);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(296, 282);
            this.labelInfo.TabIndex = 5;
            // 
            // dataGridViewFuels
            // 
            this.dataGridViewFuels.AllowUserToAddRows = false;
            this.dataGridViewFuels.AllowUserToOrderColumns = true;
            this.dataGridViewFuels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuels.Location = new System.Drawing.Point(16, 50);
            this.dataGridViewFuels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFuels.Name = "dataGridViewFuels";
            this.dataGridViewFuels.RowHeadersWidth = 51;
            this.dataGridViewFuels.Size = new System.Drawing.Size(615, 416);
            this.dataGridViewFuels.TabIndex = 0;
            this.dataGridViewFuels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuels_CellClick);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(405, 15);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(156, 28);
            this.buttonDisplay.TabIndex = 8;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(125, 17);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(271, 22);
            this.textBoxFind.TabIndex = 11;
            // 
            // labelFindFuelType
            // 
            this.labelFindFuelType.AutoSize = true;
            this.labelFindFuelType.Location = new System.Drawing.Point(24, 17);
            this.labelFindFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindFuelType.Name = "labelFindFuelType";
            this.labelFindFuelType.Size = new System.Drawing.Size(91, 17);
            this.labelFindFuelType.TabIndex = 12;
            this.labelFindFuelType.Text = "Вид топлива";
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(12, 176);
            this.buttonAddRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(145, 28);
            this.buttonAddRecord.TabIndex = 13;
            this.buttonAddRecord.Text = "Добавить";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxForChange
            // 
            this.groupBoxForChange.Controls.Add(this.buttonUpdateRecord);
            this.groupBoxForChange.Controls.Add(this.buttonAddRecord);
            this.groupBoxForChange.Controls.Add(this.labelFuelDensity);
            this.groupBoxForChange.Controls.Add(this.labelFuelType);
            this.groupBoxForChange.Controls.Add(this.labelFuelId);
            this.groupBoxForChange.Controls.Add(this.c0);
            this.groupBoxForChange.Controls.Add(this.c1);
            this.groupBoxForChange.Controls.Add(this.c2);
            this.groupBoxForChange.Location = new System.Drawing.Point(639, 298);
            this.groupBoxForChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForChange.Name = "groupBoxForChange";
            this.groupBoxForChange.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForChange.Size = new System.Drawing.Size(327, 218);
            this.groupBoxForChange.TabIndex = 20;
            this.groupBoxForChange.TabStop = false;
            this.groupBoxForChange.Text = "Изменить данные";
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Location = new System.Drawing.Point(167, 176);
            this.buttonUpdateRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateRecord.Name = "buttonUpdateRecord";
            this.buttonUpdateRecord.Size = new System.Drawing.Size(139, 28);
            this.buttonUpdateRecord.TabIndex = 35;
            this.buttonUpdateRecord.Text = "Обновить";
            this.buttonUpdateRecord.UseVisualStyleBackColor = true;
            this.buttonUpdateRecord.Click += new System.EventHandler(this.buttonUpdateRecord_Click);
            // 
            // labelFuelDensity
            // 
            this.labelFuelDensity.AutoSize = true;
            this.labelFuelDensity.Location = new System.Drawing.Point(5, 123);
            this.labelFuelDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFuelDensity.Name = "labelFuelDensity";
            this.labelFuelDensity.Size = new System.Drawing.Size(136, 17);
            this.labelFuelDensity.TabIndex = 34;
            this.labelFuelDensity.Text = "Плотность топлива";
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(5, 76);
            this.labelFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(130, 17);
            this.labelFuelType.TabIndex = 33;
            this.labelFuelType.Text = "Название топлива";
            // 
            // labelFuelId
            // 
            this.labelFuelId.AutoSize = true;
            this.labelFuelId.Location = new System.Drawing.Point(8, 32);
            this.labelFuelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFuelId.Name = "labelFuelId";
            this.labelFuelId.Size = new System.Drawing.Size(91, 17);
            this.labelFuelId.TabIndex = 32;
            this.labelFuelId.Text = "Код топлива";
            // 
            // c0
            // 
            this.c0.Enabled = false;
            this.c0.Location = new System.Drawing.Point(153, 32);
            this.c0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c0.Name = "c0";
            this.c0.Size = new System.Drawing.Size(151, 22);
            this.c0.TabIndex = 31;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(153, 73);
            this.c1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(151, 22);
            this.c1.TabIndex = 30;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(153, 123);
            this.c2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(151, 22);
            this.c2.TabIndex = 24;
            // 
            // FormFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(969, 530);
            this.Controls.Add(this.labelFindFuelType);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewFuels);
            this.Controls.Add(this.groupBoxForChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFuel";
            this.Text = "Топливо";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).EndInit();
            this.groupBoxForChange.ResumeLayout(false);
            this.groupBoxForChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewFuels;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelFindFuelType;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.GroupBox groupBoxForChange;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c0;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Label labelFuelDensity;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelFuelId;
        private System.Windows.Forms.Button buttonUpdateRecord;
    }
}

