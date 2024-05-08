using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityBase;
using TimeTracker9000.Domain.MainMenu.The_Tracker.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.MainMenu.The_Tracker.Activities
{
    public class Working : ActivitiesBase
    {
        public string Title = "Working";
        public WorkingTypes Place {  get; set; }
    }
}
