using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool birinci_x, birinci_o,ilk;
        void temizle() {
            btn_sol_ust.Text = "";
            btn_sol_orta.Text = "";
            btn_sol_alt.Text = "";
            btn_sag_ust.Text = "";
            btn_sag_orta.Text = "";
            btn_sag_alt.Text = "";
            btn_orta_ust.Text = "";
            btn_orta_orta.Text = "";
            btn_orta_alt.Text = "";

            btn_sol_ust.ForeColor = Color.White;
            btn_sol_orta.ForeColor = Color.White;
            btn_sol_alt.ForeColor = Color.White;
            btn_sag_ust.ForeColor = Color.White;
            btn_sag_orta.ForeColor = Color.White;
            btn_sag_alt.ForeColor = Color.White;
            btn_orta_ust.ForeColor = Color.White;
            btn_orta_orta.ForeColor = Color.White;
            btn_orta_alt.ForeColor = Color.White;
        }
        void etkinlestir()
        {
            btn_sol_ust.Enabled = true;
            btn_sol_orta.Enabled = true;
            btn_sol_alt.Enabled = true;
            btn_sag_ust.Enabled = true;
            btn_sag_orta.Enabled = true;
            btn_sag_alt.Enabled = true;
            btn_orta_ust.Enabled = true;
            btn_orta_orta.Enabled = true;
            btn_orta_alt.Enabled = true;
        }
        void kapat()
        {
            btn_sol_ust.Enabled = false;
            btn_sol_orta.Enabled = false;
            btn_sol_alt.Enabled = false;
            btn_sag_ust.Enabled = false;
            btn_sag_orta.Enabled = false;
            btn_sag_alt.Enabled = false;
            btn_orta_ust.Enabled = false;
            btn_orta_orta.Enabled = false;
            btn_orta_alt.Enabled = false;
        }
        void yazdır(Button buton_adi)
        {
            buton_adi.Enabled = false;
            if (birinci_x)
            {
                buton_adi.ForeColor = Color.Red;
                buton_adi.Text = "X";                
                birinci_x = false;
                btn_o.Visible = true;
                btn_o.ForeColor = Color.Cyan;
                btn_x.Visible = false;
                birinci_o = true;
            }
            else if (birinci_o)
            {
                buton_adi.ForeColor = Color.Cyan;
                buton_adi.Text = "O";
                birinci_o = false;
                btn_x.Visible = true;
                btn_x.ForeColor = Color.Red;
                btn_o.Visible = false;
                birinci_x = true;
            }           
        }
        void x_kazandı()
        {
            MessageBox.Show("Oyun Bitti X Kazandı !", "XXX");
            kapat();
            DialogResult cevap = MessageBox.Show("Yeniden Oyna", "?", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                ilk = true;
                temizle();
                btn_x.Visible = true;
                btn_o.Visible = true;
            }
        }
        void o_kazandı()
        {
            MessageBox.Show("Oyun Bitti O Kazandı !", "OOO");
            kapat();
            DialogResult cevap = MessageBox.Show("Yeniden Oyna", "?", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                ilk = true;
                temizle();
                birinci_o = false;
                birinci_x = false;
                btn_x.Visible = true;
                btn_o.Visible = true;
            }

        }
        void kontrol_et()
        {
            if (btn_sag_ust.Text=="X" && btn_sag_orta.Text == "X" && btn_sag_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sag_ust.Text == "O" && btn_sag_orta.Text == "O" && btn_sag_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_ust.Text == "X" && btn_sol_orta.Text == "X" && btn_sol_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sol_ust.Text == "O" && btn_sol_orta.Text == "O" && btn_sol_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_orta_ust.Text == "X" && btn_orta_orta.Text == "X" && btn_orta_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_orta_ust.Text == "O" && btn_orta_orta.Text == "O" && btn_orta_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_ust.Text == "X" && btn_orta_ust.Text == "X" && btn_sag_ust.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sol_ust.Text == "O" && btn_orta_ust.Text == "O" && btn_sag_ust.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_alt.Text == "X" && btn_orta_alt.Text == "X" && btn_sag_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sol_alt.Text == "O" && btn_orta_alt.Text == "O" && btn_sag_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_orta.Text == "X" && btn_orta_orta.Text == "X" && btn_sag_orta.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sol_orta.Text == "O" && btn_orta_orta.Text == "O" && btn_sag_orta.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_ust.Text == "X" && btn_orta_orta.Text == "X" && btn_sag_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sol_ust.Text == "O" && btn_orta_orta.Text == "O" && btn_sag_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sag_ust.Text == "X" && btn_orta_orta.Text == "X" && btn_sol_alt.Text == "X")
            {
                x_kazandı();
            }
            if (btn_sag_ust.Text == "O" && btn_orta_orta.Text == "O" && btn_sol_alt.Text == "O")
            {
                o_kazandı();
            }
            if (btn_sol_ust.Text!="" && btn_orta_ust.Text != "" && btn_sag_ust.Text != "" && 
                btn_sol_orta.Text != "" && btn_orta_orta.Text != "" && btn_sag_orta.Text != "" &&
                btn_sol_alt.Text != "" && btn_orta_alt.Text != "" && btn_sag_alt.Text != "" )
            {
                MessageBox.Show("Oyun Bitti Kazanan Yok !", "YOK");
                kapat();
                DialogResult cevap = MessageBox.Show("Yeniden Oyna", "?", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    ilk = true;
                    temizle();
                    birinci_o = false;
                    birinci_x = false;
                    btn_x.Visible = true;
                    btn_o.Visible = true;
                }
            }
        }
        private void btn_x_Click(object sender, EventArgs e)
        {
            birinci_x = true;
            //btn_o.Enabled = false;
            btn_o.Visible = false;
            if (ilk)
            {
                temizle();
                etkinlestir();
                ilk = false;
            }
        }
        private void btn_o_Click(object sender, EventArgs e)
        {
            birinci_o = true;
            //btn_x.Enabled = false;
            btn_x.Visible = false;
            if (ilk)
            {
                temizle();
                etkinlestir();
                ilk = false;
            }
        }       
        private void btn_sol_ust_Click(object sender, EventArgs e)
        {
            yazdır(btn_sol_ust);
            kontrol_et();
        }
        private void btn_sol_orta_Click(object sender, EventArgs e)
        {
            yazdır(btn_sol_orta);
            kontrol_et();
        }
        private void btn_sol_alt_Click(object sender, EventArgs e)
        {
            yazdır(btn_sol_alt);
            kontrol_et();
        }
        private void btn_orta_ust_Click(object sender, EventArgs e)
        {
            yazdır(btn_orta_ust);
            kontrol_et();
        }
        private void btn_orta_orta_Click_1(object sender, EventArgs e)
        {
            yazdır(btn_orta_orta);
            kontrol_et();
        }
        private void btn_orta_alt_Click(object sender, EventArgs e)
        {
            yazdır(btn_orta_alt);
            kontrol_et();
        }
        private void btn_sag_ust_Click(object sender, EventArgs e)
        {
            yazdır(btn_sag_ust);
            kontrol_et();
        }

        private void btn_sag_orta_Click(object sender, EventArgs e)
        {
            yazdır(btn_sag_orta);
            kontrol_et();
        }

        private void btn_sag_alt_Click(object sender, EventArgs e)
        {
            yazdır(btn_sag_alt);
            kontrol_et();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinci_x = false;
            birinci_o = false;
            ilk = true;
        }
    }
}
