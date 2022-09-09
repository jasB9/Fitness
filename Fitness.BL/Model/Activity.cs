using System;
using System.Collections.Generic;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Exercise> Exercise { get; set; }

        public double CalloriesPerMinute { get; set; }

        public Activity() { }

        public Activity(string name, double calloriesPerMinute)
        {
            Name = name;
            CalloriesPerMinute = calloriesPerMinute;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
