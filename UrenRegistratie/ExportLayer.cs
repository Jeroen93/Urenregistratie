using System;
using System.Text;

namespace UrenRegistratie
{
    public static class Export
    {
        public static string GenerateOverview(DateTime dt)
        {
            var regs = Data.GetRegsForMonth(dt);
            var line = ";;;;;\n";
            var sb = new StringBuilder();

            sb.Append(line);
            sb.Append(";Periode:;").Append(dt.ToString("MMMM yyyy")).Append(";;;\n");
            sb.Append(line);
            sb.Append(";Dag:;Ingeklokt:;Uitgeklokt:;Duur:;Waar:\n");
            foreach (var reg in regs)
            {
                sb.Append(";").Append(reg.checkIn.ToString("dddd d-M")).Append(";");
                sb.Append(reg.checkIn.ToShortTimeString()).Append(";");
                sb.Append(reg.checkOut.Value.ToShortTimeString()).Append(";");
                sb.Append(reg.duration(reg.checkOut.Value)).Append(";");
                sb.Append(reg.location + "\n");
            }
            sb.Append(";;;Totaal:;").Append(Registratie.TotalDuration(regs)).Append(";\n");
            sb.Append(line);
            sb.Append(";Overuren:;").Append(Registratie.Difference(Data.All())).Append(";;;\n");
            sb.Append(";Totaal gewerkt:;").Append(Registratie.TotalDuration(Data.All())).Append(";;;\n");

            return sb.ToString();
        }
    }
}
