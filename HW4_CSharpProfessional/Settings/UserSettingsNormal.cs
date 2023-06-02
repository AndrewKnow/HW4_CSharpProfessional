using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CSharpProfessional.Settings
{
    public class UserSettingsNormal
    {
        private SetNumberOfAttempts _numberOfAttempts;
        private RangeRequest _numsRange;

        public UserSettingsNormal(RangeRequest setNumsRange)
        {
            _numberOfAttempts = new SetNumberOfAttempts();
            _numsRange = setNumsRange;
        }

        public void ChangeSettings()
        {
            _numberOfAttempts.NumberOfAttempts = 3;
        }
    }
}
