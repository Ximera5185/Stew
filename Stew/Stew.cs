namespace Stew
{
    internal class Stew
    {
        public Stew(string name, int yearOfProduction, int shelfLife)
        {
            Name = name;

            YearOfProduction = yearOfProduction;

            ShelfLife = shelfLife;
        }

        public string Name { get; private set; }

        public int YearOfProduction { get; private set; }
        public int ShelfLife { get; private set; }
    }
}