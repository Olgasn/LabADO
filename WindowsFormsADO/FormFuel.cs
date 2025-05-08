using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsADO.DAL;

namespace WindowsFormsADO
{
    public partial class FormFuel : Form
    {
        private readonly FuelRepository _fuelRepository;
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["toplivoConnectionString"].ConnectionString;
        // Источник для табличного элемента управления
        private BindingSource bindingSourceFuels = [];
        private ListSortDirection direction = ListSortDirection.Ascending;
        public FormFuel()
        {
            InitializeComponent();
            _fuelRepository = new FuelRepository(ConnectionString);
            DisplayFuels("");

        }

        private void DisplayFuels(string findFuelType = "")
        {
            labelInfo.Text = "\r\n Ход выполнения процесса визуализации:\r\n";
            labelInfo.Refresh();

            try
            {
                var fuels = _fuelRepository.GetAll(findFuelType).ToList();
                // Настройка табличного элемента управления
                bindingSourceFuels.DataSource = fuels;
                dataGridViewFuels.DataSource = bindingSourceFuels;
                dataGridViewFuels.Columns["FuelId"].HeaderText = "Код топлива";
                dataGridViewFuels.Columns["FuelType"].HeaderText = "Название топлива";
                dataGridViewFuels.Columns["FuelDensity"].HeaderText = "Плотность топлива";

                if (fuels.Count != 0)
                {
                    c0.Text = fuels.First().FuelId.ToString();
                }

                labelInfo.Text += "Данные успешно загружены и отображены.\r\n";
                labelInfo.Refresh();
            }
            catch (Exception exception)
            {
                labelInfo.Text += "Ошибка: " + exception.Message;
                labelInfo.Refresh();
            }
        }

        private void ButtonDisplay_Click(object sender, EventArgs e)
        {
            DisplayFuels(textBoxFind.Text);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newFuel = new Fuel
                {
                    FuelType = groupBoxForChange.Controls["c1"].Text,
                    FuelDensity = float.Parse(groupBoxForChange.Controls["c2"].Text)
                };

                _fuelRepository.Add(newFuel);

                DisplayFuels(textBoxFind.Text);
                labelInfo.Text = "Добавлено в конец набора!\r\n";
                labelInfo.Refresh();
            }
            catch (Exception exception)
            {
                labelInfo.Text += "Ошибка: " + exception.Message;
                labelInfo.Refresh();
            }
        }

        private void ButtonUpdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedFuel = new Fuel
                {
                    FuelId = int.Parse(groupBoxForChange.Controls["c0"].Text),
                    FuelType = groupBoxForChange.Controls["c1"].Text,
                    FuelDensity = float.Parse(groupBoxForChange.Controls["c2"].Text)
                };

                _fuelRepository.Update(updatedFuel);

                DisplayFuels(textBoxFind.Text);
                labelInfo.Text = $"Обновлена запись Id={updatedFuel.FuelId}!\r\n";
                labelInfo.Refresh();
            }
            catch (Exception exception)
            {
                labelInfo.Text += "Ошибка: " + exception.Message;
                labelInfo.Refresh();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewFuels.CurrentRow.Cells[0].Value;

                _fuelRepository.Delete(id);

                DisplayFuels(textBoxFind.Text);
                labelInfo.Text = "Удалено!\r\n";
                labelInfo.Refresh();
            }
            catch (Exception exception)
            {
                labelInfo.Text += "Ошибка: " + exception.Message;
                labelInfo.Refresh();
            }
        }

        private void AssignValuesToControls()
        {
            var currentRow = dataGridViewFuels.CurrentRow;
            int colCount = dataGridViewFuels.Columns.Count;
            string controlName;

            if (currentRow != null)
            {
                for (int i = 0; i < colCount; i++)
                {
                    controlName = "c" + i;
                    groupBoxForChange.Controls[controlName].Text = currentRow.Cells[i].Value.ToString();
                }
            }
        }

        private void DataGridViewFuels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignValuesToControls();
        }


        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                // Refresh the data grid view to reflect any changes made.  
                DisplayFuels(textBoxFind.Text);
                MessageBox.Show("Изменения успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewFuels_SelectionChanged(object sender, EventArgs e)
        {
            // Implement logic to handle selection change in the DataGridView.  
            // For example, you can call AssignValuesToControls() to update the form controls  
            // based on the selected row in the DataGridView.  

            AssignValuesToControls();
        }

        private void DataGridViewFuels_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewFuels.Columns[e.ColumnIndex].DataPropertyName;

            // Проверяем текущую сортировку
            if (dataGridViewFuels.SortedColumn == dataGridViewFuels.Columns[e.ColumnIndex] &&
                dataGridViewFuels.SortOrder == SortOrder.Ascending)
            {
                direction = ListSortDirection.Descending;
            }

            // Применяем сортировку
            bindingSourceFuels.Sort = $"{columnName} {(direction == ListSortDirection.Ascending ? "ASC" : "DESC")}";
            

        }
    }
}
