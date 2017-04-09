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
            this.textBoxFindFuels = new System.Windows.Forms.TextBox();
            this.labelFindFuelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).BeginInit();
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
            this.labelInfo.Size = new System.Drawing.Size(222, 354);
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
            // textBoxFindFuels
            // 
            this.textBoxFindFuels.Location = new System.Drawing.Point(146, 11);
            this.textBoxFindFuels.Name = "textBoxFindFuels";
            this.textBoxFindFuels.Size = new System.Drawing.Size(204, 20);
            this.textBoxFindFuels.TabIndex = 11;
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
            this.buttonAdd.Location = new System.Drawing.Point(325, 385);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(716, 431);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFindFuelType);
            this.Controls.Add(this.textBoxFindFuels);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewFuels);
            this.Name = "FormFuel";
            this.Text = "Топливо";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewFuels;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.TextBox textBoxFindFuels;
        private System.Windows.Forms.Label labelFindFuelType;
        private System.Windows.Forms.Button buttonAdd;
    }
}

