﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine;

internal interface IProduct
{
    //Metoder i interface
    void Description();
    void Buy();
    void Use();
}
