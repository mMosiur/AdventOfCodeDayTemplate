using AdventOfCode.Abstractions;
using AdventOfCode.YearYYYY.DayXX;

try
{
	string? filepath = args.Length switch
	{
		0 => null,
		1 => args[0],
		_ => throw new DaySolverException(
			$"Program was called with too many arguments. Proper usage: \"dotnet run [<input filepath>]\"."
		)
	};

	DayXXSolver solver = new(options =>
	{
		options.InputFilepath = filepath ?? options.InputFilepath;
	});

	Console.WriteLine($"Advent of Code {solver.Year}");
	Console.WriteLine($"--- Day {solver.Day}: {solver.Title} ---");

	Console.Write("Part one: ");
	string part1 = solver.SolvePart1();
	Console.WriteLine(part1);

	Console.Write("Part two: ");
	string part2 = solver.SolvePart2();
	Console.WriteLine(part2);
}
catch (FileNotFoundException e)
{
	ConsoleColor previousColor = Console.ForegroundColor;
	Console.ForegroundColor = ConsoleColor.Red;
	Console.Error.WriteLine(e.Message);
	Console.ForegroundColor = previousColor;
	Environment.Exit(1);
}
catch (DaySolverException e)
{
	ConsoleColor previousColor = Console.ForegroundColor;
	Console.ForegroundColor = ConsoleColor.Red;
	Console.Error.WriteLine($"Day solver error: {e.Message}");
	Console.ForegroundColor = previousColor;
	Environment.Exit(1);
}
