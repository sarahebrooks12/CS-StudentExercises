using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Student : Person
    {
       public int id {get; set;}
    //    public int CohortId {get;set;}
       public Cohort cohort {get; set;}
       public List<Exercise> assignedExercises {get;set;} = new List<Exercise>();
    }
}
