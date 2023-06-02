using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_CSharpProfessional.Settings;

namespace HW4_CSharpProfessional.Game
{
    public class LetsPlay: UserSettingsNormal
    {
        private RangeRequest _setNumsRange;
        private SetNumberOfAttempts _numberOfAttempts;
        public LetsPlay(RangeRequest setNumsRange, SetNumberOfAttempts numberOfAttempts) : base(setNumsRange)
        {
            _setNumsRange = setNumsRange;
            _numberOfAttempts = numberOfAttempts;
        }

        public (List<int>, int ) Play()
        {
            List<int> listInt = _setNumsRange.GetRange();
            int attempts = _numberOfAttempts.NumberOfAttempts;

            return (listInt, attempts);
        }

    }
}
