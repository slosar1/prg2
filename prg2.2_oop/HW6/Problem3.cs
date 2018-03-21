using System;

namespace prg2._4_functional_programming
{
    public class Problem3
    {
        string csvlines= "forcsv.csv";
        var Person = csvlines.Select(x => x.Split(',')[0]).ToList();
        var Gear = csvlines.Select(x => x.Split(',')[1]).ToList();
        var GPA = csvlines.Select(x => x.Split(",")[2]).ToArray();

    }
}