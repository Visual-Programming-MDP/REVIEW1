using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REVIEW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void txtNpm_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNama.Focus();
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSoftSkill.Focus();
            }
        }

        private void txtSoftSkill_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtKuis.Focus();
            }
        }

        private void txtKuis_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTugas.Focus();
            }
        }

        private void txtTugas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtUts.Focus();
            }
        }

        private void txtUts_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            //Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtUas.Focus();
            }
        }

        private void txtUas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox hanya bisa diisi dengan angka
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                //Hitung Total Nilai
                double softskill = Double.Parse(txtSoftSkill.Text);
                double kuis = Double.Parse(txtKuis.Text);
                double tugas = Double.Parse(txtTugas.Text);
                double uts = Double.Parse(txtUts.Text);
                double uas = Double.Parse(txtUas.Text);

                double totalnilai = (0.1 * softskill) + (0.1 * kuis) +
                    (0.2 * tugas) + (0.3 * uts) + (0.3 * uas);
                txtTotalNilai.Text = totalnilai.ToString();

                //Hitung Grade
                String grade = "";
                if (totalnilai >= 80 && totalnilai <= 100)
                {
                    grade = "A";
                }
                else if (totalnilai >= 76 && totalnilai < 80)
                {
                    grade = "A-";
                }
                else if (totalnilai >= 72 && totalnilai < 76)
                {
                    grade = "B+";
                }
                else if (totalnilai >= 68 && totalnilai < 72)
                {
                    grade = "B";
                }
                else if (totalnilai >= 64 && totalnilai < 68)
                {
                    grade = "B-";
                }
                else if (totalnilai >= 60 && totalnilai < 64)
                {
                    grade = "C+";
                }
                else if (totalnilai >= 56 && totalnilai < 60)
                {
                    grade = "C";
                }
                else if (totalnilai >= 46 && totalnilai < 56)
                {
                    grade = "D";
                }
                else if (totalnilai >= 0 && totalnilai < 46)
                {
                    grade = "E";
                }
                txtGrade.Text = grade;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Mengisi data ke Listview
            ListViewItem data = new ListViewItem(txtNpm.Text);
            data.SubItems.Add(txtNama.Text);
            data.SubItems.Add(txtTotalNilai.Text);
            data.SubItems.Add(txtGrade.Text);

            listView1.Items.Add(data);
            bersihLayar();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bersihLayar();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void bersihLayar()
        {
            txtNpm.Clear();
            txtNama.Clear();
            txtSoftSkill.Clear();
            txtKuis.Clear();
            txtTugas.Clear();
            txtUts.Clear();
            txtUas.Clear();
            txtTotalNilai.Clear();
            txtGrade.Clear();
            txtNpm.Focus();
        }
    }
}
