namespace formDangNhap
{
    partial class frmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSnack = new System.Windows.Forms.ComboBox();
            this.cboDrink = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvAddFood = new System.Windows.Forms.DataGridView();
            this.numSLTU = new System.Windows.Forms.NumericUpDown();
            this.numSLTAN = new System.Windows.Forms.NumericUpDown();
            this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTAN)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTable
            // 
            this.cboTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(471, 76);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(272, 33);
            this.cboTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Bàn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thức Uống :";
            // 
            // cboSnack
            // 
            this.cboSnack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSnack.FormattingEnabled = true;
            this.cboSnack.Location = new System.Drawing.Point(471, 232);
            this.cboSnack.Name = "cboSnack";
            this.cboSnack.Size = new System.Drawing.Size(272, 33);
            this.cboSnack.TabIndex = 4;
            // 
            // cboDrink
            // 
            this.cboDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrink.FormattingEnabled = true;
            this.cboDrink.Location = new System.Drawing.Point(471, 157);
            this.cboDrink.Name = "cboDrink";
            this.cboDrink.Size = new System.Drawing.Size(272, 33);
            this.cboDrink.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thức ăn nhẹ :";
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.White;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(819, 62);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(69, 65);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.UseVisualStyleBackColor = false;
            // 
            // dgvAddFood
            // 
            this.dgvAddFood.AllowUserToAddRows = false;
            this.dgvAddFood.AllowUserToDeleteRows = false;
            this.dgvAddFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTable,
            this.colTU,
            this.colSLTT,
            this.colTT,
            this.colSLTAN});
            this.dgvAddFood.Location = new System.Drawing.Point(308, 299);
            this.dgvAddFood.Name = "dgvAddFood";
            this.dgvAddFood.ReadOnly = true;
            this.dgvAddFood.RowHeadersVisible = false;
            this.dgvAddFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddFood.Size = new System.Drawing.Size(580, 241);
            this.dgvAddFood.TabIndex = 8;
            // 
            // numSLTU
            // 
            this.numSLTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSLTU.Location = new System.Drawing.Point(758, 159);
            this.numSLTU.Name = "numSLTU";
            this.numSLTU.Size = new System.Drawing.Size(32, 31);
            this.numSLTU.TabIndex = 9;
            this.numSLTU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSLTAN
            // 
            this.numSLTAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSLTAN.Location = new System.Drawing.Point(757, 233);
            this.numSLTAN.Name = "numSLTAN";
            this.numSLTAN.Size = new System.Drawing.Size(32, 31);
            this.numSLTAN.TabIndex = 10;
            // 
            // colTable
            // 
            this.colTable.HeaderText = "Bàn";
            this.colTable.Name = "colTable";
            this.colTable.ReadOnly = true;
            // 
            // colTU
            // 
            this.colTU.HeaderText = "Thức uống";
            this.colTU.Name = "colTU";
            this.colTU.ReadOnly = true;
            // 
            // colSLTT
            // 
            this.colSLTT.HeaderText = "Số lượng";
            this.colSLTT.Name = "colSLTT";
            this.colSLTT.ReadOnly = true;
            // 
            // colTT
            // 
            this.colTT.HeaderText = "Thức ăn nhẹ";
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            // 
            // colSLTAN
            // 
            this.colSLTAN.HeaderText = "Số lượng";
            this.colSLTAN.Name = "colSLTAN";
            this.colSLTAN.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(819, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 65);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(819, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 65);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.numSLTAN);
            this.Controls.Add(this.numSLTU);
            this.Controls.Add(this.dgvAddFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDrink);
            this.Controls.Add(this.cboSnack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTable);
            this.Name = "frmAddFood";
            this.Text = "frmAddFood";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLTAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSnack;
        private System.Windows.Forms.ComboBox cboDrink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgvAddFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTAN;
        private System.Windows.Forms.NumericUpDown numSLTU;
        private System.Windows.Forms.NumericUpDown numSLTAN;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
    }
}