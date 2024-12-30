/*
 * 
 * //Чётный массив
static int[] GetFirstEvenNumbers(int count)
{
    var array = new int[count];
    for (var i = 1; i <= array.Length; i++)
    {
        array[i - 1] = i * 2;
    }
    return array;
}

//Индекс максимума
static int MaxIndex(double[] array)
{
    if (!array.Any())
        return -1;
    return Array.IndexOf(array, array.Max());
}

//Подсчет
static int GetElementCount(int[] items, int itemToCount)
{
    int count = 0;
    for (var i = 0; i < items.Length; i++)
    {
        if (items[i] == itemToCount) count++;
    }

    return count;
}

//Поиск массива в массиве
static bool ContainsAtIndex(int[] array, int[] subArray, int i)
{
    for (var j = 0; j < subArray.Length; j++)
    {
        if (array[i + j] != subArray[j])
        {
            return false;
        }
    }
    return true;
}

//Карты Таро
enum Suits
{
    Wands,
    Coins,
    Cups,
    Swords
}

static string GetSuit(Suits suit)
{
    return new string[] { "жезлов", "монет", "кубков", "мечей" }[Convert.ToInt32(suit)];
}


//Null или не Null?
static bool CheckFirstElement(int[] array)
{
    return array != null && array.Length != 0 && array[0] == 0;
}

//Возвести массив в степень
static int[] GetPoweredArray(int[] arr, int power)
{
    var newArray = new int[arr.Length];
    arr.CopyTo(newArray, 0);

    for (var i = 0; i < newArray.Length; i++)
    {
        int result = 1;
        if (power == 0)
        {
            newArray[i] = result;
            continue;
        }

        for (var j = 0; j < power; j++)
        {
            result *= newArray[i];
        }

        newArray[i] = result;
    }

    return newArray;
}*/
