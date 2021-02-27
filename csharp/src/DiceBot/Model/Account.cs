using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Sample.Bot.Model
{
    public class Account
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }
        public string DepositeAddress { get; set; }
        public long BetCount { get; set; }
        public decimal Balance { get; set; }
        public decimal Profit { get; set; }
        public long Win { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
