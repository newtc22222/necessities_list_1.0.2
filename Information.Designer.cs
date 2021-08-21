
namespace necessities_list
{
    partial class Information
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtPrice_String = new System.Windows.Forms.TextBox();
            this.numUDCost = new System.Windows.Forms.NumericUpDown();
            this.numUDThousands = new System.Windows.Forms.NumericUpDown();
            this.numUDMillions = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chbExp = new System.Windows.Forms.CheckBox();
            this.chbDoM = new System.Windows.Forms.CheckBox();
            this.dtPickerExp = new System.Windows.Forms.DateTimePicker();
            this.dtPickerDoM = new System.Windows.Forms.DateTimePicker();
            this.lblDoM = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTipInfor = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThousands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMillions)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 388);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCost);
            this.panel3.Controls.Add(this.txtPrice_String);
            this.panel3.Controls.Add(this.numUDCost);
            this.panel3.Controls.Add(this.numUDThousands);
            this.panel3.Controls.Add(this.numUDMillions);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbTypeProduct);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblType);
            this.panel3.Controls.Add(this.txtProducer);
            this.panel3.Controls.Add(this.lblProducer);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 349);
            this.panel3.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(369, 327);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 16);
            this.lblCost.TabIndex = 18;
            this.lblCost.Text = "Đồng";
            // 
            // txtPrice_String
            // 
            this.txtPrice_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice_String.Location = new System.Drawing.Point(130, 324);
            this.txtPrice_String.Name = "txtPrice_String";
            this.txtPrice_String.ReadOnly = true;
            this.txtPrice_String.Size = new System.Drawing.Size(233, 22);
            this.txtPrice_String.TabIndex = 17;
            // 
            // numUDCost
            // 
            this.numUDCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDCost.Location = new System.Drawing.Point(326, 291);
            this.numUDCost.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUDCost.Name = "numUDCost";
            this.numUDCost.Size = new System.Drawing.Size(80, 22);
            this.numUDCost.TabIndex = 16;
            this.toolTipInfor.SetToolTip(this.numUDCost, "tùy chỉnh trị giá sản phẩm");
            this.numUDCost.ValueChanged += new System.EventHandler(this.numUDMillions_ValueChanged);
            // 
            // numUDThousands
            // 
            this.numUDThousands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDThousands.Location = new System.Drawing.Point(225, 291);
            this.numUDThousands.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUDThousands.Name = "numUDThousands";
            this.numUDThousands.Size = new System.Drawing.Size(82, 22);
            this.numUDThousands.TabIndex = 15;
            this.toolTipInfor.SetToolTip(this.numUDThousands, "tùy chỉnh trị giá sản phẩm");
            this.numUDThousands.ValueChanged += new System.EventHandler(this.numUDMillions_ValueChanged);
            // 
            // numUDMillions
            // 
            this.numUDMillions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDMillions.Location = new System.Drawing.Point(131, 291);
            this.numUDMillions.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUDMillions.Name = "numUDMillions";
            this.numUDMillions.Size = new System.Drawing.Size(76, 22);
            this.numUDMillions.TabIndex = 14;
            this.toolTipInfor.SetToolTip(this.numUDMillions, "tùy chỉnh trị giá sản phẩm");
            this.numUDMillions.ValueChanged += new System.EventHandler(this.numUDMillions_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chbExp);
            this.panel4.Controls.Add(this.chbDoM);
            this.panel4.Controls.Add(this.dtPickerExp);
            this.panel4.Controls.Add(this.dtPickerDoM);
            this.panel4.Controls.Add(this.lblDoM);
            this.panel4.Controls.Add(this.lblExp);
            this.panel4.Location = new System.Drawing.Point(3, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 85);
            this.panel4.TabIndex = 13;
            // 
            // chbExp
            // 
            this.chbExp.AutoSize = true;
            this.chbExp.Checked = true;
            this.chbExp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExp.Location = new System.Drawing.Point(351, 52);
            this.chbExp.Name = "chbExp";
            this.chbExp.Size = new System.Drawing.Size(74, 20);
            this.chbExp.TabIndex = 14;
            this.chbExp.Text = "có HSD";
            this.toolTipInfor.SetToolTip(this.chbExp, "thông tin về hạn sử dụng của sản phẩm");
            this.chbExp.UseVisualStyleBackColor = true;
            this.chbExp.CheckedChanged += new System.EventHandler(this.chbExp_CheckedChanged);
            // 
            // chbDoM
            // 
            this.chbDoM.AutoSize = true;
            this.chbDoM.Checked = true;
            this.chbDoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDoM.Location = new System.Drawing.Point(351, 10);
            this.chbDoM.Name = "chbDoM";
            this.chbDoM.Size = new System.Drawing.Size(72, 20);
            this.chbDoM.TabIndex = 13;
            this.chbDoM.Text = "có NXS";
            this.toolTipInfor.SetToolTip(this.chbDoM, "thông tin về ngày sản xuất của sản phẩm");
            this.chbDoM.UseVisualStyleBackColor = true;
            this.chbDoM.CheckedChanged += new System.EventHandler(this.chbDoM_CheckedChanged);
            // 
            // dtPickerExp
            // 
            this.dtPickerExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerExp.Location = new System.Drawing.Point(127, 52);
            this.dtPickerExp.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerExp.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPickerExp.Name = "dtPickerExp";
            this.dtPickerExp.Size = new System.Drawing.Size(218, 20);
            this.dtPickerExp.TabIndex = 12;
            // 
            // dtPickerDoM
            // 
            this.dtPickerDoM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDoM.Location = new System.Drawing.Point(127, 10);
            this.dtPickerDoM.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickerDoM.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtPickerDoM.Name = "dtPickerDoM";
            this.dtPickerDoM.Size = new System.Drawing.Size(218, 20);
            this.dtPickerDoM.TabIndex = 11;
            // 
            // lblDoM
            // 
            this.lblDoM.AutoSize = true;
            this.lblDoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoM.Location = new System.Drawing.Point(3, 14);
            this.lblDoM.Name = "lblDoM";
            this.lblDoM.Size = new System.Drawing.Size(93, 16);
            this.lblDoM.TabIndex = 7;
            this.lblDoM.Text = "Ngày sản xuất";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExp.Location = new System.Drawing.Point(4, 56);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(83, 16);
            this.lblExp.TabIndex = 8;
            this.lblExp.Text = "Hạn sử dụng";
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Location = new System.Drawing.Point(130, 135);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(233, 24);
            this.cbTypeProduct.TabIndex = 10;
            this.toolTipInfor.SetToolTip(this.cbTypeProduct, "tùy chọn loại sản phẩm");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 293);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 16);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Giá thành";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 138);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 16);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Loại sản phẩm";
            // 
            // txtProducer
            // 
            this.txtProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducer.Location = new System.Drawing.Point(130, 86);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(233, 22);
            this.txtProducer.TabIndex = 5;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.Location = new System.Drawing.Point(3, 89);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(85, 16);
            this.lblProducer.TabIndex = 4;
            this.lblProducer.Text = "Nhà sản xuất";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(130, 9);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(233, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipInfor.SetToolTip(this.txtID, "Mã sản phẩm sẽ được chỉnh tự động");
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(89, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mã sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(3, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 30);
            this.panel2.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(353, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.toolTipInfor.SetToolTip(this.btnExit, "Trở về trang tổng hợp");
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 24);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.toolTipInfor.SetToolTip(this.btnSave, "Lưu thông tin");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 412);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Information";
            this.ShowIcon = false;
            this.Text = "Thông tin mặt hàng";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDThousands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMillions)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblDoM;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chbExp;
        private System.Windows.Forms.CheckBox chbDoM;
        private System.Windows.Forms.DateTimePicker dtPickerExp;
        private System.Windows.Forms.DateTimePicker dtPickerDoM;
        private System.Windows.Forms.NumericUpDown numUDCost;
        private System.Windows.Forms.NumericUpDown numUDThousands;
        private System.Windows.Forms.NumericUpDown numUDMillions;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtPrice_String;
        private System.Windows.Forms.ToolTip toolTipInfor;
    }
}