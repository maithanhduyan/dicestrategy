using Dice.Client.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice.Sample.Bot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            comboBox_site.SelectedIndex = 0;
        }
        bool ExitOnClose = true;
        string LastAccountCookie;

        static string LoadLastAccountCookie()
        {
            string fn = Path.Combine(Settings.DataFileDirectory, "LastAccountCookie");
            if (!File.Exists(fn))
                return null;
            return File.ReadAllText(fn);
        }
        static void SaveLastAccountCookie(string accountCookie)
        {
            Directory.CreateDirectory(Settings.DataFileDirectory);
            File.WriteAllText(Path.Combine(Settings.DataFileDirectory, "LastAccountCookie"), accountCookie);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LastAccountCookie = LoadLastAccountCookie();
        }
        void SetupButtons()
        {
            button_Continue.Enabled =
                comboBox_currencies.SelectedIndex >= 0 &&
                !string.IsNullOrWhiteSpace(LastAccountCookie);
            button_Login.Enabled =
                button_CreateAccount.Enabled =
                comboBox_currencies.SelectedIndex >= 0;
        }
        void DisplayError(BeginSessionResponse response)
        {
            if (response.InvalidApiKey)
                MessageBox.Show("The API key for this program is not valid");
            else if (response.LoginRequired)
                MessageBox.Show("This account is protected by a username and password. Please login instead.");
            else if (response.RateLimited)
                MessageBox.Show("Actions are being performed too quickly. Please slow down.");
            else if (response.WrongUsernameOrPassword)
                MessageBox.Show("Wrong username or password");
            else if (response.ErrorMessage != null)
                MessageBox.Show("Error: " + response.ErrorMessage);
            else
                MessageBox.Show("An error occurred");
        }

        Currencies GetCurrency()
        {
            switch (comboBox_currencies.SelectedIndex)
            {
                case 0:
                    return Currencies.BTC;
                case 1:
                    return Currencies.Doge;
                case 2:
                    return Currencies.LTC;
                case 3:
                    return Currencies.ETH;
            }
            return Currencies.None;
        }

        void StartSession(SessionInfo session)
        {
            Currencies c = GetCurrency();
            if (c != Currencies.None)
                new Main(session, c).Show();
            ExitOnClose = false;
            Close();
        }

        private async void button_CreateAccount_Click(object sender, EventArgs e)
        {
            if (button_Continue.Enabled)
                if (MessageBox.Show(this, "Are you sure? If you create a new account, you will no longer be able to access the old one! To keep access to the old account, choose 'Continue Last Session' and set up a username and password! Continue with creating a new account?", "WARNING", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                    return;
            Enabled = false;
            var result = await DiceWebAPI.BeginSessionAsync(Settings.ApiKey);
            if (result.Success)
            {
                // Save the account cookie so that we can access this account again
                SaveLastAccountCookie(result.Session.AccountCookie);

                StartSession(result.Session);
            }
            else
            {
                Enabled = true;
                DisplayError(result);
            }
        }

        private async void button_Continue_Click(object sender, EventArgs e)
        {
            Enabled = false;
            var result = await DiceWebAPI.BeginSessionAsync(Settings.ApiKey, LastAccountCookie);
            if (result.Success)
            {
                StartSession(result.Session);
            }
            else
            {
                Enabled = true;
                DisplayError(result);
            }
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            textBox_Username.Text = textBox_Username.Text.Trim();
            if (string.IsNullOrEmpty(textBox_Username.Text))
            {
                MessageBox.Show("Username cannot be blank");
                return;
            }
            int totp;
            if (!int.TryParse(textBox_totp.Text, out totp))
                totp = -1;
            Enabled = false;
            var result = await DiceWebAPI.BeginSessionAsync(Settings.ApiKey, textBox_Username.Text, textBox_Password.Text, totp);
            if (result.Success)
            {
                StartSession(result.Session);
            }
            else
            {
                Enabled = true;
                DisplayError(result);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitOnClose)
                Application.Exit();
        }

        private void comboBox_currencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupButtons();
        }

        private void comboBox_site_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_site.Text))
                if (!DiceWebAPI.WebUri.Host.Contains("localhost"))
                    DiceWebAPI.WebUri = new Uri(DiceWebAPI.WebUri.ToString().Replace(DiceWebAPI.WebUri.Host, "www." + comboBox_site.Text.Split(' ')[0] + ".com"));
        }
    }
}
