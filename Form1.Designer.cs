
namespace necessities_list
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxPrice = new System.Windows.Forms.CheckBox();
            this.chbProducer = new System.Windows.Forms.CheckBox();
            this.chbType = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDTo = new System.Windows.Forms.NumericUpDown();
            this.numUDFrom = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.pnlBtn);
            this.pnlMain.Controls.Add(this.pnlText);
            this.pnlMain.Controls.Add(this.pnlData);
            this.pnlMain.Location = new System.Drawing.Point(12, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 469);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtn.Controls.Add(this.btnExit);
            this.pnlBtn.Controls.Add(this.btnLoad);
            this.pnlBtn.Controls.Add(this.btnFind);
            this.pnlBtn.Location = new System.Drawing.Point(673, 332);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(99, 133);
            this.pnlBtn.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.toolTip.SetToolTip(this.btnExit, "thoát khỏi chương trình");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(3, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Tải lại";
            this.toolTip.SetToolTip(this.btnLoad, "xem lại dữ liệu gốc");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(3, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 32);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm";
            this.toolTip.SetToolTip(this.btnFind, "tìm sản phẩm phù hợp");
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlText
            // 
            this.pnlText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlText.Controls.Add(this.groupBox1);
            this.pnlText.Controls.Add(this.label2);
            this.pnlText.Controls.Add(this.numUDTo);
            this.pnlText.Controls.Add(this.numUDFrom);
            this.pnlText.Controls.Add(this.lblPrice);
            this.pnlText.Controls.Add(this.lblProducer);
            this.pnlText.Controls.Add(this.txtProducer);
            this.pnlText.Controls.Add(this.cbType);
            this.pnlText.Controls.Add(this.label1);
            this.pnlText.Controls.Add(this.lblName);
            this.pnlText.Controls.Add(this.txtName);
            this.pnlText.Location = new System.Drawing.Point(3, 332);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(667, 133);
            this.pnlText.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chboxPrice);
            this.groupBox1.Controls.Add(this.chbProducer);
            this.groupBox1.Controls.Add(this.chbType);
            this.groupBox1.Controls.Add(this.chbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 39);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm thông tin";
            this.toolTip.SetToolTip(this.groupBox1, "tùy chọn thông tin muốn tìm");
            // 
            // chboxPrice
            // 
            this.chboxPrice.AutoSize = true;
            this.chboxPrice.Checked = true;
            this.chboxPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxPrice.Location = new System.Drawing.Point(478, 15);
            this.chboxPrice.Name = "chboxPrice";
            this.chboxPrice.Size = new System.Drawing.Size(42, 17);
            this.chboxPrice.TabIndex = 14;
            this.chboxPrice.Text = "Giá";
            this.chboxPrice.UseVisualStyleBackColor = true;
            this.chboxPrice.CheckedChanged += new System.EventHandler(this.chboxPrice_CheckedChanged);
            // 
            // chbProducer
            // 
            this.chbProducer.AutoSize = true;
            this.chbProducer.Checked = true;
            this.chbProducer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbProducer.Location = new System.Drawing.Point(323, 15);
            this.chbProducer.Name = "chbProducer";
            this.chbProducer.Size = new System.Drawing.Size(52, 17);
            this.chbProducer.TabIndex = 13;
            this.chbProducer.Text = "Hãng";
            this.chbProducer.UseVisualStyleBackColor = true;
            this.chbProducer.CheckedChanged += new System.EventHandler(this.chbProducer_CheckedChanged);
            // 
            // chbType
            // 
            this.chbType.AutoSize = true;
            this.chbType.Checked = true;
            this.chbType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbType.Location = new System.Drawing.Point(191, 15);
            this.chbType.Name = "chbType";
            this.chbType.Size = new System.Drawing.Size(46, 17);
            this.chbType.TabIndex = 12;
            this.chbType.Text = "Loại";
            this.chbType.UseVisualStyleBackColor = true;
            this.chbType.CheckedChanged += new System.EventHandler(this.chbType_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(72, 15);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(45, 17);
            this.chbName.TabIndex = 11;
            this.chbName.Text = "Tên";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "đến";
            // 
            // numUDTo
            // 
            this.numUDTo.Location = new System.Drawing.Point(578, 98);
            this.numUDTo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numUDTo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUDTo.Name = "numUDTo";
            this.numUDTo.Size = new System.Drawing.Size(71, 20);
            this.numUDTo.TabIndex = 9;
            this.numUDTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numUDFrom
            // 
            this.numUDFrom.Location = new System.Drawing.Point(468, 98);
            this.numUDFrom.Name = "numUDFrom";
            this.numUDFrom.Size = new System.Drawing.Size(67, 20);
            this.numUDFrom.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(332, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Giá (nghìn VNĐ)";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(332, 58);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(93, 16);
            this.lblProducer.TabIndex = 5;
            this.lblProducer.Text = "Hãng sản xuất";
            // 
            // txtProducer
            // 
            this.txtProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducer.Location = new System.Drawing.Point(468, 55);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(181, 22);
            this.txtProducer.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(125, 95);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(179, 24);
            this.cbType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại sản phẩm";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(125, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 0;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.Controls.Add(this.dgvMain);
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(770, 326);
            this.pnlData.TabIndex = 0;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(3, 3);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(764, 318);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.delToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Thêm";
            this.addToolStripMenuItem.ToolTipText = "thêm sản phẩm";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Sửa";
            this.editToolStripMenuItem.ToolTipText = "sửa sản phẩm đang chọn";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Enabled = false;
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.delToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delToolStripMenuItem.Text = "Xóa";
            this.delToolStripMenuItem.ToolTipText = "xóa sản phẩm đang chọn";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Thoát";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.productToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aboutToolStripMenuItem.Text = "Tìm hiểu thêm";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inforToolStripMenuItem,
            this.zaloToolStripMenuItem});
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.websiteToolStripMenuItem.Text = "Trang web";
            // 
            // inforToolStripMenuItem
            // 
            this.inforToolStripMenuItem.Name = "inforToolStripMenuItem";
            this.inforToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inforToolStripMenuItem.Text = "Infor";
            this.inforToolStripMenuItem.Click += new System.EventHandler(this.inforToolStripMenuItem_Click);
            // 
            // zaloToolStripMenuItem
            // 
            this.zaloToolStripMenuItem.Name = "zaloToolStripMenuItem";
            this.zaloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zaloToolStripMenuItem.Text = "Zalo";
            this.zaloToolStripMenuItem.Click += new System.EventHandler(this.zaloToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem.Text = "Sản phẩm";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhu yếu phẩm";
            this.pnlMain.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chboxPrice;
        private System.Windows.Forms.CheckBox chbProducer;
        private System.Windows.Forms.CheckBox chbType;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
    }
}

