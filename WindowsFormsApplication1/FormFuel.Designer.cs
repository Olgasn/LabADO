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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewFuels = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFindFuelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxFuelDensity = new System.Windows.Forms.TextBox();
            this.textBoxFuelId = new System.Windows.Forms.TextBox();
            this.textBoxFuelType = new System.Windows.Forms.TextBox();
            this.labelFuelDensity = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelFuelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(37, 385);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(103, 23);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 385);
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
            // dataGridViewFuels
            // 
            this.dataGridViewFuels.AllowUserToOrderColumns = true;
            this.dataGridViewFuels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuels.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewFuels.Name = "dataGridViewFuels";
            this.dataGridViewFuels.Size = new System.Drawing.Size(461, 311);
            this.dataGridViewFuels.TabIndex = 0;
            this.dataGridViewFuels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuels_CellClick);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(356, 9);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(117, 23);
            this.buttonDisplay.TabIndex = 8;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(146, 11);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(204, 20);
            this.textBoxFind.TabIndex = 11;
            // 
            // labelFindFuelType
            // 
            this.labelFindFuelType.AutoSize = true;
            this.labelFindFuelType.Location = new System.Drawing.Point(70, 11);
            this.labelFindFuelType.Name = "labelFindFuelType";
            this.labelFindFuelType.Size = new System.Drawing.Size(70, 13);
            this.labelFindFuelType.TabIndex = 12;
            this.labelFindFuelType.Text = "Вид топлива";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(551, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Сохранить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.labelFuelDensity);
            this.groupBoxAdd.Controls.Add(this.labelFuelType);
            this.groupBoxAdd.Controls.Add(this.labelFuelId);
            this.groupBoxAdd.Controls.Add(this.textBoxFuelId);
            this.groupBoxAdd.Controls.Add(this.textBoxFuelType);
            this.groupBoxAdd.Controls.Add(this.textBoxFuelDensity);
            this.groupBoxAdd.Location = new System.Drawing.Point(479, 242);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(245, 177);
            this.groupBoxAdd.TabIndex = 20;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавить данные";
            // 
            // textBoxFuelDensity
            // 
            this.textBoxFuelDensity.Location = new System.Drawing.Point(115, 100);
            this.textBoxFuelDensity.Name = "textBoxFuelDensity";
            this.textBoxFuelDensity.Size = new System.Drawing.Size(114, 20);
            this.textBoxFuelDensity.TabIndex = 24;
            // 
            // textBoxFuelId
            // 
            this.textBoxFuelId.Enabled = false;
            this.textBoxFuelId.Location = new System.Drawing.Point(115, 26);
            this.textBoxFuelId.Name = "textBoxFuelId";
            this.textBoxFuelId.Size = new System.Drawing.Size(114, 20);
            this.textBoxFuelId.TabIndex = 31;
            // 
            // textBoxFuelType
            // 
            this.textBoxFuelType.Location = new System.Drawing.Point(115, 59);
            this.textBoxFuelType.Name = "textBoxFuelType";
            this.textBoxFuelType.Size = new System.Drawing.Size(114, 20);
            this.textBoxFuelType.TabIndex = 30;
            // 
            // labelFuelDensity
            // 
            this.labelFuelDensity.AutoSize = true;
            this.labelFuelDensity.Location = new System.Drawing.Point(4, 100);
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
            // labelFuelId
            // 
            this.labelFuelId.AutoSize = true;
            this.labelFuelId.Location = new System.Drawing.Point(6, 26);
            this.labelFuelId.Name = "labelFuelId";
            this.labelFuelId.Size = new System.Drawing.Size(70, 13);
            this.labelFuelId.TabIndex = 32;
            this.labelFuelId.Text = "Код топлива";
            // 
            // FormFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(727, 431);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFindFuelType);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewFuels);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "FormFuel";
            this.Text = "Топливо";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox textBoxFuelDensity;
        private System.Windows.Forms.TextBox textBoxFuelId;
        private System.Windows.Forms.TextBox textBoxFuelType;
        private System.Windows.Forms.Label labelFuelDensity;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelFuelId;
    }
}

