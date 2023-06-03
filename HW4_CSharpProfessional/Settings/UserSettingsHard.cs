using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Settings
{
    public class UserSettingsHard
    {
        private SetNumberOfAttempts _numberOfAttempts;
        public void ChangeSettings()
        {
            _numberOfAttempts.NumberOfAttempts = 1;
        }
    }
}

