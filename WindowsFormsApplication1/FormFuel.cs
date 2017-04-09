using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormFuel : Form
    {

        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string ConnectionString = @"Data Source =.\sqlexpress;Initial Catalog = toplivo; Integrated Security = True";
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
                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено;\r\n";
                labelInfo.Refresh();
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = conn;


                labelInfo.Text = labelInfo.Text + "2. отбор данных в локальное хранилище начат;\r\n";
                labelInfo.Refresh();

                MyCommand.CommandText = "SELECT * FROM Fuels Where FuelType LIKE '%' +@FindFuelType +'%'";
                MyCommand.Parameters.AddWithValue("@FindFuelType", FindFuelType);
                dataAdapter.SelectCommand = MyCommand;
                dataAdapter.Fill(ds, "Fuels");


                labelInfo.Text = labelInfo.Text + "3. отбор данных в локальное хранилище закончен;\r\n";
                labelInfo.Refresh();

                dataGridViewFuels.DataSource = ds.Tables["Fuels"].DefaultView;

                labelInfo.Text = labelInfo.Text + "4. отображение данных из локального хранилища в табличных элементах управления закончено!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }
            finally
            {

                conn.Close();

            }
        }



        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayFuels(textBoxFindFuels.Text);      
      
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Создание подключения

            SqlConnection conn = new SqlConnection(ConnectionString);
            
            try
            {
                conn.Open();

                

                // Создать DbCommandBuilder.
                SqlCommandBuilder builder = new SqlCommandBuilder();
                builder.DataAdapter = dataAdapter;
                // Получить команду на обновление
                dataAdapter.UpdateCommand = builder.GetUpdateCommand();
                DataTable table = ds.Tables["Fuels"];
                dataAdapter.Update(table.Select(null, null,DataViewRowState.ModifiedCurrent));

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Создание подключения
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            labelInfo.Text = "";
            //значение ключевого поля строки для удаления
            int id = (int)dataGridViewFuels.CurrentRow.Cells[0].Value;

            try
            {
                using (conn)
                {
                    // Определение строки запроса
                    string queryString = "SELECT * FROM Fuels";

                    // Создать команду на выборку
                    SqlCommand command = new SqlCommand();
                    command.CommandText = queryString;
                    command.Connection = conn;

                    // Создать DataAdapter.
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;

                    // Создать CommandBuilder.
                    SqlCommandBuilder builder = new SqlCommandBuilder();
                    builder.DataAdapter = adapter;
                    // Получить команду на удаление
                    adapter.DeleteCommand = builder.GetDeleteCommand();

                    DataTable table = ds.Tables["Fuels"];

                    // Удаление строки
                    DataRow[] deleteRow = table.Select("FuelID = " + id);
                    foreach (DataRow row in deleteRow)
                    {
                        row.Delete();
                    }
                    adapter.Update(table);
                    table.AcceptChanges();

                }

                labelInfo.Text = labelInfo.Text + "Удалено!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Создание подключения
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            labelInfo.Text = "";

            try
            {
                using (conn)
                {
                    // Определение строки запроса
                    string queryString = "SELECT * FROM Fuels";

                    // Создать команду на выборку
                    SqlCommand command = new SqlCommand();
                    command.CommandText = queryString;
                    command.Connection = conn;

                    // Создать DataAdapter.
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;

                    // Создать CommandBuilder.
                    SqlCommandBuilder builder = new SqlCommandBuilder();
                    builder.DataAdapter = adapter;
                    // Получить команду на вставку
                    adapter.InsertCommand = builder.GetInsertCommand();

                    DataTable table = ds.Tables["Fuels"];

                    adapter.Update(table);
                    table.AcceptChanges();

                }

                labelInfo.Text = labelInfo.Text + "Добавлено!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }


        }

        


    }
}
