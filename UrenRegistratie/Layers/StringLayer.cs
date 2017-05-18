using System;
using System.Windows.Forms.DataVisualization.Charting;
using UrenRegistratie.Models;

namespace UrenRegistratie.Layers
{
    public static class StringLayer
    {
        public static string GetLblOnlineString(Registratie reg)
        {
            if (reg.CheckOut == null)
            {
                var checkIn = reg.CheckIn;
                return
                    $"Aanwezig sinds {checkIn.ToShortTimeString()}    ({Registratie.TotalDuration(Data.GetRegsForDay(checkIn))})";
            }
            var r = (DateTime) reg.CheckOut;
            return $"Laatst uitgeklokt op {r.ToShortDateString()} om {r.ToShortTimeString()}";
        }

        public static string GetToolTip(DataPoint prop)
        {
            var dt = DateTime.FromOADate(prop.XValue);
            var dtBegin = dt.SetDayOfWeek(0);
            var dtEnd = dt.SetDayOfWeek(6);
            var dtBeginStr = dtBegin.Month == dtEnd.Month ? dtBegin.Day.ToString() : dtBegin.ToString("d MMMM");
            return $"{dtBeginStr} tot {dtEnd.ToString("d MMMM yyyy")}; {prop.YValues[0]} uur";
        }
    }
}
