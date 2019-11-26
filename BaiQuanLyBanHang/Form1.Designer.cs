namespace BaiQuanLyBanHang
{
    partial class fHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLoaihang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.txtMaugiay = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiQuanLyBanHang.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(40, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtLoaihang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnNhaplai);
            this.groupBox1.Controls.Add(this.txtMaugiay);
            this.groupBox1.Controls.Add(this.txtMahang);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtTenhang);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGiaban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(40, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 394);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLoaihang
            // 
            this.txtLoaihang.Location = new System.Drawing.Point(101, 181);
            this.txtLoaihang.Name = "txtLoaihang";
            this.txtLoaihang.Size = new System.Drawing.Size(121, 22);
            this.txtLoaihang.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Màu Giày";
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(263, 31);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 33);
            this.btnNhaplai.TabIndex = 14;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // txtMaugiay
            // 
            this.txtMaugiay.Location = new System.Drawing.Point(101, 227);
            this.txtMaugiay.Name = "txtMaugiay";
            this.txtMaugiay.Size = new System.Drawing.Size(121, 22);
            this.txtMaugiay.TabIndex = 16;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(101, 36);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(121, 22);
            this.txtMahang.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(192, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Giày";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(101, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(101, 81);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(121, 22);
            this.txtTenhang.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 276);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá Bán";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(101, 134);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(121, 22);
            this.txtGiaban.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Giày";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 618);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "fHome";
            this.Text = "Quản Lý Bán Giày";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHome_FormClosing);
            this.Load += new System.EventHandler(this.fHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoaihang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.TextBox txtMaugiay;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
    }
}

