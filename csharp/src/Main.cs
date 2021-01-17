using Dice.Client.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice.Sample.Bot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        readonly SessionInfo Session;
        readonly Currencies Currency;
        readonly System.Windows.Forms.Timer BalanceTimer = new System.Windows.Forms.Timer() { Interval = 1000 * 60 };
        bool BettingInProgress;
        readonly object LogFileLock = new object();
        StreamWriter LogFile;        

        string LogFileName { get { return Path.Combine(Settings.DataFileDirectory, Session.AccountId.ToString() + " Bets.txt"); } }

        public Main(SessionInfo session, Currencies currency)
            : this()
        {
            Session = session;
            Currency = currency;
        }
        void Main_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                Session.PropertyChanged += Session_PropertyChanged;
                Session[Currency].PropertyChanged += Currency_PropertyChanged;
                Session_PropertyChanged(Session, null);
                Currency_PropertyChanged(Session[Currency], null);
                BalanceTimer.Tick += BalanceTimer_Tick;
                BalanceTimer.Start();
            }
            label_cur1.Text =
                label_cur2.Text =
                label_cur3.Text =
                Currency.ToString();
            SetupBoxes();
            button_ExportToCSV.Visible = File.Exists(LogFileName);
        }

        async void BalanceTimer_Tick(object sender, EventArgs e)
        {
            if (BettingInProgress)
                return;
            await DiceWebAPI.GetBalanceAsync(Session, Currency);
        }
        void Currency_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                if (e == null || e.PropertyName == "Balance")
                    label_Balance.Text = Session[Currency].Balance.ToString() + " "+Currency.ToString();
                if (e == null ||
                    e.PropertyName == "BetCount" ||
                    e.PropertyName == "BetPayIn" ||
                    e.PropertyName == "BetPayOut" ||
                    e.PropertyName == "BetWinCount")
                {
                    label_BetCount.Text = Session[Currency].BetCount.ToString();
                    label_BetProfits.Text = (Session[Currency].BetPayIn + Session[Currency].BetPayOut).ToString() + " " + Currency.ToString();
                    label_BetWins.Text = Session[Currency].BetWinCount.ToString();
                    label_BetWinsPercent.Text = Session[Currency].BetCount == 0 ? "---" : ((decimal)Session[Currency].BetWinCount * 100M / (decimal)Session[Currency].BetCount).ToString("0.0000") + " %";
                }
                if (e == null || e.PropertyName == "DepositAddress")
                    textBox_DepositAddress.Text = Session[Currency].DepositAddress ?? "";
            }));
        }
        void Session_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                if (e == null || e.PropertyName == "Username")
                {
                    button_SetupLogin.Visible = string.IsNullOrWhiteSpace(Session.Username);
                    label_Username.Visible = !button_SetupLogin.Visible;
                    label_Username.Text = Session.Username ?? "";
                }
                if (e == null || e.PropertyName == "Email")
                    textBox_Email.Text = Session.Email ?? "";
                if (e == null || e.PropertyName == "EmergencyAddress")
                    textBox_Emergency.Text = Session.EmergencyAddress ?? "";
                if (e == null || e.PropertyName == "AccountId")
                    label_AccountId.Text = Session.AccountId.ToString();
            }));
        }
        void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session != null)
                Session.PropertyChanged -= Session_PropertyChanged;
            BalanceTimer.Dispose();
            Application.Exit();
        }
        void button_SetupLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Session.Username))
                new SetupLogin(Session) { Owner = this }.ShowDialog();
            else
                button_SetupLogin.Hide();
        }
        async void textBox_Email_Leave(object sender, EventArgs e)
        {
            textBox_Email.Text = textBox_Email.Text.Trim();
            if (textBox_Email.Text == Session.Email)
                return;
            var result = await DiceWebAPI.UpdateEmailAsync(Session, textBox_Email.Text);
            if (result.Success)
            {
                await FlashControl(label_SavedEmail, TimeSpan.FromSeconds(5));
                return;
            }
            MessageBox.Show("Failed to update your email address");
            textBox_Email.Text = Session.Email;
        }
        async void textBox_Emergency_Leave(object sender, EventArgs e)
        {
            textBox_Emergency.Text = textBox_Emergency.Text.Trim();
            if (textBox_Emergency.Text == Session.EmergencyAddress)
                return;
            var result = await DiceWebAPI.UpdateEmergencyAddressAsync(Session, textBox_Emergency.Text);
            if (result.Success)
            {
                await FlashControl(label_SavedEmergencyAddress, TimeSpan.FromSeconds(5));
                return;
            }
            MessageBox.Show("Failed to update your emergency address");
            textBox_Emergency.Text = Session.EmergencyAddress;
        }
        async Task FlashControl(Control control, TimeSpan duration)
        {
            control.Show();
            await Task.Delay(duration);
            control.Hide();
        }
        void button_Withdraw_Click(object sender, EventArgs e)
        {
            new Withdraw(Session, Currency) { Owner = this }.ShowDialog();
        }
        void OptionChanged(object sender, EventArgs e)
        {
            SetupBoxes();
        }
        void SetupBoxes()
        {
            textBox_IncreaseOnWin.Enabled = !checkBox_ResetOnWin.Checked;
            textBox_IncreaseOnLoss.Enabled = !checkBox_ResetOnLoss.Checked;
            decimal d;
            bool show = decimal.TryParse(textBox_MaxBet.Text, out d) && d > 0;
            label_afterMaxBet.Visible =
                checkBox_StopOnLoseMax.Visible =
                checkBox_ResetOnLoseMax.Visible = show;
            button_StopStartBets.Enabled =
                BettingInProgress ||
                (decimal.TryParse(textBox_BaseBet.Text, out d) && d > 0);
        }
        void numericUpDown_GuessLow_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_GuessHigh.Minimum = numericUpDown_GuessLow.Value + 49999;
            numericUpDown_GuessHigh.Maximum = (numericUpDown_GuessLow.Value + 949999) > 999999 ? 999999 : (numericUpDown_GuessLow.Value + 949999);
            ShowGuessCalculations();
        }
        void numericUpDown_GuessHigh_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_GuessLow.Maximum = numericUpDown_GuessHigh.Value - 49999;
            numericUpDown_GuessLow.Minimum = (numericUpDown_GuessHigh.Value - 949999) < 0 ? 0 : (numericUpDown_GuessHigh.Value - 949999);
            ShowGuessCalculations();
        }
        void ShowGuessCalculations()
        {
            label_ChanceToWin.Text = (DiceWebAPI.CalculateChanceToWin((long)numericUpDown_GuessLow.Value, (long)numericUpDown_GuessHigh.Value) * 100M).ToString("0.0000").TrimEnd('0').TrimEnd('.')
                + "% Chance";
            label_PayoutMultiplier.Text = DiceWebAPI.CalculatePayoutMultiplier((long)numericUpDown_GuessLow.Value, (long)numericUpDown_GuessHigh.Value).ToString("0.0000").TrimEnd('0').TrimEnd('.')
                + "x";
        }

        void button_StopStartBets_Click(object sender, EventArgs e)
        {
            startBet();
        }

        void startBet() {
            if (BettingInProgress)
            {
                BettingInProgress = false;
                button_StopStartBets.Enabled = false;
                button_StopStartBets.Text = "Begin Betting";
            }
            else
            {
                textBox_BaseBet.Text = textBox_BaseBet.Text.Trim();
                textBox_BetCount.Text = textBox_BetCount.Text.Trim();
                textBox_IncreaseOnLoss.Text = textBox_IncreaseOnLoss.Text.Trim();
                textBox_IncreaseOnWin.Text = textBox_IncreaseOnWin.Text.Trim();
                textBox_MaxBet.Text = textBox_MaxBet.Text.Trim();
                textBox_StopMaxBalance.Text = textBox_StopMaxBalance.Text.Trim();

                int betCount;
                decimal stopMaxBalance;
                decimal baseBet;
                decimal maxBet;
                decimal increaseOnWin = 0;
                decimal increaseOnLoss = 0;
                bool resetOnWin = checkBox_ResetOnWin.Checked;
                bool resetOnLoss = checkBox_ResetOnLoss.Checked;
                bool resetOnMaxLoss = checkBox_ResetOnLoseMax.Checked;
                bool stopOnMaxLoss = checkBox_StopOnLoseMax.Checked;
                if (!resetOnWin)
                    if (string.IsNullOrWhiteSpace(textBox_IncreaseOnWin.Text))
                        increaseOnWin = 0;
                    else if (!decimal.TryParse(textBox_IncreaseOnWin.Text, out increaseOnWin) || increaseOnWin < 0)
                    {
                        MessageBox.Show("Increase by % after win must be a positive number or blank");
                        return;
                    }
                if (!resetOnLoss)
                    if (string.IsNullOrWhiteSpace(textBox_IncreaseOnLoss.Text))
                        increaseOnLoss = 0;
                    else if (!decimal.TryParse(textBox_IncreaseOnLoss.Text, out increaseOnLoss) || increaseOnLoss < 0)
                    {
                        MessageBox.Show("Increase by % after loss must be a positive number or blank");
                        return;
                    }
                increaseOnWin = decimal.Round(increaseOnWin, 6);
                increaseOnLoss = decimal.Round(increaseOnLoss, 6);
                if (string.IsNullOrWhiteSpace(textBox_BetCount.Text))
                    betCount = int.MaxValue;
                else if (!int.TryParse(textBox_BetCount.Text, out betCount) || betCount <= 0)
                {
                    MessageBox.Show("# Bets must be a positive number or blank");
                    return;
                }
                if (string.IsNullOrWhiteSpace(textBox_StopMaxBalance.Text))
                    stopMaxBalance = 0;
                else if (!decimal.TryParse(textBox_StopMaxBalance.Text, out stopMaxBalance) || stopMaxBalance <= 0)
                {
                    MessageBox.Show("Goal must be a positive number or blank");
                    return;
                }
                stopMaxBalance = decimal.Round(stopMaxBalance, 8);
                if (string.IsNullOrWhiteSpace(textBox_BaseBet.Text) ||
                    !decimal.TryParse(textBox_BaseBet.Text, out baseBet) ||
                    baseBet <= 0)
                {
                    MessageBox.Show("Base bet must be a positive number or blank");
                    return;
                }
                baseBet = decimal.Round(baseBet, 8);
                if (string.IsNullOrWhiteSpace(textBox_MaxBet.Text))
                    maxBet = 0;
                else if (!decimal.TryParse(textBox_MaxBet.Text, out maxBet) || maxBet < baseBet)
                {
                    MessageBox.Show("Max bet must be greater than or equal to the base bet, or blank");
                    return;
                }
                maxBet = decimal.Round(maxBet, 8);
                if (resetOnWin)
                    increaseOnWin = 0;
                if (resetOnLoss)
                    increaseOnLoss = 0;
                if (maxBet == 0)
                    stopOnMaxLoss = resetOnMaxLoss = false;

                BettingInProgress = true;
                button_StopStartBets.Text = "Stop Betting";
                panel_BetOptions.Enabled = panel_GuessOptions.Enabled = false;

                DoBets(
                    (long)numericUpDown_GuessLow.Value, (long)numericUpDown_GuessHigh.Value,
                    betCount, stopMaxBalance,
                    baseBet, maxBet,
                    resetOnWin, resetOnLoss,
                    increaseOnWin, increaseOnLoss,
                    resetOnMaxLoss, stopOnMaxLoss);
            }
        }
        async void DoBets(
            long guessLow, long guessHigh,
            int betCount, decimal stopMaxBalance,
            decimal baseBet, decimal maxBet,
            bool resetOnWin, bool resetOnLoss,
            decimal increaseOnWin, decimal increaseOnLoss,
            bool resetOnMaxLoss, bool stopOnMaxLoss)
        {
            if (baseBet > 0) baseBet = -baseBet;
            if (maxBet > 0) maxBet = -maxBet;
            increaseOnWin /= 100M;
            increaseOnLoss /= 100M;
            Random rnd = new Random();

            while (true)
            {
                if (!BettingInProgress || betCount <= 0)
                {
                    BettingInProgress = false;
                    BeginInvoke((Action)(() =>
                    {
                        panel_BetOptions.Enabled = panel_GuessOptions.Enabled = true;
                        SetupBoxes();
                        button_StopStartBets.Text = "Begin Betting";
                        if (stopMaxBalance > 0 && Session[Currency].Balance >= stopMaxBalance)
                            MessageBox.Show("Goal reached");
                        else if (betCount <= 0)
                            MessageBox.Show("Bets complete");
                    }));
                    return;
                }
                /*
                 *  Here, we use the automated bets system
                 *  
                 *  Note: Delays for bets are the same as on the website:
                 *      0 BTC = 3 second delay
                 *      Less than 0.0000001 = 2 second delay
                 *      Less than 0.000001 = 1 second delay
                 *      Less than 0.00001 = 0.5 second delay
                 *  (100 Automated bets of 0.00000001 BTC would only have a single 2 second delay, not 200 seconds!)
                 * 
                 */
                var settings = new AutomatedBetsSettings
                {
                    BasePayIn = baseBet,
                    GuessLow = guessLow,
                    GuessHigh = guessHigh,
                    MaxBets = betCount > Session.MaxBetBatchSize ? Session.MaxBetBatchSize : betCount,
                    ResetOnWin = resetOnWin,
                    ResetOnLose = resetOnLoss,
                    IncreaseOnWinPercent = increaseOnWin,
                    IncreaseOnLosePercent = increaseOnLoss,
                    MaxAllowedPayIn = maxBet,
                    ResetOnLoseMaxBet = resetOnMaxLoss,
                    StopOnLoseMaxBet = stopOnMaxLoss,
                    StopMaxBalance = stopMaxBalance,
                    ClientSeed = rnd.Next(),
                    Currency = Currency
                };
                var result = await DiceWebAPI.PlaceAutomatedBetsAsync(Session, settings);
                if (!result.Success || result.BetCount == 0)
                {
                    BettingInProgress = false;
                    BeginInvoke((Action)(() =>
                    {
                        if (result.InsufficientFunds)
                            MessageBox.Show("Insufficient funds to continue");
                        else if (!result.Success)
                            MessageBox.Show("Error placing bets");
                    }));
                    continue;
                }
                betCount -= result.BetCount;
                decimal tmpbal = result.StartingBalance;
                LogBets(string.Join(Environment.NewLine,
                    Enumerable.Range(0, result.BetCount)
                    .Select(x => new
                    {
                        id = result.BetIds[x],
                        endbal = tmpbal += result.PayIns[x] + result.PayOuts[x],
                        payin = result.PayIns[x],
                        payout = result.PayOuts[x],
                        secret = result.Secrets[x]
                    })
                    .Select(x => string.Join(",", x.id, x.endbal - (x.payin + x.payout), x.payin, guessLow, guessHigh, x.secret, x.payout, x.endbal))));

                if (stopMaxBalance > 0 && Session[Currency].Balance >= stopMaxBalance)
                {
                    BettingInProgress = false;
                    continue;
                }


                /*
                 * Here, we use the manual 1-at-a-time bet system.
                 * 
                 * The reason is that the maximum batch for automated bets is Session.MaxBetBatchSize (Currently 200).
                 * What if the last bet was a loss, and your settings indicated you want to double your bet after a
                 * loss? If you submit another automated bet batch, it would start at your base bet.
                 * 
                 * So the solution is to place manual bets until the next bet would be the base bet size, at which
                 * time we can continue with the automated bets.
                 * 
                 */
                decimal lastPayIn = result.PayIns.Last();
                bool lastWin = result.Secrets.Last() >= guessLow && result.Secrets.Last() <= guessHigh;
                while (betCount > 0 && BettingInProgress)
                {
                    if (lastWin)
                    {
                        if (resetOnWin)
                            break;
                        if (increaseOnWin == 0 && lastPayIn == baseBet)
                            break;
                        lastPayIn *= (1 + increaseOnWin);
                    }
                    else
                    {
                        if (resetOnLoss)
                            break;
                        if (increaseOnLoss == 0 && lastPayIn == baseBet)
                            break;
                        if (lastPayIn == maxBet)
                        {
                            if (stopOnMaxLoss)
                            {
                                BettingInProgress = false;
                                Console.WriteLine("Max Bet Reach.");
                                //Console.Beep();
                                
                                // x1 Run my strategy...
                                runStrategyAsync(Session,guessLow, guessHigh, rnd.Next(), Currency);

                                break;
                            }
                            if (resetOnMaxLoss)
                                break;
                        }
                        lastPayIn *= (1 + increaseOnLoss);
                    }
                    lastPayIn = decimal.Round(lastPayIn, 8);
                    if (maxBet != 0 && lastPayIn < maxBet)
                        lastPayIn = maxBet;
                    var single = await DiceWebAPI.PlaceBetAsync(Session, lastPayIn, guessLow, guessHigh, rnd.Next(), Currency);
                    if (!single.Success)
                    {
                        BettingInProgress = false;
                        BeginInvoke((Action)(() =>
                        {
                            if (single.InsufficientFunds)
                                MessageBox.Show("Insufficient funds to continue");
                            else if (!single.Success)
                                MessageBox.Show("Error placing bets");
                        }));
                        break;
                    }
                    LogBets(string.Join(",", single.BetId, single.StartingBalance, lastPayIn, guessLow, guessHigh, single.Secret, single.PayOut, single.StartingBalance + lastPayIn + single.PayOut));
                    --betCount;
                    if (stopMaxBalance > 0 && Session[Currency].Balance >= stopMaxBalance)
                    {
                        BettingInProgress = false;
                        break;
                    }
                    lastWin = single.Secret >= guessLow && single.Secret <= guessHigh;
                }
            }
        }

        void LogBets(string text)
        {
            lock (LogFileLock)
            {
                if (LogFile == null)
                {
                    bool existed = File.Exists(LogFileName);
                    LogFile = File.AppendText(LogFileName);
                    if (!existed)
                        LogFile.WriteLine("Bet ID,Starting Balance,Amount,Guess Low,Guess High,Bet Result,Payout,Ending Balance");
                    BeginInvoke((Action)(() => { button_ExportToCSV.Visible = true; }));
                }
                LogFile.WriteLine(text);
            }
        }
        void SaveLog(string target)
        {
            lock (LogFileLock)
            {
                if (LogFile != null)
                    LogFile.Flush();
                if (File.Exists(LogFileName))
                    File.Copy(LogFileName, target, true);
            }
        }

        void button_ExportToCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "csv",
                Filter = "Comma-separated values (*.csv)|*.csv|All files (*.*)|*.*"
            })
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    try
                    {
                        SaveLog(sfd.FileName);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error saving the file: " + ee.Message);
                    }
        }

        async Task<PlaceBetResponse> doSingleBetAsync(SessionInfo session, decimal payIn, long guessLow, long guessHigh, int randNumber, Currencies currency)
        {
            return  await DiceWebAPI.PlaceBetAsync(session, payIn, guessLow, guessHigh, randNumber, currency);
        }

        async Task runStrategyAsync(SessionInfo session,  long guessLow, long guessHigh, int randNumber, Currencies currency) {
            decimal basebet = 20.48M;
            bool isStrategyRunning = true;
            int betCount = 0; // Countint bet strategy
            int onLoss = 0; 
            int onRestart = 3; // Stop this strategy's betting when win 3 times
            PlaceBetResponse betReponse;
            Console.WriteLine("Run 95% strategy x3, 3 times...");

            while (isStrategyRunning) { 
                betReponse = await DiceWebAPI.PlaceBetAsync(session, basebet,  guessLow, guessHigh, randNumber, currency);
                LogBets(string.Join(",", betReponse.BetId, betReponse.StartingBalance, basebet, guessLow, guessHigh, betReponse.Secret, betReponse.PayOut, betReponse.StartingBalance + basebet + betReponse.PayOut));
                
                Console.WriteLine(DateTime.Now + ": Balance: "+betReponse.StartingBalance + ". Base Bet: " + basebet + ". OnLossCount: " + onLoss + ". Betting: x"+ betCount+"");
                betCount++;
                if (betReponse.Success && betReponse.PayOut == 0) {
                    // OnLoss
                    onLoss++;
                    betCount = 0;
                    switch (onLoss) {
                        case 1: basebet = 163.84M; break;
                        case 2: basebet = 1310.72M; break;
                        case 3: basebet = 10485.76M; break;
                        case 4:
                            basebet = 20000M;
                            onRestart = 7;
                            //Console.Beep() ; Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep();
                            //MessageBox.Show("Loss 4 Reached");
                            break;
                        case 5:
                            MessageBox.Show("Case 5");
                            break;
                        case 6:
                            MessageBox.Show("Case 6");
                            break;
                        default: MessageBox.Show("Strategy reached on default."); BettingInProgress = false; break;

                    }
                }

                // stop strategy when betCount = onRestart 
                if (betCount == onRestart) {
                    isStrategyRunning = false;
                    Console.WriteLine(DateTime.Now + ": End strategy ./.");
                    startBet();
                }
            }
            
        }
        
    }
}
