using Logger;

ICalculator calcWithLogger = new CalculatorLogger(new Calculator());
ICalculator calcWithoutLogger = new Calculator();


ICalculator calc = new CalculatorLogger(new CalculatorCasher(new Calculator()));

calcWithLogger.Add(5, 5);
calcWithoutLogger.Add(6, 6);

Console.ReadLine();