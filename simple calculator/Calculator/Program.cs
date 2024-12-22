Console.WriteLine("Калькулятор запущен!\n");

double consoleNumber1, consoleNumber2;
string mathOperation;
List<string> mathOperationList = new List<string> {"+", "-", "*", "/", "%", "**"};
bool flag = true;

while (flag)
{
    Calculate();
    flag = TryAgain();
}

double CheckValue(){

    double result;
    while (true)
    {
        var value = Console.ReadLine();

        if (!double.TryParse(value, out result))
        {
            Console.WriteLine("\nКалькулятор принимает только числа!");
        }
        else
        {
            result = double.Parse(value);
            return result;
        }
    }
}

string CheckOperation()
{
    bool flag = true;
    while (flag)
    {
        var value = Console.ReadLine();

        switch (value)
        {
            case "+":
                flag = false;
                return value;
            case "-":
                flag = false;
                return value;
            case "*":
                flag = false;
                return value;
            case "/":
                flag = false;
                return value;
            case "%":
                flag = false;
                return value;
            case "**":
                flag = false;
                return value;
            default:
                Console.WriteLine("\nКалькулятор принимает только операции из списка!");
                break;
        }
    }
    return null;
}

double GetResult(double consoleNumber1, string mathOperation, double consoleNumber2)
{
    while (true)
    {
        switch (mathOperation)
        {
            case "+":
                return consoleNumber1 + consoleNumber2;
            case "-":
                return consoleNumber1 - consoleNumber2;
            case "*":
                return consoleNumber1 * consoleNumber2;
            case "/":
                if (consoleNumber2 == 0)
                {
                    Console.WriteLine("\nНа ноль делить нельзя!");
                    return double.NaN;
                }
                else
                {
                    return consoleNumber2 / 100 * consoleNumber1;
                }
            case "%":
                return consoleNumber2 / 100 * consoleNumber1;
            case "**":
                return consoleNumber1 * consoleNumber1;
            default:
                return double.NaN;
        }
    }
    
}

bool TryAgain()
{
    bool flag = true;

    Console.WriteLine("Продолжить расчёты (Да/Нет): ");
    while (flag)
    {
        var value = Console.ReadLine();
        if (value.ToLower().Equals("да"))
        {
            return true;
        }
        else if (value.ToLower().Equals("нет"))
        {
            return false;
        }
        else
        {
            Console.WriteLine("Выберите один из вариантов (Да/Нет)!");
        }
    }

    return flag;

}

void Calculate()
{
    Console.WriteLine("Введите первое число: ");
    consoleNumber1 = CheckValue();

    Console.WriteLine("Введите операцию (+, -, *, /, %, **): ");
    mathOperation = CheckOperation();
    if (mathOperation.Equals("**"))
    {
        Console.WriteLine($"Результат: {GetResult(consoleNumber1, mathOperation, consoleNumber1)}");
        flag = TryAgain();
        return;
    }

    Console.WriteLine("Введите второе число: ");
    consoleNumber2 = CheckValue();

    if (consoleNumber1 != double.NaN && consoleNumber2 != double.NaN)
    {
        Console.WriteLine($"Результат: {GetResult(consoleNumber1, mathOperation, consoleNumber2)}\n");
    }
}


