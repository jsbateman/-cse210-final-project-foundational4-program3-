using System.ComponentModel;

protected class Event
{
    string EventTitle = "";
    string EventDescription = "";
    string Date = "";
    string Time = "";
    string Address = "";
    string EventType = "";
    string Speaker = "";
    string StandardDetails(string Title, string Description, string date, string time, string address)
    {Title = EventTitle;
    Description = EventDescription;
    date = Date;
    time = Time;
    address = Address;
    string _StandardDetails = $"Event Title: {Title} Event Description: {Description} Date: {date} Time: {time} Address {address}";
    return _StandardDetails;
    }

    string _FullDetails(string Title,int capacity, string Weather,string RSVPemail, string speaker, string Description, string date, string time, string address, string eventtype)
    {Title = EventTitle;
    Description = EventDescription;
    date = Date;
    time = Time;
    address = Address;
    eventtype = EventType;
    speaker = Speaker;
    capacity = Capacity;
    RSVPemail = email;
    Weather = weather;
    string _FullDetails = $"Event Type: {eventtype} RSVP Email: {RSVPemail} Capacity: {capacity} Event Title: {Title} Event Description: {Description} Event Speaker: {speaker} Date: {date} Weather: {Weather} Time: {time} Address {address}";
    return _FullDetails;
    }
    string _shortDescription (string Title, string eventtype, string date)
    {date = Date;
    Title = EventTitle;
    eventtype = EventType;
    string _shortDescription = $"Event Type: {eventtype} Event Title: {Title} Date: {date}";
    return _shortDescription;
    }
    }

    