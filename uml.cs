using System;
public class card
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;
    double cardnumber;
    public card(string cardNum, int pin, string firstName, string lastName, double balance , double cardnumber)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
        this.cardnumber = cardnumber;
    }
    public string getNum()
    {
        return cardNum;

    }
    public int getpin()
    {
        return pin;

    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getlastName()
    {
        return lastName;
    }
    public double getbalance()

    {
    return balance;
   }
    public void setNum(string newcardNum)
    { cardNum = newcardNum;
    }
    public void setpin( int newpin)
    {
        pin = newpin;
    }
    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }
    public void setlastName(string newlastName)
    {
        lastName = newlastName;
    }
    public void setbalance(double newbalance)
    {
        balance = newbalance;
    }
}
namespace programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void prtintoptions()
            {
                Console.WriteLine("Deposit");
                Console.WriteLine("withdraw");
                Console.WriteLine("balance");
            }
            void deposit(card currentUser)
            {
                double deposit = Double.Parse(Console.ReadLine());

                currentUser.setbalance(deposit);
            }

            int amount, deposit, withdraw;
            int pin = 0;
            Console.WriteLine("0123 ");
            pin = int.Parse(Console.ReadLine());
            {
                    Console.WriteLine(" current balance is : {0} ", amount);
                break;

                Console.WriteLine("  thE withdraw amount : ");
                withdraw = int.Parse(Console.ReadLine());
                if (withdraw % 100 != 0)
                {
                    Console.WriteLine(" the amount in above 100");
                }
                else if (withdraw > (amount - 1000))
                {

                    {
                        amount = amount - withdraw;
                        Console.WriteLine(" CURRENT BALANCE IS Rs : {0}", amount);
                    }
                    break;

                    Console.WriteLine("  the deposit amount");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                }
    }
}
