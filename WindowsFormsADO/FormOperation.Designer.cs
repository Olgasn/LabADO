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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewOperations = new System.Windows.Forms.DataGridView();
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
            this.bindingNavigatorOperations = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.labelTankType = new System.Windows.Forms.Label();
            this.textBoxFindTank = new System.Windows.Forms.TextBox();
            this.labelFindFuelType = new System.Windows.Forms.Label();
            this.textBoxFindFuel = new System.Windows.Forms.TextBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).BeginInit();
            this.groupBoxForChange.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOperations)).BeginInit();
            this.bindingNavigatorOperations.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(16, 548);
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
            this.labelInfo.Location = new System.Drawing.Point(639, 31);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(296, 262);
            this.labelInfo.TabIndex = 5;
            // 
            // dataGridViewOperations
            // 
            this.dataGridViewOperations.AllowUserToAddRows = false;
            this.dataGridViewOperations.AllowUserToOrderColumns = true;
            this.dataGridViewOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperations.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOperations.Name = "dataGridViewOperations";
            this.dataGridViewOperations.ReadOnly = true;
            this.dataGridViewOperations.RowHeadersWidth = 51;
            this.dataGridViewOperations.Size = new System.Drawing.Size(631, 420);
            this.dataGridViewOperations.TabIndex = 0;
            this.dataGridViewOperations.SelectionChanged += new System.EventHandler(this.dataGridViewOperations_SelectionChanged);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(12, 242);
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
            this.groupBoxForChange.Location = new System.Drawing.Point(639, 298);
            this.groupBoxForChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForChange.Name = "groupBoxForChange";
            this.groupBoxForChange.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForChange.Size = new System.Drawing.Size(327, 278);
            this.groupBoxForChange.TabIndex = 20;
            this.groupBoxForChange.TabStop = false;
            this.groupBoxForChange.Text = "Изменить данные";
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(156, 210);
            this.c4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(151, 22);
            this.c4.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Дата";
            // 
            // c2
            // 
            this.c2.FormattingEnabled = true;
            this.c2.Location = new System.Drawing.Point(156, 121);
            this.c2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(151, 24);
            this.c2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Емкость";
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Location = new System.Drawing.Point(153, 76);
            this.c1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(151, 24);
            this.c1.TabIndex = 36;
            // 
            // buttonUpdateRecord
            // 
            this.buttonUpdateRecord.Location = new System.Drawing.Point(167, 242);
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
            this.labelFuelDensity.Location = new System.Drawing.Point(8, 165);
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
            // labelOperationId
            // 
            this.labelOperationId.AutoSize = true;
            this.labelOperationId.Location = new System.Drawing.Point(8, 32);
            this.labelOperationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperationId.Name = "labelOperationId";
            this.labelOperationId.Size = new System.Drawing.Size(101, 17);
            this.labelOperationId.TabIndex = 32;
            this.labelOperationId.Text = "Код операции";
            this.labelOperationId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(156, 165);
            this.c3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(151, 22);
            this.c3.TabIndex = 24;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton1.Text = "Топливо";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 24);
            this.toolStripButton2.Text = "Емкости";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(980, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bindingNavigatorOperations
            // 
            this.bindingNavigatorOperations.AddNewItem = null;
            this.bindingNavigatorOperations.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorOperations.DeleteItem = null;
            this.bindingNavigatorOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorOperations.Location = new System.Drawing.Point(0, 597);
            this.bindingNavigatorOperations.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorOperations.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorOperations.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorOperations.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorOperations.Name = "bindingNavigatorOperations";
            this.bindingNavigatorOperations.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorOperations.Size = new System.Drawing.Size(980, 27);
            this.bindingNavigatorOperations.TabIndex = 22;
            this.bindingNavigatorOperations.Text = "bindingNavigatorOperations";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Controls.Add(this.labelTankType);
            this.groupBoxFind.Controls.Add(this.textBoxFindTank);
            this.groupBoxFind.Controls.Add(this.labelFindFuelType);
            this.groupBoxFind.Controls.Add(this.textBoxFindFuel);
            this.groupBoxFind.Controls.Add(this.buttonDisplay);
            this.groupBoxFind.Location = new System.Drawing.Point(16, 34);
            this.groupBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFind.Size = new System.Drawing.Size(615, 81);
            this.groupBoxFind.TabIndex = 25;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Найти";
            // 
            // labelTankType
            // 
            this.labelTankType.AutoSize = true;
            this.labelTankType.Location = new System.Drawing.Point(15, 47);
            this.labelTankType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTankType.Name = "labelTankType";
            this.labelTankType.Size = new System.Drawing.Size(62, 17);
            this.labelTankType.TabIndex = 29;
            this.labelTankType.Text = "Емкость";
            // 
            // textBoxFindTank
            // 
            this.textBoxFindTank.Location = new System.Drawing.Point(116, 47);
            this.textBoxFindTank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFindTank.Name = "textBoxFindTank";
            this.textBoxFindTank.Size = new System.Drawing.Size(271, 22);
            this.textBoxFindTank.TabIndex = 28;
            // 
            // labelFindFuelType
            // 
            this.labelFindFuelType.AutoSize = true;
            this.labelFindFuelType.Location = new System.Drawing.Point(15, 23);
            this.labelFindFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFindFuelType.Name = "labelFindFuelType";
            this.labelFindFuelType.Size = new System.Drawing.Size(91, 17);
            this.labelFindFuelType.TabIndex = 27;
            this.labelFindFuelType.Text = "Вид топлива";
            // 
            // textBoxFindFuel
            // 
            this.textBoxFindFuel.Location = new System.Drawing.Point(116, 23);
            this.textBoxFindFuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFindFuel.Name = "textBoxFindFuel";
            this.textBoxFindFuel.Size = new System.Drawing.Size(271, 22);
            this.textBoxFindFuel.TabIndex = 26;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(451, 34);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(139, 28);
            this.buttonDisplay.TabIndex = 25;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 624);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.bindingNavigatorOperations);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewOperations);
            this.Controls.Add(this.groupBoxForChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOperation";
            this.Text = "Операции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).EndInit();
            this.groupBoxForChange.ResumeLayout(false);
            this.groupBoxForChange.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorOperations)).EndInit();
            this.bindingNavigatorOperations.ResumeLayout(false);
            this.bindingNavigatorOperations.PerformLayout();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

