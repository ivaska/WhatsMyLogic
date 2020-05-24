using System;
using System.IO;
using System.Net.Sockets;
//using MySql;
//using MySql.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace ImGraph
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }

        public void Encript()
        {   //https://docs.microsoft.com/ru-ru/dotnet/standard/security/encrypting-data
            try
            {
                //Create a TCP connection to a listening TCP process.  
                //Use "localhost" to specify the current computer or  
                //replace "localhost" with the IP address of the   
                //listening process.    
                TcpClient tcp = new TcpClient("localhost", 11000);

                //Create a network stream from the TCP connection.   
                NetworkStream netStream = tcp.GetStream();

                //Create a new instance of the RijndaelManaged class  
                // and encrypt the stream.  
                RijndaelManaged rmCrypto = new RijndaelManaged();

                byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] iv = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt   
                //it with the Rijndael class.  
                CryptoStream cryptStream = new CryptoStream(netStream,
                rmCrypto.CreateEncryptor(key, iv),
                CryptoStreamMode.Write);

                //Create a StreamWriter for easy writing to the   
                //network stream.  
                StreamWriter sWriter = new StreamWriter(cryptStream);

                //Write to the stream.  
                sWriter.WriteLine("Hello World!");

                //Inform the user that the message was written  
                //to the stream.  
                Console.WriteLine("The message was sent.");

                //Close all the connections.  
                sWriter.Close();
                cryptStream.Close();
                netStream.Close();
                tcp.Close();
            }
            catch
            {
                //Inform the user that an exception was raised.  
                Console.WriteLine("The connection failed.");
            }
        }

        private void TextBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MySql.Data.MySqlClient.MySqlConnection conn;
            //string myConnectionString;

            // myConnectionString = "server=127.0.0.1;uid=uzzer;" +
            //"pwd=W@11B@se;database=blockchain";

            // MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
            //try
            //{
            //    conn = new MySql.Data.MySqlClient.MySqlConnection();
            //    conn.ConnectionString = myConnectionString;
            //    conn.Open();

            //    cmd.Connection = conn;
            //    cmd.CommandType = CommandType.Text;

            //    cmd.CommandText = "select * from wallets";
            //    MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            //    int i;
            //    string str=string.Empty;
            //    while (reader.Read())
            //    {
            //        for (i=0;i< reader.FieldCount; i++)
            //        {
            //            str += reader[i].ToString()+" ";
            //        }
            //        MessageBox.Show(str);
            //        str = string.Empty;
            //        //Console.WriteLn(reader[0], reader[1]...);
            //    }
            //    conn.Close();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            ////находит только первый фрагмент
            //// -1 если ничего не найдено
            //int start, len;
            //int found = richTextBox1.Find("купить",0,RichTextBoxFinds.WholeWord);
            //while (found != -1) 
            //{
            //        richTextBox1.SelectionColor = Color.Red;
            //        start = richTextBox1.SelectionStart;
            //        len = richTextBox1.SelectionLength;
            //        found = richTextBox1.Find("купить", start + len, RichTextBoxFinds.WholeWord);
            //}
        }
    }
}
