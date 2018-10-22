namespace Cryptology.Helpers
{
    public static class CharHelper
    {
        public static bool IsSpaceOrEndln(char character)
        {
            return char.IsSeparator(character) || character == 13;
        }
    }
}
