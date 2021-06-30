using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    class SleepState : BasicState
    {
        public override void GoIdle()
        {
            this._subject.ChangeState(new IdleState());
        }

        public override void GoToEating()
        {
            this._subject.ChangeState(new EatState());
        }

        public override void GoToSleep()
        {
            Console.WriteLine("already sleeping");
        }
    }
}
