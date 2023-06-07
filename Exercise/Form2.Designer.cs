namespace Exercise
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apotekCemaraUASDataSet = new Exercise.ApotekCemaraUASDataSet();
            this.pembeliTableAdapter = new Exercise.ApotekCemaraUASDataSetTableAdapters.PembeliTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekCemaraUASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPembeliDataGridViewTextBoxColumn,
            this.namaPembeliDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatPembeliDataGridViewTextBoxColumn,
            this.noTelpPembeliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembeliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(95, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDPembeliDataGridViewTextBoxColumn
            // 
            this.iDPembeliDataGridViewTextBoxColumn.DataPropertyName = "ID_Pembeli";
            this.iDPembeliDataGridViewTextBoxColumn.HeaderText = "ID_Pembeli";
            this.iDPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPembeliDataGridViewTextBoxColumn.Name = "iDPembeliDataGridViewTextBoxColumn";
            this.iDPembeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPembeliDataGridViewTextBoxColumn
            // 
            this.namaPembeliDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pembeli";
            this.namaPembeliDataGridViewTextBoxColumn.HeaderText = "Nama_Pembeli";
            this.namaPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPembeliDataGridViewTextBoxColumn.Name = "namaPembeliDataGridViewTextBoxColumn";
            this.namaPembeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatPembeliDataGridViewTextBoxColumn
            // 
            this.alamatPembeliDataGridViewTextBoxColumn.DataPropertyName = "Alamat_Pembeli";
            this.alamatPembeliDataGridViewTextBoxColumn.HeaderText = "Alamat_Pembeli";
            this.alamatPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatPembeliDataGridViewTextBoxColumn.Name = "alamatPembeliDataGridViewTextBoxColumn";
            this.alamatPembeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelpPembeliDataGridViewTextBoxColumn
            // 
            this.noTelpPembeliDataGridViewTextBoxColumn.DataPropertyName = "No_Telp_Pembeli";
            this.noTelpPembeliDataGridViewTextBoxColumn.HeaderText = "No_Telp_Pembeli";
            this.noTelpPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelpPembeliDataGridViewTextBoxColumn.Name = "noTelpPembeliDataGridViewTextBoxColumn";
            this.noTelpPembeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // pembeliBindingSource
            // 
            this.pembeliBindingSource.DataMember = "Pembeli";
            this.pembeliBindingSource.DataSource = this.apotekCemaraUASDataSet;
            // 
            // apotekCemaraUASDataSet
            // 
            this.apotekCemaraUASDataSet.DataSetName = "ApotekCemaraUASDataSet";
            this.apotekCemaraUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembeliTableAdapter
            // 
            this.pembeliTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(23, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "MENU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(308, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Grid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(868, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekCemaraUASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ApotekCemaraUASDataSet apotekCemaraUASDataSet;
        private System.Windows.Forms.BindingSource pembeliBindingSource;
        private ApotekCemaraUASDataSetTableAdapters.PembeliTableAdapter pembeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}