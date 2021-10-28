using System;

namespace Day5_Practice_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Flipcoin Program");

            FlipCoin flip = new FlipCoin();
            flip.Coin();

            Leap_Year year = new Leap_Year();
            year.Year();

            Power_Of_2 number = new Power_Of_2();
            number.Power();

            Harmonic_No harmonic = new Harmonic_No();
            harmonic.Series();

            PrimeFactors prime = new PrimeFactors();
            prime.Factor();

            QuotientAndRemainder qr = new QuotientAndRemainder();
            qr.compute();

            SwapTwoNumbers numbers = new SwapTwoNumbers();
            numbers.Swap();

            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.evenOdd();

            Alphabet leter = new Alphabet();
            leter.VowelOrConsonant();

            LargestNumber largest = new LargestNumber();
            largest.Max();

        }
    }
}
