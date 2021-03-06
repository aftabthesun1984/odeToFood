﻿using ode2Food.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ode2Food.Services
{
    public class InMemoryResturant : IResturant
    {
        public InMemoryResturant()
        {
            _resturants = new List<Resturant>
            {
                new Resturant(){Id=1, Name="Olive" },
                new Resturant(){Id=2, Name="Pepe's Pizza" },
                new Resturant(){Id=3, Name="Cafe De Club" },
                new Resturant(){Id=4, Name="Cafe Pasal" },
                new Resturant(){Id=5, Name="Fire N Ice" },
        };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _resturants;
        }

        public Resturant Get(int id)
        {
            return _resturants.FirstOrDefault(x => x.Id == id);
        }

        public Resturant Add(Resturant resturant)
        {
            resturant.Id = _resturants.Max(x => x.Id) + 1;
            _resturants.Add(resturant);

            return resturant;
        }

        List<Resturant> _resturants = new List<Resturant>();

    }
}
