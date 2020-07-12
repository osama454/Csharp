using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary
{
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
        }
        public static string modify(string src, string old, string mod)
        {
            string result = src;
            string templ, tempr;

            int a, b, c;
            while (true)
            {
                if (result.Contains(old))
                {
                    a = result.IndexOf(old);
                    b = a + old.Length - 1;
                    c = result.Length;
                    templ = result.Substring(0, a);
                    tempr = result.Substring(b + 1, c - b - 1);
                    result = templ + mod + tempr;
                }
                else
                {break;}
            }
            return result;
        }
        public static void split(string src,string s ,ref string lift, ref string  right)
        {
            if (src.Contains(s))
            {
                int a, b,c;
                a = src.IndexOf(s);
                b = a + s.Length - 1;
                c = src.Length;
                lift = src.Substring(0, a);
                right = src.Substring(b + 1, c - b - 1);
            }
        }
        private void creat(string str)
        {
            //MessageBox.Show(str);
            str = str.Substring(1, str.Length - 1);
           // MessageBox.Show(str);

            int a, b,i=-1;
            string line;
            string temp1 = "", temp2 = "", temp3 = "";
            while (str.Length!=0)
            {
                i++;
                a = str.IndexOf("\n");

                //MessageBox.Show(a.ToString());
                b = str.Length;
                if (a  <= 0) break;
                line = str.Substring(0, a);
                //MessageBox.Show(line);
                str = str.Substring(a + 1, b - a-1);
                if(line.Contains("="))
                {
                    a = line.IndexOf("=");

                }
                else
                {
                    a = line.Length;
                }
                Label lbl = new Label();
                lbl.Text = line.Substring(0, a)+":";
                lbl.AutoSize = true;
                //lbl.Size = new System.Drawing.Size(75, 29);
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.AutoScroll = true;
                //flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
                flp.Location = new System.Drawing.Point(3, 3);
                flp.Size = new System.Drawing.Size(667, 42);
                flp.TabIndex = 3;
                flp.Controls.Add(lbl);
                flowLayoutPanel1.Controls.Add(flp);
                
                if (line.Contains("{"))
                {
                    
                    a = line.IndexOf("{");
                    b = line.IndexOf("}");
                    temp1 = line.Substring(a + 1, b - a - 1);
                    while (true)
                    {
                        
                       // MessageBox.Show(temp1);
                        split(temp1, ",", ref temp2, ref temp3);
                        temp1 = temp3;
                        RadioButton rb =new  RadioButton();
                        rb.AutoSize = true;
                        rb.Text = temp2;
                        flp.Controls.Add(rb);
                       // MessageBox.Show(temp2);
                        if (temp3.Contains(",")==false||temp2.Length<=0)
                        {
                            RadioButton rb2 = new RadioButton();
                            rb2.AutoSize = true;
                            rb2.Text = temp3;
                            flp.Controls.Add(rb2);
                            
                            if(line.Contains(":"))
                            {
                                a = line.IndexOf(":");
                                b = line.Length;
                                temp1 = line.Substring(a + 1, b - a - 1);
                                a= Int32.Parse(temp1);
                                RadioButton rb3 = (RadioButton)flowLayoutPanel1.Controls[i].Controls[a+1];
                                rb3.Checked = true;
                                

                            }
                            break;
                        }
                       
                    }


                }
                else
                {
                    TextBox tb = new TextBox();
                    tb.Size = new System.Drawing.Size(412, 36);
                    tb.AcceptsTab = true;
                    tb.Multiline = true;
                    flp.Controls.Add(tb);
                    if(line.Contains("="))
                    {
                        a = line.IndexOf("=");
                        b = line.Length;
                        tb.Text = line.Substring(a + 1, b - a - 1);
                        
                    }
                }

            }
        }



        private void input_Load(object sender, EventArgs e)
        {
            Form z = (Form)Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Controls[0];

            TabControl z2 = (TabControl)z.Controls[0];
            GroupBox z3 = (GroupBox)z2.TabPages[0].Controls[0];
            GroupBox z32 = (GroupBox)z2.TabPages[0].Controls[1];
            GroupBox z33 = (GroupBox)z2.TabPages[1].Controls[0];
            GroupBox z34 = (GroupBox)z2.TabPages[1].Controls[1];
            ListBox z4 = (ListBox)z3.Controls[0];//C+files
            ListBox z42 = (ListBox)z32.Controls[0];
            ListBox z5 = (ListBox)z33.Controls[0];
            ListBox z52 = (ListBox)z34.Controls[0];

            string path2 = "";
            if (z2.SelectedIndex == 0)
            { path2 = @"c\" + z42.SelectedItem.ToString() + @"\" + z4.SelectedItem.ToString(); }
            else { path2 = @"p\" + z52.SelectedItem.ToString() + @"\" + z5.SelectedItem.ToString(); }
            string path = @"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\" + path2 + ".txt";
            string text = System.IO.File.ReadAllText(path);
            string lift="", right="";
            split(text, "<***>",ref lift,ref right);
            creat(right);
           // MessageBox.Show(right);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(flowLayoutPanel1.Controls[0].Controls[0].Text.ToString());
            Form z = (Form)Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Controls[0];

            TabControl z2 = (TabControl)z.Controls[0];
            GroupBox z3 = (GroupBox)z2.TabPages[0].Controls[0];
            GroupBox z32 = (GroupBox)z2.TabPages[0].Controls[1];
            GroupBox z33 = (GroupBox)z2.TabPages[1].Controls[0];
            GroupBox z34 = (GroupBox)z2.TabPages[1].Controls[1];
            ListBox z4 = (ListBox)z3.Controls[0];//C+files
            ListBox z42 = (ListBox)z32.Controls[0];
            ListBox z5 = (ListBox)z33.Controls[0];
            ListBox z52 = (ListBox)z34.Controls[0];

            string path2 = "";
            if (z2.SelectedIndex == 0)
            { path2 = @"c\" + z42.SelectedItem.ToString() + @"\" + z4.SelectedItem.ToString(); }
            else { path2 = @"p\" + z52.SelectedItem.ToString() + @"\" + z5.SelectedItem.ToString(); }
            string path = @"Data\" + Form1.tc1.TabPages[Form1.tc1.SelectedIndex].Text.ToString() + @"\" + path2 + ".txt";
            string text = System.IO.File.ReadAllText(path);
            string lift = "", right = "";
            split(text, "<***>", ref lift, ref right);
            string str,lbl;
             
            int i = 0,j=0;
            while(true)
            {
                try
                {
                    Label lb = (Label)flowLayoutPanel1.Controls[i].Controls[0];

                }
                catch
                {
                    goto L3;
                }
                try
                {
                    TextBox tb = (TextBox)flowLayoutPanel1.Controls[i].Controls[1];
                    lbl = flowLayoutPanel1.Controls[i].Controls[0].Text.ToString();
                    lbl = lbl.Substring(0, lbl.Length - 1);
                    str = tb.Text.ToString();
                    if (str.Length <= 0) goto L ;
                    //MessageBox.Show(str);
                    i += 1;

                }
                catch(Exception)
                {
                    try
                    {
                        j = 1;
                        while (true)
                        { 
                            RadioButton tb = (RadioButton)flowLayoutPanel1.Controls[i].Controls[j];
                            if(tb.Checked)
                            {
                                str = tb.Text.ToString();
                                lbl = flowLayoutPanel1.Controls[i].Controls[0].Text.ToString();
                                lbl = lbl.Substring(0, lbl.Length - 1);
                                //MessageBox.Show(str);
                                i += 1;
                                //MessageBox.Show(str);
                                goto L2;
                            }
                            j++;
                        }
                        
                
                        
                    }
                    catch(Exception)
                    {
                        //MessageBox.Show(j.ToString());
                        goto L;
                    }
                }
                L2:
                //MessageBox.Show(lbl);
                lift = modify(lift, "<" + lbl + ">", str);
               // MessageBox.Show(lift);

            }
            
            L3:
            Form1.richTextBox2.Text = Form1.richTextBox2.Text  + lift ;
            this.Close();
        L:;


        }
    }
}
