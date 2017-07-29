using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyfOnLibrary.Model;
using LyfOnLibrary.Common;
using System.Data;
using System.Data.SqlClient;

namespace LyfOnLibrary.Service
{
    public class WriteService
    {
        public string _ConString;

        public string ConString { get { return _ConString; } set { _ConString = value; } }

        public WriteService(string ConString) { this.ConString = ConString; }

        public bool LogOut(string UserId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "Logout";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = UserId;
                        connection.Open();
                        Command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }


            return false;
        }

        public bool ChangePassword(string UserName, string PassWord)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "ChangePassword";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                        Command.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = PassWord;
                        connection.Open();
                        Command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return false;
        }

        public bool RegisterUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "InsertUser";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@Dob", SqlDbType.DateTime).Value = user.UserName;
                        Command.Parameters.Add("@Gender", SqlDbType.Bit).Value = user.UserName;
                        Command.Parameters.Add("@Age", SqlDbType.Int).Value = user.UserName;

                        Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Pincode", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@City", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@StateId", SqlDbType.Int).Value = user.UserName;
                        Command.Parameters.Add("@CountryId", SqlDbType.Int).Value = user.UserName;
                        Command.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.UserName;

                        connection.Open();
                        Command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return false;
        }

        public bool UpdateUserDetails(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "UpdateUser";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@Dob", SqlDbType.DateTime).Value = user.UserName;
                        Command.Parameters.Add("@Gender", SqlDbType.Bit).Value = user.UserName;
                        Command.Parameters.Add("@Age", SqlDbType.Int).Value = user.UserName;

                        Command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Pincode", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@City", SqlDbType.NVarChar).Value = user.UserName;

                        Command.Parameters.Add("@StateId", SqlDbType.Int).Value = user.UserName;
                        Command.Parameters.Add("@CountryId", SqlDbType.Int).Value = user.UserName;
                        Command.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = user.UserName;
                        Command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.UserName;

                        connection.Open();
                        Command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return false;
        }

    }
}
