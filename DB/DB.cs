using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public sealed class Database
    {
        private SqlConnection _conn;
        private Database instances = null;
        public Database()
        {
            if (this.instances == null)
            {
                this.instances = new Database();
                this._conn = new SqlConnection("Data Source=DESKTOP-HL6447C\\SQLEXPRESS;Database = HotelManager;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");
            }
        }

        public DataTable queryExecuteAdapter(string proc, string[] param = null, string[] value = null)
        {
            try
            {
                _conn.Open();

                SqlCommand command = new SqlCommand(proc, _conn);

                command.CommandType = CommandType.StoredProcedure;

                if (param != null && value != null)
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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

