using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();//rastgele bir sayı oluşuyor

        private void button1_Click(object sender, EventArgs e)
        {
            switch (r.Next(3))//rastgele birisini yazdıırıyor
            {
                case 0:
                    label4.Text = "KAĞIT";
                    break;
                case 1:
                    label4.Text = "MAKAS";
                    break;
                case 2:
                    label4.Text = "TAŞ";
                    break;
            }
            if (radioButton1.Checked==true && label4.Text == "MAKAS")//klasik taş kağıt makas kuralları
            {
                MessageBox.Show("TAŞ MAKASI KIRAR","KAZANDIN");
            }
            else if (radioButton2.Checked == true && label4.Text == "TAŞ")
            {             
                MessageBox.Show("KAĞIT TAŞI SARAR", "KAZANDIN");
            }
            else if (radioButton3.Checked == true && label4.Text == "KAĞIT")
            {
                MessageBox.Show("MAKAS KAĞIDI KESER", "KAZANDIN");
            }
            else if (radioButton1.Checked == true && label4.Text == "KAĞIT")
            {
                MessageBox.Show("KAĞIT TAŞI SARAR", "KAYBETTİN");
            }
            else if (radioButton2.Checked == true && label4.Text == "MAKAS")
            {
                MessageBox.Show("MAKAS KAĞIDI KESER", "KAYBETTİN");
            }
            else if (radioButton3.Checked == true && label4.Text == "TAŞ")
            {
                MessageBox.Show("TAŞ MAKASI KIRAR", "KAYBETTİN");
            }
            else
            {
                MessageBox.Show("BERABERE");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
