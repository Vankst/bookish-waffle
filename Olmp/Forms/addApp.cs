using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp.Forms
{
    public partial class addApp : Form
    {
        public addApp()
        {
            InitializeComponent();
        }
        public static string email;

        private void btn_acc_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            Account.email = email;
            account.Show();
            this.Close();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = email;
            Main.SignIN = true;
            main.Show();
            this.Close();
        }

        private void addApp_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            if(tb_name.Text == String.Empty)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Введите название";
            }
            else
            {
                Random rnd = new Random();
                string ucode = String.Empty;
                int r;
                char[] ch4r = "abcdefghijklmnopqrstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
                for (int i = 0; i < 32; i++)
                {
                    r = rnd.Next(ch4r.Length);
                    ucode += ch4r[r];
                }
                DB dB = new DB();
                dB.CheckUCode(ucode, out bool check);
                while (check)
                {
                    for (int i = 0; i < 32; i++)
                    {
                        r = rnd.Next(ch4r.Length);
                        ucode += ch4r[r];
                    }
                    dB.CheckUCode(ucode, out bool check2);
                    check = check2;
                }
                dB.addApp(tb_name.Text, ucode, email);


            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Main.email = string.Empty;
            Main.SignIN = false;
            main.Show();
            this.Close();
        }
    }
}
