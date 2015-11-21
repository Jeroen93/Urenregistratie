using System;
using System.Text;
// ReSharper disable PossibleInvalidOperationException

namespace UrenRegistratie
{
    public static class Export
    {
        public static bool CanGenerate(DateTime dt)
        {
            return Data.GetRegsForMonth(dt).Count > 0;
        }

        public static string GenerateOverview(DateTime dt)
        {
            if (!CanGenerate(dt)) return "";
            var regs = Data.GetRegsForMonth(dt);
            const string line = "\n";
            //var periodstr = "26 " + dt.AddMonths(-1).ToString("MMMM") + " tot 25 " + dt.ToString("MMMM yyyy");
            var periodstr = dt.ToString("MMMM yyyy");
            var sb = new StringBuilder();

            sb.Append(line);
            sb.Append(";Periode:;;").Append(periodstr + line);
            sb.Append(line);
            sb.Append(";Dag:;;Ingeklokt:;Uitgeklokt:;Duur:;Waar:;;Vervoer:;Km:" + line);
            foreach (var r in regs)
            {
                sb.Append(";").Append(r.CheckIn.ToString("dddd d-M")).Append(";;");
                sb.Append(r.CheckIn.ToShortTimeString()).Append(";");
                sb.Append(r.CheckOut.Value.ToShortTimeString()).Append(";");
                sb.Append(r.Duration(r.CheckOut.Value)).Append(";");
                sb.Append(r.Location).Append(";;");
                sb.Append(r.ModeOfTransport).Append(";");
                sb.Append(r.Distance + line);
            }
            sb.Append(";;;;Totaal:;").Append(Registratie.TotalDuration(regs) + line);
            sb.Append(line);
            sb.Append(";Overuren:;;").Append(Registratie.Difference(Data.All()) + line);
            sb.Append(";Totaal gewerkt:;;").Append(Registratie.TotalDuration(Data.All()) + line);

            return sb.ToString();
        }
    }
}
