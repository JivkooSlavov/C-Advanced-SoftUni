Stack<int> moneyInPocket = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> foodsPrice = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

int countOfFood = 0;
while (moneyInPocket.Count>0 && foodsPrice.Count>0)
{
    int lastOfMoney = moneyInPocket.Peek();
    int firstOfPrice = foodsPrice.Peek();
    int change = lastOfMoney - firstOfPrice;

    if (lastOfMoney == firstOfPrice)
    {
        moneyInPocket.Pop();
        foodsPrice.Dequeue();
        countOfFood++;
    }
    else if (lastOfMoney > firstOfPrice)
    {
        moneyInPocket.Pop();
        if (moneyInPocket.Count!=0)
        {
            int lastIn = moneyInPocket.Pop();
            int total = lastIn + change;
            moneyInPocket.Push(total);
        }
        foodsPrice.Dequeue();
        countOfFood++;
    }
    else if (firstOfPrice > lastOfMoney)
    {
        moneyInPocket.Pop();
        foodsPrice.Dequeue();
    }
}
if (countOfFood >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {countOfFood} foods.");
}
else if (countOfFood==0)
{
    Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
}
else if (countOfFood<4)
{
    
    if (countOfFood == 1)
    {
        Console.WriteLine($"Henry ate: {countOfFood} food.");
    }
    else
    {
        Console.WriteLine($"Henry ate: {countOfFood} foods.");
    }
    
}
