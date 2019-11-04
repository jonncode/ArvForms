﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvForms
{
    class Cat: Animal
    {
        public Cat(string name)
        {
            Name = name;
            Species = SPECIES.CAT;
            CanFly = false;
        }
    }
}
