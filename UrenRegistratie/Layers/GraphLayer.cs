using System;
using System.Windows.Forms.DataVisualization.Charting;
using UrenRegistratie.Models;

namespace UrenRegistratie.Layers
{
    public static class GraphLayer
    {
        public static Series GetSeries(Func<DateTime, double> method)
        {
            var todayInTwoWeeks = DateTime.Today.SetDayOfWeek(3).AddDays(14);
            var s = new Series
            {
                ChartType = SeriesChartType.Spline,
                XValueType = ChartValueType.DateTime,
                MarkerStyle = method == WorkedHours ? MarkerStyle.Square : MarkerStyle.None,
            };
            var d = new DateTime(DateTime.Today.Year, 1, 1).SetDayOfWeek(3);

            do
            {
                s.Points.AddXY(d, method(d));
                d = d.AddDays(7);
            } while (!d.Equals(todayInTwoWeeks));
            return s;
        }

        public static double WorkedHours(DateTime d)
        {
            return Convert.ToDouble(Registratie.TotalDuration(Data.GetRegsForWeek(d)).Replace(':', ','));
        }

        public static double HoursByContract(DateTime d)
        {
            return d.CompareTo(Contract.Begin) == 1 && d.CompareTo(Contract.End) == -1 ? Contract.Uren : 0.0;
        }
    }
}
