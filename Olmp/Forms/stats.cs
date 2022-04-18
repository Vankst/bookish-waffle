using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olmp.Forms;

namespace Olmp.Forms
{
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }

        public static string email;
        private void stats_Load(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.statsApp(email, chrt);
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.SignIN = true;
            Main.email = email;
            main.Show();
            this.Close();
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            Account.email = email;
            account.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.SignIN = false;
            Main.email = string.Empty;
            main.Show();
            this.Close();
        }
    }
}
