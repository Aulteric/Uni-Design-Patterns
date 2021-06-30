using System;
using System.Collections.Generic;
using System.Text;

namespace Uni_design_pattern
{
    class Subject
    {
        private BasicState _state = null;

        public Subject(BasicState state)
        {
            this.ChangeState(state);
        }

        public string GetState()
        {
            return ($"{_state.GetType().Name}.");
        }

        public void ChangeState(BasicState state)
        {
            this._state = state;
            this._state.SetSubject(this);
        }

        public void ChangeToEating()
        {
            this._state.GoToEating();
        }

        public void ChangeToSleeping()
        {
            this._state.GoToSleep();
        }

        public void ChangeToIdle()
        {
            this._state.GoIdle();
        }
    }
}
