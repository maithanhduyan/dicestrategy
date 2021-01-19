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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        readonly SessionInfo Session;
        readonly Currencies Currency;

        public Withdraw(SessionInfo session, Currencies currency)
            : this()
        {
            Session = session;
            Currency = currency;
        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                Session.PropertyChanged += Session_PropertyChanged;
                Session_PropertyChanged(Session, null);

                textBox_Address.Text = Session.EmergencyAddress;
                textBox_Amount.Text = Session[Currency].Balance.ToString();
            }
        }
        void Session_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                if (e == null || e.PropertyName == "Balance")
                    label_Balance.Text = Session[Currency].Balance.ToString() + " " + Currency.ToString();
            }));
        }
        private void Withdraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session != null)
                Session.PropertyChanged -= Session_PropertyChanged;
        }
        void DisplayError(WithdrawResponse response)
        {
            if (response.WithdrawalTooSmall)
                MessageBox.Show("Amount is too small for withdrawal (0.0001 BTC / 1 Doge / 0.001 LTC / 0.001 ETH is taken by the transaction fee)");
            else if (response.RateLimited)
                MessageBox.Show("Actions are being performed too quickly, please slow down");
            else if (response.InsufficientFunds)
                MessageBox.Show("You have insufficient funds for the withdrawal");
            else if (response.ErrorMessage != null)
                MessageBox.Show("Error: " + response.ErrorMessage);
            else
                MessageBox.Show("An error has occurred requesting the withdrawal");
        }
        void HandleResponse(WithdrawResponse response)
        {
            if (response.Success)
            {
                if (response.WithdrawalPending > 0)
                    MessageBox.Show(response.WithdrawalPending.ToString() + " " + Currency.ToString() + " is now pending for withdrawal");
                Close();
                return;
            }
            Enabled = true;
            DisplayError(response);
        }
        void ValidateAddress()
        {
            textBox_Address.Text = textBox_Address.Text.Trim();
            if (string.IsNullOrEmpty(textBox_Address.Text))
            {
                MessageBox.Show("Withdrawal address cannot be blank");
                return;
            }
        }
        private async void button_WithdrawAll_Click(object sender, EventArgs e)
        {
            ValidateAddress();
            Enabled = false;
            HandleResponse(await DiceWebAPI.WithdrawAllAsync(Session, textBox_Address.Text, Currency));
        }
        private async void button_Withdraw_Click(object sender, EventArgs e)
        {
            ValidateAddress();
            textBox_Amount.Text = textBox_Amount.Text.Trim();
            decimal amount;
            if (!decimal.TryParse(textBox_Amount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Invalid withdrawal amount");
                return;
            }
            if (Currency == Currencies.BTC)
                if (amount <= 0.0001M)
                {
                    MessageBox.Show("Withdrawal amount is less than Bitcoin's transaction fee (0.0001 BTC)");
                    return;
                }
            if (Currency == Currencies.Doge)
                if (amount <= 1M)
                {
                    MessageBox.Show("Withdrawal amount is less than Dogecoin's transaction fee (1 Doge)");
                    return;
                }
            if (Currency == Currencies.LTC)
                if (amount <= 0.001M)
                {
                    MessageBox.Show("Withdrawal amount is less than Litecoin's transaction fee (0.001 LTC)");
                    return;
                }
            if (Currency == Currencies.ETH)
                if (amount <= 0.001M)
                {
                    MessageBox.Show("Withdrawal amount is less than Ethereum's transaction fee (0.001 ETH)");
                    return;
                }
            Enabled = false;
            HandleResponse(await DiceWebAPI.WithdrawAsync(Session, amount, textBox_Address.Text, Currency));
        }
    }
}
