

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using System.IO;

namespace WpfApp1
{
    public static class Connection
    {

        static MySql.Data.MySqlClient.MySqlConnection conn;
        static string myConnectionString;
        static string host = "localhost";
        static string database = "project";
        static string UID = "root";
        static string password = "dtn38hyj";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + UID + ";Password=" + password;
        public static bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + UID + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        public static void Close()
        {
            conn.Close();
            conn.Dispose();
        }


        public static void AddOrder(int userid, List<int> orders)
        {
            Open();

            List<string> Rows = new List<string>();
            foreach (var menu_id in orders)
            {
                Rows.Add(string.Format("('{0}','{1}')", MySqlHelper.EscapeString(userid.ToString()), MySqlHelper.EscapeString(menu_id.ToString())));
            }

            var orderstring = string.Join(",", Rows);

            string Query = "insert into project.orders (user_id,menu_id) values " + orderstring + "";
            using (var cmd = new MySqlCommand(Query, conn))
            {
                cmd.ExecuteNonQuery();
            }

            Close();
        }

        public static Dictionary<int, List<int>> ReadOrders()
        {
            Open();
            using (var cmd = new MySqlCommand("select * from orders;", conn))
            {

                var reader = cmd.ExecuteReader();

                var dictionaryorder = new Dictionary<int, List<int>>();

                while (reader.Read())
                {
                    var userid = reader.GetInt32("user_id");
                    var menuid = reader.GetInt32("menu_id");

                    if (dictionaryorder.ContainsKey(userid))
                    {

                        dictionaryorder[userid].Add(menuid);
                    }
                    else
                    {
                        dictionaryorder.Add(userid, new List<int> { menuid });
                    }

                }
                Close();
                return dictionaryorder;
            }
        }

        public static Dictionary<int, string> MenuLookUpTable()
        {
            Open();
            using (var cmd = new MySqlCommand("select * from menu;", conn))
            {

                var reader = cmd.ExecuteReader();

                var lookuptable = new Dictionary<int, string>();

                while (reader.Read())
                {
                    var menuid = reader.GetInt32("id");
                    var name = reader.GetString("name");

                    lookuptable.Add(menuid, name);


                }
                Close();
                return lookuptable;
            }
        }


        public static DataTable ReadMenu()
        {
            Open();
            using (var adapter = new MySqlDataAdapter("SELECT * FROM menu", conn))
            {
                var dt = new DataTable();
                adapter.Fill(dt);
                Close();

                return dt;
            }

        }

        public static void RemoveOrder(int userid)
        {
            Open();

            string Query = "DELETE FROM project.orders WHERE user_id = @userid;";

            using (var cmd = new MySqlCommand(Query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.ExecuteNonQuery();
            }

            Close();
        }

    }
}
