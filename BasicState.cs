using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    abstract class BasicState
    {
        protected Subject _subject;

        public void SetSubject(Subject subject)
        {
            this._subject = subject;
        }

        public abstract void GoToSleep();

        public abstract void GoToEating();

        public abstract void GoIdle();
    }
}
