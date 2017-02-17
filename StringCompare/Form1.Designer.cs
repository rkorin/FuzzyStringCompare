namespace StringCompare
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbw = new System.Windows.Forms.ComboBox();
            this.lw = new System.Windows.Forms.ListBox();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.l = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.d4 = new System.Windows.Forms.Label();
            this.lco = new System.Windows.Forms.Label();
            this.lJaro = new System.Windows.Forms.Label();
            this.lHamm = new System.Windows.Forms.Label();
            this.lDamer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMAXMistakes = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSWwords = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSWchars = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRchars = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAWend = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAWstart = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAWmiddle = new System.Windows.Forms.TrackBar();
            this.lBitap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMAXMistakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSWwords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSWchars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRchars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWmiddle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbw);
            this.splitContainer1.Panel1.Controls.Add(this.lw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lBitap);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.tbAWmiddle);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.tbAWstart);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.tbAWend);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbRchars);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tbSWchars);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbSWwords);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbMAXMistakes);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.lDamer);
            this.splitContainer1.Panel2.Controls.Add(this.lHamm);
            this.splitContainer1.Panel2.Controls.Add(this.lJaro);
            this.splitContainer1.Panel2.Controls.Add(this.lco);
            this.splitContainer1.Panel2.Controls.Add(this.d4);
            this.splitContainer1.Panel2.Controls.Add(this.ll);
            this.splitContainer1.Panel2.Controls.Add(this.l);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 548);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbw
            // 
            this.cbw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbw.FormattingEnabled = true;
            this.cbw.Location = new System.Drawing.Point(12, 12);
            this.cbw.Name = "cbw";
            this.cbw.Size = new System.Drawing.Size(244, 28);
            this.cbw.TabIndex = 1;
            this.cbw.SelectedIndexChanged += new System.EventHandler(this.cbw_SelectedIndexChanged);
            // 
            // lw
            // 
            this.lw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lw.FormattingEnabled = true;
            this.lw.ItemHeight = 20;
            this.lw.Location = new System.Drawing.Point(3, 61);
            this.lw.Name = "lw";
            this.lw.Size = new System.Drawing.Size(253, 484);
            this.lw.TabIndex = 0;
            // 
            // t
            // 
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(3, 132);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(51, 20);
            this.l.TabIndex = 0;
            this.l.Text = "label1";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(3, 175);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(86, 20);
            this.ll.TabIndex = 1;
            this.ll.Text = "Levenstain";
            // 
            // d4
            // 
            this.d4.AutoSize = true;
            this.d4.Location = new System.Drawing.Point(3, 213);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(27, 20);
            this.d4.TabIndex = 2;
            this.d4.Text = "d4";
            // 
            // lco
            // 
            this.lco.AutoSize = true;
            this.lco.Location = new System.Drawing.Point(3, 253);
            this.lco.Name = "lco";
            this.lco.Size = new System.Drawing.Size(51, 20);
            this.lco.TabIndex = 3;
            this.lco.Text = "label1";
            // 
            // lJaro
            // 
            this.lJaro.AutoSize = true;
            this.lJaro.Location = new System.Drawing.Point(3, 289);
            this.lJaro.Name = "lJaro";
            this.lJaro.Size = new System.Drawing.Size(43, 20);
            this.lJaro.TabIndex = 4;
            this.lJaro.Text = "lJaro";
            // 
            // lHamm
            // 
            this.lHamm.AutoSize = true;
            this.lHamm.Location = new System.Drawing.Point(3, 324);
            this.lHamm.Name = "lHamm";
            this.lHamm.Size = new System.Drawing.Size(59, 20);
            this.lHamm.TabIndex = 5;
            this.lHamm.Text = "lHamm";
            // 
            // lDamer
            // 
            this.lDamer.AutoSize = true;
            this.lDamer.Location = new System.Drawing.Point(3, 355);
            this.lDamer.Name = "lDamer";
            this.lDamer.Size = new System.Drawing.Size(60, 20);
            this.lDamer.TabIndex = 6;
            this.lDamer.Text = "lDamer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMAXMistakes
            // 
            this.tbMAXMistakes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMAXMistakes.Location = new System.Drawing.Point(707, 12);
            this.tbMAXMistakes.Maximum = 30;
            this.tbMAXMistakes.Name = "tbMAXMistakes";
            this.tbMAXMistakes.Size = new System.Drawing.Size(194, 64);
            this.tbMAXMistakes.TabIndex = 8;
            this.tbMAXMistakes.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add to searched string mistakes:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total MAX mistakes";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Swap words (max)";
            // 
            // tbSWwords
            // 
            this.tbSWwords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSWwords.Location = new System.Drawing.Point(707, 61);
            this.tbSWwords.Maximum = 5;
            this.tbSWwords.Name = "tbSWwords";
            this.tbSWwords.Size = new System.Drawing.Size(194, 64);
            this.tbSWwords.TabIndex = 11;
            this.tbSWwords.Value = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Swap chars (max)";
            // 
            // tbSWchars
            // 
            this.tbSWchars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSWchars.Location = new System.Drawing.Point(707, 113);
            this.tbSWchars.Maximum = 5;
            this.tbSWchars.Name = "tbSWchars";
            this.tbSWchars.Size = new System.Drawing.Size(194, 64);
            this.tbSWchars.TabIndex = 13;
            this.tbSWchars.Value = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Replace chars (max)";
            // 
            // tbRchars
            // 
            this.tbRchars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRchars.Location = new System.Drawing.Point(707, 169);
            this.tbRchars.Maximum = 5;
            this.tbRchars.Name = "tbRchars";
            this.tbRchars.Size = new System.Drawing.Size(194, 64);
            this.tbRchars.TabIndex = 15;
            this.tbRchars.Value = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Add words to end";
            // 
            // tbAWend
            // 
            this.tbAWend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAWend.Location = new System.Drawing.Point(707, 224);
            this.tbAWend.Maximum = 5;
            this.tbAWend.Name = "tbAWend";
            this.tbAWend.Size = new System.Drawing.Size(194, 64);
            this.tbAWend.TabIndex = 17;
            this.tbAWend.Value = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add words to start";
            // 
            // tbAWstart
            // 
            this.tbAWstart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAWstart.Location = new System.Drawing.Point(707, 280);
            this.tbAWstart.Maximum = 5;
            this.tbAWstart.Name = "tbAWstart";
            this.tbAWstart.Size = new System.Drawing.Size(194, 64);
            this.tbAWstart.TabIndex = 19;
            this.tbAWstart.Value = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Add words to middle";
            // 
            // tbAWmiddle
            // 
            this.tbAWmiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAWmiddle.Location = new System.Drawing.Point(707, 334);
            this.tbAWmiddle.Maximum = 5;
            this.tbAWmiddle.Name = "tbAWmiddle";
            this.tbAWmiddle.Size = new System.Drawing.Size(194, 64);
            this.tbAWmiddle.TabIndex = 21;
            this.tbAWmiddle.Value = 1;
            // 
            // lBitap
            // 
            this.lBitap.AutoSize = true;
            this.lBitap.Location = new System.Drawing.Point(3, 390);
            this.lBitap.Name = "lBitap";
            this.lBitap.Size = new System.Drawing.Size(49, 20);
            this.lBitap.TabIndex = 23;
            this.lBitap.Text = "lBitap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMAXMistakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSWwords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSWchars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRchars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAWmiddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lw;
        private System.Windows.Forms.ComboBox cbw;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Label d4;
        private System.Windows.Forms.Label lco;
        private System.Windows.Forms.Label lJaro;
        private System.Windows.Forms.Label lHamm;
        private System.Windows.Forms.Label lDamer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbMAXMistakes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSWwords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbAWmiddle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbAWstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbAWend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbRchars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbSWchars;
        private System.Windows.Forms.Label lBitap;
    }
}

