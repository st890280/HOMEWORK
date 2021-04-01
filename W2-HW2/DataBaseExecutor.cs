using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationDB
{
    class DataBaseExecutor
    {
        public static DataTable SelectTable1DT(string id)  //查詢資料method
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true"; //設定連接字串

            string queryString =
                $@" SELECT * FROM HW2
                    WHERE id = @ID 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString)) //設定Sqlcommand 
            {
                SqlCommand command = new SqlCommand(queryString, connection); 

                command.Parameters.AddWithValue("@ID", id);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }


        public static DataTable SelectTableDT()  //顯示所有資料method
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true"; //設定連接字串

            string queryString =
                $@" SELECT * FROM HW2;";

            using (SqlConnection connection = new SqlConnection(connectionString)) //設定Sqlcommand 
            {
                SqlCommand command = new SqlCommand(queryString, connection);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }


        public static void InsertTestTable1(string id, string firstname, string lastname, string account, string password,
             string birthday, string email, string cellphone, string address)  //新增資料method
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString =
                $@" INSERT INTO HW2
                       (ID, FirstName, LastName,Account,Password,Birthday,Email,Cellphone,Address)
                    VALUES
                       (@ID, @FirstName, @LastName,@Account,@Password,@Birthday,@Email,@Cellphone,@Address)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                command.Parameters.AddWithValue("@Account", account);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Cellphone", cellphone);
                command.Parameters.AddWithValue("@Address", address);


                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("登録成功　合計" + totalChangeRows + "つの資料が変更された");
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex);
                    
                }
                
                //finally
                //{
                //    connection.Close();
                //}
            }

        }

        public static void DeleteTestTable1(string id)   //刪除資料method
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString =
                $@" DELETE FROM HW2 WHERE  ID = @ID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);
                

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();

                    HttpContext.Current.Response.Write("　合計" + totalChangeRows + "つの資料が変更された");

                    //Console.WriteLine("Total change" + totalChangeRows + "Rows.");
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            
                //finally
                //{
                //    connection.Close();
                //}
            }

        }


        public static void UpdateTable1(string id, string firstname, string lastname, string account, string password,
             string birthday, string email, string cellphone, string address)  //修改資料method
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLesson; Integrated Security=true";

            string queryString =
                $@" UPDATE HW2
                    SET ID = @ID, FirstName = @FirstName, LastName = @LastName, Account = @Account, Password = @Password , 
                        Birthday = @birthday, Email = @Email , Cellphone = @Cellphone, Address = @Address
                    WHERE ID = @ID;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                command.Parameters.AddWithValue("@Account", account);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Cellphone", cellphone);
                command.Parameters.AddWithValue("@Address", address);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("変更成功　合計" + totalChangeRows + "つの資料が変更された");
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex);
                    Console.WriteLine(ex.Message);
                }
                
                //finally
                //{
                //    connection.Close();
                //}
            }

        }


        public static DataTable BuildDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2021, 1, 1);
            for (var i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] = "UserName" + i;
                dr["Birthday"] = baseDate.AddDays(i);
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}