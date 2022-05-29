using AdventOfCode.Abstractions;

namespace AdventOfCode.YearYYYY.DayXX;

public class DayXXSolver : DaySolver
{
	public DayXXSolver(DayXXSolverOptions options) : base(options)
	{
		// Initialize DayXX solver here.
		// Property `Input` contains the raw input text.
		// Property `InputLines` enumerates lines in the input text.
	}

	public DayXXSolver(Action<DayXXSolverOptions>? configure = null)
		: this(DaySolverOptions.FromConfigureAction(configure))
	{
	}

	public override string SolvePart1()
	{
		return "UNSOLVED";
	}

	public override string SolvePart2()
	{
		return "UNSOLVED";
	}
}
