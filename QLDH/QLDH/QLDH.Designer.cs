namespace QLDH
{
    partial class QLDH
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
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.dienThoaiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgayDH = new System.Windows.Forms.DateTimePicker();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.dtpNgayDonHang = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ThemCTDH = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gVDH = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVDH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(19, 48);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(74, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã đơn hàng:";
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Location = new System.Drawing.Point(19, 75);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(81, 13);
            this.ngaySinhLabel.TabIndex = 4;
            this.ngaySinhLabel.Text = "Ngày đặt hàng:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Location = new System.Drawing.Point(355, 78);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(59, 13);
            this.diaChiLabel.TabIndex = 6;
            this.diaChiLabel.Text = "Nhân viên:";
            // 
            // dienThoaiLabel
            // 
            this.dienThoaiLabel.AutoSize = true;
            this.dienThoaiLabel.Location = new System.Drawing.Point(355, 48);
            this.dienThoaiLabel.Name = "dienThoaiLabel";
            this.dienThoaiLabel.Size = new System.Drawing.Size(68, 13);
            this.dienThoaiLabel.TabIndex = 8;
            this.dienThoaiLabel.Text = "Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNhanVien);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.dtpNgayDH);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.txtMaDH);
            this.groupBox1.Controls.Add(this.ngaySinhLabel);
            this.groupBox1.Controls.Add(this.diaChiLabel);
            this.groupBox1.Controls.Add(this.dienThoaiLabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(426, 75);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(218, 21);
            this.cbNhanVien.TabIndex = 14;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(426, 46);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(218, 21);
            this.cbKhachHang.TabIndex = 14;
            // 
            // dtpNgayDH
            // 
            this.dtpNgayDH.Location = new System.Drawing.Point(124, 75);
            this.dtpNgayDH.Name = "dtpNgayDH";
            this.dtpNgayDH.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDH.TabIndex = 13;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(124, 45);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(200, 20);
            this.txtMaDH.TabIndex = 3;
            // 
            // dtpNgayDonHang
            // 
            this.dtpNgayDonHang.Location = new System.Drawing.Point(186, 109);
            this.dtpNgayDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDonHang.Name = "dtpNgayDonHang";
            this.dtpNgayDonHang.Size = new System.Drawing.Size(298, 20);
            this.dtpNgayDonHang.TabIndex = 5;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ThemCTDH);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Location = new System.Drawing.Point(279, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // ThemCTDH
            // 
            this.ThemCTDH.Location = new System.Drawing.Point(258, 19);
            this.ThemCTDH.Name = "ThemCTDH";
            this.ThemCTDH.Size = new System.Drawing.Size(75, 58);
            this.ThemCTDH.TabIndex = 3;
            this.ThemCTDH.Text = "Thêm CTDH";
            this.ThemCTDH.UseVisualStyleBackColor = true;
            this.ThemCTDH.Click += new System.EventHandler(this.ThemCTDH_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(349, 19);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 58);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(168, 19);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 58);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(87, 19);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 58);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(6, 19);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 58);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gVDH);
            this.groupBox3.Location = new System.Drawing.Point(55, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 301);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đơn hàng";
            // 
            // gVDH
            // 
            this.gVDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDH.Location = new System.Drawing.Point(9, 18);
            this.gVDH.Margin = new System.Windows.Forms.Padding(2);
            this.gVDH.Name = "gVDH";
            this.gVDH.RowHeadersWidth = 62;
            this.gVDH.RowTemplate.Height = 28;
            this.gVDH.Size = new System.Drawing.Size(650, 269);
            this.gVDH.TabIndex = 0;
            this.gVDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVDH_CellClick);
            this.gVDH.DoubleClick += new System.EventHandler(this.gVDH_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýĐơnHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(764, 29);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quảnLýSảnPhẩmToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(159, 25);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            // 
            // quảnLýĐơnHàngToolStripMenuItem
            // 
            this.quảnLýĐơnHàngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quảnLýĐơnHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.quảnLýĐơnHàngToolStripMenuItem.Name = "quảnLýĐơnHàngToolStripMenuItem";
            this.quảnLýĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.quảnLýĐơnHàngToolStripMenuItem.Text = "Quản lý đơn hàng";
            // 
            // QLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 609);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLDH";
            this.Text = "FOrderDetails";
            this.Load += new System.EventHandler(this.QLDH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVDH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker dtpNgayDonHang;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label dienThoaiLabel;
        private System.Windows.Forms.DataGridView gVDH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpNgayDH;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Button ThemCTDH;
    }
}