namespace NotePadPlus
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
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
            this.butf.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCanc
            // 
            this.butCanc.Location = new System.Drawing.Point(294, 132);
            this.butCanc.Name = "butCanc";
            this.butCanc.Size = new System.Drawing.Size(88, 23);
            this.butCanc.TabIndex = 3;
            this.butCanc.Text = "Cancel";
            this.butCanc.UseVisualStyleBackColor = true;
            this.butCanc.Click += new System.EventHandler(this.button2_Click);
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Replase Text";
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
            this.butRA.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.butRA);
            this.Controls.Add(this.butR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.checkWR);
            this.Controls.Add(this.checkM);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.butCanc);
            this.Controls.Add(this.butf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butf;
        private System.Windows.Forms.Button butCanc;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioU;
        private System.Windows.Forms.CheckBox checkM;
        private System.Windows.Forms.CheckBox checkWR;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butR;
        private System.Windows.Forms.Button butRA;
    }
}