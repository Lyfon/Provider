using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyfOnLibrary.Model;
using LyfOnLibrary.Common;
using System.Data.SqlClient;
using System.Data;

namespace LyfOnLibrary.Service
{
    public class ReadService
    {
        private string _ConString;

        public string ConString { get { return _ConString; } set { _ConString = value; } }

        public ReadService(string ConString) { this.ConString = ConString; }

        public LoginView LoginProvider(string UserName, string PassWord)
        {
            LoginView UserLogin = new LoginView();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "loginprovider";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                        Command.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = PassWord;
                        Command.Parameters.Add("@RandomKey", SqlDbType.NVarChar).Value = Utility.GenerateKey();
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            UserLogin.UserId =Convert.ToInt64(reader["Id"]);
                            UserLogin.UserName = reader["UserName"].ToString();
                            UserLogin.Key = reader["UserKey"].ToString();
                            UserLogin.Status = reader["Status"].ToString();
                            UserLogin.LoginDate = Convert.ToDateTime(reader["LoginDate"].ToString());
                        }
                        return UserLogin;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return UserLogin;
        }

        public List<SubmissionView> GetSubmissionByCriteria(Criteria.SubmissionCriteria Criteria)
        {
            List<SubmissionView> submissions = new List<SubmissionView>();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "GetSubmissionByCriteria";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@ProviderId", SqlDbType.BigInt).Value = Criteria.ProviderId;
                        Command.Parameters.Add("@SubmissionId", SqlDbType.BigInt).Value = Criteria.SubmissionId;
                        Command.Parameters.Add("@StatusId", SqlDbType.NVarChar).Value = Criteria.StatusId;
                        Command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Criteria.Title;
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            SubmissionView submission = new SubmissionView
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Submission = reader["Submission"].ToString(),
                                Category = reader["Category"].ToString(),
                                Publisher = reader["Publisher"].ToString(),
                                CreatedDate = reader["CreatedDate"].ToString(),
                                SubmittedDate = reader["SubmittedDate"].ToString(),
                                InprogressDate = reader["InprogressDate"].ToString(),
                                AcceptedDate = reader["AcceptedDate"].ToString(),
                                DeclinedDate = reader["DeclinedDate"].ToString(),
                                WithdrawDate = reader["WithdrawDate"].ToString(),
                                Status = reader["Status"].ToString(),
                            };
                            submissions.Add(submission);
                        }
                        return submissions;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return submissions;
        }

        public List<PublisherView> GetPublisherByCriteria(Criteria.PublisherCriteria Criteria)
        {
            List<PublisherView> Publishers = new List<PublisherView>();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "GetPublisherByCriteria";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@Category", SqlDbType.NVarChar).Value = Criteria.CategoryId;
                        Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Criteria.Name;
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            PublisherView Publisher = new PublisherView
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Description = reader["Description"].ToString(),
                                Category = reader["Category"].ToString(),
                                Name = reader["Name"].ToString(),
                                CreationDate = reader["CreationDate"].ToString()
                            };
                            Publishers.Add(Publisher);
                        }
                        return Publishers;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }

            return Publishers;
        }

        public List<PublisherView> GeFollowingById(long ProviderId)
        {
            List<PublisherView> Publishers = new List<PublisherView>();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand Command = new SqlCommand())
                    {
                        connection.ConnectionString = ConString;
                        Command.Connection = connection;
                        Command.CommandText = "GetFollowing";
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.Add("@ProviderId", SqlDbType.NVarChar).Value = ProviderId;
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            PublisherView Publisher = new PublisherView
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Description = reader["Description"].ToString(),
                                Category = reader["Category"].ToString(),
                                Name = reader["Name"].ToString(),
                                CreationDate = reader["CreationDate"].ToString()
                            };
                            Publishers.Add(Publisher);
                        }
                        return Publishers;
                    }
                }
            }
            catch (Exception ex) { Utility.WriteLog(ex); }
            return Publishers;
        }
    }
}
