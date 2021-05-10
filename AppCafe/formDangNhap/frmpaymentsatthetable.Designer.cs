namespace formDangNhap
{
    partial class frmpaymentsatthetable
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
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.dgvdsmon = new System.Windows.Forms.DataGridView();
            this.lbltong = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colthucuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceDrink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienDrink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSnack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceSnack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienSnack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsmon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvban
            // 
            this.dgvban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colten,
            this.coltrangthai});
            this.dgvban.Location = new System.Drawing.Point(12, 22);
            this.dgvban.Name = "dgvban";
            this.dgvban.RowHeadersVisible = false;
            this.dgvban.RowTemplate.Height = 24;
            this.dgvban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvban.Size = new System.Drawing.Size(307, 588);
            this.dgvban.TabIndex = 3;
            // 
            // dgvdsmon
            // 
            this.dgvdsmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colthucuong,
            this.colSLTU,
            this.colPriceDrink,
            this.colThanhTienDrink,
            this.colSnack,
            this.colSLTA,
            this.colPriceSnack,
            this.colThanhTienSnack});
            this.dgvdsmon.Location = new System.Drawing.Point(348, 22);
            this.dgvdsmon.Name = "dgvdsmon";
            this.dgvdsmon.RowHeadersVisible = false;
            this.dgvdsmon.RowTemplate.Height = 24;
            this.dgvdsmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdsmon.Size = new System.Drawing.Size(868, 474);
            this.dgvdsmon.TabIndex = 4;
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.Location = new System.Drawing.Point(355, 547);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(108, 36);
            this.lbltong.TabIndex = 5;
            this.lbltong.Text = "Tổng : ";
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(535, 536);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(383, 53);
            this.txttongtien.TabIndex = 6;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(953, 516);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(263, 87);
            this.btnthanhtoan.TabIndex = 7;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            // 
            // colid
            // 
            this.colid.HeaderText = "ID";
            this.colid.Name = "colid";
            // 
            // colten
            // 
            this.colten.HeaderText = "Tên Bàn";
            this.colten.Name = "colten";
            // 
            // coltrangthai
            // 
            this.coltrangthai.HeaderText = "Trạng Thái";
            this.coltrangthai.Name = "coltrangthai";
            this.coltrangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrangthai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colthucuong
            // 
            this.colthucuong.HeaderText = "Thức Uống";
            this.colthucuong.Name = "colthucuong";
            // 
            // colSLTU
            // 
            this.colSLTU.HeaderText = "Số Lượng";
            this.colSLTU.Name = "colSLTU";
            // 
            // colPriceDrink
            // 
            this.colPriceDrink.HeaderText = "Giá Món";
            this.colPriceDrink.Name = "colPriceDrink";
            // 
            // colThanhTienDrink
            // 
            this.colThanhTienDrink.HeaderText = "Thành Tiền";
            this.colThanhTienDrink.Name = "colThanhTienDrink";
            // 
            // colSnack
            // 
            this.colSnack.HeaderText = "Thức ĂN Nhẹ";
            this.colSnack.Name = "colSnack";
            // 
            // colSLTA
            // 
            this.colSLTA.HeaderText = "Số Lượng";
            this.colSLTA.Name = "colSLTA";
            // 
            // colPriceSnack
            // 
            this.colPriceSnack.HeaderText = "Giá Món";
            this.colPriceSnack.Name = "colPriceSnack";
            // 
            // colThanhTienSnack
            // 
            this.colThanhTienSnack.HeaderText = "Thành Tiền";
            this.colThanhTienSnack.Name = "colThanhTienSnack";
            // 
            // frmpaymentsatthetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.dgvdsmon);
            this.Controls.Add(this.dgvban);
            this.Name = "frmpaymentsatthetable";
            this.Text = "frmpayment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvban;
        private System.Windows.Forms.DataGridView dgvdsmon;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthucuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceDrink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienDrink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSnack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceSnack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienSnack;
    }
}