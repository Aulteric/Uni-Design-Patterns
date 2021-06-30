using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    class IdleState : BasicState
    {
        public override void GoToSleep()
        {
            this._subject.ChangeState(new SleepState());
        }

        public override void GoToEating()
        {
            this._subject.ChangeState(new EatState());
        }

        public override void GoIdle()
        {
            Console.WriteLine("already idle");
        }
    }
}
