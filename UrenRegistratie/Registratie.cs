using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace UrenRegistratie
{
    [Table(Name="Registraties")]
    public class Registratie
    {
        [Column(IsPrimaryKey=true, IsDbGenerated=true)]
        public int regId {get; set; }

        [Column]
        public DateTime checkIn { get; set; }
        [Column]
        public DateTime? checkOut { get; set; }

        public string duration(DateTime end)
        {
            var duration = end - checkIn;
            return durationToTime(duration);
        }

        public static string totalDuration(List<Registratie> regs)
        {
            var total = new TimeSpan();
            regs.ForEach(r => total += r.checkOut != null ? (TimeSpan)(r.checkOut - r.checkIn) : DateTime.Now - r.checkIn);
            return durationToTime(total);
        }

        public static string difference(List<Registratie> regs)
        {
            var total = new TimeSpan();
            regs.ForEach(r => total += r.checkOut != null ? (TimeSpan)(r.checkOut - r.checkIn) : DateTime.Now - r.checkIn);
            var difference = total.TotalHours - (double)(Math.Ceiling((decimal)(DateTime.Today - Contract.Begin).Days / 7) * Contract.Uren);
            var hrs = Math.Floor(Math.Abs(difference));
            var min = Math.Floor(Math.Abs(difference * 60) % 60);
            return (difference < 0 ? "-" : "+") + hrs + ":" + (min < 10 ? "0" : "") + min;
        }

        private static string durationToTime(TimeSpan duration)
        {
            var hrs = Math.Floor(Math.Abs(duration.TotalHours));
            var min = Math.Floor(Math.Abs(duration.TotalMinutes) % 60);
            return (duration.TotalHours < 0 ? "-" : "") + hrs + ":" + (min < 10 ? "0" : "") + min;
        }
    }
}
