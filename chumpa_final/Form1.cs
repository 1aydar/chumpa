using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;


namespace chumpa_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false; // костыль :(

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void команднаяСтрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void дефрагментацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("dfrgui.exe");
        }

        private void directXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("dxdiag");
        }

        private void очисткаДискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr");
        }

        private void редакторРеестраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("regedit");
        }

        private void rDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc");
        }

        private void диспетчерУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void журналСобытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.msc");
        }

        private void службыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void управлениеДискамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");
        }

        private void настройкаСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("msconfig");
        }

        private void восстановлениеСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rstrui");
        }

        private void клавиатураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("osk");
        }

        private void bluetoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("fsquirt");
        }

        private void громкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("sndvol");
        }

        private void панельУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Сделано!");
            label3.Visible = true;
            label4.Visible = true;
            checkBox1.Visible = false;
            String host = System.Net.Dns.GetHostName(); // Получение имени машины. Взято с http://www.cyberforum.ru/csharp-net/thread27170.html
            label3.Text = host.ToString();
            string ip_external = new WebClient().DownloadString("http://icanhazip.com/"); // Получение внешнего IP, взято с http://www.cyberforum.ru/csharp-beginners/thread1109904.html
            label4.Text = ip_external.ToString();
}

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вадим (0x000001), e-mail: user.230392@gmail.com");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chump-a, финальная версия, оболочка для системных и сетевых утилит Windows.");
        }

        private void whoisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
                string URL = textBox1.Text;
                string strCmdText = "/c ping " + URL; //Взято отсюда http://stackoverflow.com/questions/16617695/c-sharp-string-textbox-text-in-a-command-line
                System.Diagnostics.Process.Start("CMD", strCmdText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;

            if (box.TextLength > 0)         // пижжено отсюда 
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Адрес в глобальной сети.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Имя ПК.");
        }

        private void netshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URL = textBox1.Text;
            string strCmdText = "/c netsh " + URL; //Взято отсюда http://stackoverflow.com/questions/16617695/c-sharp-string-textbox-text-in-a-command-line
            System.Diagnostics.Process.Start("CMD", strCmdText);
        }

        private void сепарированныйПроводникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer /separate");
        }
    }
}
