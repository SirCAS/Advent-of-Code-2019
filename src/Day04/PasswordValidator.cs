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
    }
}