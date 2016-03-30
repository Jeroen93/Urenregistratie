using System;

namespace UrenRegistratie.Models
{
    internal class Addmode : Registratie
    {
        public bool IsAdding { get; set; }
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
                Location = Location,
                ModeOfTransport = ModeOfTransport,
                Distance = Distance
            };
        }

        public bool IsValid(out string reason)
        {
            reason = "De gegevens zijn niet goed ingevuld:" + Environment.NewLine;
            var result = CheckIn.CompareTo(CheckOut) == -1;
            if (!result) reason += " - CheckIn moet voor CheckOut zijn" + Environment.NewLine;
            var valid = result;

            result = CheckIn.Date.Equals(_date);
            if (!result) reason += " - CheckIn moet op dezelfde dag zijn" + Environment.NewLine;
            valid = valid && result;

            if (CheckOut != null) result = CheckOut.Value.Date.Equals(_date);
            if (!result) reason += " - CheckOut moet op dezelfde dag zijn" + Environment.NewLine;
            valid = valid && result;

            result = Location != null;
            if (!result) reason += " - Locatie is niet ingevuld" + Environment.NewLine;
            valid = valid && result;
            return valid;
        }
    }
}
