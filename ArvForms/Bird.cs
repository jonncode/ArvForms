﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvForms
{
    class Bird: Animal
    {
        public Bird(string name)
        {
            Name = name;
            Species = SPECIES.BIRD;
            CanFly = false;
        }
    }
}
