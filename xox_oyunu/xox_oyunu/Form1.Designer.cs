namespace xox_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_sag_ust = new System.Windows.Forms.Button();
            this.btn_sol_ust = new System.Windows.Forms.Button();
            this.btn_orta_ust = new System.Windows.Forms.Button();
            this.btn_sol_orta = new System.Windows.Forms.Button();
            this.btn_orta_orta = new System.Windows.Forms.Button();
            this.btn_sag_orta = new System.Windows.Forms.Button();
            this.btn_sol_alt = new System.Windows.Forms.Button();
            this.btn_orta_alt = new System.Windows.Forms.Button();
            this.btn_sag_alt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_o
            // 
            this.btn_o.BackColor = System.Drawing.Color.White;
            this.btn_o.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_o.ForeColor = System.Drawing.Color.Cyan;
            this.btn_o.Location = new System.Drawing.Point(243, 27);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(37, 35);
            this.btn_o.TabIndex = 1;
            this.btn_o.Text = "O";
            this.btn_o.UseVisualStyleBackColor = false;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.White;
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_x.ForeColor = System.Drawing.Color.Red;
            this.btn_x.Location = new System.Drawing.Point(153, 27);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(39, 37);
            this.btn_x.TabIndex = 11;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // btn_sag_ust
            // 
            this.btn_sag_ust.BackColor = System.Drawing.Color.White;
            this.btn_sag_ust.Enabled = false;
            this.btn_sag_ust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sag_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sag_ust.ForeColor = System.Drawing.Color.Red;
            this.btn_sag_ust.Location = new System.Drawing.Point(241, 115);
            this.btn_sag_ust.Name = "btn_sag_ust";
            this.btn_sag_ust.Size = new System.Drawing.Size(39, 37);
            this.btn_sag_ust.TabIndex = 12;
            this.btn_sag_ust.Text = "X";
            this.btn_sag_ust.UseVisualStyleBackColor = false;
            this.btn_sag_ust.Click += new System.EventHandler(this.btn_sag_ust_Click);
            // 
            // btn_sol_ust
            // 
            this.btn_sol_ust.BackColor = System.Drawing.Color.White;
            this.btn_sol_ust.Enabled = false;
            this.btn_sol_ust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sol_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sol_ust.ForeColor = System.Drawing.Color.Red;
            this.btn_sol_ust.Location = new System.Drawing.Point(153, 115);
            this.btn_sol_ust.Name = "btn_sol_ust";
            this.btn_sol_ust.Size = new System.Drawing.Size(39, 37);
            this.btn_sol_ust.TabIndex = 14;
            this.btn_sol_ust.Text = "X";
            this.btn_sol_ust.UseVisualStyleBackColor = false;
            this.btn_sol_ust.Click += new System.EventHandler(this.btn_sol_ust_Click);
            // 
            // btn_orta_ust
            // 
            this.btn_orta_ust.BackColor = System.Drawing.Color.White;
            this.btn_orta_ust.Enabled = false;
            this.btn_orta_ust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orta_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_orta_ust.ForeColor = System.Drawing.Color.Cyan;
            this.btn_orta_ust.Location = new System.Drawing.Point(198, 115);
            this.btn_orta_ust.Name = "btn_orta_ust";
            this.btn_orta_ust.Size = new System.Drawing.Size(37, 35);
            this.btn_orta_ust.TabIndex = 13;
            this.btn_orta_ust.Text = "O";
            this.btn_orta_ust.UseVisualStyleBackColor = false;
            this.btn_orta_ust.Click += new System.EventHandler(this.btn_orta_ust_Click);
            // 
            // btn_sol_orta
            // 
            this.btn_sol_orta.BackColor = System.Drawing.Color.White;
            this.btn_sol_orta.Enabled = false;
            this.btn_sol_orta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sol_orta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sol_orta.ForeColor = System.Drawing.Color.Red;
            this.btn_sol_orta.Location = new System.Drawing.Point(153, 158);
            this.btn_sol_orta.Name = "btn_sol_orta";
            this.btn_sol_orta.Size = new System.Drawing.Size(39, 37);
            this.btn_sol_orta.TabIndex = 17;
            this.btn_sol_orta.Text = "X";
            this.btn_sol_orta.UseVisualStyleBackColor = false;
            this.btn_sol_orta.Click += new System.EventHandler(this.btn_sol_orta_Click);
            // 
            // btn_orta_orta
            // 
            this.btn_orta_orta.BackColor = System.Drawing.Color.White;
            this.btn_orta_orta.Enabled = false;
            this.btn_orta_orta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orta_orta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_orta_orta.ForeColor = System.Drawing.Color.Cyan;
            this.btn_orta_orta.Location = new System.Drawing.Point(198, 158);
            this.btn_orta_orta.Name = "btn_orta_orta";
            this.btn_orta_orta.Size = new System.Drawing.Size(37, 35);
            this.btn_orta_orta.TabIndex = 16;
            this.btn_orta_orta.Text = "O";
            this.btn_orta_orta.UseVisualStyleBackColor = false;
            this.btn_orta_orta.Click += new System.EventHandler(this.btn_orta_orta_Click_1);
            // 
            // btn_sag_orta
            // 
            this.btn_sag_orta.BackColor = System.Drawing.Color.White;
            this.btn_sag_orta.Enabled = false;
            this.btn_sag_orta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sag_orta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sag_orta.ForeColor = System.Drawing.Color.Red;
            this.btn_sag_orta.Location = new System.Drawing.Point(241, 158);
            this.btn_sag_orta.Name = "btn_sag_orta";
            this.btn_sag_orta.Size = new System.Drawing.Size(39, 37);
            this.btn_sag_orta.TabIndex = 15;
            this.btn_sag_orta.Text = "X";
            this.btn_sag_orta.UseVisualStyleBackColor = false;
            this.btn_sag_orta.Click += new System.EventHandler(this.btn_sag_orta_Click);
            // 
            // btn_sol_alt
            // 
            this.btn_sol_alt.BackColor = System.Drawing.Color.White;
            this.btn_sol_alt.Enabled = false;
            this.btn_sol_alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sol_alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sol_alt.ForeColor = System.Drawing.Color.Red;
            this.btn_sol_alt.Location = new System.Drawing.Point(153, 201);
            this.btn_sol_alt.Name = "btn_sol_alt";
            this.btn_sol_alt.Size = new System.Drawing.Size(39, 37);
            this.btn_sol_alt.TabIndex = 20;
            this.btn_sol_alt.Text = "X";
            this.btn_sol_alt.UseVisualStyleBackColor = false;
            this.btn_sol_alt.Click += new System.EventHandler(this.btn_sol_alt_Click);
            // 
            // btn_orta_alt
            // 
            this.btn_orta_alt.BackColor = System.Drawing.Color.White;
            this.btn_orta_alt.Enabled = false;
            this.btn_orta_alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orta_alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_orta_alt.ForeColor = System.Drawing.Color.Cyan;
            this.btn_orta_alt.Location = new System.Drawing.Point(198, 201);
            this.btn_orta_alt.Name = "btn_orta_alt";
            this.btn_orta_alt.Size = new System.Drawing.Size(37, 35);
            this.btn_orta_alt.TabIndex = 19;
            this.btn_orta_alt.Text = "O";
            this.btn_orta_alt.UseVisualStyleBackColor = false;
            this.btn_orta_alt.Click += new System.EventHandler(this.btn_orta_alt_Click);
            // 
            // btn_sag_alt
            // 
            this.btn_sag_alt.BackColor = System.Drawing.Color.White;
            this.btn_sag_alt.Enabled = false;
            this.btn_sag_alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sag_alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sag_alt.ForeColor = System.Drawing.Color.Red;
            this.btn_sag_alt.Location = new System.Drawing.Point(241, 201);
            this.btn_sag_alt.Name = "btn_sag_alt";
            this.btn_sag_alt.Size = new System.Drawing.Size(39, 37);
            this.btn_sag_alt.TabIndex = 18;
            this.btn_sag_alt.Text = "X";
            this.btn_sag_alt.UseVisualStyleBackColor = false;
            this.btn_sag_alt.Click += new System.EventHandler(this.btn_sag_alt_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(458, 306);
            this.Controls.Add(this.btn_sol_alt);
            this.Controls.Add(this.btn_orta_alt);
            this.Controls.Add(this.btn_sag_alt);
            this.Controls.Add(this.btn_sol_orta);
            this.Controls.Add(this.btn_orta_orta);
            this.Controls.Add(this.btn_sag_orta);
            this.Controls.Add(this.btn_sol_ust);
            this.Controls.Add(this.btn_orta_ust);
            this.Controls.Add(this.btn_sag_ust);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_o);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_sag_ust;
        private System.Windows.Forms.Button btn_sol_ust;
        private System.Windows.Forms.Button btn_orta_ust;
        private System.Windows.Forms.Button btn_sol_orta;
        private System.Windows.Forms.Button btn_orta_orta;
        private System.Windows.Forms.Button btn_sag_orta;
        private System.Windows.Forms.Button btn_sol_alt;
        private System.Windows.Forms.Button btn_orta_alt;
        private System.Windows.Forms.Button btn_sag_alt;
    }
}

