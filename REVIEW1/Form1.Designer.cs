
namespace REVIEW1
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtTotalNilai = new System.Windows.Forms.TextBox();
            this.txtUas = new System.Windows.Forms.TextBox();
            this.txtUts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTugas = new System.Windows.Forms.TextBox();
            this.txtKuis = new System.Windows.Forms.TextBox();
            this.txtSoftSkill = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtNpm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Grade";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NPM";
            this.columnHeader1.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 430);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(948, 125);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Nilai";
            this.columnHeader3.Width = 150;
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(634, 342);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.Red;
            this.guna2Button3.Size = new System.Drawing.Size(128, 45);
            this.guna2Button3.TabIndex = 45;
            this.guna2Button3.Text = "KELUAR";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtGrade.Location = new System.Drawing.Point(679, 221);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(178, 31);
            this.txtGrade.TabIndex = 44;
            // 
            // txtTotalNilai
            // 
            this.txtTotalNilai.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtTotalNilai.Location = new System.Drawing.Point(679, 184);
            this.txtTotalNilai.Name = "txtTotalNilai";
            this.txtTotalNilai.Size = new System.Drawing.Size(178, 31);
            this.txtTotalNilai.TabIndex = 43;
            // 
            // txtUas
            // 
            this.txtUas.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtUas.Location = new System.Drawing.Point(679, 147);
            this.txtUas.Name = "txtUas";
            this.txtUas.Size = new System.Drawing.Size(178, 31);
            this.txtUas.TabIndex = 42;
            this.txtUas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUas_KeyPress);
            // 
            // txtUts
            // 
            this.txtUts.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtUts.Location = new System.Drawing.Point(679, 110);
            this.txtUts.Name = "txtUts";
            this.txtUts.Size = new System.Drawing.Size(178, 31);
            this.txtUts.TabIndex = 41;
            this.txtUts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUts_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "GRADE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Total Nilai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Nilai UAS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Nilai UTS";
            // 
            // txtTugas
            // 
            this.txtTugas.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtTugas.Location = new System.Drawing.Point(308, 258);
            this.txtTugas.Name = "txtTugas";
            this.txtTugas.Size = new System.Drawing.Size(178, 31);
            this.txtTugas.TabIndex = 36;
            this.txtTugas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTugas_KeyPress);
            // 
            // txtKuis
            // 
            this.txtKuis.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtKuis.Location = new System.Drawing.Point(308, 221);
            this.txtKuis.Name = "txtKuis";
            this.txtKuis.Size = new System.Drawing.Size(178, 31);
            this.txtKuis.TabIndex = 35;
            this.txtKuis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKuis_KeyPress);
            // 
            // txtSoftSkill
            // 
            this.txtSoftSkill.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtSoftSkill.Location = new System.Drawing.Point(308, 184);
            this.txtSoftSkill.Name = "txtSoftSkill";
            this.txtSoftSkill.Size = new System.Drawing.Size(178, 31);
            this.txtSoftSkill.TabIndex = 34;
            this.txtSoftSkill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoftSkill_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtNama.Location = new System.Drawing.Point(308, 147);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(178, 31);
            this.txtNama.TabIndex = 33;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(436, 342);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Red;
            this.guna2Button2.Size = new System.Drawing.Size(128, 45);
            this.guna2Button2.TabIndex = 32;
            this.guna2Button2.Text = "HAPUS";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(237, 342);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Red;
            this.guna2Button1.Size = new System.Drawing.Size(128, 45);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "SIMPAN";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtNpm
            // 
            this.txtNpm.Font = new System.Drawing.Font("Futura Md BT", 12F);
            this.txtNpm.Location = new System.Drawing.Point(308, 110);
            this.txtNpm.Name = "txtNpm";
            this.txtNpm.Size = new System.Drawing.Size(178, 31);
            this.txtNpm.TabIndex = 30;
            this.txtNpm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNpm_KeyPress);
            this.txtNpm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNpm_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nilai Tugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nilai Kuis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nilai Softskill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "NPM";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 55);
            this.label1.TabIndex = 24;
            this.label1.Text = "APLIKASI PERHITUNGAN NILAI AKHIR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 560);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtTotalNilai);
            this.Controls.Add(this.txtUas);
            this.Controls.Add(this.txtUts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTugas);
            this.Controls.Add(this.txtKuis);
            this.Controls.Add(this.txtSoftSkill);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtNpm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtTotalNilai;
        private System.Windows.Forms.TextBox txtUas;
        private System.Windows.Forms.TextBox txtUts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTugas;
        private System.Windows.Forms.TextBox txtKuis;
        private System.Windows.Forms.TextBox txtSoftSkill;
        private System.Windows.Forms.TextBox txtNama;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox txtNpm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

