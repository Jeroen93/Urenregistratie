using System;

namespace UrenRegistratie.Models
{
    internal class Addmode
    {
        public bool IsAdding { get; set; }
        public string Loc { get; set; }
        public string Transport { get; set; }
        public double Distance { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        private readonly DateTime _date;

        public Addmode(DateTime date)
        {
            _date = date;
        }

        public Registratie ToRegistratie()
        {
            return new Registratie
            {
                CheckIn = CheckIn,
                CheckOut = CheckOut,
                Location = Loc,
                ModeOfTransport = Transport,
                Distance = Distance
            };
        }

        public bool IsValid()
        {
            var valid = CheckIn.CompareTo(CheckOut) == -1;
            valid = valid && CheckIn.Date.Equals(_date);
            valid = valid && CheckOut.Date.Equals(_date);
            valid = valid && Loc != null;
            return valid;
        }
    }
}
