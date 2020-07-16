using System;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
             Cohort cohort1 = new Cohort()
            {
                id = 1,
                name = "Cohort 1",
            };
            Cohort cohort2 = new Cohort()
            {
                id = 2,
                name = "Cohort 2"
            };
            Cohort cohort3 = new Cohort()
            {
                id = 3,
                name = "Cohort 3"
            };

            Student sarah = new Student()
            {
                id = 1,
                firstName = "Sarah",
                lastName = "Brooks",
                slackHandle = "@sarahBrooks",
                cohort = cohort3
            };
            Student swathi = new Student()
            {
                id = 2,
                firstName = "Swathi",
                lastName = "Mukkamala",
                slackHandle = "@swathiMukkamala",
                cohort = cohort3
            };
            Student barry = new Student()
            {
                id = 3,
                firstName = "Barry",
                lastName = "Griffith",
                slackHandle = "@barryGriffith",
                cohort = cohort2
            };
            Student pat = new Student()
            {
                id = 4,
                firstName = "Pat",
                lastName = "Shaver",
                slackHandle = "@patShaver",
                cohort = cohort3
            };
            Student mandy = new Student()
            {
                id = 5,
                firstName = "Mandy",
                lastName = "Campbell",
                slackHandle = "@mandyCampbell",
                cohort = cohort2
            };

            Exercise studentExercises = new Exercise()
            {
                id = 1,
                name = "Student Exercise",
                language = "C#"
            };
            Exercise urbanPlanner = new Exercise()
            {
                id = 2,
                name = "Urban Planner",
                language = "C#"
            };
            Exercise kennel = new Exercise()
            {
                id = 3,
                name = "Kennel",
                language = "React"
            };
            Exercise dailyJournal = new Exercise()
            {
                id = 4,
                name = "Daily Journal",
                language = "JavaScript"
            };

            Instructor jordan = new Instructor()
            {
                id = 1,
                firstName = "Jordan",
                lastName = "Castelloe",
                slackHandle = "@jordanCastelloe",
                specialty = "Pop Culture References",
                cohort = cohort1
            };
            Instructor tommy = new Instructor()
            {
                id = 2,
                firstName = "Tommy",
                lastName = "Spurlock",
                slackHandle = "@tommySpurlock",
                specialty = "Pep Talks",
                cohort = cohort3
            };
           Instructor jacob = new Instructor()
            {
                id = 3,
                firstName = "Jacob",
                lastName = "Perry",
                slackHandle = "@jacobPerry",
                specialty = "Video Game Capstones",
                cohort = cohort2
            };
        }

        //         Create 4, or more, exercises.
        // Create 3, or more, cohorts.
        // Create 4, or more, students and assign them to one of the cohorts.
        // Create 3, or more, instructors and assign them to one of the cohorts.
        // Have each instructor assign 2 exercises to each of the students.
    }
}
