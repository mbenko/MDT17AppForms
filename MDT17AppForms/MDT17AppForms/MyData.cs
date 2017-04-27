//using Microsoft.WindowsAzure.MobileServices;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace MDT17AppForms
{
    public class MyDataViewModel
    {
        public MobileServiceClient MobileClient;
        static IMobileServiceTable<Event> EventTable;// = MobileClient.GetTable<Event>();

        public ObservableCollection<Event> Items { get; set; }
        public ObservableCollection<Event> Events { get; set; }
        public string Title { get; set; }
        public int Count { get { return Items.Count; } }

        public MyDataViewModel()
        {
            
            Title = "Mobile Dev Test 2017";
            Events = new ObservableCollection<Event>
            {
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "3/24", ImageURL = "minneapolis.png", Venue = "Minneapolis" },
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/11", ImageURL = "desmoines.jpg", Venue = "Des Moines" },
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/12", ImageURL = "omaha.jpg", Venue = "Omaha" },
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/17", ImageURL = "chicago.jpg", Venue = "Chicago" },
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/18", ImageURL = "stlouis.jpg", Venue = "St Louis" },
                new Event { Name = "VS 2017 Best Of Launch", Attendees = 1, Date = "4/19", ImageURL = "kansascity.jpg", Venue = "Kansas City" }
            };
            //Events = Items;

            try
            {
                if (MobileClient == null)
                    MobileClient = new MobileServiceClient("https://mobile-00542e52-3fe6-450a-a895-f0a89f37240b.azurewebsites.net/");

                EventTable = MobileClient.GetTable<Event>();
            }
            catch (Exception ex)
            {
                var msg = ex;
            }
        }

        public async Task LoadData()
        {
            try
            {
                if (MobileClient == null)
                    MobileClient = new MobileServiceClient("https://mobile-00542e52-3fe6-450a-a895-f0a89f37240b.azurewebsites.net/");
                var data = await EventTable.ToCollectionAsync<Event>();
                Events.Clear();
                foreach (var item in data)
                    Events.Add(item);
            }
            catch (Exception ex)
            {
                var msg = ex;
                //throw;
            }


        }

        public async Task InsertItem(Event item)
        {
            if (item.Id == null)
                item.Id = Guid.NewGuid().ToString();
            await EventTable.InsertAsync(item);
            await LoadData();
        }


        public async Task UpdateItem(Event item)
        {
            try
            {
                if (item.Id == null)
                    await InsertItem(item);
                else
                    await EventTable.UpdateAsync(item);

                await LoadData();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
    public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Venue { get; set; }
        public string ImageURL { get; set; }
        public int Attendees { get; internal set; }
        public Event()
        {
            ImageURL = "NewEvent.jpg";
        }
    }
}
