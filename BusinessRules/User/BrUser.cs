

namespace BusinessRules.User
{
    using BusinessRules.Connection;
    using DataAccess.User;
    using Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   

    public class BrUser:BrConnection
    {
        public string Login(Login login)
        {
            string request = "";
            using (SqlConnection connection=new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaUser daUser = new DaUser();
                    request = daUser.Login(connection,login);
                    connection.Close();

                }
                catch(Exception e)
                {
                    return e.Message;
                }
            }

            return request;
        }
    }
}
