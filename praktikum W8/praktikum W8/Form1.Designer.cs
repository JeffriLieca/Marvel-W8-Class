namespace praktikum_W8
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
            this.box = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(12, 37);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(152, 21);
            this.box.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamDataToolStripMenuItem,
            this.findMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamDataToolStripMenuItem
            // 
            this.teamDataToolStripMenuItem.Name = "teamDataToolStripMenuItem";
            this.teamDataToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.teamDataToolStripMenuItem.Text = "Team Data";
            this.teamDataToolStripMenuItem.Click += new System.EventHandler(this.teamDataToolStripMenuItem_Click);
            // 
            // findMatchToolStripMenuItem
            // 
            this.findMatchToolStripMenuItem.Name = "findMatchToolStripMenuItem";
            this.findMatchToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.findMatchToolStripMenuItem.Text = "Find Match";
            this.findMatchToolStripMenuItem.Click += new System.EventHandler(this.findMatchToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.data2);
            this.panel1.Controls.Add(this.data1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 387);
            this.panel1.TabIndex = 2;
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(32, 3);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(342, 381);
            this.data1.TabIndex = 0;
            // 
            // data2
            // 
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Location = new System.Drawing.Point(424, 3);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(342, 381);
            this.data2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findMatchToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Button button1;
    }
}

