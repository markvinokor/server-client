using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message;
                Int32 port = int.Parse(textBox6.Text);
                IPAddress addressserver = IPAddress.Parse(textBox7.Text);
                TcpClient client = new TcpClient(addressserver.ToString(), port);
                listBox1.Items.Clear();
                listBox1.Items.Add("Connection to server :");
                byte[] data = System.Text.Encoding.ASCII.GetBytes(textBox3.Text);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                string messagefromserver = "";
                data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                messagefromserver = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                listBox1.Items.Add("Answer from Server :" + messagefromserver);
                stream.Close();
                client.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string message;
                    Int32 port = int.Parse(textBox6.Text);
                    IPAddress addressserver = IPAddress.Parse(textBox7.Text);
                    TcpClient client = new TcpClient(addressserver.ToString(), port);
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Connection to server :");
                    message = "1" + textBox4.Text + "!" + textBox5.Text + "@" + textBox2.Text + "#" + textBox3.Text + "$" + textBox1.Text;
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    string messagefromserver = "";
                    data = new byte[256];
                    int bytes = stream.Read(data, 0, data.Length);
                    messagefromserver = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    listBox1.Items.Add("Answer from Server :" + messagefromserver);
                    stream.Close();
                    client.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    string Message = "firstname";
                    Int32 port = int.Parse("13000");
                    IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                    TcpClient client = new TcpClient(addressserver.ToString(), port);
                    byte[] AskData = System.Text.Encoding.ASCII.GetBytes(Message);
                    NetworkStream stream = client.GetStream();
                    stream.Write(AskData, 0, AskData.Length);
                    string DataRecieved = "";
                    AskData = new byte[256];
                    int bytes = stream.Read(AskData, 0, AskData.Length);
                    DataRecieved = System.Text.Encoding.ASCII.GetString(AskData, 0, bytes);
                    Message = DataRecieved;
                    label11.Text = Message;
                    stream.Close();
                    client.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        string Message = "lastname";
                        Int32 port = int.Parse("13000");
                        IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                        TcpClient client = new TcpClient(addressserver.ToString(), port);
                        byte[] AskData = System.Text.Encoding.ASCII.GetBytes(Message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(AskData, 0, AskData.Length);
                        string DataRecieved = "";
                        AskData = new byte[256];
                        int bytes = stream.Read(AskData, 0, AskData.Length);
                        DataRecieved = System.Text.Encoding.ASCII.GetString(AskData, 0, bytes);
                        Message = DataRecieved;
                        label11.Text = Message;
                        stream.Close();
                        client.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        string Message = "id";
                        Int32 port = int.Parse("13000");
                        IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                        TcpClient client = new TcpClient(addressserver.ToString(), port);
                        byte[] AskData = System.Text.Encoding.ASCII.GetBytes(Message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(AskData, 0, AskData.Length);
                        string DataRecieved = "";
                        AskData = new byte[256];
                        int bytes = stream.Read(AskData, 0, AskData.Length);
                        DataRecieved = System.Text.Encoding.ASCII.GetString(AskData, 0, bytes);
                        Message = DataRecieved;
                        label11.Text = Message;
                        stream.Close();
                        client.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        string Message = "phone";
                        Int32 port = int.Parse("13000");
                        IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                        TcpClient client = new TcpClient(addressserver.ToString(), port);
                        byte[] AskData = System.Text.Encoding.ASCII.GetBytes(Message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(AskData, 0, AskData.Length);
                        string DataRecieved = "";
                        AskData = new byte[256];
                        int bytes = stream.Read(AskData, 0, AskData.Length);
                        DataRecieved = System.Text.Encoding.ASCII.GetString(AskData, 0, bytes);
                        Message = DataRecieved;
                        label11.Text = Message;
                        stream.Close();
                        client.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        string Message = "email";
                        Int32 port = int.Parse("13000");
                        IPAddress addressserver = IPAddress.Parse("127.0.0.1");
                        TcpClient client = new TcpClient(addressserver.ToString(), port);
                        byte[] AskData = System.Text.Encoding.ASCII.GetBytes(Message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(AskData, 0, AskData.Length);
                        string DataRecieved = "";
                        AskData = new byte[256];
                        int bytes = stream.Read(AskData, 0, AskData.Length);
                        DataRecieved = System.Text.Encoding.ASCII.GetString(AskData, 0, bytes);
                        Message = DataRecieved;
                        label11.Text = Message;
                        stream.Close();
                        client.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }

        }
    }
}
