using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace dictionary
{
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

        private void temp_Load(object sender, EventArgs e)
        {

        }


        private void listBox2_Click(object sender, EventArgs e)
        {
            if(Form1.radioButton2.Checked==true && Form1.textBox1.Text.Count() == 0 && listBox2.SelectedItem.ToString() != "+")
            {
                string text = System.IO.File.ReadAllText(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + listBox2.SelectedItem.ToString() + ".txt");
                if (text.Contains("<***>"))
                {
                    input f2 = new input();
                    f2.Show();
                }
                else
                {
                    Form1.richTextBox2.Text = Form1.richTextBox2 .Text.ToString()+ text+"\n";
                }

            }
            else if (Form1.textBox1.Text.Count() != 0 && !File.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + Form1.textBox1.Text.ToString() + ".txt") && listBox2.SelectedItem.ToString() == "+")
            {
                //MessageBox.Show(Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString());
                listBox2.Items.Remove("+");
                listBox2.Items.Add(Form1.textBox1.Text.ToString() );
                listBox2.Items.Add("+");
                var myFile=File.Create(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + Form1.textBox1.Text.ToString() + ".txt");
                myFile.Close();
               // Application.Restart();
            }
            else if(Form1.textBox1.Text.Count() != 0 && Form1.textBox1.Text.ToString()=="*")
            {
                FileInfo file = new FileInfo(@"Data\"+ Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + listBox2.SelectedItem.ToString() + ".txt");               
                file.Delete();
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && !File.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + Form1.textBox1.Text.ToString() + ".txt"))
            {
                System.IO.File.Move(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" +
                    listBox2.SelectedItem.ToString() + ".txt",
                    @"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" +
                    Form1.textBox1.Text.ToString() + ".txt");
                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove("+");
                listBox2.Items.Add(Form1.textBox1.Text.ToString());
                listBox2.Items.Add("+");
            }
            else if (listBox2.SelectedItem.ToString() != "+")

            {
                //if (File.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + listBox2.SelectedItem.ToString() + ".txt"))
                {
                    string text = System.IO.File.ReadAllText(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString() + @"\" + listBox2.SelectedItem.ToString()+".txt");
                    Form1.richTextBox2.Text = text;
                    //if (text.Count() != 0)
                        //System.Windows.Forms.Clipboard.SetText(text);
                }
            }
            Form1.textBox1.Clear();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            string path = "Data";

            listBox2.Items.Clear();
            if ( Form1.textBox1.Text.Count() != 0 && !Directory.Exists(path + @"\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" +Form1.textBox1.Text.ToString())&& listBox1.SelectedItem.ToString() == "+")
            {
                //MessageBox.Show(Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString());
                listBox1.Items.Remove("+");
                listBox1.Items.Add(Form1.textBox1.Text.ToString());
                listBox1.Items.Add("+");
                Directory.CreateDirectory(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\"+ Form1.textBox1.Text.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && Form1.textBox1.Text.ToString() == "**")
            {

                System.IO.Directory.Delete("Data" + @"\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString(), true);
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && !Directory.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\c\" + Form1.textBox1.Text.ToString()))
            {
                System.IO.Directory.Move(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString(),
                    @"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" +
                    Form1.textBox1.Text.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove("+");
                listBox1.Items.Add(Form1.textBox1.Text.ToString());
                listBox1.Items.Add("+");
            }
            else if (listBox1.SelectedItem.ToString() != "+")
                    { DirectoryInfo di3 = new DirectoryInfo(path + @"\" + Form1.tc1.SelectedTab.Text.ToString() + @"\c\" + listBox1.SelectedItem.ToString());
                        FileInfo[] Files2 = di3.GetFiles("*.txt"); //Getting Text files
                        foreach (FileInfo file2 in Files2)
                        { listBox2.Items.Add(file2.Name.Substring(0, file2.Name.Count()-4)); }
                        listBox2.Items.Add("+"); }
            Form1.textBox1.Clear();
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            string path = "Data";

            listBox3.Items.Clear();
            if (Form1.textBox1.Text.Count() != 0 && !Directory.Exists(path + @"\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + Form1.textBox1.Text.ToString()) && listBox4.SelectedItem.ToString() == "+")
            {
                //MessageBox.Show(Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString());
                listBox4.Items.Remove("+");
                listBox4.Items.Add(Form1.textBox1.Text.ToString());
                listBox4.Items.Add("+");
                Directory.CreateDirectory(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + Form1.textBox1.Text.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && Form1.textBox1.Text.ToString() == "**")
            {
                
                System.IO.Directory.Delete("Data" + @"\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString(), true);
                listBox4.Items.Remove(listBox4.SelectedItem.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && !Directory.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + Form1.textBox1.Text.ToString() ))
            {
                System.IO.Directory.Move(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\"+listBox4.SelectedItem.ToString(),
                    @"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\" +
                    Form1.textBox1.Text.ToString() );
                listBox4.Items.Remove(listBox4.SelectedItem.ToString());
                listBox4.Items.Remove("+");
                listBox4.Items.Add(Form1.textBox1.Text.ToString());
                listBox4.Items.Add("+");
            }
            else if (listBox4.SelectedItem.ToString() != "+")

            {
                DirectoryInfo di3 = new DirectoryInfo(path + @"\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString());
                FileInfo[] Files2 = di3.GetFiles("*.txt"); //Getting Text files
                foreach (FileInfo file2 in Files2)
                {

                    listBox3.Items.Add(file2.Name.Substring(0, file2.Name.Count() - 4));

                }
                listBox3.Items.Add("+");
            }
            Form1.textBox1.Clear();
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            if (Form1.textBox1.Text.Count() != 0 && !File.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" + Form1.textBox1.Text.ToString() + ".txt") && listBox3.SelectedItem.ToString() == "+")
            {
                //MessageBox.Show(Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString());
                listBox3.Items.Remove("+");
                listBox3.Items.Add(Form1.textBox1.Text.ToString());
                listBox3.Items.Add("+");
                var myFile=File.Create(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" +listBox4.SelectedItem.ToString()+@"\"+Form1.textBox1.Text.ToString()+".txt");
                myFile.Close();
            }
            else if (Form1.textBox1.Text.Count() != 0 && Form1.textBox1.Text.ToString() == "*")
            {
                FileInfo file = new FileInfo(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" + listBox3.SelectedItem.ToString() + ".txt");
                file.Delete();
                listBox3.Items.Remove(listBox3.SelectedItem.ToString());
            }
            else if (Form1.textBox1.Text.Count() != 0 && !File.Exists(@"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" + Form1.textBox1.Text.ToString() + ".txt"))
            {
                System.IO.File.Move(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" + 
                    listBox3.SelectedItem.ToString() + ".txt",
                    @"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" +
                    Form1.textBox1.Text.ToString() + ".txt");
                listBox3.Items.Remove(listBox3.SelectedItem.ToString());
                listBox3.Items.Remove("+");
                listBox3.Items.Add(Form1.textBox1.Text.ToString());
                listBox3.Items.Add("+");
            }
            else if (listBox3.SelectedItem.ToString() != "+")

            {
                
                string text = System.IO.File.ReadAllText(@"Data\" + Form1.tc1.SelectedTab.Text.ToString() + @"\p\" + listBox4.SelectedItem.ToString() + @"\" + listBox3.SelectedItem.ToString()+".txt");
                Form1.richTextBox2.Text = text;
               //if( text.Count()!=0)
                //System.Windows.Forms.Clipboard.SetText(text);
            }
            Form1.textBox1.Clear();
        }

    }
}
