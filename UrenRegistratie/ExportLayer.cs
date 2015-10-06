using System;
using System.Text;

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
            var line = "\n";
            var periodstr = "26 " + dt.AddMonths(-1).ToString("MMMM") + " tot 25 " + dt.ToString("MMMM yyyy");
            var sb = new StringBuilder();

            sb.Append(line);
            sb.Append(";Periode:;;").Append(periodstr + line);
            sb.Append(line);
            sb.Append(";Dag:;;Ingeklokt:;Uitgeklokt:;Duur:;Waar:;;Vervoer:;Km:" + line);
            foreach (var reg in regs)
            {
                sb.Append(";").Append(reg.checkIn.ToString("dddd d-M")).Append(";;");
                sb.Append(reg.checkIn.ToShortTimeString()).Append(";");
                sb.Append(reg.checkOut.Value.ToShortTimeString()).Append(";");
                sb.Append(reg.duration(reg.checkOut.Value)).Append(";");
                sb.Append(reg.location).Append(";;");
                sb.Append(reg.modeOfTransport).Append(";");
                sb.Append(reg.distance + line);
            }
            sb.Append(";;;;Totaal:;").Append(Registratie.TotalDuration(regs) + line);
            sb.Append(line);
            sb.Append(";Overuren:;;").Append(Registratie.Difference(Data.All()) + line);
            sb.Append(";Totaal gewerkt:;;").Append(Registratie.TotalDuration(Data.All()) + line);

            return sb.ToString();
        }
    }
}
