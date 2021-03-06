﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace UrenRegistratie.Models
{
    [Table(Name = "Registraties")]
    public class Registratie
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int RegId { get; set; }

        [Column]
        public DateTime CheckIn { get; set; }

        [Column]
        public DateTime? CheckOut { get; set; }

        [Column]
        public string Location { get; set; }

        [Column]
        public string ModeOfTransport { get; set; }

        [Column]
        public double Distance { get; set; }

        public Registratie() { }

        public Registratie(string loc, string mot, double dist)
        {
            CheckIn = DateTime.Now;
            CheckOut = null;
            Location = loc;
            ModeOfTransport = mot;
            Distance = dist;
        }

        public string Duration(DateTime end)
        {
            var duration = end - CheckIn;
            return DurationToTime(duration.TotalHours);
        }

        public static string TotalDuration(List<Registratie> regs)
        {
            var total = TotalTimeSpan(regs);
            return DurationToTime(total.TotalHours);
        }

        public static string Difference(List<Registratie> regs)
        {
            return Difference(regs, DateTime.Today);
        }

        /// <summary>
        /// Calculates the difference between the hours worked in a certain period, and the hours that should have been worked
        /// in the period from the start of the contract until end
        /// </summary>
        public static string Difference(List<Registratie> regs, DateTime end)
        {
            var total = TotalTimeSpan(regs);
            var difference = total.TotalHours - Math.Ceiling((end - Contract.Begin).Days / 7.0) * Contract.Uren;
            return DurationToTime(difference);
        }

        private static TimeSpan TotalTimeSpan(List<Registratie> regs)
        {
            var total = new TimeSpan();
            regs.ForEach(r => total += (r.CheckOut ?? DateTime.Now) - r.CheckIn);
            return total;
        }

        private static string DurationToTime(double duration)
        {
            var hrs = Math.Floor(Math.Abs(duration));
            var min = Math.Floor(Math.Abs(duration * 60) % 60);
            return (duration < 0 ? "-" : "") + hrs + ":" + (min < 10 ? "0" : "") + min;
        }

        public override string ToString()
        {
            return $"{CheckIn.ToShortTimeString()} - {CheckOut?.ToShortTimeString()} - {Location}";
        }
    }
}
