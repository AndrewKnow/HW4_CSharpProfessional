using HW4_CSharpProfessional.GameAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Settings
{
    public class UserSettingsNormal: IGameAttempts
    {
        /// <summary>
        /// Количество попыток
        /// </summary>
        /// <returns> число </returns>
        public int ChangeSettings()
        {
            return 3;
        }
    }
}
