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

        protected DataTable queryExecuteAdapter(string proc, string[] param = null, string[] value = null)
        {
            _conn.Close();

            _conn.Open();

            SqlCommand command = new SqlCommand(proc, _conn);

            command.CommandType = CommandType.StoredProcedure;

            if(param != null && value != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    SqlParameter p = new SqlParameter("@" + param[i], value[i]);
                    p.Direction = ParameterDirection.Input;
                    p.DbType = DbType.String;
                    command.Parameters.Add(p);
                }
            }

            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable res = new DataTable();

            adapter.Fill(res);

            _conn.Close();

            return res;
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
