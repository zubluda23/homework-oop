using System;

namespace WorkplaceApp;

public class QA : Worker
{
    private const int MinTestsCount = 1;
    private const int MaxTestsCount = 10;

    private Random _random;

    public QA(string name) : base(name)
    {
        Position = "QA";
        _random = new Random();
    }
    
    public override void FillWorkDay()
    {
        int testsCount = _random.Next(MinTestsCount, MaxTestsCount + 1);
        for (int i = 0; i < testsCount; i++)
        {
            Test();
        }

        Relax();

        int testCount = _random.Next(MinTestsCount, MaxTestsCount + 1);
        for (int i = 0; i < testsCount; i++)
        {
            Test();
        }
    }
}
