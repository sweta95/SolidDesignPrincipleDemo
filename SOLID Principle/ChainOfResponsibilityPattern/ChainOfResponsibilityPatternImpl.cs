﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// The 'Handler' abstract class
    abstract class Approver

    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }

    /// The 'ConcreteHandler' class
    class Director : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }

    /// The 'ConcreteHandler' class
    class VicePresident : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }

    /// The 'ConcreteHandler' class
    class President : Approver

    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
            }
            else

            {
                Console.WriteLine(
                  "Request# {0} requires an executive meeting!",
                  purchase.Number);
            }
        }
    }

    /// Class holding request details
    class Purchase

    {
        private int _number;
        private double _amount;
        private string _purpose;

        // Constructor

        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        // Gets or sets purchase number

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Gets or sets purchase amount

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        // Gets or sets purchase purpose

        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}

