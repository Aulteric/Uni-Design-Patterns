using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    class Horse : Animal
    {
        public Subject currentStateSubject = null;

        public Horse()
        {
            this.currentStateSubject = new Subject(new IdleState());
            Console.WriteLine("Current animal is horse");
        }

        public override void Feed()
        {
            this.currentStateSubject.ChangeState(new EatState());
            currentStateSubject.ChangeToEating();
        }

        public override void Sleep()
        {
            this.currentStateSubject.ChangeState(new SleepState());
            currentStateSubject.ChangeToSleeping();
        }

        public override void Idle()
        {
            this.currentStateSubject.ChangeState(new IdleState());
            currentStateSubject.ChangeToIdle();
        }
    }
}
