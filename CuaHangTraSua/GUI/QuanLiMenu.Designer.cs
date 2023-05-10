
namespace CuaHangTraSua.GUI
{
    partial class QuanLiMenu
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
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnThemSP = new System.Windows.Forms.Label();
            this.SP_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SP_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(10, 31);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(451, 23);
            this.search.TabIndex = 4;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // BtnThemSP
            // 
            this.BtnThemSP.BackColor = System.Drawing.Color.Transparent;
            this.BtnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThemSP.Location = new System.Drawing.Point(471, 22);
            this.BtnThemSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnThemSP.Name = "BtnThemSP";
            this.BtnThemSP.Size = new System.Drawing.Size(53, 39);
            this.BtnThemSP.TabIndex = 16;
            this.BtnThemSP.Text = "Tìm kiếm";
            this.BtnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnThemSP.Click += new System.EventHandler(this.BtnThemSP_Click);
            // 
            // SP_gridview
            // 
            this.SP_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SP_gridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SP_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SP_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SP_gridview.DefaultCellStyle = dataGridViewCellStyle4;
            this.SP_gridview.Location = new System.Drawing.Point(1, 67);
            this.SP_gridview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SP_gridview.Name = "SP_gridview";
            this.SP_gridview.RowHeadersVisible = false;
            this.SP_gridview.RowHeadersWidth = 62;
            this.SP_gridview.RowTemplate.Height = 28;
            this.SP_gridview.Size = new System.Drawing.Size(936, 384);
            this.SP_gridview.TabIndex = 17;
            this.SP_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoSP_gridview_CellClick);
            this.SP_gridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoSP_gridview_MouseClick);
            // 
            // QuanLiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 470);
            this.Controls.Add(this.SP_gridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnThemSP);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLiMenu";
            this.Text = "QuanLiMenu";
            this.Load += new System.EventHandler(this.QuanLiMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label BtnThemSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SP_gridview;
    }
}