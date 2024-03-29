﻿using AOC.Services;
using AOC2022;

var year = ConfigurationService.GetYear();
var days = ConfigurationService.GetDays();

if (args.Length > 0 && int.TryParse(args.First(), out int day)) days = new[] { day };

foreach (var solution in SolutionCollector.FetchSolutions(year, days))
{
    Console.WriteLine(solution.ToString());
}