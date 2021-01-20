using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifyBetResult
{
    public partial class VerifyBetResultForm : Form
    {
        public VerifyBetResultForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string serverSeed = txtServerSeed.Text.Trim();
            int clienSeed = int.Parse(txtClientSeed.Text.Trim());
            int betNumber = int.Parse(txtBetNumber.Text.Trim());
            long betResult = long.Parse(txtBetResult.Text.Trim());
            string serverSeedHash = txtServerSeedHash.Text.Trim();
            bool fairBet = VerifyBetResult(serverSeed, clienSeed, betNumber, betResult, serverSeedHash);
            if (fairBet)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("Not Fair");
            }
        }

        static bool VerifyBetResult(string serverSeed, int clientSeed, int betNumber,
                            long betResult, string serverSeedHash = null)
        {
            Func<string, byte[]> strtobytes = s => Enumerable
                .Range(0, s.Length / 2)
                .Select(x => byte.Parse(s.Substring(x * 2, 2), NumberStyles.HexNumber))
                .ToArray();
            byte[] server = strtobytes(serverSeed);
            byte[] client = BitConverter.GetBytes(clientSeed).Reverse().ToArray();
            byte[] num = BitConverter.GetBytes(betNumber).Reverse().ToArray();
            byte[] serverhash = serverSeedHash == null ? null : strtobytes(serverSeedHash);
            byte[] data = server.Concat(client).Concat(num).ToArray();
            using (SHA512 sha512 = new SHA512Managed())
            {
                if (serverhash != null)
                    using (SHA256 sha256 = new SHA256Managed())
                        if (!sha256.ComputeHash(server).SequenceEqual(serverhash))
                            throw new Exception("Server seed hash does not match server seed");
                byte[] hash = sha512.ComputeHash(sha512.ComputeHash(data));
                while (true)
                {
                    for (int x = 0; x <= 61; x += 3)
                    {
                        long result = (hash[x] << 16) | (hash[x + 1] << 8) | hash[x + 2];
                        if (result < 16000000)
                            Console.WriteLine("" + (result % 1000000));
                        return result % 1000000 == betResult;
                    }
                    hash = sha512.ComputeHash(hash);
                }
            }
        }

        long CalculateBetResult(string serverSeed, int clientSeed)
        {
            Func<string, byte[]> strtobytes = s => Enumerable
                .Range(0, s.Length / 2)
                .Select(x => byte.Parse(s.Substring(x * 2, 2), NumberStyles.HexNumber))
                .ToArray();

            byte[] server = strtobytes(serverSeed);
            byte[] client = BitConverter.GetBytes(clientSeed).Reverse().ToArray();

            // First Number = 0
            byte[] num = BitConverter.GetBytes(0).Reverse().ToArray();

            // ServerSeed + ClientSeed + NONCE (Sequences number)
            byte[] data = server.Concat(client).Concat(num).ToArray();

            using (SHA512 sha512 = new SHA512Managed())
            {
                byte[] hash = sha512.ComputeHash(sha512.ComputeHash(data));
                while (true)
                {
                    for (int x = 0; x <= 61; x += 3)
                    {
                        long result = (hash[x] << 16) | (hash[x + 1] << 8) | hash[x + 2];
                        if (result < 16000000)
                            Console.WriteLine("Bet Result: " + (result % 1000000));
                        return result % 1000000;
                    }
                    hash = sha512.ComputeHash(hash);
                }
            }
        }

        private void lblCalculateBetResult_Click(object sender, EventArgs e)
        {
            long betResult = CalculateBetResult(txtServerSeed.Text.Trim(), int.Parse(txtClientSeed.Text.Trim()));
            lblCalculateBetResult.Text = "" + betResult;
        }
    }
}
