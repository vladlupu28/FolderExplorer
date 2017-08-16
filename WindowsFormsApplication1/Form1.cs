using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public List<DirectorVideo> listaDirectoare =new List<DirectorVideo>();
        public Form1()
        {
            InitializeComponent();
            //PopulateTreeView("E:\\Filme\\BBC - Connections -  Complete, History, Science");
            PopulateTreeView("E:\\Filme");
            
            this.treeView1.NodeMouseClick +=new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
           
        }
        private void PopulateTreeView(String nume)
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(nume);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        void treeView1_NodeMouseClick(object sender,
            TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            
            int i = 0;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"), 
                     new ListViewItem.ListViewSubItem(item, 
						dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
                DirectorVideo dv = new DirectorVideo();
                dv.Id = i;
                dv.Nume = dir.Name;
                //nodeDirInfo.GetFiles()
                foreach (FileInfo file in  dir.GetFiles())
                {
                    String[] aux;
                    aux = file.Name.Split('.');
                    if (aux[(aux.Length - 1)] == "mkv" || aux[(aux.Length - 1)] == "avi")
                    {
                        item = new ListViewItem(file.Name, 1);
                        subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), 
                     new ListViewItem.ListViewSubItem(item, 
						file.LastAccessTime.ToShortDateString())};

                        item.SubItems.AddRange(subItems);
                        listView1.Items.Add(item);
                        FisierVideo fv = new FisierVideo();
                        fv.Nume = file.Name;
                        dv.Fisiere.Add(fv);

                    }
                    
                }
                listaDirectoare.Add(dv);
                i++;
            }
            

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var indices = listView1.SelectedIndices;

            ListViewItem itm = listView1.Items[indices[0]];

            String nume = itm.Text;
            Form2 macheta = new Form2();
            macheta.ShowDialog();
            int ok = 1;
            while (ok == 1)
            {
                if (macheta.IsDisposed)
                {
                    ok = 0;
                    if (macheta.DialogResult == DialogResult.OK)
                    {
                        float rating = macheta.rating;
                        float time = macheta.time;
                        listView1.Items[indices[0]].SubItems.Add(new ListViewItem.ListViewSubItem(itm, rating.ToString()));
                        listView1.Items[indices[0]].SubItems.Add(new ListViewItem.ListViewSubItem(itm, time.ToString()));
                        foreach (DirectorVideo dir in listaDirectoare)
                        {
                            foreach (FisierVideo fis in dir.Fisiere)
                            {
                                if (fis.Nume == itm.Text)
                                {
                                    fis.Rating = rating;
                                    fis.Durata = time;
                                }
                            }
                        }
                    }
                }

                if (macheta.DialogResult == DialogResult.Cancel)
                {
                    ok = 0;
                }
            }
        }
        private void butonAdaugare_Click(object sender, EventArgs e)
        {
            Form3 macheta = new Form3();
            macheta.ShowDialog();
            ListViewItem item = null;
            ListViewItem.ListViewSubItem[] subItems;
            int ok = 1;
            while (ok == 1)
            {
                if (macheta.IsDisposed)
                {
                    ok = 0;
                    if (macheta.DialogResult == DialogResult.OK)
                    {
                        item = new ListViewItem(macheta.nume);
                        subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), 
                     new ListViewItem.ListViewSubItem(item, DateTime.Today.ToShortDateString()),
                     new ListViewItem.ListViewSubItem(item, macheta.rating.ToString()),
                     new ListViewItem.ListViewSubItem(item, macheta.time.ToString())
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                    String aux;
                    aux = treeView1.SelectedNode.Text;
                    FisierVideo nou = new FisierVideo();
                    nou.Nume = macheta.nume;
                    nou.Rating = macheta.rating;
                    nou.Durata = macheta.time;
                        foreach (DirectorVideo dir in listaDirectoare)
                        {
                            if (dir.Nume == aux)
                            {
                                dir.Fisiere.Add(nou);
                            }
                        }

                    }
                }

                if (macheta.DialogResult == DialogResult.Cancel)
                {
                    ok = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butonSearch_Click(object sender, EventArgs e)
        {
            String nume = tbSearch.Text;
            bool valid = true;
            if (string.IsNullOrWhiteSpace(nume))
            {
                ep_Search.Icon = Properties.Resources.err;
                ep_Search.SetError((Control)sender, "Introduceti filmul cautat!");
                valid = false;
            }
            else { 
                ep_Search.Icon = Properties.Resources.Ok;
                ep_Search.SetError((Control)sender, "A fost gasit!");
            }
            if (!valid)
            {
                MessageBox.Show("Exista erori");
                return;
            }
            else
                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.Text != tbSearch.Text)
                    {
                        listView1.Items.Remove(it);
                    }
                }
            
        }

        private void butonPrint_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.ShowDialog();

            
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            
            Graphics g = e.Graphics;

            int distanta = 0;
            int x = 10;
            //MessageBox.Show()
            g.DrawString("Lista filme:", Font, new SolidBrush(Color.Black), new Point(10, 10));
            foreach (DirectorVideo it in listaDirectoare){
                g.DrawString(it.AfisareFilme(), Font, new SolidBrush(Color.BlueViolet), new Point(x, distanta));
                distanta += 10;
            }

        }

        private void butonSearch_Validating(object sender, CancelEventArgs e)
        {
            String search = tbSearch.Text;
            if (string.IsNullOrWhiteSpace(search))
            {
                ep_Search.Icon = Properties.Resources.err;
                ep_Search.SetError((Control)sender, "Introduceti filmul cautat!");
            }
            else
            {
                ep_Search.Icon = Properties.Resources.Ok;
                ep_Search.SetError((Control)sender, "A fost gasit!");
            }
        }

        private void butonSearch_Validated(object sender, EventArgs e)
        {
            ep_Search.Clear();
        }

        private void butonDB_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DataBaseFilme.accdb; Persist Security Info = False;");
            OleDbCommand comanda = new OleDbCommand();

            try
            {
                conexiune.Open();
                

                comanda.Connection = conexiune;
                
                foreach (DirectorVideo dir in listaDirectoare)
                {
                    foreach (FisierVideo video in dir.Fisiere)
                    {
                        comanda.CommandText = "insert into Filme values(?,?,?)";
                        
                        comanda.Parameters.Add("Nume", OleDbType.Char, 100).Value = video.Nume;
                        comanda.Parameters.Add("Rating", OleDbType.Numeric, 2).Value = video.Rating;
                        comanda.Parameters.Add("Durata", OleDbType.Numeric, 100).Value = video.Durata;
                        comanda.ExecuteNonQuery();
                       
                  
                }
                }
                MessageBox.Show("Date salvate!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
           
      }

              private void butonSalvareXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FisierVideo>));
            using (TextWriter writer = new StreamWriter("SerializedXML.xml"))
            {
                foreach (DirectorVideo dir in listaDirectoare)
                {
                    serializer.Serialize(writer, dir.Fisiere);
                }
            }
        }

              private void listView1_SelectedIndexChanged(object sender, EventArgs e)
              {

              }
    }
       
 
        

        



    }

