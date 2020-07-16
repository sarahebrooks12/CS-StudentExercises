using System;

namespace student_exercises
{
    class Instructor : Person
    {
        public int id { get; set; }
        public string specialty { get; set; }
        public Cohort cohort { get; set; }

    }
}
