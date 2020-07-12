namespace dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tc1 = new System.Windows.Forms.TabControl();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(636, 0);
            richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(710, 670);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            richTextBox2.WordWrap = false;
            richTextBox2.AcceptsTab = true;
            // 
            // tc1
            // 
            tc1.Location = new System.Drawing.Point(0, 0);
            tc1.Margin = new System.Windows.Forms.Padding(2);
            tc1.Name = "tc1";
            tc1.SelectedIndex = 0;
            tc1.Size = new System.Drawing.Size(632, 658);
            tc1.TabIndex = 0;
            tc1.Click += new System.EventHandler(tc1_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Data Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(214, 663);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(418, 36);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1225, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1049, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(radioButton2);
            this.panel1.Controls.Add(radioButton1);
            this.panel1.Location = new System.Drawing.Point(875, 671);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 50);
            this.panel1.TabIndex = 9;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(70, 33);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Edit";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            radioButton1.Checked = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(79, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(84, 33);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Code";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(richTextBox2);
            this.Controls.Add(tc1);
            this.Controls.Add(textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Osama Adel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Label label1;
        public static System.Windows.Forms.TextBox textBox1;
        public static System.Windows.Forms.TabControl tc1;
        public static System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        public static System.Windows.Forms.RadioButton radioButton2;
        public static System.Windows.Forms.RadioButton radioButton1;
    }
}

