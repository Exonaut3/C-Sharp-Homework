using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityBase;
using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.MainMenu.The_Tracker.Activities
{
    public class Exercising : ActivitiesBase
    {
        public string Title = "Exercising";
        public ExerciseTypes TypeOfExercise {  get; set; }
     
    }
}
