using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsMyLogic;
//using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
//using IWshRuntimeLibrary;
namespace ImGraph
{
    public partial class Form1 : Form
    {
        Board board = new Board(4);
        public void Vizualize() {
            label11.Text = board.Cells[1 - 1, 1 - 1].ToString();
            label12.Text = board.Cells[1 - 1, 2 - 1].ToString();
            label13.Text = board.Cells[1 - 1, 3 - 1].ToString();
            label14.Text = board.Cells[1 - 1, 4 - 1].ToString();
            label21.Text = board.Cells[2 - 1, 1 - 1].ToString();
            label22.Text = board.Cells[2 - 1, 2 - 1].ToString();
            label23.Text = board.Cells[2 - 1, 3 - 1].ToString();
            label24.Text = board.Cells[2 - 1, 4 - 1].ToString();
            label31.Text = board.Cells[3 - 1, 1 - 1].ToString();
            label32.Text = board.Cells[3 - 1, 2 - 1].ToString();
            label33.Text = board.Cells[3 - 1, 3 - 1].ToString();
            label34.Text = board.Cells[3 - 1, 4 - 1].ToString();
            label41.Text = board.Cells[4 - 1, 1 - 1].ToString();
            label42.Text = board.Cells[4 - 1, 2 - 1].ToString();
            label43.Text = board.Cells[4 - 1, 3 - 1].ToString();
            label44.Text = board.Cells[4 - 1, 4 - 1].ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node node = new Node("A", null);
            Node node2 = new Node("B", "3");
            Edge edge = new Edge("e1",true, node.id, node2.id);
            List<Edge> edges = new List<Edge>();
            List<Node> nodes = new List<Node>();
            edges.Add(edge);
            nodes.Add(node);
            nodes.Add(node2);
            Bitmap bitmap = new Bitmap(200, 150);
            
            for (int i = 1; i < 150; i++)
            {
                bitmap.SetPixel(i, i, Color.Red);
            }
            //pictureBox1.Image = bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(new Pen(Color.Green), new Rectangle(10, 10, 100, 100));
           // g.dr
            pictureBox1.Image = bitmap;
            //graph.addNode();
            //graph.addEdge();
            //Svg.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Graph));
            // десериализация
            using (FileStream fs = new FileStream("graph1.xml", FileMode.OpenOrCreate))
            {
                Graph newGraph = (Graph)formatter.Deserialize(fs);
                MessageBox.Show(String.Format("Ребер {0}, Вершин {1}", newGraph.edges.Length,  newGraph.nodes.Length));
               // Console.WriteLine("Объект десериализован");
                //Console.WriteLine("Имя: {0} --- Возраст: {1}", newPerson.Name, newPerson.Age);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Graph));
            Node node = new Node("A", null);
            Node node2 = new Node("B", "3");
            Edge edge = new Edge("e1", true, node.id, node2.id);
            Data data = new Data();
            Data data2 = new Data();
            data.key = "+";
            data2.key = "1000000";
            node.data = new Data[] { data2 };
            edge.data = new Data[] { data, data2 };
            Graph graph = new Graph(new Node[] { node, node2 }, new Edge[] { edge });

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("graph1.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, graph);

                //Console.WriteLine("Объект сериализован");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Matrix m = new Matrix(2, 2);
            double[,] d= new double[2, 2];
            d =  m.Multiply(new double[,] { { 1,0},{ 0,1} }, new double[,] { {1,10 }, {0, 11 } });
            MessageBox.Show(string.Format("{0} {1} \n {2} {3}",d[0,0],d[0,1],d[1,0],d[1,1]));
            d = m.Sum(new double[,] { { 1, 0 }, { 0, 1 } }, new double[,] { { 1, 10 }, { 0, 11 } });
            MessageBox.Show(string.Format("{0} {1} \n {2} {3}", d[0, 0], d[0, 1], d[1, 0], d[1, 1]));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Red,4),new Point(19,100),new Point(100,19));
            //e.Graphics.
            Point[] piramid = new Point[3];
            Point Center = new Point(this.Width /2, this.Height / 2);
            piramid[0] = new Point(100+Center.X,0+Center.Y);
            piramid[1] = new Point(0 + Center.X, 0 + Center.Y);
            piramid[2] = new Point(0 + Center.X, -100 + Center.Y);
            e.Graphics.DrawLine(new Pen(Color.Red,4),piramid[0],piramid[1]);
            e.Graphics.DrawLine(new Pen(Color.Red, 4), piramid[1], piramid[2]);
            e.Graphics.DrawLine(new Pen(Color.Red, 4), piramid[2], piramid[0]);
            e.Graphics.DrawCurve(new Pen(Color.Green,3),piramid);
            e.Graphics.DrawClosedCurve(new Pen(Color.Green, 3), piramid);
            e.Graphics.DrawLines(new Pen(Color.Green, 3), piramid);
            // e.Graphics.DrawPath();
            //System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath(piramid, new byte[] { 2, 2, 2 });
            //e.Graphics.DrawPath(new Pen(Color.Red),path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Board board = new Board(4);
            board.Add2s();
            Vizualize();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            board.Rotate(Board.Side.Right);
            Vizualize();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int ff= 0xff+1;

            // MessageBox.Show(ff.ToString());
            int[,] A = new int[4, 5];
            MessageBox.Show( A.GetLength(1).ToString());
            int[,,] a = new int[5, 2, 4];
            MessageBox.Show(a.Length.ToString());
            string str = "около кола-колокола";
            str.Replace("о", "");
            
            MessageBox.Show(str);
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < list.Count; i++) Console.Write("{0}\t", list[i]);
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(4);
            //queue.Enqueue(8);
            //queue.Enqueue(16);
            //foreach (int i in queue)
            //{
            //    Console.Write("{0} ", i);
            //}
            int k, j, s = 0;
            for (k=1,j=5; k<j; ++k,--j)
            { s += k; }
            MessageBox.Show(s.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            MCBL mCBL = new MCBL();
            MCBL.Command command = new MCBL.Command();
            command.Interprete("do jam=wow");
            MessageBox.Show(command.verb + " " + command.noun);
            Cash cash = new Cash();
            cash.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            StoreByExn storeByExn = new StoreByExn("d:\\files");
            storeByExn.PutFile(@"C:\Users\k25v\OneDrive\Documents\hh.pdf");
        }
    }
}
