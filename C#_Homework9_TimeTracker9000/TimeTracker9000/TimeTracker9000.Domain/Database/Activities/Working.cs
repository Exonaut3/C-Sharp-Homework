using TimeTracker9000.Domain.Database.Activities.ActivityBaseFolder;
using TimeTracker9000.Domain.Database.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.Database.Activities
{
    public class Working : ActivitiesBase
    {
        public string Title = "Working";
        public WorkingTypes Place { get; set; }
    }
}
