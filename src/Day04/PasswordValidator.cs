using System.Linq;

namespace Day04
{
    public static class PasswordValidator
    {
        public static bool NeverDecreases(string password)
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] > password[i + 1])
                    return false;
            }

            return true;
        }
        
        public static bool HasDouble(string password)
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                if (password[i] == password[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        public static bool HasDoubleWhichIsNotTriple(string password)
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                var groupChar = password[i];
                if (groupChar == password[i + 1])
                {
                    var groupSize = password.Substring(i).TakeWhile(c => c.Equals(groupChar)).Count();
                    if (groupSize > 2)
                    {
                        i += groupSize - 1; // Take the loop increment into account 
                        continue;
                    }
                    
                    return true;
                }
            }

            return false;   
        }
    }
}