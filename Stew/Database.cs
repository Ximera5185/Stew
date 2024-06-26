﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stew
{
    internal class Database
    {
        private List<Stew> _stews = new List<Stew>();

        public Database()
        {
            AddStaws();
        }

        public void ShowExpiredStews(int currentDate)
        {
            var exspiredListStews = _stews.Where(stew => stew.YearOfProduction + stew.ShelfLife < currentDate);

            foreach (Stew stew in exspiredListStews)
            {
                Console.WriteLine($"{stew.Name} Дата производства - {stew.YearOfProduction} Срок годности - {stew.ShelfLife}");
            }
        }

        private void AddStaws()
        {
            _stews.Add(new Stew("Тушонка Ангарскя", 1989, 10));
            _stews.Add(new Stew("Тушонка Ангарскя", 1990, 11));
            _stews.Add(new Stew("Тушонка Ангарскя", 1995, 12));
            _stews.Add(new Stew("Тушонка Русская", 2000, 10));
            _stews.Add(new Stew("Тушонка Русская", 2001, 9));
            _stews.Add(new Stew("Тушонка Украинская", 2004, 15));
            _stews.Add(new Stew("Тушонка Украинская", 2007, 16));
            _stews.Add(new Stew("Тушонка Монгольска", 2002, 13));
            _stews.Add(new Stew("Тушонка Монгольска", 2003, 5));
            _stews.Add(new Stew("Тушонка Вкусная", 2008, 12));
            _stews.Add(new Stew("Тушонка Вкусная", 2024, 12));
        }
    }
}