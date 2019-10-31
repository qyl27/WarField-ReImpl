﻿using System;
using System.Collections.Generic;
using System.Text;
using WarField.Common.Enumerates;
using WarField.Common.Interfaces;

namespace WarField.Common.Armors
{
    class ArmorNone : IArmor
    {
        public string Name { get; }
        public ArmorFor For { get; }
        public double Armor { get; }

        public ArmorNone()
        {
            Name = "None";
            For = ArmorFor.All;
            Armor = 0;
        }
    }
}
