﻿using Xbehave;
using Xunit;

namespace BDD
{
    public class Calculator
    {
        public int Add(int first, int second) =>
            first + second;
    }

    public class CalculatorFeature
    {
        [Scenario]
        public void Addition(int x, int y, Calculator calculator, int answer)
        {
            "Given the number 1"
                .x(() => x = 1);

            "And the number 2"
                .x(() => y = 2);

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Assert.Equal(3, answer));
        }
    }
}
