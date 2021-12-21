
namespace Exchange_App
{
    partial class UserControlAlimSatim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24.1791F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALIM SATIM PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(306, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 4);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(302, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ÜRÜN";
            // 
            // cmbUrun
            // 
            this.cmbUrun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUrun.Font = new System.Drawing.Font("Century Gothic", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Items.AddRange(new object[] {
            "ARPA",
            "BUĞDAY",
            "PAMUK"});
            this.cmbUrun.Location = new System.Drawing.Point(306, 94);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(254, 28);
            this.cmbUrun.TabIndex = 25;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(306, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 4);
            this.panel2.TabIndex = 30;
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMiktar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiktar.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(306, 151);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(254, 21);
            this.txtMiktar.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(302, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "MİKTAR(KG)";
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.Green;
            this.btnAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAl.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAl.Location = new System.Drawing.Point(303, 268);
            this.btnAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(128, 32);
            this.btnAl.TabIndex = 31;
            this.btnAl.Text = "AL";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSat.Font = new System.Drawing.Font("Century Gothic", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSat.Location = new System.Drawing.Point(435, 268);
            this.btnSat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(125, 32);
            this.btnSat.TabIndex = 31;
            this.btnSat.Text = "SAT";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 228);
            this.dataGridView1.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(306, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 20);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "LİMİT EMRİ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(302, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "FİYAT";
            this.label4.Visible = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiyat.Font = new System.Drawing.Font("Century Gothic", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(306, 230);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(254, 21);
            this.txtFiyat.TabIndex = 29;
            this.txtFiyat.Visible = false;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(306, 248);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 4);
            this.panel3.TabIndex = 30;
            this.panel3.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(845, 521);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 57;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(24, 11);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.Visible = false;
            // 
            // UserControlAlimSatim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAlimSatim";
            this.Size = new System.Drawing.Size(872, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
