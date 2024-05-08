using System.Text.RegularExpressions;
using System.Xml.XPath;
namespace advent2023{
    public class Day01
    {
        public Day01()
        {
        }

        public void Part01 (){
            var result = 0;
            Console.WriteLine("Day 1: Trebuchet?!");
            var input = File.ReadAllLines(@"./Day01/input.txt");
            foreach(var line in input){
            result+= int.Parse($"{line.First(char.IsDigit)}{line.Last(char.IsDigit)}");
            }
            Console.WriteLine(result);
        }
        

        public void Part02 (){
            var result = 0;
            var input = File.ReadAllLines(@"./Day01/input.txt");
            var pattern = @"(?=([1-9]|one|two|three|four|five|six|seven|eight|nine))";
            var rx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach(var line in input){
                 var matches = rx.Matches(line);
                 result+= int.Parse($"{DigitConvert(matches.First().Groups[1].Value)}{DigitConvert(matches.Last().Groups[1].Value)}");
            }
             Console.WriteLine(result);
        }

        static string DigitConvert(string input){
            var result = input switch
            {
                "one"=>"1",
                "two"=>"2",
                "three"=>"3",
                "four"=>"4",
                "five"=>"5",
                "six"=>"6",
                "seven"=>"7",
                "eight"=>"8",
                "nine"=>"9",
                _=>input
            };
            return result;
        }
    }
}