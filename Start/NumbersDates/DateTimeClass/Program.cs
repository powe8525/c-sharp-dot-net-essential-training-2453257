// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine($"The current date and time is {now}");

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
// DateTime today = DateTime.Today;
// Console.WriteLine($"Today's date is {today}");

// TODO: DateOnly and TimeOnly represent just dates and times
// DateOnly todayDate = DateOnly.FromDateTime(now);
// Console.WriteLine($"Today's date is {todayDate}");
// TimeOnly timeOnly = TimeOnly.FromDateTime(now);
// Console.WriteLine($"The current time is {timeOnly}");

// TODO: Dates have properties that can be inspected
// Console.WriteLine(today.DayOfWeek);
// Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
// now = now.AddDays(5);
// now = now.AddHours(9);
// now = now.AddMonths(1);
// Console.WriteLine($"The date five days from now is {now}");


// TODO: The TimeSpan class represents a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
Console.WriteLine($"The number of days between New Year's and April Fools is {interval.Days}");

// TODO: Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools}");
Console.WriteLine($"{NewYears > AprilFools}");
