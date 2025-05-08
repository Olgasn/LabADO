namespace WindowsFormsADO
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            buttonDelete = new System.Windows.Forms.Button();
            labelInfo = new System.Windows.Forms.Label();
            dataGridViewOperations = new System.Windows.Forms.DataGridView();
            buttonAddRecord = new System.Windows.Forms.Button();
            groupBoxForChange = new System.Windows.Forms.GroupBox();
            c4 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            c2 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            c1 = new System.Windows.Forms.ComboBox();
            buttonUpdateRecord = new System.Windows.Forms.Button();
            labelFuelDensity = new System.Windows.Forms.Label();
            labelFuelType = new System.Windows.Forms.Label();
            labelOperationId = new System.Windows.Forms.Label();
            c0 = new System.Windows.Forms.TextBox();
            c3 = new System.Windows.Forms.TextBox();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            bindingNavigatorOperations = new System.Windows.Forms.BindingNavigator(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            groupBoxFind = new System.Windows.Forms.GroupBox();
            labelTankType = new System.Windows.Forms.Label();
            textBoxFindTank = new System.Windows.Forms.TextBox();
            labelFindFuelType = new System.Windows.Forms.Label();
            textBoxFindFuel = new System.Windows.Forms.TextBox();
            buttonDisplay = new System.Windows.Forms.Button();
            buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).BeginInit();
            groupBoxForChange.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigatorOperations).BeginInit();
            bindingNavigatorOperations.SuspendLayout();
            groupBoxFind.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(16, 713);
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
            labelInfo.Location = new System.Drawing.Point(691, 42);
            labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelInfo.Size = new System.Drawing.Size(396, 325);
            labelInfo.TabIndex = 5;
            // 
            // dataGridViewOperations
            // 
            dataGridViewOperations.AllowUserToAddRows = false;
            dataGridViewOperations.AllowUserToOrderColumns = true;
            dataGridViewOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOperations.Location = new System.Drawing.Point(13, 151);
            dataGridViewOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dataGridViewOperations.Name = "dataGridViewOperations";
            dataGridViewOperations.ReadOnly = true;
            dataGridViewOperations.RowHeadersWidth = 51;
            dataGridViewOperations.Size = new System.Drawing.Size(661, 554);
            dataGridViewOperations.TabIndex = 0;
            dataGridViewOperations.SelectionChanged += DataGridViewOperations_SelectionChanged;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new System.Drawing.Point(0, 302);
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
            groupBoxForChange.Controls.Add(c4);
            groupBoxForChange.Controls.Add(label2);
            groupBoxForChange.Controls.Add(c2);
            groupBoxForChange.Controls.Add(label1);
            groupBoxForChange.Controls.Add(c1);
            groupBoxForChange.Controls.Add(buttonUpdateRecord);
            groupBoxForChange.Controls.Add(buttonAddRecord);
            groupBoxForChange.Controls.Add(labelFuelDensity);
            groupBoxForChange.Controls.Add(labelFuelType);
            groupBoxForChange.Controls.Add(labelOperationId);
            groupBoxForChange.Controls.Add(c0);
            groupBoxForChange.Controls.Add(c3);
            groupBoxForChange.Location = new System.Drawing.Point(682, 372);
            groupBoxForChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxForChange.Name = "groupBoxForChange";
            groupBoxForChange.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxForChange.Size = new System.Drawing.Size(423, 348);
            groupBoxForChange.TabIndex = 20;
            groupBoxForChange.TabStop = false;
            groupBoxForChange.Text = "Изменить данные";
            // 
            // c4
            // 
            c4.Location = new System.Drawing.Point(169, 262);
            c4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c4.Name = "c4";
            c4.Size = new System.Drawing.Size(246, 27);
            c4.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 262);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 20);
            label2.TabIndex = 40;
            label2.Text = "Дата";
            // 
            // c2
            // 
            c2.FormattingEnabled = true;
            c2.Location = new System.Drawing.Point(169, 151);
            c2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c2.Name = "c2";
            c2.Size = new System.Drawing.Size(246, 28);
            c2.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 151);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 37;
            label1.Text = "Емкость";
            // 
            // c1
            // 
            c1.FormattingEnabled = true;
            c1.Location = new System.Drawing.Point(166, 95);
            c1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1.Name = "c1";
            c1.Size = new System.Drawing.Size(249, 28);
            c1.TabIndex = 36;
            // 
            // buttonUpdateRecord
            // 
            buttonUpdateRecord.Location = new System.Drawing.Point(241, 302);
            buttonUpdateRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonUpdateRecord.Name = "buttonUpdateRecord";
            buttonUpdateRecord.Size = new System.Drawing.Size(174, 35);
            buttonUpdateRecord.TabIndex = 35;
            buttonUpdateRecord.Text = "Сохранить изменения";
            buttonUpdateRecord.UseVisualStyleBackColor = true;
            buttonUpdateRecord.Click += ButtonUpdateRecord_Click;
            // 
            // labelFuelDensity
            // 
            labelFuelDensity.AutoSize = true;
            labelFuelDensity.Location = new System.Drawing.Point(21, 206);
            labelFuelDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFuelDensity.Name = "labelFuelDensity";
            labelFuelDensity.Size = new System.Drawing.Size(143, 20);
            labelFuelDensity.TabIndex = 34;
            labelFuelDensity.Text = "Плотность топлива";
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new System.Drawing.Point(18, 95);
            labelFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new System.Drawing.Size(138, 20);
            labelFuelType.TabIndex = 33;
            labelFuelType.Text = "Название топлива";
            // 
            // labelOperationId
            // 
            labelOperationId.AutoSize = true;
            labelOperationId.Location = new System.Drawing.Point(21, 40);
            labelOperationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOperationId.Name = "labelOperationId";
            labelOperationId.Size = new System.Drawing.Size(109, 20);
            labelOperationId.TabIndex = 32;
            labelOperationId.Text = "Код операции";
            labelOperationId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // c0
            // 
            c0.Enabled = false;
            c0.Location = new System.Drawing.Point(166, 40);
            c0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c0.Name = "c0";
            c0.Size = new System.Drawing.Size(101, 27);
            c0.TabIndex = 31;
            // 
            // c3
            // 
            c3.Location = new System.Drawing.Point(169, 206);
            c3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c3.Name = "c3";
            c3.Size = new System.Drawing.Size(246, 27);
            c3.TabIndex = 24;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(73, 24);
            toolStripButton1.Text = "Топливо";
            toolStripButton1.Click += ToolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(70, 24);
            toolStripButton2.Text = "Емкости";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1113, 27);
            toolStrip1.TabIndex = 21;
            toolStrip1.Text = "toolStrip1";
            // 
            // bindingNavigatorOperations
            // 
            bindingNavigatorOperations.AddNewItem = null;
            bindingNavigatorOperations.CountItem = bindingNavigatorCountItem;
            bindingNavigatorOperations.DeleteItem = null;
            bindingNavigatorOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            bindingNavigatorOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            bindingNavigatorOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2 });
            bindingNavigatorOperations.Location = new System.Drawing.Point(0, 753);
            bindingNavigatorOperations.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigatorOperations.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigatorOperations.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigatorOperations.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigatorOperations.Name = "bindingNavigatorOperations";
            bindingNavigatorOperations.PositionItem = bindingNavigatorPositionItem;
            bindingNavigatorOperations.Size = new System.Drawing.Size(1113, 27);
            bindingNavigatorOperations.TabIndex = 22;
            bindingNavigatorOperations.Text = "bindingNavigatorOperations";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            bindingNavigatorCountItem.Text = "из {0}";
            bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Положение";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBoxFind
            // 
            groupBoxFind.Controls.Add(labelTankType);
            groupBoxFind.Controls.Add(textBoxFindTank);
            groupBoxFind.Controls.Add(labelFindFuelType);
            groupBoxFind.Controls.Add(textBoxFindFuel);
            groupBoxFind.Controls.Add(buttonDisplay);
            groupBoxFind.Location = new System.Drawing.Point(16, 42);
            groupBoxFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxFind.Name = "groupBoxFind";
            groupBoxFind.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBoxFind.Size = new System.Drawing.Size(615, 101);
            groupBoxFind.TabIndex = 25;
            groupBoxFind.TabStop = false;
            groupBoxFind.Text = "Найти";
            // 
            // labelTankType
            // 
            labelTankType.AutoSize = true;
            labelTankType.Location = new System.Drawing.Point(15, 59);
            labelTankType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTankType.Name = "labelTankType";
            labelTankType.Size = new System.Drawing.Size(65, 20);
            labelTankType.TabIndex = 29;
            labelTankType.Text = "Емкость";
            // 
            // textBoxFindTank
            // 
            textBoxFindTank.Location = new System.Drawing.Point(116, 59);
            textBoxFindTank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxFindTank.Name = "textBoxFindTank";
            textBoxFindTank.Size = new System.Drawing.Size(288, 27);
            textBoxFindTank.TabIndex = 28;
            // 
            // labelFindFuelType
            // 
            labelFindFuelType.AutoSize = true;
            labelFindFuelType.Location = new System.Drawing.Point(15, 29);
            labelFindFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFindFuelType.Name = "labelFindFuelType";
            labelFindFuelType.Size = new System.Drawing.Size(96, 20);
            labelFindFuelType.TabIndex = 27;
            labelFindFuelType.Text = "Вид топлива";
            // 
            // textBoxFindFuel
            // 
            textBoxFindFuel.Location = new System.Drawing.Point(116, 29);
            textBoxFindFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBoxFindFuel.Name = "textBoxFindFuel";
            textBoxFindFuel.Size = new System.Drawing.Size(288, 27);
            textBoxFindFuel.TabIndex = 26;
            // 
            // buttonDisplay
            // 
            buttonDisplay.Location = new System.Drawing.Point(468, 44);
            buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new System.Drawing.Size(139, 35);
            buttonDisplay.TabIndex = 25;
            buttonDisplay.Text = "Найти";
            buttonDisplay.UseVisualStyleBackColor = true;
            buttonDisplay.Click += ButtonDisplay_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new System.Drawing.Point(218, 714);
            buttonReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new System.Drawing.Size(202, 35);
            buttonReload.TabIndex = 30;
            buttonReload.Text = "Загрузить из БД";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += ButtonReload_Click;
            // 
            // FormOperation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1113, 780);
            Controls.Add(buttonReload);
            Controls.Add(groupBoxFind);
            Controls.Add(bindingNavigatorOperations);
            Controls.Add(toolStrip1);
            Controls.Add(buttonDelete);
            Controls.Add(labelInfo);
            Controls.Add(dataGridViewOperations);
            Controls.Add(groupBoxForChange);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FormOperation";
            Text = "Операции";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).EndInit();
            groupBoxForChange.ResumeLayout(false);
            groupBoxForChange.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigatorOperations).EndInit();
            bindingNavigatorOperations.ResumeLayout(false);
            bindingNavigatorOperations.PerformLayout();
            groupBoxFind.ResumeLayout(false);
            groupBoxFind.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewOperations;
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
        private System.Windows.Forms.BindingNavigator bindingNavigatorOperations;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Label labelTankType;
        private System.Windows.Forms.TextBox textBoxFindTank;
        private System.Windows.Forms.Label labelFindFuelType;
        private System.Windows.Forms.TextBox textBoxFindFuel;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonReload;
    }
}

