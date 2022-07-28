using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NotePadPlus
{
    public partial class Form1 : Form
    {
        //private char star = '*';
        private string title = "Untitled - ";
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            InitializeComponent2();
            InitializeComponent3();
            toolStripStatusLabel3.Text.PadLeft(20);
            toolStripStatusLabel1.Text = Environment.MachineName.PadRight(20);
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            //file();

        }

        // Fild
        private System.Windows.Forms.Form Formfi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;


        private void InitializeComponent2()
        {
            this.Formfi = new Form();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            // 
            // textBox1
            // 
            Formfi.Location = new System.Drawing.Point(50, 50);
            Formfi.StartPosition = FormStartPosition.CenterScreen;
            Formfi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Formfi.MaximizeBox = false;
            this.Formfi.ClientSize = new System.Drawing.Size(371, 176);
            Formfi.MinimizeBox = false;
            Formfi.Name = "Form2";
            Formfi.ShowIcon = false;
            Formfi.Text = "Find";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Formfi.ResumeLayout(false);
            Formfi.PerformLayout();
            Formfi.Controls.Add(this.checkBox2);
            Formfi.Controls.Add(this.checkBox1);
            Formfi.Controls.Add(this.groupBox1);
            Formfi.Controls.Add(this.button2);
            Formfi.Controls.Add(this.button1);
            Formfi.Controls.Add(this.label1);
            Formfi.Controls.Add(this.textBox1);
            //
            //
            //
            this.textBox1.Location = new System.Drawing.Point(74, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find What";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(116, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Up";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(63, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Down";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Match Case";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Wrap around";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
        }

        public void button1_Click(object Sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            int a = richTextBox1.SelectionStart + 1;

            if (radioButton1.Checked == true &&
                (checkBox1.Checked == false && checkBox2.Checked == false))
            {
                int startpos = richTextBox1.Find(s1.ToCharArray(), a);
                int leanth = s1.Length; a = startpos;
                richTextBox1.Focus();
                if (startpos > -1)
                {
                    richTextBox1.Select(startpos, textBox1.Text.Length);
                }
                else
                {
                    richTextBox1.SelectionStart = 0;
                    MessageBox.Show("Finsh Find" + textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else if (radioButton1.Checked == true && (checkBox1.Checked == true && checkBox2.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1, StringComparison.CurrentCulture);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }


            else if (radioButton1.Checked == true && (checkBox1.Checked == true && checkBox2.Checked == false))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1, StringComparison.CurrentCulture);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    MessageBox.Show("Finsh Find" + textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else if (radioButton1.Checked == true && (checkBox1.Checked == false && checkBox2.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
                //int startpos = richTextBox1.Find(textBox1.Text, a + 1, RichTextBoxFinds.WholeWord);
                //int leanth = s1.Length; a = startpos;
                //richTextBox1.Focus();
                //richTextBox1.Select(startpos, textBox1.Text.Length);
            }

            else if (radioButton2.Checked == true && (checkBox1.Checked == true && checkBox2.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.MatchCase);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }
            else if (radioButton2.Checked == true && (checkBox1.Checked == true && checkBox2.Checked == false))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.MatchCase);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    MessageBox.Show("Finsh Find" + textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radioButton2.Checked == true && (checkBox1.Checked == false && checkBox2.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.None);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //this.Formfi.Close();
            this.Formfi.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        // This Methode do Create a File in Direction and emplement Condetion if 
        private void file()
        {
            int a = 1;
            string Exten = @"C:\temp\Untitled.txt";

            if (!File.Exists(Exten))
            {
                this.Text = title + "NotePadPlus";
                StreamWriter ffn = File.CreateText(Exten);
                ffn.Write(richTextBox1.Text);
            }
            else if (File.Exists(Exten))
            {

                this.Text = title + a.ToString() + "NotePadPlus";

                MessageBox.Show(Exten.Insert(16, a.ToString()));
                StreamWriter ffy = File.CreateText(Exten);
                ffy.Write(richTextBox1.Text);
            }

            if (radioButton2.Checked == true &&
                (checkBox1.Checked == false && checkBox2.Checked == false))
            {
                string s1 = textBox1.Text;
                int startpos = richTextBox1.Find(s1.ToCharArray(), a);
                int leanth = s1.Length; a = startpos;
                richTextBox1.Focus();
                if (startpos > -1)
                {
                    richTextBox1.Select(startpos, textBox1.Text.Length);
                }
                else
                {
                    richTextBox1.SelectionStart = 0;
                    MessageBox.Show("Finsh Find" + textBox1.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


        private string path;
        private int Enum;

        public int _Enum
        {
            get { return Enum; }
            set { Enum = value; }
        }
        public string _Path
        {
            set { path = value; }
            get { return path; }
        }
        System.Drawing.Printing.PrintDocument PD = new System.Drawing.Printing.PrintDocument();
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = PD;
            
            DialogResult result = printDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                PD.Print();
            }
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            //object a;
            //if(DialogResult = DialogResult.OK)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            //int a;
            //string Exten = @"C:\temp\" + title + ".txt";
            //if (!File.Exists(Exten))
            //{
            //    StreamWriter SW = File.CreateText(Exten);
            //    SW.WriteLine(richTextBox1.Text);
            //    SW.Close();
            //}

            //else
            //{
            //    for (a = 0; File.Exists(Exten); a++)
            //    {
            //        bool tre = File.Exists(Exten = @"C:\temp\" + title + a + ".txt");
            //        if (tre == true)
            //        {
            //            Exten = @"C:\temp\" + title + a + ".txt";
            //        }
            //        else
            //            break;
            //    }
            //    StreamWriter SW = File.CreateText(Exten);
            //    SW.WriteLine(richTextBox1.Text);
            //    SW.Close();
            //}
        }
        public static void newwindow()
        {
            Application.Run(new Form1());
        }
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Plase Choose File";
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Filter = "All Txet (*.txt);|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = Path.GetFullPath(openFileDialog1.FileName);
                string S = Path.GetFileName(openFileDialog1.FileName);
                this.Text = S + "NotePadPlus";
                _Path = s;
                //MessageBox.Show(s , "Extention File " , MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                StreamReader d = new StreamReader(s);
                richTextBox1.Text = d.ReadToEnd();
                //System.IO.StreamReader s = new StreamReader(openFileDialog1.FileName);
                //richTextBox1.Text = s.ReadToEnd();
            }
        }

        private void specifiedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Exten = openFileDialog1.FileName;
            //int a;
            ////do
            ////{
            //if (!File.Exists(Exten))
            //    {
            //        StreamWriter ffn = File.CreateText(Exten);
            //        ffn.WriteLine(richTextBox1.Text);

            //    }
            //    else if (File.Exists(Exten))
            //    {
            //        Exten.Insert(13, "a");
            //        StreamWriter ffy = File.CreateText(Exten );
            //        ffy.Write(richTextBox1.Text);
            //    }
            //    a++;
            //} while (!File.Exists(Exten));

            //if (!File.Exists(Exten))
            //{
            //    StreamWriter SW = File.CreateText(Exten);
            //    SW.WriteLine(richTextBox1.Text);
            //    SW.Close();
            //}

            //else
            //{
            //    for (a = 0; File.Exists(Exten); a++)
            //    {
            //        bool tre = File.Exists(Exten = @"C:\temp\" + title + a + ".txt");
            //        if (tre == true)
            //        {
            //            Exten = @"C:\temp\" + title + a + ".txt";
            //        }
            //        else
            //            break;
            //    }
            //    StreamWriter SW = File.CreateText(Exten);
            //    SW.WriteLine(richTextBox1.Text);
            //    SW.Close();
            //}
            if (!File.Exists(_Path))
            {
                StreamWriter SW = new StreamWriter(_Path);
                SW.WriteLine(richTextBox1.Text);
                SW.Close();
            }
            else if (File.Exists(_Path))
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.FileName = "";
                SFD.AddExtension = true;
                SFD.DefaultExt = ".txt";
                DialogResult result= SFD.ShowDialog();
                if(string.IsNullOrEmpty( SFD.FileName))
                {
                    return;
                }
                else if(result==DialogResult.OK)
                {
                    StreamWriter SW = new StreamWriter(SFD.FileName);
                    SW.WriteLine(richTextBox1.Text);
                    SW.Close();
                }
                
                //FileStream fs = new FileStream(_Path, FileMode.Open, FileAccess.Read);
                //using (StreamWriter SW = new StreamWriter(fs))
                //{
                //    SW.WriteLine(richTextBox1.Text);
                //    SW.Close();
                //}
                //try
                //{ File.WriteAllText(_Path, richTextBox1.Text); return; }
                //catch (Exception r)
                //{
                //    MessageBox.Show(Convert.ToString(r));
                //    MessageBox.Show("Plase Using Save As", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //CountRichtextboxchar();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog()
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = "All Text (*.txt )| .txt",
                FileName = title
            };
            if (Save.ShowDialog() == DialogResult.OK)
            {
                string s = Save.FileName;
                StreamWriter SW = File.CreateText(s);
                SW.WriteLine(richTextBox1.Text);
                SW.Close();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string Dir = @"C:\temp";
            if(!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            int a;
            _Path = @"C:\temp\Untitled.txt";
            for (a = 0; File.Exists(_Path); a++)
            {
                bool tre = File.Exists(_Path = @"C:\temp\" + title + a + ".txt");
                if (tre == true)
                {
                    _Path = @"C:\temp\" + title + a + ".txt";
                }
                else
                    break;
            }
            this.Text = title + a + "NotePadPlus";
            _Enum = a;

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void paseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //bool fg = richTextBox1.CanSelect;
        //    //if (fg)
        //    //    cutToolStripMenuItem.Enabled = true;

        //    //cutToolStripMenuItem.Enabled = (richTextBox1.SelectedText.Length > 0) ? true : false;
        //    string txt = textBox1.Text;
        //    int ff;
        //    int aa = 0;
        //    int[] arr = new Int32[100];
        //    if (txt != "")
        //    {
        //        for (int af = 2; af < 10; ++a)
        //        {
        //            ff = richTextBox1.Find(txt, f + 1, RichTextBoxFinds.None);
        //            //if (f != ff)
        //            //{
        //            //MessageBox.Show(ff.ToString());
        //            Array.Resize(ref arr, af);
        //            arr[aa] = ff;
        //            f = ff;
        //            richTextBox1.Select(ff, arr.Length);
        //            richTextBox1.SelectionBackColor = Color.Yellow;
        //            aa += 1;

        //        }
        //    }

        //else
        //    break;
        //}


        private void cutToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == null)
            {
                cutToolStripMenuItem.Enabled = true;
            }
            else
                cutToolStripMenuItem.Enabled = false;



        }

        private void cutToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionBullet == true)
            {
                cutToolStripMenuItem.Enabled = true;
            }
            else
                cutToolStripMenuItem.Enabled = false;
        }
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            //toolStripStatusLabel3.Text = Convert.ToString("Ln" + a++ );2
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            cutToolStripMenuItem.Enabled = (richTextBox1.SelectedText.Length > 0) ? true : false;
            copyToolStripMenuItem.Enabled = (richTextBox1.SelectedText.Length > 0) ? true : false;
            deleteToolStripMenuItem.Enabled = (richTextBox1.SelectedText.Length > 0) ? true : false;
            undoToolStripMenuItem.Enabled = richTextBox1.Text.Length > 0 ? true : false;
         
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void statuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statuesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (statuesToolStripMenuItem.CheckOnClick == true)
                statusStrip1.Visible = true;
            else
                statusStrip1.Visible = false;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 1;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor -= 1;
        }

        private void restoryDefultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float a = 0;
            richTextBox1.ZoomFactor = a;

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void selectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void allTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void selectedTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void allTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void statuesToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            //if (statuesToolStripMenuItem.CheckOnClick == true)
            //    statusStrip1.Visible = false;
            //else
            //    statusStrip1.Visible = true;
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Formfi.Visible = true
            FormFind F2 = new FormFind();
            F2.Formfi2.Show();
            //this.MdiParent = F2.Formfi1;
            //F2.Show();
            //F2.MdiParent = this;
            //F2.Show();



        }

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int last = richTextBox1.Text.LastIndexOf(" ", richTextBox1.SelectionStart);
            last += 1;
            int first = richTextBox1.Text.IndexOf(" ",richTextBox1.SelectionStart);
            first -= 1;
            string Proces = richTextBox1.Text.Substring(last,(first-last)+1);
            System.Diagnostics.Process.Start(Proces);
        }
        //private int CountRichtextboxchar()
        //{
        //    int d=0;
        //    int CF=1;
        //    for (int dd=0;CF!= d ;dd++)
        //    {
        //        CF = richTextBox1.Find(textBox2.Text, a+1, RichTextBoxFinds.None);
        //        if (CF == d)
        //        {
        //            d = CF;
        //            Timer++;
        //        }
        //        else
        //            break;
        //    }
        //    MessageBox.Show(Timer.ToString());
        //    return Timer;
        //}


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int Timer = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            string txt = textBox2.Text;
            int ff = 0;

            for (int af = 0; ff != -1; af++)
            {
                ff = richTextBox1.Find(textBox2.Text, Timer + 1, RichTextBoxFinds.None);
                if (ff != -1)
                {
                    Timer = ff;
                    richTextBox1.Select(ff, txt.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
            Timer = 0;
            /* Solutions Other
             * 1-
               
                  Regex re = new Regex(textBox2.Text);
                  MatchCollection MC = re.Matches(richTextBox1.Text);
                  richTextBox1.SelectAll();
                  richTextBox1.SelectionBackColor = richTextBox1.BackColor;
                  foreach(Match M in MC)
                  {
                      richTextBox1.Select(M.Index, M.Length);
                      richTextBox1.SelectionBackColor = Color.Yellow;
                  }
           

            *2-
            
             string s1 = textBox2.Text;

             if (s1.Length > 0)
             {
                 int startpos = richTextBox1.Find(textBox2.Text, a + 1, RichTextBoxFinds.NoHighlight);
                 int leanth = s1.Length; a = startpos;
                 MessageBox.Show(startpos.ToString());
                 richTextBox1.Focus();
                 richTextBox1.Select(startpos, textBox2.Text.Length);
             }

             else
                 MessageBox.Show("This Text Or Characters is Not Find");

             */


        }
        private void InitializeComponent3()
        {
            this.Formfirp = new Form();
            this.textF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butf = new System.Windows.Forms.Button();
            this.butCanc = new System.Windows.Forms.Button();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioU = new System.Windows.Forms.RadioButton();
            this.checkM = new System.Windows.Forms.CheckBox();
            this.checkWR = new System.Windows.Forms.CheckBox();
            this.textR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.butR = new System.Windows.Forms.Button();
            this.butRA = new System.Windows.Forms.Button();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(83, 16);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(153, 20);
            this.textF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find What";
            // 
            // butf
            // 
            this.butf.Location = new System.Drawing.Point(294, 16);
            this.butf.Name = "butf";
            this.butf.Size = new System.Drawing.Size(88, 23);
            this.butf.TabIndex = 2;
            this.butf.Text = "Find Next";
            this.butf.UseVisualStyleBackColor = true;
            this.butf.Click += new System.EventHandler(this.button2_Click);
            // 
            // butCanc
            // 
            this.butCanc.Location = new System.Drawing.Point(294, 132);
            this.butCanc.Name = "butCanc";
            this.butCanc.Size = new System.Drawing.Size(88, 23);
            this.butCanc.TabIndex = 3;
            this.butCanc.Text = "Cancel";
            this.butCanc.UseVisualStyleBackColor = true;
            this.butCanc.Click += new System.EventHandler(this.button4_Click);
            // 
            // group2
            // 
            this.group2.Controls.Add(this.radioD);
            this.group2.Controls.Add(this.radioU);
            this.group2.Location = new System.Drawing.Point(143, 129);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(129, 53);
            this.group2.TabIndex = 4;
            this.group2.TabStop = false;
            this.group2.Text = "Direction";
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Location = new System.Drawing.Point(63, 20);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(53, 17);
            this.radioD.TabIndex = 1;
            this.radioD.TabStop = true;
            this.radioD.Text = "Down";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // radioU
            // 
            this.radioU.AutoSize = true;
            this.radioU.Location = new System.Drawing.Point(18, 20);
            this.radioU.Name = "radioU";
            this.radioU.Size = new System.Drawing.Size(39, 17);
            this.radioU.TabIndex = 0;
            this.radioU.TabStop = true;
            this.radioU.Text = "Up";
            this.radioU.Checked = true;
            this.radioU.UseVisualStyleBackColor = true;
            // 
            // checkM
            // 
            this.checkM.AutoSize = true;
            this.checkM.Location = new System.Drawing.Point(10, 132);
            this.checkM.Name = "checkM";
            this.checkM.Size = new System.Drawing.Size(83, 17);
            this.checkM.TabIndex = 5;
            this.checkM.Text = "Match Case";
            this.checkM.UseVisualStyleBackColor = true;
            // 
            // checkWR
            // 
            this.checkWR.AutoSize = true;
            this.checkWR.Location = new System.Drawing.Point(10, 165);
            this.checkWR.Name = "checkWR";
            this.checkWR.Size = new System.Drawing.Size(88, 17);
            this.checkWR.TabIndex = 6;
            this.checkWR.Text = "Wrap around";
            this.checkWR.UseVisualStyleBackColor = true;
            // 
            // textR
            // 
            this.textR.Location = new System.Drawing.Point(83, 51);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(153, 20);
            this.textR.TabIndex = 7;
            // 
            // label2
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(7, 58);
            this.labelR.Name = "label2";
            this.labelR.Size = new System.Drawing.Size(70, 13);
            this.labelR.TabIndex = 8;
            this.labelR.Text = "Replase Text";
            // 
            // butR
            // 
            this.butR.Location = new System.Drawing.Point(294, 48);
            this.butR.Name = "butR";
            this.butR.Size = new System.Drawing.Size(88, 23);
            this.butR.TabIndex = 9;
            this.butR.Text = "Replase";
            this.butR.UseVisualStyleBackColor = true;
            this.butR.Click += new System.EventHandler(this.button3_Click);
            // 
            // butRA
            // 
            this.butRA.Location = new System.Drawing.Point(294, 79);
            this.butRA.Name = "butRA";
            this.butRA.Size = new System.Drawing.Size(88, 23);
            this.butRA.TabIndex = 10;
            this.butRA.Text = "Replase All";
            this.butRA.UseVisualStyleBackColor = true;
            this.butRA.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.Formfirp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Formfirp.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Formfirp.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Formfirp.ClientSize = new System.Drawing.Size(394, 194);
            this.Formfirp.Controls.Add(this.butRA);
            this.Formfirp.Controls.Add(this.butR);
            this.Formfirp.Controls.Add(this.labelR);
            this.Formfirp.Controls.Add(this.textR);
            this.Formfirp.Controls.Add(this.checkWR);
            this.Formfirp.Controls.Add(this.checkM);
            this.Formfirp.Controls.Add(this.group2);
            this.Formfirp.Controls.Add(this.butCanc);
            this.Formfirp.Controls.Add(this.butf);
            this.Formfirp.Controls.Add(this.label1);
            this.Formfirp.Controls.Add(this.textF);
            this.Formfirp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Formfirp.MaximizeBox = false;

            this.Formfirp.MinimizeBox = false;
            this.Formfirp.Name = "Form2";
            this.Formfirp.ShowIcon = false;
            this.Formfirp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Formfirp.Text = "Find";
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.Formfirp.ResumeLayout(false);
            this.Formfirp.PerformLayout();


        }

        private System.Windows.Forms.Form Formfirp;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Button butf;
        private System.Windows.Forms.Button butCanc;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioU;
        private System.Windows.Forms.CheckBox checkM;
        private System.Windows.Forms.CheckBox checkWR;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Button butR;
        private System.Windows.Forms.Button butRA;

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textF.Text;
            int a = richTextBox1.SelectionStart + 1;

            if (radioU.Checked == true &&
                (checkM.Checked == false && checkWR.Checked == false))
            {
                int startpos = richTextBox1.Find(s1.ToCharArray(), a);
                int leanth = s1.Length; a = startpos;
                richTextBox1.Focus();
                if (startpos > -1)
                {
                    richTextBox1.Select(startpos, textF.Text.Length);
                }
                else
                {
                    richTextBox1.SelectionStart = 0;
                    MessageBox.Show("Finsh Find" + textF.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else if (radioU.Checked == true && (checkM.Checked == true && checkWR.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1, StringComparison.CurrentCulture);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }


            else if (radioU.Checked == true && (checkM.Checked == true && checkWR.Checked == false))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1, StringComparison.CurrentCulture);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    MessageBox.Show("Finsh Find" + textF.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else if (radioU.Checked == true && (checkM.Checked == false && checkWR.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Text.LastIndexOf(s1, position - 1);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
                //int startpos = richTextBox1.Find(textBox1.Text, a + 1, RichTextBoxFinds.WholeWord);
                //int leanth = s1.Length; a = startpos;
                //richTextBox1.Focus();
                //richTextBox1.Select(startpos, textBox1.Text.Length);
            }

            else if (radioD.Checked == true && (checkM.Checked == true && checkWR.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.MatchCase);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }
            else if (radioD.Checked == true && (checkM.Checked == true && checkWR.Checked == false))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.MatchCase);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    MessageBox.Show("Finsh Find" + textF.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (radioD.Checked == true && (checkM.Checked == false && checkWR.Checked == true))
            {
                int position = richTextBox1.SelectionStart;
                int b = richTextBox1.Find(s1, position + 1, RichTextBoxFinds.None);
                if (b > -1)
                {
                    richTextBox1.Focus();
                    richTextBox1.Select(b, s1.Length);
                }
                else
                {
                    b = richTextBox1.Text.Length;
                    richTextBox1.SelectionStart = richTextBox1.Text.Length - 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string r = textR.Text;
            richTextBox1.SelectedText = r;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Formfi.Visible = false;
        }
        int Timer;
        private void button5_Click(object sender, EventArgs e)
        {
            string r = textR.Text;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            string txt = textF.Text;
            int ff = 0;

            for (int af = 0; ff != -1; af++)
            {
                ff = richTextBox1.Find(textF.Text, Timer + 1, RichTextBoxFinds.None);
                if (ff != -1)
                {
                    Timer = ff;
                    richTextBox1.Select(ff, txt.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    richTextBox1.SelectedText = r;
                }
            }
            Timer = 0;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formfirp.ShowDialog();
        }

        private void rightToLiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            richTextBox1.Lines.Length.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text ="Line "+ richTextBox1.Lines.Length.ToString();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Line " + richTextBox1.Lines.Length.ToString();
        }
    }
}
