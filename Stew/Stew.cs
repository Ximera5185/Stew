namespace Stew
{
    internal class Stew
    {
        public Stew(int yearOfProduction, int shelfLife)
        {
            YearOfProduction = yearOfProduction;

            ShelfLife = shelfLife;
        }

        public int YearOfProduction { get; private set; }
        public int ShelfLife { get; private set; }
    }
}