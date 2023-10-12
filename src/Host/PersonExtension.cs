using Model;

namespace Host
{
    public static class PersonExtension
    {
        public static int SymbolCount(this Worker anyPerson, int a)
        {
            return anyPerson.Age.ToString().Length;
        }
    }
}
