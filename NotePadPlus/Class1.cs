using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadPlus
{
    class FormFind 
    {
        // Fild
        private System.Windows.Forms.Form Formfi;
        private System.Windows.Forms.RichTextBox richtextbox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.MdiClient ctlClient;
        public Form Formfi2
        {
            get
            {
                return Formfi;
            }
            set
            {
                Formfi = value;
            }
        }

        public int Richtextbox1
        {
            get
            {
                return richtextbox1.SelectionStart;
            }

            set
            { Form1 f = new Form1();
                richtextbox1.SelectionStart = f.richTextBox1.SelectionStart;
            }
        }

        //public Form this.
        //{
        //    get
        //    {
        //        if(this.Formfi == null)
        //        {
        //            this.Formfi = new Form();
        //            System.Reflection.FieldInfo Field = typeof(Form).GetField("ctlClient", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        //            Field.SetValue(this.Formfi, this.ctlClient);
        //        }
        //        return this.Formfi;
        //    }


        //}

        public FormFind()
        {
            this.InitializeComponent();
            //base.Controls.Add(this.ctlClient);

        }
        private void InitializeComponent()
        {
            this.Formfi = new Form();
            this.ctlClient = new MdiClient();
            this.richtextbox1 = new System.Windows.Forms.RichTextBox();
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
           this.Formfi.Location = new System.Drawing.Point(50, 50);
            this.Formfi.StartPosition = FormStartPosition.CenterScreen;
            this.Formfi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Formfi.MaximizeBox = false;
            this.Formfi.ClientSize = new System.Drawing.Size(371, 176);
            this.Formfi.MinimizeBox = false;
            this.Formfi.Name = "Form2";
            this.Formfi.ShowIcon = false;
            this.Formfi.Text = "Find";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.Formfi.ResumeLayout(false);
            this.Formfi.PerformLayout();
            this.Formfi.Controls.Add(this.checkBox2);
            this.Formfi.Controls.Add(this.checkBox1);
            this.Formfi.Controls.Add(this.groupBox1);
            this.Formfi.Controls.Add(this.button2);
            this.Formfi.Controls.Add(this.button1);
            this.Formfi.Controls.Add(this.label1);
            this.Formfi.Controls.Add(this.textBox1);
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
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
            Form1 f1 = new Form1();
            string s1 = textBox1.Text;
            int position = f1.RichTextBox1.SelectionStart;
            
            MessageBox.Show(position.ToString());
            int b =f1.RichTextBox1.Text.LastIndexOf(s1, position-1);
            if (b > -1)
            {
                f1.RichTextBox1.Focus();
                f1.RichTextBox1.Select(b, s1.Length);
            }
            else
            {
                b = f1.RichTextBox1.Text.Length;
                //f1.RichTextBox1.SelectionStart = f1.RichTextBox1.Text.Length - 1;
            }
        
        }

        public void visible ()
        {
            //this.Visible = true;
        }

    }
}
