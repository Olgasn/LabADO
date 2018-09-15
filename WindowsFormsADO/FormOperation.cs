using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsADO
{
    public partial class FormOperation : Form
    {
        // Локальное хранилище
        DataSet ds = new DataSet();
        // Адаптер между локальным хранилищем и базой данных
        SqlDataAdapter dataAdapter;
        // Генератор однотабличных команд, используемые для согласования изменений, внесенных в DataSet, со связанной базой данных SQL Server
        SqlCommandBuilder builder;
        // Строка запроса для выбора из заданной таблицы
        string queryString = "SELECT  * FROM Operations";
        // Строка соединения с базой данных
        string ConnectionString = ConfigurationManager.ConnectionStrings["toplivoConnectionString"].ConnectionString;

        public FormOperation()
        {
            InitializeComponent();
            //Отображение всех данных из таблицы Fuels
            DisplayOperations("");
        }
        private void DisplayOperations(string FindFuelType)
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

                //Команда на выборку с параметром
                
                MyCommand.CommandText = "SELECT OperationId, Operations.FuelId, Operations.TankId, Inc_Exp, [Date], FuelType, TankType FROM Operations, Fuels, Tanks WHERE (Operations.TankID = Tanks.TankID AND Operations.FuelID = Fuels.FuelID AND FuelType LIKE '%' +@FindFuelType +'%');";
                MyCommand.Parameters.AddWithValue("@FindFuelType", FindFuelType);

                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = MyCommand;
                dataAdapter.Fill(ds, "Operations");

                MyCommand.CommandText = "SELECT * FROM Fuels;";
                dataAdapter.Fill(ds, "Fuels");

                MyCommand.CommandText = "SELECT * FROM Tanks;";
                dataAdapter.Fill(ds, "Tanks");

                labelInfo.Text = labelInfo.Text + "3. отбор данных в локальное хранилище закончен;\r\n";
                labelInfo.Refresh();
                dataGridViewOperations.DataSource = ds.Tables["Operations"].DefaultView;

                dataGridViewOperations.Columns["OperationID"].HeaderText = "Код операции";
                dataGridViewOperations.Columns["FuelId"].Visible = false;
                dataGridViewOperations.Columns["FuelId"].ReadOnly = true;
                dataGridViewOperations.Columns["FuelType"].HeaderText = "Название топлива";
                dataGridViewOperations.Columns["TankId"].Visible = false;
                dataGridViewOperations.Columns["TankId"].ReadOnly = true;
                dataGridViewOperations.Columns["TankType"].HeaderText = "Емкость";
                dataGridViewOperations.Columns["Inc_Exp"].HeaderText = "Приход-Расход";
                dataGridViewOperations.Columns["Date"].HeaderText = "Дата";

                c0.Text = ds.Tables["Operations"].Rows[0][0].ToString();
                c1.DataSource = ds.Tables["Fuels"]; c1.DisplayMember = "FuelType"; c1.ValueMember = "FuelId";
                c2.DataSource = ds.Tables["Tanks"]; c2.DisplayMember = "TankType"; c2.ValueMember = "TankId";

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
            DisplayOperations(textBoxFind.Text);     
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            //значение ключевого поля строки для удаления
            int id = (int)dataGridViewOperations.CurrentRow.Cells[0].Value;

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

                    DataTable table = ds.Tables["Operations"];

                    // Удаление строки из таблицы локального хранилища
                    DataRow[] deleteRow = table.Select("OperationID = " + id);
                    foreach (DataRow row in deleteRow)
                    {
                        row.Delete();
                    }
                    // Синхронизировать изменения с базой данных
                    dataAdapter.Update(table);
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

            labelInfo.Text = "";
            try
            {
                // Создание подключения
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    // Создать команду на добавление с параметрами
                    SqlCommand insertCommand = new SqlCommand();
                    insertCommand.CommandText = "INSERT INTO Operations " +
                        "(FuelId, TankId, Inc_Exp, [Date]) " +
                        "VALUES (@FuelId, @TankId, @Inc_Exp, @Date)";
                    insertCommand.Connection = conn;

                    // добавляем параметры
                    insertCommand.Parameters.Add("@FuelId", SqlDbType.Int);
                    insertCommand.Parameters["@FuelId"].Value = c1.SelectedValue;
                    insertCommand.Parameters.Add("@TankId", SqlDbType.Int);
                    insertCommand.Parameters["@TankId"].Value = c2.SelectedValue;
                    insertCommand.Parameters.Add("@Inc_Exp", SqlDbType.Real);
                    insertCommand.Parameters["@Inc_Exp"].Value = c3.Text;
                    insertCommand.Parameters.Add("@Date", SqlDbType.Date);
                    insertCommand.Parameters["@Date"].Value = c4.Text;


                    //выполняем запрос
                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                }

                DisplayOperations(textBoxFind.Text);
                labelInfo.Text = "";
                labelInfo.Text = labelInfo.Text + "Добавлено в конец набора!!!\r\n";
                labelInfo.Refresh();
                dataGridViewOperations.CurrentCell = dataGridViewOperations[0, dataGridViewOperations.Rows.Count-1];


            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }

        }

        private void dataGridViewOperations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridViewOperations.CurrentRow;
            int colCount = dataGridViewOperations.Columns.Count;
            string controlName;
            for (int i = 0; i < colCount; i++)
            {                
                controlName = "c" + i;
                if (groupBoxForChange.Controls.ContainsKey(controlName))
                {
                    var currentControl = groupBoxForChange.Controls[controlName];
                    if (currentControl.GetType().Equals(typeof(ComboBox)))
                    {
                        ComboBox comboBox = (ComboBox)currentControl;
                        comboBox.SelectedValue = currentRow.Cells[i].Value.ToString();
                    }
                    else
                    {
                        groupBoxForChange.Controls[controlName].Text = currentRow.Cells[i].Value.ToString();
                    }
                }
            }
        }


        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            int positionCurrentRow = dataGridViewOperations.CurrentRow.Index;
            int idCurrentRow = 1;
            if (c0.Text != "")
            {
                idCurrentRow = Convert.ToInt32(c0.Text);
            }                  

     
            try
            {
                // Создание подключения
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    // Создать команду на добавление с параметрами
                    SqlCommand updateCommand = new SqlCommand();
                    updateCommand.CommandText = "UPDATE Operations " +
                        "SET FuelId=@FuelId, TankId=@TankId, Inc_Exp=@Inc_Exp, Date=@Date " +
                        "WHERE OperationId=@OperationId";
                    updateCommand.Connection = conn;

                    // добавляем параметры
                    updateCommand.Parameters.Add("@OperationId", SqlDbType.Int);
                    updateCommand.Parameters["@OperationId"].Value = idCurrentRow;
                    updateCommand.Parameters.Add("@FuelId", SqlDbType.Int);
                    updateCommand.Parameters["@FuelId"].Value = c1.SelectedValue;
                    updateCommand.Parameters.Add("@TankId", SqlDbType.Int);
                    updateCommand.Parameters["@TankId"].Value = c2.SelectedValue;
                    updateCommand.Parameters.Add("@Inc_Exp", SqlDbType.Real);
                    updateCommand.Parameters["@Inc_Exp"].Value = c3.Text;
                    updateCommand.Parameters.Add("@Date", SqlDbType.Date);
                    updateCommand.Parameters["@Date"].Value = c4.Text;

                    //выполняем запрос
                    conn.Open();
                    updateCommand.ExecuteNonQuery();
                }

                var currentCell = dataGridViewOperations.CurrentCell;

                DisplayOperations(textBoxFind.Text);

                dataGridViewOperations.CurrentCell = dataGridViewOperations[0, positionCurrentRow];
                labelInfo.Text = "";
                labelInfo.Text = labelInfo.Text + "Обновлена запись Id="+ idCurrentRow.ToString()+ "!!!\r\n";
                labelInfo.Refresh();

            }
            catch (Exception exeption)
            {
                labelInfo.Text = labelInfo.Text + "Ошибка: " + exeption.ToString();
                labelInfo.Refresh();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormFuel formFuel = new FormFuel();
            formFuel.Show();
        }


    }
}
