using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    public static class TestDiagnosticProgram
    {
        
    }


    public static class IntCodeComputer
    {
        public static int Run(int[] instructions, IInput inputProvider)
        {
            var outputs = new List<int>();
            var instructionPointer = 0;
            
            while (instructionPointer < instructions.Length)
            {
                var instruction = instructions[instructionPointer].ToString("D5");

                var opCode = (OpCodes) int.Parse(instruction.Substring(3, 2));
                var paramModes = instruction
                    .Take(3) // Grab first three chars which is params
                    .Select(x => (ParameterModes) char.GetNumericValue(x)) // Convert to enum
                    .ToArray() // Make 0-index array
                    .Reverse(); // Reverse order in to make 1st parameter at index 0;
                
                if (opCode == OpCodes.Add || opCode == OpCodes.Multiply)
                {
                    var parameters = paramModes
                        .Select( (mode, idx) =>
                        {
                            var pos = instructionPointer + idx;
                            if (mode == ParameterModes.Position)
                                return instructions[pos];

                            return pos;
                        })
                        .ToArray();

                    if (opCode == OpCodes.Add)
                    {
                        instructions[parameters[2]] = instructions[parameters[1]] + instructions[parameters[0]];                        
                    }

                    if (opCode == OpCodes.Multiply)
                    {
                        instructions[parameters[2]] = instructions[parameters[1]] * instructions[parameters[0]];
                    }

                    instructionPointer += parameters.Length;
                }

                if (opCode == OpCodes.Input)
                {
                    
                }
                
                if (opCode == OpCodes.Output)
                {
                }
                
                if (opCode == OpCodes.Terminate)
                {
                }
                
                
            }
            
            throw new NotSupportedException("Invalid end of intcode");
            
            
            
            
            
            const int diagnosticCode = 1;
            
            return diagnosticCode;
            
        }
    }
}