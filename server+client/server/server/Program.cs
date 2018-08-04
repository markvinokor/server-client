using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Data.OleDb;

namespace server
{
    class Program
    {
        public static string bdika(string str)
        {
            string str_new;
            if (str[0] == '1')
                str_new = addnew(str);
            else if (str == "firstname")
                str_new = find_firstname(str);
            else if (str == "lastname")
                str_new = find_lastname(str);
            else if (str == "id")
                str_new = find_id(str);
            else if (str == "phone")
                str_new = find_phone(str);
            else if (str == "email")
                str_new = find_email(str);
            else
                str_new = "no found";
            return str_new;
        }
        public static string addnew(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                OleDbConnection conn2 = new OleDbConnection(strDb);
                conn.Open();
                conn2.Open();
                OleDbCommand cmd = conn.CreateCommand();
                OleDbCommand cmd2 = conn.CreateCommand();
                str = str.Substring(1);
                string str1 = str.Substring(0, str.IndexOf('!'));
                string str2 = str.Substring(str1.Length+1, str.IndexOf('@')- str1.Length-1);
                string str3 = str.Substring(str2.Length+ str1.Length+2, str.IndexOf('#')- str1.Length- str2.Length-2);
                string str4 = str.Substring(str3.Length+ str2.Length+ str1.Length + 3, str.IndexOf('$') - str1.Length - str2.Length- str3.Length-3);
                string str5 = str.Substring(str.IndexOf('$') + 1);
                cmd2.CommandText = "delete * from people;";
                cmd.CommandText = "insert into people values ('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "');";
                int n1 = cmd2.ExecuteNonQuery();
                int n = cmd.ExecuteNonQuery();
                conn2.Close();
                conn.Close();
                return ("insert " + n.ToString() + " row" + "delete" + n1.ToString() + " row");
            }
            catch (Exception err)
            {
                return (err.Message);
            }
        }
        public static string find_firstname(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select name from people;", conn);
                dr = cmd.ExecuteReader();
                string str_new = "";
                while (dr.Read())
                    str_new += dr[0].ToString();
                dr.Close();
                conn.Close();
                if (str_new.Length == 0)
                    str_new = "not found";
                return str_new;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "error";
            }
        }
        public static string find_lastname(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select lastname from people;", conn);
                dr = cmd.ExecuteReader();
                string str_new = "";
                while (dr.Read())
                    str_new += dr[0].ToString();
                dr.Close();
                conn.Close();
                if (str_new.Length == 0)
                    str_new = "not found";
                return str_new;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "error";
            }
        }
        public static string find_id(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select id from people;", conn);
                dr = cmd.ExecuteReader();
                string str_new = "";
                while (dr.Read())
                    str_new += dr[0].ToString();
                dr.Close();
                conn.Close();
                if (str_new.Length == 0)
                    str_new = "not found";
                return str_new;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "error";
            }
        }
        public static string find_phone(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select phone from people;", conn);
                dr = cmd.ExecuteReader();
                string str_new = "";
                while (dr.Read())
                    str_new += dr[0].ToString();
                dr.Close();
                conn.Close();
                if (str_new.Length == 0)
                    str_new = "not found";
                return str_new;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "error";
            }
        }
        public static string find_email(string str)
        {
            try
            {
                string strDb;
                strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(strDb);
                conn.Open();
                OleDbDataReader dr;
                OleDbCommand cmd = new OleDbCommand("Select email from people;", conn);
                dr = cmd.ExecuteReader();
                string str_new = "";
                while (dr.Read())
                    str_new += dr[0].ToString();
                dr.Close();
                conn.Close();
                if (str_new.Length == 0)
                    str_new = "not found";
                return str_new;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return "error";
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                TcpListener server = new TcpListener(localAddr, port);
                server.Start();
                Console.WriteLine("address server : " + server.LocalEndpoint.ToString());
                byte[] bytes = new byte[256];
                string data = null;
                while (true)
                {
                    Console.WriteLine("Waiting to connection.......");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connecting .....");
                    Console.WriteLine(client.Client.RemoteEndPoint.ToString());
                    Console.WriteLine("time is : {0}", DateTime.Now.ToShortTimeString());
                    data = null;
                    NetworkStream stream = client.GetStream();
                    int i;
                    i = stream.Read(bytes, 0, bytes.Length);
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Message from client : {0}", data);
                    string data1 = bdika(data);
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(data1);
                    stream.Write(msg, 0, msg.Length);
                    client.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Console.Read();
        }
    }
}
