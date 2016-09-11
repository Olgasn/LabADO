using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        // Получить фабрику
        DbProviderFactory provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
        DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);

            // Использовать фабрику для получения соединения
            DbConnection conn = provider.CreateConnection();
            conn.ConnectionString = ConnectionString;

            labelInfo.Text = "Ход выполнения процесса заполнения базы данных:\r\n";
            labelInfo.Refresh();

            try
            {

             
                conn.Open();

                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено;\r\n";
                labelInfo.Refresh();
                //Создать команду
                DbCommand MyCommand = provider.CreateCommand();
                MyCommand.Connection = conn;
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
            //string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            // Использовать фабрику для получения соединения
            DbConnection conn = provider.CreateConnection();
            conn.ConnectionString = ConnectionString;
            labelInfo.Text = labelInfo.Text + "\r\n Ход выполнения процесса визуализации:\r\n";
            labelInfo.Refresh();

            try
            {
                conn.Open();
                ds.Clear();
                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено;\r\n";
                labelInfo.Refresh();
               


                labelInfo.Text = labelInfo.Text + "2. отбор ланных в локальное хранилище начат;\r\n";
                labelInfo.Refresh();

                //Создать команду
                DbCommand MyCommand = provider.CreateCommand();
                MyCommand.CommandText = "SELECT * FROM Fuels";
                MyCommand.Connection = conn;
                //Создать адаптер
                DbDataAdapter dataAdapter = provider.CreateDataAdapter();
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

                labelInfo.Text = labelInfo.Text + "3. отбор данных в локальное хранилище закончено;\r\n";
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
            //string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            // Использовать фабрику для получения соединения
            DbConnection conn = provider.CreateConnection();
            conn.ConnectionString = ConnectionString;

            try
            {
                conn.Open();

                DataTable table = ds.Tables["Fuels"];

                //Создать команду
                DbCommand command = provider.CreateCommand();
                command.Connection = conn;
                command.CommandText= "UPDATE Fuels SET FuelType = @FuelType, FuelDensity=@FuelDensity WHERE FuelID = @FuelID";
                // Добавить параметры для UpdateCommand.
                DbParameter parameter = command.CreateParameter();

                parameter.ParameterName = "@FuelID";
                parameter.DbType = DbType.Int32;
                parameter.Value = "FuelID";
                command.Parameters.Add(parameter);

                parameter.ParameterName = "@FuelType";
                parameter.DbType = DbType.String;
                parameter.Value = "FuelType";
                command.Parameters.Add(parameter);

                parameter.ParameterName = "@FuelDensity";
                parameter.DbType = DbType.Decimal;
                parameter.Value = "FuelDensity";
                command.Parameters.Add(parameter);

                DbDataAdapter dataAdapter = provider.CreateDataAdapter();
                dataAdapter.UpdateCommand = command;
                dataAdapter.Update(table.Select(null, null,DataViewRowState.ModifiedCurrent));

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.Source;
                labelInfo.Refresh();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
