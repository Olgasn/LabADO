using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsADO.DAL
{
    public class FuelRepository : IRepository<Fuel>
    {
        private readonly string _connectionString;

        public FuelRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Fuel> GetAll(string fuelTypeFilter = "")
        {
            var fuels = new List<Fuel>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var sqlCommand = new SqlCommand("SELECT * FROM Fuels WHERE FuelType LIKE '%' + @fuelTypeFilter + '%'", connection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@fuelTypeFilter", SqlDbType.NVarChar)
                        {
                            Value = fuelTypeFilter ?? string.Empty
                        });

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                fuels.Add(new Fuel
                                {
                                    FuelId = reader.GetInt32(0),
                                    FuelType = reader.GetString(1),
                                    FuelDensity = reader.GetFloat(2)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                throw new Exception("Ошибка при получении списка топлива", ex);
            }

            return fuels;
        }

        public Fuel GetById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("SELECT FuelId, FuelType, FuelDensity FROM Fuels WHERE FuelId = @Id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Fuel
                                {
                                    FuelId = reader.GetInt32(0),
                                    FuelType = reader.GetString(1),
                                    FuelDensity = reader.GetFloat(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                throw new Exception($"Ошибка при получении топлива с Id = {id}", ex);
            }

            return null;
        }

        public void Add(Fuel entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("INSERT INTO Fuels (FuelType, FuelDensity) VALUES (@FuelType, @FuelDensity)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@FuelType", SqlDbType.NVarChar) { Value = entity.FuelType });
                        command.Parameters.Add(new SqlParameter("@FuelDensity", SqlDbType.Real) { Value = entity.FuelDensity });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                throw new Exception("Ошибка при добавлении топлива", ex);
            }
        }

        public void Update(Fuel entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("UPDATE Fuels SET FuelType = @FuelType, FuelDensity = @FuelDensity WHERE FuelId = @FuelId", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@FuelId", SqlDbType.Int) { Value = entity.FuelId });
                        command.Parameters.Add(new SqlParameter("@FuelType", SqlDbType.NVarChar) { Value = entity.FuelType });
                        command.Parameters.Add(new SqlParameter("@FuelDensity", SqlDbType.Real) { Value = entity.FuelDensity });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                throw new Exception($"Ошибка при обновлении топлива с Id = {entity.FuelId}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("DELETE FROM Fuels WHERE FuelId = @FuelId", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@FuelId", SqlDbType.Int) { Value = id });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                throw new Exception($"Ошибка при удалении топлива с Id = {id}", ex);
            }
        }
    }
}
