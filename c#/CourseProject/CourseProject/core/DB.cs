using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CourseProject.core
{
    class DB
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand cmd = new NpgsqlCommand();

        public DB()
        {
            connection = new NpgsqlConnection(
                connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=$tepanShun1n;Database=postgres;");

            OpenConnection();
        }
        ~DB()
        {
            CloseConnection();
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmd.Connection = connection;
        }
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable GetData(string command)
        {
            DataTable table = new DataTable();
            cmd.CommandText = command;

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            table.Load(dataReader);
            return table;
        }

        public async void Commit(string command)
        {
            cmd.CommandText = command;
            await cmd.ExecuteNonQueryAsync();
        }
    }
}
