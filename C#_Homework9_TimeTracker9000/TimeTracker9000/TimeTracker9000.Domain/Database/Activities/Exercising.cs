using TimeTracker9000.Domain.Database.Activities.ActivityBaseFolder;
using TimeTracker9000.Domain.Database.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.Database.Activities
{
    public class Exercising : ActivitiesBase
    {
        public string Title = "Exercising";
        public ExerciseTypes TypeOfExercise { get; set; }

    }
}
