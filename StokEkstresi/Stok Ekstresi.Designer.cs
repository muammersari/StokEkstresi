
namespace StokEkstresi
{
    partial class Stok_Ekstresi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKriter = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.selectKriter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ExcelExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(142, 23);
            this.startDate.MaxDate = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            this.startDate.MinDate = new System.DateTime(2016, 1, 4, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.ShowCheckBox = true;
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 1;
            this.startDate.Value = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(142, 61);
            this.endDate.MaxDate = new System.DateTime(2017, 4, 25, 0, 0, 0, 0);
            this.endDate.MinDate = new System.DateTime(2016, 1, 4, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.ShowCheckBox = true;
            this.endDate.Size = new System.Drawing.Size(200, 23);
            this.endDate.TabIndex = 1;
            this.endDate.Value = new System.DateTime(2016, 4, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(372, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Arama Yapılacak Kriter :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(438, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kriter Seçiniz :";
            // 
            // cbKriter
            // 
            this.cbKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKriter.FormattingEnabled = true;
            this.cbKriter.Items.AddRange(new object[] {
            "Mal Koduna Göre",
            "Mal Adına Göre"});
            this.cbKriter.Location = new System.Drawing.Point(551, 27);
            this.cbKriter.Name = "cbKriter";
            this.cbKriter.Size = new System.Drawing.Size(238, 23);
            this.cbKriter.TabIndex = 2;
            this.cbKriter.SelectedIndexChanged += new System.EventHandler(this.cbKriter_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(551, 59);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(238, 23);
            this.cbProduct.TabIndex = 2;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged_1);
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.LightGray;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(0, 141);
            this.Table.Name = "Table";
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(1074, 496);
            this.Table.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.Location = new System.Drawing.Point(142, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Arama";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // selectKriter
            // 
            this.selectKriter.AutoSize = true;
            this.selectKriter.Location = new System.Drawing.Point(616, 88);
            this.selectKriter.Name = "selectKriter";
            this.selectKriter.Size = new System.Drawing.Size(0, 15);
            this.selectKriter.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mal Kodu :";
            // 
            // btn_ExcelExport
            // 
            this.btn_ExcelExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExcelExport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExcelExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ExcelExport.Location = new System.Drawing.Point(453, 643);
            this.btn_ExcelExport.Name = "btn_ExcelExport";
            this.btn_ExcelExport.Size = new System.Drawing.Size(163, 32);
            this.btn_ExcelExport.TabIndex = 7;
            this.btn_ExcelExport.Text = "Excel Çıktısı Al";
            this.btn_ExcelExport.UseVisualStyleBackColor = false;
            this.btn_ExcelExport.Click += new System.EventHandler(this.btn_ExcelExport_Click);
            // 
            // Stok_Ekstresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1074, 679);
            this.Controls.Add(this.btn_ExcelExport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectKriter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbKriter);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stok_Ekstresi";
            this.Text = "Stok Ekstresi";
            this.Load += new System.EventHandler(this.Stok_Ekstresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKriter;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label selectKriter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ExcelExport;
    }
}