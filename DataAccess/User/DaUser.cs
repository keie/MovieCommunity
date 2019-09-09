

namespace DataAccess.User
{
    using Entity;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class DaUser
    {
        public string Login(SqlConnection sqlConnection,Login login)
        {
            string ans = "Oh! There is a trouble";
            SqlCommand sqlCommand = new SqlCommand("[usp.Login]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@userName", SqlDbType.VarChar).Value = login.GetUsername();
            sqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = login.GetPassword();
            Object obj = sqlCommand.ExecuteScalar();
            if (obj != null)
            {
                ans = "Login SucessFully";
            }

            return ans;
        }
    }
}
