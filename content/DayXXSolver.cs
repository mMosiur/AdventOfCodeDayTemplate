using AdventOfCode.Abstractions;

namespace AdventOfCode.YearYYYY.DayXX;

public sealed class DayXXSolver : DaySolver
{
	public override int Year => YYYY;
	public override int Day => XX;
	public override string Title => "TITLE";

	public DayXXSolver(DayXXSolverOptions options) : base(options)
	{
		// Initialize DayXX solver here.
		// Property `Input` contains the raw input text.
		// Property `InputLines` enumerates lines in the input text.
	}

	public DayXXSolver(Action<DayXXSolverOptions> configure)
		: this(DaySolverOptions.FromConfigureAction(configure))
	{
	}

	public DayXXSolver() : this(new DayXXSolverOptions())
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
