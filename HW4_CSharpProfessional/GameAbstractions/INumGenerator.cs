﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Abstractions
{
    /// <summary>
    /// Создание рандомных чисел
    /// </summary>
    public interface INumGenerator
    {
        int Generat(int min, int max);
    }
}
