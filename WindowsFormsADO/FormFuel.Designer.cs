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
            buttonUpdate = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            labelInfo = new System.Windows.Forms.Label();
            dataGridViewFuels = new System.Windows.Forms.DataGridView();
            buttonDisplay = new System.Windows.Forms.Button();
            textBoxFind = new System.Windows.Forms.TextBox();
            labelFindFuelType = new System.Windows.Forms.Label();
            buttonAddRecord = new System.Windows.Forms.Button();
            groupBoxForChange = new System.Windows.Forms.GroupBox();
            buttonUpdateRecord = new System.Windows.Forms.Button();
            labelFuelDensity = new System.Windows.Forms.Label();
            labelFuelType = new System.Windows.Forms.Label();
            labelFuelId = new System.Windows.Forms.Label();
            c0 = new System.Windows.Forms.TextBox();
            c1 = new System.Windows.Forms.TextBox();
            c2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
            groupBoxForChange.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(226, 611);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(199, 35);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Сохранить изменения";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(16, 610);
            buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(161, 35);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // labelInfo
            // 
            labelInfo.Location = new System.Drawing.Point(639, 14);
            labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelInfo.Size = new System.Drawing.Size(391, 352);
            labelInfo.TabIndex = 5;
            // 
            // dataGridViewFuels
            // 
            dataGridViewFuels.AllowUserToAddRows = false;
            dataGridViewFuels.AllowUserToOrderColumns = true;
            dataGridViewFuels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuels.Location = new System.Drawing.Point(16, 62);
            dataGridViewFuels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dataGridViewFuels.Name = "dataGridViewFuels";
            dataGridViewFuels.RowHeadersWidth = 51;
            dataGridViewFuels.Size = new System.Drawing.Size(615, 520);
            dataGridViewFuels.TabIndex = 0;
            dataGridViewFuels.CellClick += DataGridViewFuels_CellClick;
            dataGridViewFuels.ColumnHeaderMouseClick += DataGridViewFuels_ColumnHeaderMouseClick;
            dataGridViewFuels.SelectionChanged += DataGridViewFuels_SelectionChanged;
            // 
            // buttonDisplay
            // 
            buttonDisplay.Location = new System.Drawing.Point(405, 19);
            buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new System.Drawing.Size(156, 35);
            buttonDisplay.TabIndex = 8;
            buttonDisplay.Text = "Отобразить";
            buttonDisplay.UseVisualStyleBackColor = true;
            buttonDisplay.Click += ButtonDisplay_Click;
            // 
            // textBoxFind
            // 
            textBoxFind.Location = new System.Drawing.Point(125, 21);
            textBoxFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.Size = new System.Drawing.Size(271, 27);
            textBoxFind.TabIndex = 11;
            // 
            // labelFindFuelType
            // 
            labelFindFuelType.AutoSize = true;
            labelFindFuelType.Location = new System.Drawing.Point(24, 21);
            labelFindFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFindFuelType.Name = "labelFindFuelType";
            labelFindFuelType.Size = new System.Drawing.Size(96, 20);
            labelFindFuelType.TabIndex = 12;
            labelFindFuelType.Text = "Вид топлива";
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new System.Drawing.Point(12, 220);
            buttonAddRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new System.Drawing.Size(145, 35);
            buttonAddRecord.TabIndex = 13;
            buttonAddRecord.Text = "Добавить";
            buttonAddRecord.UseVisualStyleBackColor = true;
            buttonAddRecord.Click += ButtonAdd_Click;
            // 
            // groupBoxForChange
            // 
            groupBoxForChange.Controls.Add(buttonUpdateRecord);
            groupBoxForChange.Controls.Add(buttonAddRecord);
            groupBoxForChange.Controls.Add(labelFuelDensity);
            groupBoxForChange.Controls.Add(labelFuelType);
            groupBoxForChange.Controls.Add(labelFuelId);
            groupBoxForChange.Controls.Add(c0);
            groupBoxForChange.Controls.Add(c1);
            groupBoxForChange.Controls.Add(c2);
            groupBoxForChange.Location = new System.Drawing.Point(639, 372);
            groupBoxForChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxForChange.Name = "groupBoxForChange";
            groupBoxForChange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxForChange.Size = new System.Drawing.Size(391, 272);
            groupBoxForChange.TabIndex = 20;
            groupBoxForChange.TabStop = false;
            groupBoxForChange.Text = "Изменить данные";
            // 
            // buttonUpdateRecord
            // 
            buttonUpdateRecord.Location = new System.Drawing.Point(167, 220);
            buttonUpdateRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonUpdateRecord.Name = "buttonUpdateRecord";
            buttonUpdateRecord.Size = new System.Drawing.Size(197, 35);
            buttonUpdateRecord.TabIndex = 35;
            buttonUpdateRecord.Text = "Сохранить изменения";
            buttonUpdateRecord.UseVisualStyleBackColor = true;
            buttonUpdateRecord.Click += ButtonUpdateRecord_Click;
            // 
            // labelFuelDensity
            // 
            labelFuelDensity.AutoSize = true;
            labelFuelDensity.Location = new System.Drawing.Point(5, 154);
            labelFuelDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFuelDensity.Name = "labelFuelDensity";
            labelFuelDensity.Size = new System.Drawing.Size(143, 20);
            labelFuelDensity.TabIndex = 34;
            labelFuelDensity.Text = "Плотность топлива";
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new System.Drawing.Point(5, 95);
            labelFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new System.Drawing.Size(138, 20);
            labelFuelType.TabIndex = 33;
            labelFuelType.Text = "Название топлива";
            // 
            // labelFuelId
            // 
            labelFuelId.AutoSize = true;
            labelFuelId.Location = new System.Drawing.Point(8, 40);
            labelFuelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFuelId.Name = "labelFuelId";
            labelFuelId.Size = new System.Drawing.Size(96, 20);
            labelFuelId.TabIndex = 32;
            labelFuelId.Text = "Код топлива";
            // 
            // c0
            // 
            c0.Enabled = false;
            c0.Location = new System.Drawing.Point(153, 40);
            c0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c0.Name = "c0";
            c0.Size = new System.Drawing.Size(130, 27);
            c0.TabIndex = 31;
            // 
            // c1
            // 
            c1.Location = new System.Drawing.Point(153, 91);
            c1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1.Name = "c1";
            c1.Size = new System.Drawing.Size(211, 27);
            c1.TabIndex = 30;
            // 
            // c2
            // 
            c2.Location = new System.Drawing.Point(153, 154);
            c2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c2.Name = "c2";
            c2.Size = new System.Drawing.Size(211, 27);
            c2.TabIndex = 24;
            // 
            // FormFuel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1043, 664);
            Controls.Add(labelFindFuelType);
            Controls.Add(textBoxFind);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDisplay);
            Controls.Add(labelInfo);
            Controls.Add(dataGridViewFuels);
            Controls.Add(groupBoxForChange);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormFuel";
            Text = "Топливо";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
            groupBoxForChange.ResumeLayout(false);
            groupBoxForChange.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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

