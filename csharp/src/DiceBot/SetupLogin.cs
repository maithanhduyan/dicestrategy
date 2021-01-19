using Dice.Client.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice.Sample.Bot
{
    public partial class SetupLogin : Form
    {
        public SetupLogin()
        {
            InitializeComponent();
        }

        readonly SessionInfo Session;

        public SetupLogin(SessionInfo session)
            :this()
        {
            Session = session;
            if (!string.IsNullOrWhiteSpace(session.Username))
                throw new ArgumentOutOfRangeException("This account already has a username");
        }

        private async void button_CreateUsername_Click(object sender, EventArgs e)
        {
            textBox_Username.Text = textBox_Username.Text.Trim();
            if (string.IsNullOrEmpty(textBox_Username.Text))
            {
                MessageBox.Show("Username cannot be blank");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Password cannot be blank");
                return;
            }
            if (textBox_Password.Text != textBox_Password2.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            Enabled = false;
            var result = await DiceWebAPI.CreateUserAsync(Session, textBox_Username.Text, textBox_Password.Text);
            if (result.Success)
            {
                Close();
                return;
            }
            if (result.UsernameAlreadyTaken)
                MessageBox.Show("That username is already taken, please try another");
            else if (result.AccountAlreadyHasUser)
                MessageBox.Show("This account already has a username: " + Session.Username);
            else if (result.RateLimited)
                MessageBox.Show("You are performing actions too quickly, please slow down");
            else if (result.ErrorMessage != null)
                MessageBox.Show("Error: " + result.ErrorMessage);
            else
                MessageBox.Show("An error has occurred, please try again.");
        }
    }
}
