
using System;
using System.Collections.Generic;
using System.Linq;

#region #AreaDifference
// write a program which can find difference between areas 

Console.WriteLine("Input radius:");

var radius = Convert.ToInt32(Console.ReadLine());
int diameter = 2 * radius;

int lineS1 = Convert.ToInt32(diameter / Math.Sqrt(2));
int areaS2 = Convert.ToInt32(Math.Pow(diameter, 2));
int areaS1 = Convert.ToInt32(Math.Pow(lineS1, 2));

int difference = Convert.ToInt32(areaS2 - areaS1);

Console.WriteLine($"Difference between S2 and S1 areas is: {difference}");


#endregion

#region JACKPOT
// Check if user got Jackpot
List<string> jackpot = new List<string> { };

Console.WriteLine("Write your input. When you are done, write - DONE ");

while (true)
{
    var userinput = Console.ReadLine();
    if (userinput == "DONE")
    {
        break;
    }
    else
    {
        jackpot.Add(userinput);

    }

}

int counter = jackpot.Count;
List<string> jacklist = new List<string> { };


for (int i = 0; i < counter - 1; i++)
{
    for (int j = i + 1; j < counter; j++)
    {
        if (jackpot[i] != jackpot[j])
        {
            Console.WriteLine("NO");

        }
        else
        {
            jacklist.Add(jackpot[j]);
        }
        break;
    }

}



if (jackpot.OrderBy(x => x).SequenceEqual(jacklist.OrderBy(x => x)))
{
    Console.WriteLine("YES");
}


#endregion

#region Game Scores

Console.WriteLine("Scores input:");

var result = Convert.ToInt32(Console.ReadLine());

Dictionary<string, int> results = new Dictionary<string, int>();

results.Add("win", 3);
results.Add("draw", 1);
results.Add("lose", 0);






#endregion