using _07.Tuple;
using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {

        string[] personInput = Console.ReadLine().Split(' ');
        string[] beerInput = Console.ReadLine().Split(' ');
        string[] numbersInput = Console.ReadLine().Split(' ');

        MyTuple<string, string> personInfo = new MyTuple<string, string>($"{personInput[0]} {personInput[1]}", personInput[2]);

        MyTuple<string, int> beerInfo = new MyTuple<string, int>(beerInput[0], int.Parse(beerInput[1]));

        MyTuple<string, double> numbersInfo = new MyTuple<string, double>(numbersInput[0], double.Parse(numbersInput[1]));


        Console.WriteLine(personInfo.T);
        Console.WriteLine(beerInfo);
        Console.WriteLine(numbersInfo);


    }
}