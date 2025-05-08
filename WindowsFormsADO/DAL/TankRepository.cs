using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WindowsFormsADO.DAL
{
    public class TankRepository : IRepository<Tank>
    {
        private readonly string _connectionString;

        public TankRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Tank> GetAll(string tankTypeFilter = "")
        {
            var tanks = new List<Tank>();

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var sqlCommand = new SqlCommand("SELECT * FROM Tanks WHERE TankType LIKE '%' + @tankTypeFilter + '%'", connection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@tankTypeFilter", SqlDbType.NVarChar)
                        {
                            Value = tankTypeFilter ?? string.Empty
                        });

                        using (var reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tanks.Add(new Tank
                                {
                                    TankId = reader.GetInt32(0),
                                    TankType = reader.GetString(1),
                                    TankWeight = reader.GetFloat(2),
                                    TankVolume = reader.GetFloat(3),
                                    TankMaterial = reader.GetString(4),
                                    TankPicture = reader.GetString(5)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получении списка емкостей", ex);
            }

            return tanks;
        }

        public Tank GetById(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("SELECT TankId, TankType, TankWeight, TankVolume, TankMaterial, TankPicture FROM Tanks WHERE TankId = @Id", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Tank
                                {
                                    TankId = reader.GetInt32(0),
                                    TankType = reader.GetString(1),
                                    TankWeight = reader.GetFloat(2),
                                    TankVolume = reader.GetFloat(3),
                                    TankMaterial = reader.GetString(4),
                                    TankPicture = reader.GetString(5)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении емкости с Id = {id}", ex);
            }

            return null;
        }

        public void Add(Tank entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("INSERT INTO Tanks (TankType, TankWeight, TankVolume, TankMaterial, TankPicture) VALUES (@TankType, @TankWeight, @TankVolume, @TankMaterial, @TankPicture)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@TankType", SqlDbType.NVarChar) { Value = entity.TankType });
                        command.Parameters.Add(new SqlParameter("@TankWeight", SqlDbType.Real) { Value = entity.TankWeight });
                        command.Parameters.Add(new SqlParameter("@TankVolume", SqlDbType.Real) { Value = entity.TankVolume });
                        command.Parameters.Add(new SqlParameter("@TankMaterial", SqlDbType.NVarChar) { Value = entity.TankMaterial });
                        command.Parameters.Add(new SqlParameter("@TankPicture", SqlDbType.NVarChar) { Value = entity.TankPicture });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении емкости", ex);
            }
        }

        public void Update(Tank entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("UPDATE Tanks SET TankType = @TankType, TankWeight = @TankWeight, TankVolume = @TankVolume, TankMaterial = @TankMaterial, TankPicture = @TankPicture WHERE TankId = @TankId", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@TankId", SqlDbType.Int) { Value = entity.TankId });
                        command.Parameters.Add(new SqlParameter("@TankType", SqlDbType.NVarChar) { Value = entity.TankType });
                        command.Parameters.Add(new SqlParameter("@TankWeight", SqlDbType.Real) { Value = entity.TankWeight });
                        command.Parameters.Add(new SqlParameter("@TankVolume", SqlDbType.Real) { Value = entity.TankVolume });
                        command.Parameters.Add(new SqlParameter("@TankMaterial", SqlDbType.NVarChar) { Value = entity.TankMaterial });
                        command.Parameters.Add(new SqlParameter("@TankPicture", SqlDbType.NVarChar) { Value = entity.TankPicture });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при обновлении емкости с Id = {entity.TankId}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("DELETE FROM Tanks WHERE TankId = @TankId", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@TankId", SqlDbType.Int) { Value = id });

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при удалении емкости с Id = {id}", ex);
            }
        }
    }
}
