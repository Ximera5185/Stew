using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stew
{
    internal class Database
    {
        List<Stew> _stews = new List<Stew>();

        public Database() 
        {
            AddStaws();
        }

        private void AddStaws() 
        {
            _stews.Add(new Stew(1989,10));
            _stews.Add(new Stew(1990, 11));
            _stews.Add(new Stew(1995, 12));
            _stews.Add(new Stew(2000, 10));
            _stews.Add(new Stew(2001, 9));
            _stews.Add(new Stew(2004, 15));
            _stews.Add(new Stew(2007, 16));
            _stews.Add(new Stew(2002, 13));
            _stews.Add(new Stew(2003, 5));
            _stews.Add(new Stew(2008, 12));
            _stews.Add(new Stew(2024, 12));
        }
    }
}