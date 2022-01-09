namespace Adona_Pharm
{
    partial class UCCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomers));
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShowAll = new System.Windows.Forms.TextBox();
            this.dvgShowAll = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.ShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ShowAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPanel
            // 
            this.ShowPanel.BackColor = System.Drawing.Color.Salmon;
            this.ShowPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPanel.BackgroundImage")));
            this.ShowPanel.Controls.Add(this.lblLoginType);
            this.ShowPanel.Controls.Add(this.label20);
            this.ShowPanel.Controls.Add(this.btnShow);
            this.ShowPanel.Controls.Add(this.label29);
            this.ShowPanel.Controls.Add(this.txtCustomerId);
            this.ShowPanel.Controls.Add(this.dgvShow);
            this.ShowPanel.Location = new System.Drawing.Point(19, 100);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(410, 368);
            this.ShowPanel.TabIndex = 22;
            // 
            // lblLoginType
            // 
            this.lblLoginType.AutoSize = true;
            this.lblLoginType.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLoginType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLoginType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginType.Location = new System.Drawing.Point(345, 0);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(65, 28);
            this.lblLoginType.TabIndex = 21;
            this.lblLoginType.Text = "label5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Info;
            this.label20.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(232, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 39);
            this.label20.TabIndex = 20;
            this.label20.Text = "Adona Pharm";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(123, 179);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(38, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 15);
            this.label29.TabIndex = 11;
            this.label29.Text = "CustomerId";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(123, 113);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerId.TabIndex = 2;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(3, 290);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 25;
            this.dgvShow.Size = new System.Drawing.Size(404, 78);
            this.dgvShow.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerToolStripMenuItem,
            this.showCustomerToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showCustomerToolStripMenuItem
            // 
            this.showCustomerToolStripMenuItem.Name = "showCustomerToolStripMenuItem";
            this.showCustomerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.showCustomerToolStripMenuItem.Text = "Show Customer";
            this.showCustomerToolStripMenuItem.Click += new System.EventHandler(this.showCustomerToolStripMenuItem_Click);
            // 
            // showCustomerToolStripMenuItem1
            // 
            this.showCustomerToolStripMenuItem1.Name = "showCustomerToolStripMenuItem1";
            this.showCustomerToolStripMenuItem1.Size = new System.Drawing.Size(186, 20);
            this.showCustomerToolStripMenuItem1.Text = "Show Customer With The Order";
            this.showCustomerToolStripMenuItem1.Click += new System.EventHandler(this.showCustomerToolStripMenuItem1_Click);
            // 
            // ShowAllPanel
            // 
            this.ShowAllPanel.BackColor = System.Drawing.Color.LightYellow;
            this.ShowAllPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowAllPanel.BackgroundImage")));
            this.ShowAllPanel.Controls.Add(this.label3);
            this.ShowAllPanel.Controls.Add(this.label1);
            this.ShowAllPanel.Controls.Add(this.btnShowAll);
            this.ShowAllPanel.Controls.Add(this.label2);
            this.ShowAllPanel.Controls.Add(this.txtShowAll);
            this.ShowAllPanel.Controls.Add(this.dvgShowAll);
            this.ShowAllPanel.Location = new System.Drawing.Point(567, 100);
            this.ShowAllPanel.Name = "ShowAllPanel";
            this.ShowAllPanel.Size = new System.Drawing.Size(410, 368);
            this.ShowAllPanel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(345, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adona Pharm";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(123, 179);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "Show";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "CustomerId";
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(123, 113);
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(100, 23);
            this.txtShowAll.TabIndex = 2;
            // 
            // dvgShowAll
            // 
            this.dvgShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShowAll.Location = new System.Drawing.Point(3, 290);
            this.dvgShowAll.Name = "dvgShowAll";
            this.dvgShowAll.RowTemplate.Height = 25;
            this.dvgShowAll.Size = new System.Drawing.Size(404, 78);
            this.dvgShowAll.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1484, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "label5";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(740, 570);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UCCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowAllPanel);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCCustomers";
            this.Size = new System.Drawing.Size(1549, 679);
            this.ShowPanel.ResumeLayout(false);
            this.ShowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShowAllPanel.ResumeLayout(false);
            this.ShowAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerToolStripMenuItem1;
        private System.Windows.Forms.Panel ShowAllPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShowAll;
        private System.Windows.Forms.DataGridView dvgShowAll;
        private System.Windows.Forms.Label lblLoginType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}
