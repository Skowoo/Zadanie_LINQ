namespace Zadanie_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var napis = " B BB, 1901-01-01; A BB, 1911-01-01; B AA, 1901-01-02; B B, 1901-01-02; BB A, 1901-01-02";
            var wynik = Linq_to_Object_SortByDateThenLastNameTest.SortByDateOfBirthThenLastName(napis);
            Console.WriteLine(wynik);
        }
    }
}