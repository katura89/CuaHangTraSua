
namespace CuaHangTraSua.GUI
{
    partial class QuanLiNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.InfoNV_gridview = new System.Windows.Forms.DataGridView();
            this.BtnThem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoNV_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(12, 30);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(425, 23);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // InfoNV_gridview
            // 
            this.InfoNV_gridview.AllowUserToOrderColumns = true;
            this.InfoNV_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoNV_gridview.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoNV_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.InfoNV_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoNV_gridview.DefaultCellStyle = dataGridViewCellStyle4;
            this.InfoNV_gridview.Location = new System.Drawing.Point(1, 67);
            this.InfoNV_gridview.Margin = new System.Windows.Forms.Padding(2);
            this.InfoNV_gridview.Name = "InfoNV_gridview";
            this.InfoNV_gridview.RowHeadersVisible = false;
            this.InfoNV_gridview.RowHeadersWidth = 62;
            this.InfoNV_gridview.RowTemplate.Height = 28;
            this.InfoNV_gridview.Size = new System.Drawing.Size(945, 369);
            this.InfoNV_gridview.TabIndex = 17;
            this.InfoNV_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoNV_gridview_CellClick);
            this.InfoNV_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoNV_gridview_CellContentClick);
            this.InfoNV_gridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoNV_gridview_MouseClick_1);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThem.Location = new System.Drawing.Point(453, 22);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(65, 33);
            this.BtnThem.TabIndex = 16;
            this.BtnThem.Text = "Tìm kiếm";
            this.BtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 433);
            this.Controls.Add(this.InfoNV_gridview);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLiNhanVien";
            this.Text = "QuanLiNhanVien";
            this.Load += new System.EventHandler(this.QuanLiNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoNV_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label BtnThem;
        private System.Windows.Forms.DataGridView InfoNV_gridview;
    }
}