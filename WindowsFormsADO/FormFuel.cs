using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsADO
{
    public partial class FormFuel : Form
    {
        // Локальное хранилище
        DataSet ds = new DataSet();
        // Адаптер между локальным хранилищем и базой данных
        SqlDataAdapter dataAdapter;
        // Генератор однотабличных команд, используемые для согласования изменений, внесенных в DataSet, со связанной базой данных SQL Server
        SqlCommandBuilder builder;
        // Строка запроса для выбора из заданной таблицы
        string queryString = "SELECT * FROM Fuels";
        // Строка соединения с базой данных
        string ConnectionString = ConfigurationManager.ConnectionStrings["toplivoConnectionString"].ConnectionString;

        public FormFuel()
        {
            InitializeComponent();
            //Отображение всех данных из таблицы Fuels
            DisplayFuels("");
        }
        private void DisplayFuels(string FindFuelType)
        //загрузка данных в локальное хранилище и отображение их на форме
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            labelInfo.Text = "\r\n Ход выполнения процесса визуализации:\r\n";
            labelInfo.Refresh();
            try
            {
                conn.Open();
                ds.Clear();
                labelInfo.Text += "1. cоединение с базой данных установлено;\r\n";
                labelInfo.Refresh();
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = conn;

                labelInfo.Text += "2. отбор данных в локальное хранилище начат;\r\n";
                labelInfo.Refresh();

                //Команда на выборку с параметром
                MyCommand.CommandText = "SELECT * FROM Fuels Where FuelType LIKE '%' +@FindFuelType +'%'";
                MyCommand.Parameters.AddWithValue("@FindFuelType", FindFuelType);

                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = MyCommand;
                dataAdapter.Fill(ds, "Fuels");

                labelInfo.Text += "3. отбор данных в локальное хранилище закончен;\r\n";
                labelInfo.Refresh();

                dataGridViewFuels.DataSource = ds.Tables["Fuels"].DefaultView;
                dataGridViewFuels.Columns["FuelId"].HeaderText = "Код топлива";
                dataGridViewFuels.Columns["FuelType"].HeaderText = "Название топлива";
                dataGridViewFuels.Columns["FuelDensity"].HeaderText = "Плотность топлива";

                c0.Text = ds.Tables["Fuels"].Rows[0][0].ToString();
                labelInfo.Text += "4. отображение данных из локального хранилища в табличных элементах управления закончено!!!\r\n";
                labelInfo.Refresh();
            }
            catch (Exception exeption)
            {
                labelInfo.Text += "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }
            finally
            {
                conn.Close();
            }
        }


        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayFuels(textBoxFind.Text);     
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Создание подключения
            SqlConnection conn = new SqlConnection(ConnectionString);
            
            try
            {
                conn.Open();

                // Создать команду на выборку
                SqlCommand command = new SqlCommand();
                command.CommandText = queryString;
                command.Connection = conn;

                // Создать DataAdapter.
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                // Создать экземпляр CommandBuilder
                builder = new SqlCommandBuilder();
                builder.DataAdapter = dataAdapter;

                // Получить сгенерированную команду на обновление
                dataAdapter.UpdateCommand = builder.GetUpdateCommand();

                DataTable table = ds.Tables["Fuels"];
                // Синхронизировать изменения с базой данных
                dataAdapter.Update(table);

            }
            catch (Exception exeption)
            {
                labelInfo.Text += "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            //значение ключевого поля строки для удаления
            int id = (int)dataGridViewFuels.CurrentRow.Cells[0].Value;

            try
            {
                // Создание подключения
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    // Создать команду на выборку
                    SqlCommand command = new SqlCommand();
                    command.CommandText = queryString;
                    command.Connection = conn;

                    // Создать DataAdapter.
                    dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = command;

                    // Создать CommandBuilder.
                    builder = new SqlCommandBuilder();
                    builder.DataAdapter = dataAdapter;
                    // Задать сгенерированную команду на удаление для dataAdapter
                    dataAdapter.DeleteCommand = builder.GetDeleteCommand();

                    DataTable table = ds.Tables["Fuels"];

                    // Удаление строки из таблицы локального хранилища
                    DataRow[] deleteRow = table.Select("FuelID = " + id);
                    foreach (DataRow row in deleteRow)
                    {
                        row.Delete();
                    }
                    // Синхронизировать изменения с базой данных
                    dataAdapter.Update(table);
                    table.AcceptChanges();

                }

                labelInfo.Text += "Удалено!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text += "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            labelInfo.Text = "";
            try
            {
                // Создание подключения
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    // Создать команду на добавление с параметрами
                    SqlCommand insertCommand = new SqlCommand();
                    insertCommand.CommandText = "INSERT INTO Fuels (FuelType, FuelDensity) VALUES (@FuelType, @FuelDensity)";
                    insertCommand.Connection = conn;

                    // добавляем параметры
                    insertCommand.Parameters.Add("@FuelType",SqlDbType.VarChar);
                    insertCommand.Parameters["@FuelType"].Value = groupBoxForChange.Controls["c1"].Text;
                    insertCommand.Parameters.Add("@FuelDensity", SqlDbType.Real);
                    insertCommand.Parameters["@FuelDensity"].Value = groupBoxForChange.Controls["c2"].Text;

                    //выполняем запрос
                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                }

                DisplayFuels(textBoxFind.Text);
                labelInfo.Text = "";
                labelInfo.Text += "Добавлено в конец набора!!!\r\n";
                labelInfo.Refresh();
                dataGridViewFuels.CurrentCell = dataGridViewFuels[0, dataGridViewFuels.Rows.Count-1];


            }
            catch (Exception exeption)
            {
                labelInfo.Text += "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }

        }

        private void dataGridViewFuels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridViewFuels.CurrentRow;
            int colCount = dataGridViewFuels.Columns.Count;
            string controlName;
            if (currentRow!=null)
            {
                for (int i = 0; i < colCount; i++)
                {
                    controlName = "c" + i;
                    groupBoxForChange.Controls[controlName].Text = currentRow.Cells[i].Value.ToString();
                }
            }

        }
            

        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            int positionCurrentRow = dataGridViewFuels.CurrentRow.Index;
            int idCurrentRow = 1;
            if ((groupBoxForChange.Controls["c0"].Text) != "")
            {
                idCurrentRow = Convert.ToInt32(groupBoxForChange.Controls["c0"].Text);
            }                   

     
            try
            {
                // Создание подключения
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    // Создать команду на добавление с параметрами
                    SqlCommand updateCommand = new SqlCommand();
                    updateCommand.CommandText = "UPDATE Fuels SET FuelType=@FuelType, FuelDensity=@FuelDensity WHERE FuelId=@FuelId";
                    updateCommand.Connection = conn;

                    // добавляем параметры
                    updateCommand.Parameters.Add("@FuelId", SqlDbType.Int);
                    updateCommand.Parameters["@FuelId"].Value = idCurrentRow;
                    updateCommand.Parameters.Add("@FuelType", SqlDbType.VarChar);
                    updateCommand.Parameters["@FuelType"].Value = groupBoxForChange.Controls["c1"].Text;
                    updateCommand.Parameters.Add("@FuelDensity", SqlDbType.Real);
                    updateCommand.Parameters["@FuelDensity"].Value = groupBoxForChange.Controls["c2"].Text;

                    //выполняем запрос
                    conn.Open();
                    updateCommand.ExecuteNonQuery();
                }

                var currentCell = dataGridViewFuels.CurrentCell;

                DisplayFuels(textBoxFind.Text);

                dataGridViewFuels.CurrentCell = dataGridViewFuels[0, positionCurrentRow];
                labelInfo.Text = "";
                labelInfo.Text += "Обновлена запись Id="+ idCurrentRow.ToString()+ "!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text += "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }

        }
    }
}
