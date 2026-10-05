using System;

namespace WorkplaceApp
{
    public class Manager : Worker
    {
        private const int MinFirstCallsCount = 1;
        private const int MaxFirstCallsCount = 10;
        private const int MinSecondCallsCount = 1;
        private const int MaxSecondCallsCount = 5;

        private Random _random;

        public Manager(string name) : base(name)
        {
            Position = "Manager";
            _random = new Random();
        }

        public override void FillWorkDay()
        {
            int firstCallsCount = _random.Next(MinFirstCallsCount, MaxFirstCallsCount + 1);
            for (int i = 0; i < firstCallsCount; i++)
            {
                Call();
            }

            Relax();

            int secondCallsCount = _random.Next(MinSecondCallsCount, MaxSecondCallsCount + 1);
            for (int i = 0; i < secondCallsCount; i++)
            {
                Call();
            }
        }
    }
}