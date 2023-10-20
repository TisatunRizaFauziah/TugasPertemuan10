namespace TugasPertemuan10
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
            this.btnKereta = new System.Windows.Forms.Button();
            this.btnStasiun = new System.Windows.Forms.Button();
            this.btnPenumpang = new System.Windows.Forms.Button();
            this.btnKelas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "PT KERETA API INDONESIA";
            // 
            // btnKereta
            // 
            this.btnKereta.BackColor = System.Drawing.Color.Red;
            this.btnKereta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKereta.Location = new System.Drawing.Point(1043, 148);
            this.btnKereta.Name = "btnKereta";
            this.btnKereta.Size = new System.Drawing.Size(168, 60);
            this.btnKereta.TabIndex = 1;
            this.btnKereta.Text = "Kereta";
            this.btnKereta.UseVisualStyleBackColor = false;
            this.btnKereta.Click += new System.EventHandler(this.btnKereta_Click);
            // 
            // btnStasiun
            // 
            this.btnStasiun.BackColor = System.Drawing.Color.Red;
            this.btnStasiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStasiun.Location = new System.Drawing.Point(1043, 283);
            this.btnStasiun.Name = "btnStasiun";
            this.btnStasiun.Size = new System.Drawing.Size(168, 62);
            this.btnStasiun.TabIndex = 2;
            this.btnStasiun.Text = "Stasiun";
            this.btnStasiun.UseVisualStyleBackColor = false;
            this.btnStasiun.Click += new System.EventHandler(this.btnStasiun_Click);
            // 
            // btnPenumpang
            // 
            this.btnPenumpang.BackColor = System.Drawing.Color.Red;
            this.btnPenumpang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenumpang.Location = new System.Drawing.Point(1043, 410);
            this.btnPenumpang.Name = "btnPenumpang";
            this.btnPenumpang.Size = new System.Drawing.Size(168, 66);
            this.btnPenumpang.TabIndex = 3;
            this.btnPenumpang.Text = "Penumpang";
            this.btnPenumpang.UseVisualStyleBackColor = false;
            this.btnPenumpang.Click += new System.EventHandler(this.btnPenumpang_Click);
            // 
            // btnKelas
            // 
            this.btnKelas.BackColor = System.Drawing.Color.Red;
            this.btnKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelas.Location = new System.Drawing.Point(1043, 545);
            this.btnKelas.Name = "btnKelas";
            this.btnKelas.Size = new System.Drawing.Size(168, 65);
            this.btnKelas.TabIndex = 4;
            this.btnKelas.Text = "Kelas";
            this.btnKelas.UseVisualStyleBackColor = false;
            this.btnKelas.Click += new System.EventHandler(this.btnKelas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(33, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(957, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKelas);
            this.Controls.Add(this.btnPenumpang);
            this.Controls.Add(this.btnStasiun);
            this.Controls.Add(this.btnKereta);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKereta;
        private System.Windows.Forms.Button btnStasiun;
        private System.Windows.Forms.Button btnPenumpang;
        private System.Windows.Forms.Button btnKelas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

