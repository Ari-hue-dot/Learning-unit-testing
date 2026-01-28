namespace Progetto_testing.Services
{
    public class CFService
    {
        public bool SeVocale(char c)
        {
            char clower = char.ToLower(c);
            char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char v in vocali)
            {
                if (v == clower)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
