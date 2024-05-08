using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityBase;
using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.MainMenu.The_Tracker.Activities
{
    public class Reading : ActivitiesBase
    {
        public string Title = "Reading";
        public int NumberOfPages {  get; set; }
        public ReadingTypes TypeOfReading {  get; set; }

    }
}
