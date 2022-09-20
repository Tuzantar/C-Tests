namespace Zadania
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Task1a = new System.Windows.Forms.TextBox();
            this.txt_Task1b = new System.Windows.Forms.TextBox();
            this.btn_Task1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Z = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_T2b = new System.Windows.Forms.TextBox();
            this.txt_T2a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTS = new System.Windows.Forms.Button();
            this.bttn_bb = new System.Windows.Forms.Button();
            this.txtT3_wynik = new System.Windows.Forms.TextBox();
            this.btnT3 = new System.Windows.Forms.Button();
            this.txtT3_2 = new System.Windows.Forms.TextBox();
            this.txtT3_1 = new System.Windows.Forms.TextBox();
            this.btn_T3_QS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Z.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Task1a
            // 
            this.txt_Task1a.Location = new System.Drawing.Point(6, 26);
            this.txt_Task1a.Name = "txt_Task1a";
            this.txt_Task1a.Size = new System.Drawing.Size(204, 27);
            this.txt_Task1a.TabIndex = 0;
            this.txt_Task1a.TextChanged += new System.EventHandler(this.txt_Task1a_TextChanged);
            // 
            // txt_Task1b
            // 
            this.txt_Task1b.Location = new System.Drawing.Point(6, 59);
            this.txt_Task1b.Name = "txt_Task1b";
            this.txt_Task1b.ReadOnly = true;
            this.txt_Task1b.Size = new System.Drawing.Size(204, 27);
            this.txt_Task1b.TabIndex = 1;
            // 
            // btn_Task1
            // 
            this.btn_Task1.Location = new System.Drawing.Point(216, 26);
            this.btn_Task1.Name = "btn_Task1";
            this.btn_Task1.Size = new System.Drawing.Size(94, 29);
            this.btn_Task1.TabIndex = 2;
            this.btn_Task1.Text = "Przelicz";
            this.btn_Task1.UseVisualStyleBackColor = true;
            this.btn_Task1.Click += new System.EventHandler(this.btn_Task1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Task1a);
            this.groupBox1.Controls.Add(this.btn_Task1);
            this.groupBox1.Controls.Add(this.txt_Task1b);
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zadanie 1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Z);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 553);
            this.tabControl1.TabIndex = 4;
            // 
            // Z
            // 
            this.Z.Controls.Add(this.label1);
            this.Z.Controls.Add(this.groupBox1);
            this.Z.Location = new System.Drawing.Point(4, 29);
            this.Z.Name = "Z";
            this.Z.Padding = new System.Windows.Forms.Padding(3);
            this.Z.Size = new System.Drawing.Size(914, 520);
            this.Z.TabIndex = 0;
            this.Z.Text = "Task 1";
            this.Z.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Napisać program służący do konwersji wartości temperatury podanej w stopniach\r\nCe" +
    "lsjusza na stopnie w skali Fahrenheita (stopnie Fahrenheita = 1.8 * stopnie\r\nCel" +
    "sjusza + 32.0)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_T2b);
            this.tabPage2.Controls.Add(this.txt_T2a);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_T2b
            // 
            this.txt_T2b.Location = new System.Drawing.Point(6, 79);
            this.txt_T2b.Multiline = true;
            this.txt_T2b.Name = "txt_T2b";
            this.txt_T2b.ReadOnly = true;
            this.txt_T2b.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_T2b.Size = new System.Drawing.Size(902, 435);
            this.txt_T2b.TabIndex = 2;
            // 
            // txt_T2a
            // 
            this.txt_T2a.Location = new System.Drawing.Point(6, 46);
            this.txt_T2a.Name = "txt_T2a";
            this.txt_T2a.Size = new System.Drawing.Size(902, 27);
            this.txt_T2a.TabIndex = 1;
            this.txt_T2a.TextChanged += new System.EventHandler(this.txt_T2a_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wczytać od użytkownika 3 liczby całkowite i wypisać na ekran największą oraz\r\nnaj" +
    "mniejszą z nich.";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_T3_QS);
            this.tabPage1.Controls.Add(this.btnTS);
            this.tabPage1.Controls.Add(this.bttn_bb);
            this.tabPage1.Controls.Add(this.txtT3_wynik);
            this.tabPage1.Controls.Add(this.btnT3);
            this.tabPage1.Controls.Add(this.txtT3_2);
            this.tabPage1.Controls.Add(this.txtT3_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 520);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sortowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(137, 41);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(94, 29);
            this.btnTS.TabIndex = 5;
            this.btnTS.Text = "Test S";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // bttn_bb
            // 
            this.bttn_bb.Location = new System.Drawing.Point(137, 76);
            this.bttn_bb.Name = "bttn_bb";
            this.bttn_bb.Size = new System.Drawing.Size(94, 29);
            this.bttn_bb.TabIndex = 4;
            this.bttn_bb.Text = "Bubble S";
            this.bttn_bb.UseVisualStyleBackColor = true;
            this.bttn_bb.Click += new System.EventHandler(this.bttn_bb_Click);
            // 
            // txtT3_wynik
            // 
            this.txtT3_wynik.Location = new System.Drawing.Point(237, 6);
            this.txtT3_wynik.Multiline = true;
            this.txtT3_wynik.Name = "txtT3_wynik";
            this.txtT3_wynik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtT3_wynik.Size = new System.Drawing.Size(671, 508);
            this.txtT3_wynik.TabIndex = 3;
            // 
            // btnT3
            // 
            this.btnT3.Location = new System.Drawing.Point(137, 6);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(94, 29);
            this.btnT3.TabIndex = 2;
            this.btnT3.Text = "Generate";
            this.btnT3.UseVisualStyleBackColor = true;
            this.btnT3.Click += new System.EventHandler(this.btnT3_Click);
            // 
            // txtT3_2
            // 
            this.txtT3_2.Location = new System.Drawing.Point(6, 39);
            this.txtT3_2.Multiline = true;
            this.txtT3_2.Name = "txtT3_2";
            this.txtT3_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtT3_2.Size = new System.Drawing.Size(125, 475);
            this.txtT3_2.TabIndex = 1;
            // 
            // txtT3_1
            // 
            this.txtT3_1.Location = new System.Drawing.Point(6, 6);
            this.txtT3_1.Name = "txtT3_1";
            this.txtT3_1.Size = new System.Drawing.Size(125, 27);
            this.txtT3_1.TabIndex = 0;
            this.txtT3_1.Text = "2000";
            this.txtT3_1.TextChanged += new System.EventHandler(this.txtT3_1_TextChanged);
            // 
            // btn_T3_QS
            // 
            this.btn_T3_QS.Location = new System.Drawing.Point(137, 111);
            this.btn_T3_QS.Name = "btn_T3_QS";
            this.btn_T3_QS.Size = new System.Drawing.Size(94, 29);
            this.btn_T3_QS.TabIndex = 6;
            this.btn_T3_QS.Text = "Quick S";
            this.btn_T3_QS.UseVisualStyleBackColor = true;
            this.btn_T3_QS.Click += new System.EventHandler(this.btn_T3_QS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Z.ResumeLayout(false);
            this.Z.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_Task1a;
        private TextBox txt_Task1b;
        private Button btn_Task1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage Z;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txt_T2b;
        private TextBox txt_T2a;
        private Label label2;
        private TabPage tabPage1;
        private TextBox txtT3_wynik;
        private Button btnT3;
        private TextBox txtT3_2;
        private TextBox txtT3_1;
        private Button bttn_bb;
        private Button btnTS;
        private Button btn_T3_QS;
    }
}