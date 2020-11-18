using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;


namespace _151
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.DoWork();

        }

        void DoWork()
        {
            //static void ExecuteSqlTransaction(string connectionString)
            
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("procl", connection);

                SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
                finally
                {
                    commmand.Dispose();
                    connection.Dispose();
                }

            
        }


    }

}
