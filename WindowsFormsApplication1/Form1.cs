using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();  
            
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            labelInfo.Text = "Ход выполнения процесса заполнения базы данных:\r\n";
            labelInfo.Refresh();

            try
            {
                conn.Open();
                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено;\r\n";
                labelInfo.Refresh();
                SqlCommand MyCommand = conn.CreateCommand();
                MyCommand.CommandText = commandText;
                labelInfo.Text = labelInfo.Text + "2. заполнение таблиц базы данных начато, подождите немного...;\r\n";
                labelInfo.Refresh();

                MyCommand.ExecuteNonQuery();
                labelInfo.Text = labelInfo.Text + "3. заполнение таблиц базы данных окончено!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: "+ exeption.Source;
                labelInfo.Refresh();
            }
            finally
            {
                conn.Close();
            }

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
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

                MyCommand.CommandText = "SELECT * FROM Fuels";
                dataAdapter.SelectCommand = MyCommand;
                if (!(ds.Tables.Contains("Fuels"))) ds.Tables.Add("Fuels");
                dataAdapter.Fill(ds, "Fuels"); // 

                MyCommand.CommandText = "SELECT * FROM Tanks";
                dataAdapter.SelectCommand = MyCommand;
                if (!(ds.Tables.Contains("Tanks"))) ds.Tables.Add("Tanks");
                dataAdapter.Fill(ds, "Tanks"); // 


                MyCommand.CommandText = "SELECT * FROM Operations";
                dataAdapter.SelectCommand = MyCommand;
                if (!(ds.Tables.Contains("Operations"))) ds.Tables.Add("Operations");
                dataAdapter.Fill(ds, "Operations");

                labelInfo.Text = labelInfo.Text + "3. отбор данных в локальное хранилище закончен;\r\n";
                labelInfo.Refresh();

                dataGridView1.DataSource = ds.Tables["Fuels"].DefaultView;
                dataGridView2.DataSource = ds.Tables["Tanks"].DefaultView;
                dataGridView3.DataSource = ds.Tables["Operations"].DefaultView;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            
            try
            {
                conn.Open();

                DataTable table = ds.Tables["Fuels"];
                SqlCommand command = new SqlCommand("UPDATE Fuels SET FuelType = @FuelType, FuelDensity=@FuelDensity WHERE FuelID = @FuelID", conn);
                // Добавить парметры для команды обновления
                SqlParameter[] parameters = new SqlParameter[table.Columns.Count];
                int number = 0;
                foreach (DataColumn column in table.Columns)
                {
                    parameters[number] = command.CreateParameter();
                    parameters[number].ParameterName = "@" + column.ColumnName;
                    parameters[number].SourceColumn = column.ColumnName;
                    command.Parameters.Add(parameters[number]);
                    number = number + 1;
                }
                dataAdapter.UpdateCommand = command;
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
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            // Использовать фабрику для получения соединения
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            labelInfo.Text = "";
            //значение ключевого поля строки для удаления
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;

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

                    // Создать DbDataAdapter.
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;

                    // Создать DbCommandBuilder.
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

        
    }
}
