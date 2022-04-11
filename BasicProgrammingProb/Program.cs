﻿using BasicProgrammingProb;
using System;
namespace BasicProgrammingProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Programming Problems");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. LeapYear Problem\n3. " +
                "TableOfTwo\n4. HarmonicSeries\n5. PrimeFactors\n6. " +
                "Remainder and Quotient\n7. EvenOrOdd\n8. VowelConsonent\n9." +
                " End the Program ");
            while (end)
            {
                Console.WriteLine("Choose an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipcoin = new FlipCoin();
                        flipcoin.Flip();
                        break;
                    case 2:
                        LeapYear checking = new LeapYear();
                        checking.CheckLeapyear();
                        break;
                    case 3:
                        TableOfTwo table = new TableOfTwo();
                        table.Table();
                        break;
                    case 4:
                        HarmonicNumber series = new HarmonicNumber();
                        series.HarmonicSeries();
                        break;
                    case 5:
                        PrimeFactors factors = new PrimeFactors();
                        factors.factors();
                        break;
                    case 6:
                        QuotientandRemainder computing = new QuotientandRemainder();
                        computing.ComputeQuotientandRemainder();
                        break;
                    case 7:
                        EvenOdd checkingevenodd = new EvenOdd();
                        checkingevenodd.Checking();
                        break;
                    case 8:
                        VowelConsonant checkingalpha = new VowelConsonant();
                        checkingalpha.alphabetcheck();
                        break;
                    case 9:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct option");
                        break;
                }
            }

        }

    }
}