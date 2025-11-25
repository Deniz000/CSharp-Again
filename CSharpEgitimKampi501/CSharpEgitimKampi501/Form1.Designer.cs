using System.Threading.Tasks;

namespace CSharpEgitimKampi501
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private async Task InitializeComponent()
        {
            label1 = new Label();
            txtid = new TextBox();
            dataGridView1 = new DataGridView();
            btnList = new Button();
            txtName = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtCategory = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            lblTotalProductCount = new Label();
            label7 = new Label();
            lblMaxPriceProductName = new Label();
            lbl0 = new Label();
            lblDistinctCategoryCount = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 57);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "ÜrünID : ";
            // 
            // txtid
            // 
            txtid.Location = new Point(106, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(208, 27);
            txtid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(341, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(893, 457);
            dataGridView1.TabIndex = 2;
            // 
            // btnList
            // 
            btnList.Location = new Point(106, 278);
            btnList.Name = "btnList";
            btnList.Size = new Size(208, 46);
            btnList.TabIndex = 3;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Ürün Adı : ";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(106, 182);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(208, 27);
            txtStock.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 189);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Stok :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(106, 138);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(208, 27);
            txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 145);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Fiyat : ";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(106, 229);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(208, 27);
            txtCategory.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 236);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 10;
            label5.Text = "Kategori : ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(106, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(208, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_ClickAsync;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(106, 461);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 46);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(106, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(208, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_ClickAsync;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 572);
            label6.Name = "label6";
            label6.Size = new Size(292, 32);
            label6.TabIndex = 15;
            label6.Text = "Toplam Ürün Sayısı : ";
            // 
            // lblTotalProductCount
            // 
            lblTotalProductCount.AutoSize = true;
            lblTotalProductCount.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductCount.Location = new Point(320, 572);
            lblTotalProductCount.Name = "lblTotalProductCount";
            lblTotalProductCount.Size = new Size(42, 32);
            lblTotalProductCount.TabIndex = 16;
            lblTotalProductCount.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 628);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 17;
            // 
            // lblMaxPriceProductName
            // 
            lblMaxPriceProductName.AutoSize = true;
            lblMaxPriceProductName.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxPriceProductName.Location = new Point(320, 619);
            lblMaxPriceProductName.Name = "lblMaxPriceProductName";
            lblMaxPriceProductName.Size = new Size(46, 32);
            lblMaxPriceProductName.TabIndex = 19;
            lblMaxPriceProductName.Text = "\" \"";
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0.Location = new Point(81, 619);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(234, 32);
            lbl0.TabIndex = 18;
            lbl0.Text = "En Pahalı Ürün : ";
            // 
            // lblDistinctCategoryCount
            // 
            lblDistinctCategoryCount.AutoSize = true;
            lblDistinctCategoryCount.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistinctCategoryCount.Location = new Point(319, 667);
            lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
            lblDistinctCategoryCount.Size = new Size(46, 32);
            lblDistinctCategoryCount.TabIndex = 21;
            lblDistinctCategoryCount.Text = "\" \"";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("High Tower Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(80, 667);
            label9.Name = "label9";
            label9.Size = new Size(226, 32);
            label9.TabIndex = 20;
            label9.Text = "Kategori Sayısı : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1283, 740);
            Controls.Add(lblDistinctCategoryCount);
            Controls.Add(label9);
            Controls.Add(lblMaxPriceProductName);
            Controls.Add(lbl0);
            Controls.Add(label7);
            Controls.Add(lblTotalProductCount);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnList);
            Controls.Add(dataGridView1);
            Controls.Add(txtid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid;
        private DataGridView dataGridView1;
        private Button btnList;
        private TextBox txtName;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtCategory;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private Label lblTotalProductCount;
        private Label label7;
        private Label lblMaxPriceProductName;
        private Label lbl0;
        private Label lblDistinctCategoryCount;
        private Label label9;
    }
}
