using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WindowsFormsADO.DAL
{
    public class OperationRepository : IRepository<Operation>
    {
        private readonly string _connectionString;

        public OperationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DataTable GetFilteredRecords(string filterTank = "", string filterFuel = "")
        {
            DataTable operations;

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Создаем DataSet для хранения данных
                    var dataSet = new DataSet();

                    // Создаем SqlDataAdapter для выполнения запроса
                    using (var dataAdapter = new SqlDataAdapter(
                    "SELECT OperationId, Operations.FuelId, Operations.TankId, Inc_Exp, [Date], FuelType, TankType " +
                    "FROM Operations INNER JOIN Fuels ON Operations.FuelID = Fuels.FuelID " +
                    "INNER JOIN Tanks ON Operations.TankID = Tanks.TankID WHERE CAST(FuelType AS NVARCHAR) LIKE '%' + @filterFuel + '%' OR CAST(TankType AS NVARCHAR) LIKE '%' + @filterTank + '%';",
                    connection))
                    {
                        // Добавляем параметр фильтра
                        dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@filterTank", SqlDbType.NVarChar)
                        {
                            Value = filterTank ?? string.Empty
                        });
                        dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@filterFuel", SqlDbType.NVarChar)
                        {
                            Value = filterFuel ?? string.Empty
                        });


                        // Заполняем DataSet данными из таблицы Operations
                        dataAdapter.Fill(dataSet, "Operations");
                        operations=dataSet.Tables["Operations"];

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка операций", ex);
            }

            return operations;
        }
        public IEnumerable<Operation> GetAll(string filter = "")
        {
            var operations = new List<Operation>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Создаем DataSet для хранения данных
                    var dataSet = new DataSet();

                    // Создаем SqlDataAdapter для выполнения запроса
                    using (var dataAdapter = new SqlDataAdapter("SELECT * FROM Operations;", connection))
                    {
                        // Добавляем параметр фильтра
                        dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@filter", SqlDbType.NVarChar)
                        {
                            Value = filter ?? string.Empty
                        });

                        // Заполняем DataSet данными из таблицы Operations
                        dataAdapter.Fill(dataSet, "Operations");

                        // Преобразуем данные из DataSet в список объектов Operation
                        foreach (DataRow row in dataSet.Tables["Operations"].Rows)
                        {
                            operations.Add(new Operation
                            {
                                OperationId = Convert.ToInt32(row["OperationId"]),
                                FuelId = Convert.ToInt32(row["FuelId"]),
                                TankId = Convert.ToInt32(row["TankId"]),
                                Inc_Exp = row.IsNull("Inc_Exp") ? (float?)null : Convert.ToSingle(row["Inc_Exp"]),
                                Date = Convert.ToDateTime(row["Date"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка операций", ex);
            }

            return operations;
        }

        public Operation GetById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(
                        "SELECT OperationId, FuelId, TankId, Inc_Exp, [Date] FROM Operations WHERE OperationId = @Id",
                        connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Operation
                                {
                                    OperationId = reader.GetInt32(0),
                                    FuelId = reader.GetInt32(1),
                                    TankId = reader.GetInt32(2),
                                    Inc_Exp = reader.IsDBNull(3) ? (float?)null : reader.GetFloat(3),
                                    Date = reader.GetDateTime(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении операции с Id = {id}", ex);
            }

            return null;
        }

        public void Add(Operation entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(
                        "INSERT INTO Operations (FuelId, TankId, Inc_Exp, [Date]) VALUES (@FuelId, @TankId, @Inc_Exp, @Date)",
                        connection))
                    {
                        command.Parameters.Add(new SqlParameter("@FuelId", SqlDbType.Int) { Value = entity.FuelId });
                        command.Parameters.Add(new SqlParameter("@TankId", SqlDbType.Int) { Value = entity.TankId });
                        command.Parameters.Add(new SqlParameter("@Inc_Exp", SqlDbType.Real) { Value = (object)entity.Inc_Exp ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = entity.Date });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении операции", ex);
            }
        }

        public void Update(Operation entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(
                        "UPDATE Operations SET FuelId = @FuelId, TankId = @TankId, Inc_Exp = @Inc_Exp, [Date] = @Date WHERE OperationId = @OperationId",
                        connection))
                    {
                        command.Parameters.Add(new SqlParameter("@OperationId", SqlDbType.Int) { Value = entity.OperationId });
                        command.Parameters.Add(new SqlParameter("@FuelId", SqlDbType.Int) { Value = entity.FuelId });
                        command.Parameters.Add(new SqlParameter("@TankId", SqlDbType.Int) { Value = entity.TankId });
                        command.Parameters.Add(new SqlParameter("@Inc_Exp", SqlDbType.Real) { Value = (object)entity.Inc_Exp ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = entity.Date });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обновлении операции с Id = {entity.OperationId}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("DELETE FROM Operations WHERE OperationId = @OperationId", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@OperationId", SqlDbType.Int) { Value = id });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при удалении операции с Id = {id}", ex);
            }
        }
    }
}
