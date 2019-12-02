using System;

namespace Day02
{
    public static class IntCodeBruteforce
    {
        public static int Solve(int desiredOutput, int[] memory)
        {
            for (int noun = 0; noun <= 99; noun++)
            for (int verb = 0; verb <= 99; verb++)
            {
                // Copy original
                var memCopy = (int[]) memory.Clone();
                
                // Noun
                memCopy[1] = noun;
            
                // Verb
                memCopy[2] = verb;

                try
                {
                    var sequence = IntCodeComputer.Run(memCopy);

                    if (desiredOutput == sequence[0])
                    {
                        return 100 * noun + verb;
                    }
                }
                catch (Exception)
                {
                    // Please don't judge me Santa! I've been a good boy up until this catch-all...
                    // Have a glass of milk
                    //     _________
                    //    | _______ |
                    //   / \         \
                    //  /___\_________\
                    //  |   | \       |
                    //  |   |  \      |
                    //  |   |   \     |
                    //  |   | M  \    |
                    //  |   |     \   |
                    //  |   |\  I  \  |
                    //  |   | \     \ |
                    //  |   |  \  L  \|
                    //  |   |   \     |
                    //  |   |    \  K |
                    //  |   |     \   |
                    //  |   |      \  |
                    //  |___|_______\_|
                }
            }
            
            throw new NotFiniteNumberException("Solution not found");
        }
    }
}