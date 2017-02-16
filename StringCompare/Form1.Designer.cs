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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.lco);
            this.splitContainer1.Panel2.Controls.Add(this.d4);
            this.splitContainer1.Panel2.Controls.Add(this.ll);
            this.splitContainer1.Panel2.Controls.Add(this.l);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 548);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbw
            // 
            this.cbw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbw.FormattingEnabled = true;
            this.cbw.Location = new System.Drawing.Point(12, 12);
            this.cbw.Name = "cbw";
            this.cbw.Size = new System.Drawing.Size(315, 28);
            this.cbw.TabIndex = 1;
            this.cbw.SelectedIndexChanged += new System.EventHandler(this.cbw_SelectedIndexChanged);
            // 
            // lw
            // 
            this.lw.FormattingEnabled = true;
            this.lw.ItemHeight = 20;
            this.lw.Location = new System.Drawing.Point(3, 61);
            this.lw.Name = "lw";
            this.lw.Size = new System.Drawing.Size(334, 484);
            this.lw.TabIndex = 0;
            // 
            // t
            // 
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(4, 4);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(51, 20);
            this.l.TabIndex = 0;
            this.l.Text = "label1";
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(4, 47);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(86, 20);
            this.ll.TabIndex = 1;
            this.ll.Text = "Levenstain";
            // 
            // d4
            // 
            this.d4.AutoSize = true;
            this.d4.Location = new System.Drawing.Point(4, 85);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(27, 20);
            this.d4.TabIndex = 2;
            this.d4.Text = "d4";
            // 
            // lco
            // 
            this.lco.AutoSize = true;
            this.lco.Location = new System.Drawing.Point(4, 125);
            this.lco.Name = "lco";
            this.lco.Size = new System.Drawing.Size(51, 20);
            this.lco.TabIndex = 3;
            this.lco.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}

