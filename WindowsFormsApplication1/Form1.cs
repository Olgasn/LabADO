using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено\r\n";
                labelInfo.Refresh();
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = conn;
                //или SqlCommand MyCommand=conn.CreateCommand(); 
                MyCommand.CommandText = commandText;
                labelInfo.Text = labelInfo.Text + "2. заполнение таблиц базы данных начато, подождите немного...\r\n";
                labelInfo.Refresh();

                MyCommand.ExecuteNonQuery();
                labelInfo.Text = labelInfo.Text + "3. заполнение таблиц базы данных окончено!!!\r\n";
                labelInfo.Refresh();

                conn.Close();
            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: "+ exeption.Source;
                labelInfo.Refresh();
            }

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            labelInfo.Text = labelInfo.Text + "\r\n Ход выполнения процесса визуализации:\r\n";
            labelInfo.Refresh();

            try
            {
                conn.Open();
                ds.Clear();
                labelInfo.Text = labelInfo.Text + "1. cоединение с базой данных установлено\r\n";
                labelInfo.Refresh();
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = conn;
                

                labelInfo.Text = labelInfo.Text + "2. отбор ланных в локальное хранилище начато\r\n";
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

                labelInfo.Text = labelInfo.Text + "3. отбор данных в локальное хранилище закончено\r\n";
                labelInfo.Refresh();

                dataGridView1.DataSource = ds.Tables["Fuels"].DefaultView;
                dataGridView2.DataSource = ds.Tables["Tanks"].DefaultView;
                dataGridView3.DataSource = ds.Tables["Operations"].DefaultView;

                labelInfo.Text = labelInfo.Text + "4. отображение данных из локального хранилища в табличных элементах управления закончено!!!\r\n";
                labelInfo.Refresh();


                conn.Close();
            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.Source;
                labelInfo.Refresh();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string commandText = Convert.ToString(textBoxCommand.Text);
            string ConnectionString = Convert.ToString(textBoxConnectionString.Text);
            SqlConnection conn = new SqlConnection(ConnectionString);
            
            try
            {
                conn.Open();

                DataTable table = ds.Tables["Fuels"];
                // Create the UpdateCommand.
                SqlCommand command = new SqlCommand("UPDATE Fuels SET FuelType = @FuelType WHERE FuelID = @FuelID", conn);
                // Add the parameters for the UpdateCommand.
                command.Parameters.Add("@FuelID", SqlDbType.Int, 5, "FuelID");
                command.Parameters.Add("@FuelType", SqlDbType.NVarChar, 50, "FuelType");
                
                
// Next process updates.
                dataAdapter.UpdateCommand = command;
                dataAdapter.Update(table.Select(null, null,DataViewRowState.ModifiedCurrent));

// Finally, process inserts.
//dataAdapter.Update(table.Select(null, null, DataViewRowState.Added));



                conn.Close();
            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.Source;
                labelInfo.Refresh();
            }
        }
    }
}
