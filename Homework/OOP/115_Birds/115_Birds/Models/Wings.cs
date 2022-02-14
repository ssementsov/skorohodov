using System;

namespace _115_Birds
{
    public class Wings
    {
        public string State { get; set; }

        public Wings ()
        {
            State = "folded";
        }

        public Wings(string state)
        {
            State = state;
        }

        public void Spread()
        {
            State = "spread";
        }

        public void Fold()
        {
            State = "folded";
        }
    }
}