using CommandPattern;
using System.Security.Cryptography;

Calculator calculator = new Calculator();

for (int i = 0; i < 100; i++)
{
    int operation = RandomNumberGenerator.GetInt32(0, 4);
    int changeValue = RandomNumberGenerator.GetInt32(1, 100);

    switch (operation)
    {
        case 0:
            AddValue addValue = new AddValue(i, changeValue);
            ICommand addCommand = new AddValueCommand(addValue);
            calculator.SetOperation(addCommand);
            break;
        case 1:
            SubtractValue subtractValue = new SubtractValue(i, changeValue);
            ICommand subtractCommand = new SubtractValueCommand(subtractValue);
            calculator.SetOperation(subtractCommand);
            break;
        case 2:
            MultiplyValue multiplyValue = new MultiplyValue(i, changeValue);
            ICommand multiplyCommand = new MultiplyValueCommand(multiplyValue);
            calculator.SetOperation(multiplyCommand);
            break;
        case 3:
            DivideValue divideValue = new DivideValue(i, changeValue);
            ICommand divideCommand = new DivideValueCommand(divideValue);
            calculator.SetOperation(divideCommand);
            break;
    }
}

for (int i = 0; i < calculator.CommandCount; i++)
{
    calculator.ExecuteOperation();
}