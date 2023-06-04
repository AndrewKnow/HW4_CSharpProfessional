using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.GameAbstractions
{
    public interface IParse<T>
    {
        int ParseObj(T obj);
    }
}
