using System;

namespace BankSystem
{
    // Base class (Abstract) - BankAccount
    abstract class BankAccount
    {
        // Encapsulated fields (private)
        private string accountHolder;
        private double balance;

        // Constructor to initialize account holder and balance
        public BankAccount(string accountHolder, double balance)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Public property to get the account holder (Encapsulation)
        public string AccountHolder
        {
            get { return accountHolder; }
        }

        // Public property to get and set the balance (Encapsulation)
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        // Abstract method to be overridden by derived classes
        public abstract void Deposit(double amount);

        public abstract bool Withdraw(double amount);

        // Virtual method - can be overridden, but has default behavior
        public virtual void ShowBalance()
        {
            Console.WriteLine($"Account Holder: {accountHolder}, Balance: {balance:C}");
        }
    }

    // Derived class - SavingsAccount (Inheritance)
    class SavingsAccount : BankAccount
    {
        // Constructor calling base class constructor
        public SavingsAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

        // Overriding abstract Deposit method (Polymorphism)
        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to {AccountHolder}'s Savings Account.");
        }

        // Overriding abstract Withdraw method (Polymorphism)
        public override bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s Savings Account.");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
                return false;
            }
        }
    }

    // Derived class - CurrentAccount (Inheritance)
    class CurrentAccount : BankAccount
    {
        private double overdraftLimit;

        // Constructor calling base class constructor and setting overdraft limit
        public CurrentAccount(string accountHolder, double balance, double overdraftLimit)
        : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        // Overriding abstract Deposit method (Polymorphism)
        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to {AccountHolder}'s Current Account.");
        }

        // Overriding abstract Withdraw method (Polymorphism)
        public override bool Withdraw(double amount)
        {
            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s Current Account.");
                return true;
            }
            else
            {
                Console.WriteLine("Exceeded overdraft limit.");
                return false;
            }
        }

        // Overriding ShowBalance method (Polymorphism)
        public override void ShowBalance()
        {
            base.ShowBalance();
            Console.WriteLine($"Overdraft Limit: {overdraftLimit:C}");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects for different account types (Abstraction)
            BankAccount savings = new SavingsAccount("Alice", 1000);
            BankAccount current = new CurrentAccount("Bob", 500, 300);

            // Demonstrating polymorphism with method calls
            savings.Deposit(200);
            savings.Withdraw(500);
            savings.ShowBalance();

            Console.WriteLine(); // Line break

            current.Deposit(100);
            current.Withdraw(800); // Using overdraft
            current.ShowBalance();

            Console.ReadLine();
        }
    }
}