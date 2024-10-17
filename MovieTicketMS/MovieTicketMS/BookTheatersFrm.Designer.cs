namespace MovieTicketMS
{
    partial class BookTheatersFrm
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
            this.lblNgayXem = new System.Windows.Forms.Label();
            this.lblRapChieu = new System.Windows.Forms.Label();
            this.lblKhungGio = new System.Windows.Forms.Label();
            this.cmbRapChieu = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbKhungGio = new System.Windows.Forms.ComboBox();
            this.lbl_X = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMovieInBookTheater = new System.Windows.Forms.PictureBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieInBookTheater)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayXem
            // 
            this.lblNgayXem.AutoSize = true;
            this.lblNgayXem.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayXem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXem.Location = new System.Drawing.Point(12, 451);
            this.lblNgayXem.Name = "lblNgayXem";
            this.lblNgayXem.Size = new System.Drawing.Size(130, 26);
            this.lblNgayXem.TabIndex = 1;
            this.lblNgayXem.Text = "NGÀY XEM";
            // 
            // lblRapChieu
            // 
            this.lblRapChieu.AutoSize = true;
            this.lblRapChieu.BackColor = System.Drawing.Color.Transparent;
            this.lblRapChieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapChieu.Location = new System.Drawing.Point(12, 530);
            this.lblRapChieu.Name = "lblRapChieu";
            this.lblRapChieu.Size = new System.Drawing.Size(127, 26);
            this.lblRapChieu.TabIndex = 2;
            this.lblRapChieu.Text = "RẠP CHIẾU";
            // 
            // lblKhungGio
            // 
            this.lblKhungGio.AutoSize = true;
            this.lblKhungGio.BackColor = System.Drawing.Color.Transparent;
            this.lblKhungGio.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhungGio.Location = new System.Drawing.Point(12, 388);
            this.lblKhungGio.Name = "lblKhungGio";
            this.lblKhungGio.Size = new System.Drawing.Size(137, 26);
            this.lblKhungGio.TabIndex = 4;
            this.lblKhungGio.Text = "KHUNG GIỜ";
            // 
            // cmbRapChieu
            // 
            this.cmbRapChieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRapChieu.FormattingEnabled = true;
            this.cmbRapChieu.Location = new System.Drawing.Point(155, 522);
            this.cmbRapChieu.Name = "cmbRapChieu";
            this.cmbRapChieu.Size = new System.Drawing.Size(330, 34);
            this.cmbRapChieu.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(155, 613);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(330, 45);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(17, 613);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(125, 45);
            this.btnTroVe.TabIndex = 23;
            this.btnTroVe.Text = "TRỞ VỀ";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 445);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbKhungGio
            // 
            this.cmbKhungGio.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhungGio.FormattingEnabled = true;
            this.cmbKhungGio.Location = new System.Drawing.Point(155, 380);
            this.cmbKhungGio.Name = "cmbKhungGio";
            this.cmbKhungGio.Size = new System.Drawing.Size(330, 34);
            this.cmbKhungGio.TabIndex = 3;
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.BackColor = System.Drawing.Color.Transparent;
            this.lbl_X.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(1263, 9);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(19, 20);
            this.lbl_X.TabIndex = 22;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblThoiLuong);
            this.panel1.Controls.Add(this.lblTheLoai);
            this.panel1.Controls.Add(this.cmbKhungGio);
            this.panel1.Controls.Add(this.lblNgayXem);
            this.panel1.Controls.Add(this.btnTroVe);
            this.panel1.Controls.Add(this.lblRapChieu);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblKhungGio);
            this.panel1.Controls.Add(this.cmbRapChieu);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(797, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 673);
            this.panel1.TabIndex = 24;
            // 
            // picMovieInBookTheater
            // 
            this.picMovieInBookTheater.Dock = System.Windows.Forms.DockStyle.Left;
            this.picMovieInBookTheater.Location = new System.Drawing.Point(0, 0);
            this.picMovieInBookTheater.Name = "picMovieInBookTheater";
            this.picMovieInBookTheater.Size = new System.Drawing.Size(791, 673);
            this.picMovieInBookTheater.TabIndex = 25;
            this.picMovieInBookTheater.TabStop = false;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblTheLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(12, 120);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(114, 26);
            this.lblTheLoai.TabIndex = 24;
            this.lblTheLoai.Text = "THỂ LOẠI";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiLuong.Location = new System.Drawing.Point(12, 179);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(152, 26);
            this.lblThoiLuong.TabIndex = 25;
            this.lblThoiLuong.Text = "THỜI LƯỢNG";
            // 
            // BookTheatersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 673);
            this.Controls.Add(this.picMovieInBookTheater);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTheatersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonRap_TG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovieInBookTheater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNgayXem;
        private System.Windows.Forms.Label lblRapChieu;
        private System.Windows.Forms.Label lblKhungGio;
        private System.Windows.Forms.ComboBox cmbRapChieu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbKhungGio;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMovieInBookTheater;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblTheLoai;
    }
}