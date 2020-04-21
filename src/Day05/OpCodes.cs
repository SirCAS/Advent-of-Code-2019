namespace Day05
{
    public enum OpCodes
    {
        Add = 1,
        Multiply = 2,
        Input = 3,
        Output = 4,
        Terminate = 99,
    }

    public enum ParameterModes
    {
        Position = 0,
        Immediate = 1
    }
}