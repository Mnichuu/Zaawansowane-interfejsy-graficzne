using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Player
{
    public class CreditAccount {
        public int Balance { get; private set; }
        public CreditAccount() {
            Balance = 0;
        }

        public int GetBalance() { return Balance; }

        public void Deposit(int amount) {
            if (amount > 0) {
                Balance += amount;
            } else {
                throw new ArgumentException("Deposit amount must be positive.");
            }
        }

        public void Withdraw(int amount) {
            if (amount > 0 && amount <= Balance) {
                Balance -= amount;
            } else {
                throw new ArgumentException("Withdrawal amount must be positive and less than or equal to the balance.");
            }
        }


    }
}
