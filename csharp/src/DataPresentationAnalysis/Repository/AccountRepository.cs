using Dapper;
using DataPresentationAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPresentationAnalysis.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private IDbConnection db;
        public AccountRepository(IDbConnection db)
        {
            this.db = db;
        }

        public int Create(Account account)
        {
            int sucess = 0;
            try
            {
                string sql = "INSERT INTO account (id, username, balance, currency, deposite_address, bets, profit, win)"
                    + "VALUES("
                    + account.ID + ","
                    + "'" + account.Username + "',"
                    + account.Balance + ","
                    + "'" + account.Currency + "',"
                    + "'" + account.DepositeAddress + "',"
                    + account.BetCount + ","
                    + account.Profit + ","
                    + account.Win
                    + ");";
                db.Execute(sql);
                return 1;
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show("Error: " + e.Message);
                Console.WriteLine("Error: " + e.Message);
            }
            return 0;
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Account FindById(long Id)
        {
            Account account = db.QueryFirstOrDefault<Account>("SELECT * FROM account WHERE id = " + Id, null);
            return account;
        }

        public int Update(Account account)
        {
            try
            {
                string sql = "UPDATE account SET "
                    + "username = '" + account.Username + "'"
                    + ",balance=" + account.Balance
                    + ",currency= '" + account.Currency + "'"
                    + ",deposite_address= '" + account.DepositeAddress + "'"
                    + ",bets=" + account.BetCount
                    + ",profit=" + account.Profit
                    + ",win=" + account.Win
                    + ",updated_at='" + DateTime.Now + "'"
                    + " WHERE id=" + account.ID;
                int rowsEffected = db.Execute(sql);
                return rowsEffected;
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show("Error: " + e.Message);
                Console.WriteLine("Error: " + e.Message);
            }
            return 0;
        }
    }
}
