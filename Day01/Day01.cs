using System.Text.RegularExpressions;

public class Day01{
    public Day01()
    {
    }

    public void Part01 (){
     var result = 0;
     var input = File.ReadAllLines(@"./Day01/input.txt");
     foreach(var line in input){
       result+= int.Parse($"{line.First(char.IsDigit)}{line.Last(char.IsDigit)}");
     }
     Console.WriteLine(result);
    }

    public void Part02 (){

    }
}
