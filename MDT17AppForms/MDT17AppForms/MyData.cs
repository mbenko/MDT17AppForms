using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MDT17AppForms
{
    public class MyDataViewModel
    {
        public ObservableCollection<Event> Items { get; set; }

        public string Title { get; set; }
        public int Count { get { return Items.Count; } }

        public MyDataViewModel()
        {
            Title = "Mobile Dev Test 2017";
            Items = new ObservableCollection<Event>();
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "3/24", ImageURL = "minneapolis.png", Venue = "Minneapolis" });
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/11", ImageURL = "desmoines.jpg", Venue = "Des Moines" });
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/12", ImageURL = "omaha.jpg", Venue = "Omaha" });
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/17", ImageURL = "chicago.jpg", Venue = "Chicago" });
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/18", ImageURL = "stlouis.jpg", Venue = "St Louis" });
            Items.Add(new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/19", ImageURL = "kansascity.jpg", Venue = "Kansas City" });
        }
    }
    public class Event
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Venue { get; set; }
        public string ImageURL { get; set; }
        public int Attendees { get; internal set; }
    }
}
