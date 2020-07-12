using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            string path = "Data";
            DirectoryInfo di1 = new DirectoryInfo(path);
            DirectoryInfo[] diArr = di1.GetDirectories();
            int i = 0;
            //add the topics
            foreach (DirectoryInfo dri in diArr)
            {
                tc1.TabPages.Add(dri.Name);
                //z42.Items.Add(dri.Name);
                temp f = new temp();

                f.MdiParent = this;
                tc1.TabPages[i].Controls.Add(f);
                f.Show();
                Form z = (Form)tc1.TabPages[i].Controls[0];
                i++;
                TabControl z2 = (TabControl)z.Controls[0];
                GroupBox z3 = (GroupBox)z2.TabPages[0].Controls[0];
                GroupBox z32 = (GroupBox)z2.TabPages[0].Controls[1];
                GroupBox z33 = (GroupBox)z2.TabPages[1].Controls[0];
                GroupBox z34 = (GroupBox)z2.TabPages[1].Controls[1];
                ListBox z4 = (ListBox)z3.Controls[0];
                ListBox z42 = (ListBox)z32.Controls[0];
                ListBox z5 = (ListBox)z33.Controls[0];
                ListBox z52 = (ListBox)z34.Controls[0];


                //add the files in code dictionary
                DirectoryInfo di2 = new DirectoryInfo(path + @"\" + dri.Name.ToString() + @"\" + "c");
                DirectoryInfo[] Files1 = di2.GetDirectories();
                foreach (DirectoryInfo file1 in Files1)
                {
                    z42.Items.Add(file1.Name);
                }
                z42.Items.Add("+");
                //add the files in Projects
                DirectoryInfo di4 = new DirectoryInfo(path + @"\" + dri.Name.ToString() + @"\" + "p");
                DirectoryInfo[] Files3 = di4.GetDirectories(); //Getting Text files
                foreach (DirectoryInfo file3 in Files3)
                {
                    z52.Items.Add(file3.Name);
                }
                z52.Items.Add("+");

            }
            tc1.TabPages.Add("+");
           // radioButton1.
        }

        private void tc1_Click(object sender, EventArgs e)
        {   if (tc1.SelectedIndex == tc1.TabPages.Count - 1  && textBox1.Text.Count()!=0 && !Directory.Exists(@"Data\"+textBox1.Text.ToString()))
            {
                
                tc1.TabPages[tc1.TabPages.Count - 1].Text = textBox1.Text.ToString();
                tc1.TabPages.Add("+");
                Directory.CreateDirectory(@"Data\" + textBox1.Text.ToString());
                Directory.CreateDirectory(@"Data\" + textBox1.Text.ToString()+@"\p");
                Directory.CreateDirectory(@"Data\" + textBox1.Text.ToString() + @"\c");
                Application.Restart();

            }
            else if (textBox1.Text.Count() != 0 && textBox1.Text.ToString() == "***")
            {

                System.IO.Directory.Delete("Data" + @"\" + Form1.tc1.TabPages[tc1.SelectedIndex].Text.ToString() , true);
                Application.Restart();

            }

            else if(textBox1.Text.Count() != 0 && !Directory.Exists(@"Data\" + textBox1.Text.ToString()))
            {

                System.IO.Directory.Move(@"Data\" + tc1.TabPages[tc1.SelectedIndex].Text.ToString(),
                    @"Data\" + textBox1.Text.ToString());

                tc1.TabPages[tc1.SelectedIndex].Text = textBox1.Text.ToString();
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form z = (Form)tc1.TabPages[tc1.SelectedIndex].Controls[0];
            
            TabControl z2 = (TabControl)z.Controls[0];
            GroupBox z3 = (GroupBox)z2.TabPages[0].Controls[0];
            GroupBox z32 = (GroupBox)z2.TabPages[0].Controls[1];
            GroupBox z33 = (GroupBox)z2.TabPages[1].Controls[0];
            GroupBox z34 = (GroupBox)z2.TabPages[1].Controls[1];
            ListBox z4 = (ListBox)z3.Controls[0];
            ListBox z42 = (ListBox)z32.Controls[0];
            ListBox z5 = (ListBox)z33.Controls[0];
            ListBox z52 = (ListBox)z34.Controls[0];
            if (radioButton1.Checked == true)
            {
                string path2 = "";
                if (z2.SelectedIndex == 0)
                { path2 = @"c\" + z42.SelectedItem.ToString() + @"\" + z4.SelectedItem.ToString(); }
                else { path2 = @"p\" + z52.SelectedItem.ToString() + @"\" + z5.SelectedItem.ToString(); }
                string path = @"Data\" + tc1.TabPages[tc1.SelectedIndex].Text.ToString() + @"\" + path2 + ".txt";
                TextWriter tw = new StreamWriter(path);
                tw.Write(richTextBox2.Text.ToString());
                tw.Close();
            }
            else
            {
                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = "unknown.txt";
                // set filters - this can be done in properties as well
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        sw.Write(richTextBox2.Text.ToString());
                }
            }
        }

        private void tc1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter(@"Data/temp.txt");
            tw.Write(richTextBox2.Text.ToString());
            tw.Close();



           
                Form z = (Form)tc1.TabPages[tc1.SelectedIndex].Controls[0];

                TabControl z2 = (TabControl)z.Controls[0];
                GroupBox z3 = (GroupBox)z2.TabPages[0].Controls[0];
                GroupBox z32 = (GroupBox)z2.TabPages[0].Controls[1];
                GroupBox z33 = (GroupBox)z2.TabPages[1].Controls[0];
                GroupBox z34 = (GroupBox)z2.TabPages[1].Controls[1];
                ListBox z4 = (ListBox)z3.Controls[0];
                ListBox z42 = (ListBox)z32.Controls[0];
                ListBox z5 = (ListBox)z33.Controls[0];
                ListBox z52 = (ListBox)z34.Controls[0];

                z4.ClearSelected();
                z5.ClearSelected(); 






        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"Data\temp.txt");
            richTextBox2.Text = text;


            
        }
    }
}
