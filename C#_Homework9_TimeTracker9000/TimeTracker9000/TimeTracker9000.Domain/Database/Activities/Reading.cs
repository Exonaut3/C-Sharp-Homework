using TimeTracker9000.Domain.Database.Activities.ActivityBaseFolder;
using TimeTracker9000.Domain.Database.Activities.ActivityEnums;

namespace TimeTracker9000.Domain.Database.Activities
{
    public class Reading : ActivitiesBase
    {
        public string Title = "Reading";
        public int NumberOfPages { get; set; }
        public ReadingTypes TypeOfReading { get; set; }

    }
}
