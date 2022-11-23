using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.Payment_Multiple_Bank_
{
    public interface IBank
    {
        Boolean Verify(int orderid);
        void Pay(int orderid, int amount);
    }
    public class BankMelli : IBank
    {
        public void Pay(int orderid, int amount)
        {
            Console.WriteLine($"payment for orderid:{orderid}  , amount: {amount} was successfull");
        }

        public bool Verify(int orderid)
        {   
            //do something
            return true;
        }
    }

    public class BankTejarat : IBank
    {
        public void Pay(int orderid, int amount)
        {
            throw new NotImplementedException();
        }

        public bool Verify(int orderid)
        {
            throw new NotImplementedException();
        }
    }

    public interface IBankFactory
    {
        IBank GetBank();
    }

    public class MelliFactory:IBankFactory
    {
        public IBank GetBank()
        {
            return new BankMelli();
        }
    }

    public class TejaratFactory:IBankFactory
    {
        public IBank GetBank()
        {
            return new BankTejarat();
        }
    }

    public enum BankType
    {
        TejaratBank, MelliBank
    }

    public class Payment
    {
       
        public static IBankFactory CreatePayment(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.TejaratBank:return new TejaratFactory();
                    case BankType.MelliBank:return new MelliFactory();
                default:return null;
            }
        }
    }




    public class Program
    {
        public static void StartPay(BankType bankType,int orderid,int amount)
        {
           var bank=Payment.CreatePayment(bankType);
            bank.GetBank().Pay(orderid,amount); 
        }
    }
}