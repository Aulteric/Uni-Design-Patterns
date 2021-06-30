using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    class EatState : BasicState
    {
        public override void GoIdle()
        {
            this._subject.ChangeState(new IdleState());
        }

        public override void GoToEating()
        {
            Console.WriteLine("already eating");
        }

        public override void GoToSleep()
        {
            this._subject.ChangeState(new SleepState());
        }
    }
}
