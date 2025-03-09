// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information
using System.Globalization;

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
// Console.WriteLine($"Short date: {AprFools:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
// Console.WriteLine($"Short date: {AprFools:D}");


// TODO: 'f' Full date, short time
// Console.WriteLine($"Full date, short time: {AprFools:f}");



// TODO: 'F' Full date, long time
// Console.WriteLine($"Full date, long time: {AprFools:F}");



// TODO: 'g' General date and time
// Console.WriteLine($"General date and time: {AprFools:g}");



// TODO: 'G' General date and time
// Console.WriteLine($"General date and time: {AprFools:G}");



// TODO: Format using a specific CultureInfo
Console.WriteLine($"{AprFools.ToString("d", new CultureInfo("fr-FR"))}");
Console.WriteLine(AprFools.ToString("d", new CultureInfo("de-DE")));

// TODO: Defining custom date and time formats
