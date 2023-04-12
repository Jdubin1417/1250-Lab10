/**
*--------------------------------------------------------------------
* File name: BankAccount.cs
* Project name: lab9
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 20 Apr 2022
*
-------------------------------------------------------------------
*/
public class BankAccount
{
    private int accountNumber;
    private char type;
    private decimal balance;
    public string FirstName;
    public string LastName;



    public BankAccount(char type, decimal initialDeposit, int accountNumber, string firstName, string lastName)
    {
         _name = name;
        _address = address;
        _age = age;
        _phoneNumber = phoneNumber;
    }

    public BankAccount(obj BankAccount)
    {
         _name = name;
        _address = address;
        _age = age;
        _phoneNumber = phoneNumber;
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public string GetAccountTypeAsAString()
    {
        return type;
    }

    public bool Deposit(decimal amount)
    {
        
    }

    public bool Withdrawal(decimal amount)
    {
        
    }

    public decimal MonthlyInterest()
    {
        
    }

    public bool Equals(obj object)
    {
        
    }

    public string ToString()
    {
        
    }
}