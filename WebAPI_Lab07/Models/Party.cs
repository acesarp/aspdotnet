using System;

namespace WebAPI_Lab07.Models {

    public class Party {

        public Party(int id, string name, DateTime date, int numOfGuests, string location){ 
            PartyId = id;
            PartyName = name;
            PartyDate = date;
            NumberOfGuests = numOfGuests;
            Location = location;

        }

        public int PartyId { get; set; }
        string PartyName { get; set; }
        public DateTime PartyDate { get; set; }
        public int NumberOfGuests {get; set;}
        public string Location {get; set;}
    }
}
