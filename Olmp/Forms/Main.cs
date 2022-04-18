using Olmp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olmp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static bool SignIN;
        public static string email;
        private void Main_Load(object sender, EventArgs e)
        {
            if (SignIN)
            {
                lbl_amount.Visible = true;
               // DB dB = new DB();
                //dB.amountApp(email, out int amount);
                lbl_amount.Text = "Количество приложений " + 0;
                btn_signin.Visible = false;
                btn_signup.Visible = false;
                btn_PersonalArea.Visible = true;
                btn_exit.Visible = true;
            }
            else
                lbl_amount.Visible = false;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btn_PersonalArea_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            SignIN = false;
            email = string.Empty;
            lbl_amount.Visible=false;
            lbl_amount.Visible=false;
            btn_signin.Visible = true;
            btn_signup.Visible = true;
            btn_PersonalArea.Visible = false;
            btn_exit.Visible = false;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {

        }
    }
}
