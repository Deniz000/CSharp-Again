namespace CSharpEgitimKampi301.EFProject
{
    partial class Form1
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
            this.btn_list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rehber Id:";
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(141, 177);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(182, 44);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "listele";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 376);
            this.dataGridView1.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(141, 62);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(182, 22);
            this.txt_id.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(141, 101);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(182, 22);
            this.txt_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Adı:";
            // 
            // txt_soyadı
            // 
            this.txt_soyadı.Location = new System.Drawing.Point(141, 138);
            this.txt_soyadı.Name = "txt_soyadı";
            this.txt_soyadı.Size = new System.Drawing.Size(182, 22);
            this.txt_soyadı.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(141, 229);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(182, 44);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(141, 331);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(182, 44);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(141, 279);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(182, 44);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(141, 381);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(182, 44);
            this.btn_get.TabIndex = 11;
            this.btn_get.Text = "Getir";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_soyadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyadı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_get;
    }
}

