using System;

namespace Day02
{
    public static class IntCodeComputer
    {
        public static int[] Run(int[] memory)
        {
            for (var instructionPointer = 0; instructionPointer < memory.Length; instructionPointer += 4)
            {
                var instruction = (OpCodes)memory[instructionPointer];
                if (instruction == OpCodes.Terminate)
                    return memory;
                
                var aAddress = memory[instructionPointer + 1];
                var bAddress = memory[instructionPointer + 2];
                var resultAddress = memory[instructionPointer + 3];
                
                switch (instruction)
                {
                    case OpCodes.Add:
                        memory[resultAddress] = memory[aAddress] + memory[bAddress];
                        break;
                    
                    case OpCodes.Multiply:
                        memory[resultAddress] = memory[aAddress] * memory[bAddress];
                        break;
                    
                    default:
                        throw new NotSupportedException("Invalid opcode received");
                }
            }
            
            throw new NotSupportedException("Invalid end of intcode");
        }
    }
}