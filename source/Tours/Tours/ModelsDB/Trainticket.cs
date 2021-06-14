using System;
using System.Collections.Generic;

#nullable disable

namespace Tours
{
    public partial class Trainticket
    {
        public Trainticket()
        {
            Transfers = new HashSet<Transfer>();
        }

        public int Traintid { get; set; }
        public int? Train { get; set; }
        public int? Coach { get; set; }
        public int? Seat { get; set; }
        public string Cityfrom { get; set; }
        public string Cityto { get; set; }
        public TimeSpan? Departuretime { get; set; }
        public TimeSpan? Arrivaltime { get; set; }
        public bool? Linens { get; set; }
        public int? Cost { get; set; }

        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
