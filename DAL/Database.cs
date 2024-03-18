using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-HL6447C\\SQLEXPRESS;Database = HotelManager;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");

        protected SqlDataReader queryExecute(string query)
        {
            _conn.Close();
            _conn.Open();

            SqlCommand command = new SqlCommand(query, _conn);

            command.Connection = _conn;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    return reader;
                }

                return null;
            }
            else
            {
                return null;
            }
        }

        protected SqlDataReader queryExecuteReader(string proc, string[] param = null, string[] value = null)
        {
            _conn.Close();
            _conn.Open();

            SqlCommand command = new SqlCommand(proc, _conn);
            command.CommandType = CommandType.StoredProcedure;

            if(param != null)
            {
                for (int i = 0; i < param.Count(); i++)
                {
                    command.Parameters.AddWithValue("@" + param[i], value[i]);
                }
            }

            command.Connection = _conn;
            SqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows) 
            {
                while (reader.Read())
                {
                    return reader;
                }

                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
