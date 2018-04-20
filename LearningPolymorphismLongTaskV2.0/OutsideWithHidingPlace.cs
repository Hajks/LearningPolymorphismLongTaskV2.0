﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV2._0
{
    class OutsideWithHidingPlace: Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace):base(name, hot)
        {
            this.HidingPlace = hidingPlace;
        }
        public string HidingPlace { get; }
    }
}
