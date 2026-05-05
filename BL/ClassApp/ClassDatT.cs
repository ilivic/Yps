using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace BL.ClassApp
{
    public class ClassDatT
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NUGN0TR\\SQLL;Persist Security Info=True;User ID=sa;Password=9113164242Io!!;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public static List<Users> ListUser {  get; set; }
        public static void ClEventAddUser(string _name,string _login,string _pass)
        {
           try
           {
                connection.Open();
                SqlCommand com = new SqlCommand("" +
                    "USE [HeadHor] " +
                    "INSERT INTO " +
                    "[Users] ([Name],[Login],[pass]) " +
                    "VALUES " +
                    "(@Name,@Login,@pass)" +
                    "", connection);
                com.Parameters.AddWithValue("@Name", _name);
                com.Parameters.AddWithValue("@Login", _login);
                com.Parameters.AddWithValue("@pass", _pass);
                com.ExecuteNonQuery();
                MessageBox.Show("Успешно ");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Ошибка");
            }
            finally 
            {
                connection.Close();
            }

        }
        public static void GetUser()
        {
         GetUsers();
            
        }
        private static void GetUsers()
        {
            try
            {
                ListUser = new List<Users>();
                connection.Open();
                SqlCommand com = new SqlCommand("" +
                    "USE [HeadHor] " +
                    "select * from Users", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ListUser.Add(new Users()
                    {
                        id = Convert.ToInt32(reader[0]),
                        Name = reader[1].ToString(),
                        Login = reader[2].ToString(),
                        Password = reader[3].ToString(),
                    });
                }
                reader.Close();
         
                MessageBox.Show("Успешно ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public class Users
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
