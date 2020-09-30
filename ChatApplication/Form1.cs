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
                                    

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private StreamReader str;
        private StreamWriter stw;
        string resiver;
        string text_send;
       
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIp=Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIp)
            {
                textlocalip.Text = adress.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textlocalip.Text = Getlocalip();
            textdestip.Text = Getlocalip();*/
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textlocalport.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter (client.GetStream());
            stw.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

            
            
            
            /*
            eplocal = new IPEndPoint(IPAddress.Parse(textlocalip.Text), Convert.ToInt32(textlocalport.Text));
            sck.Bind(eplocal);

            epdest = new IPEndPoint(IPAddress.Parse(textdestip.Text), Convert.ToInt32(textdestport.Text));
            sck.Connect(epdest);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epdest, new AsyncCallback(MessageCallBack), buffer);
*/
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
         /*   try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();

                string receivedMessage = aEncoding.GetString(receivedData);

                listmsgs.Items.Add("Ami : " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epdest, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }*/
        }
         private void buttonenv_Click(object sender, EventArgs e)
            {

                if (textmsg.Text != "")
                { text_send = textmsg.Text;
                backgroundWorker2.RunWorkerAsync();
                }
               textmsg.Text = "";
            /*ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textmsg.Text);

            sck.Send(sendingMessage);

            listmsgs.Items.Add("Moi : " + textmsg.Text);
            textmsg.Text = "";
*/
            }

       
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            { try 
            {
            resiver=str.ReadLine();
            this.listmsgs.Invoke(new MethodInvoker(delegate() { listmsgs.Text = "Toi   :"+"  " + resiver + "\n"; }));
               // resiver="";
            }catch(Exception x)
            {
            MessageBox.Show(x.Message.ToString());
            }
              
            }
            
              
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
           if (client.Connected)
            {
                 stw.WriteLine(text_send);
                      this.listmsgs.Invoke(new MethodInvoker(delegate() { listmsgs.Text = "Moi  :"+"  " + text_send + "\n"; }));
                   
                }
           else
           {
               MessageBox.Show("msg nonnn envoiye..");
           }
               backgroundWorker2.CancelAsync(); 

            }
            
              
       

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(textdestip.Text), int.Parse(textdestport.Text));
            try
            {
                client.Connect(ip_end);
                if (client.Connected)
                {
                    listmsgs.Text = ("connection vs servur" + "/n");
                    stw = new StreamWriter(client.GetStream());
                    str = new StreamReader(client.GetStream());
                    stw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;


                }
            }
            catch (Exception x)
            { MessageBox.Show(x.Message.ToString());   }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
