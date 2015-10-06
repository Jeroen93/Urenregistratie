using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public static class Data
    {
        public static string ConnectionString;
        public static bool IsConnected = false;
        private static DataContext context;
        private static Table<Registratie> table;

        public static void Initialise()
        {
#if DEBUG
            ConnectionString = @"Data Source=.\RECORNECT;Initial Catalog=JeroenTest;Integrated Security=True";
#else
            ConnectionString = @"Data Source=.\RECORNECT;Initial Catalog=JeroenDB;Integrated Security=True";
#endif
            context = new DataContext(ConnectionString);
            try
            {
                table = context.GetTable<Registratie>();
                table.ToList(); //Hacky method to check if the connection is made. Will raise exception if no valid connection available
                IsConnected = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Geen verbinding met database: " + e.Message, "Geen verbinding!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseConnection()
        {
            context.Connection.Close();
            context.Dispose();
        }

        public static bool IsLoggedIn()
        {
            return GetOpenReg() != null;
        }

        public static Registratie GetOpenReg()
        {
            try
            {
                return table.Where(r => !r.checkOut.HasValue).First();
            }
            catch { return null; }
        }

        public static bool CheckIn(string location, string modeOfTransport, double dist)
        {
            if (IsLoggedIn()) return false;
            var reg = new Registratie();
            reg.checkIn = DateTime.Now;
            reg.checkOut = null;
            reg.location = location;
            reg.modeOfTransport = modeOfTransport;
            reg.distance = dist;
            table.InsertOnSubmit(reg);
            context.SubmitChanges();
            return true;
        }

        public static bool CheckOut()
        {
            if (!IsLoggedIn()) return false;
            var openReg = GetOpenReg();
            openReg.checkOut = DateTime.Now;
            context.SubmitChanges();
            return true;
        }

        public static bool Update(DateTime registration)
        {
            if (registration == null) return false;
            var reg = Last();
            if (IsLoggedIn())
            {
                reg.checkIn = registration;
            }
            else
            {
                reg.checkOut = registration;
            }
            context.SubmitChanges();            
            return true;
        }

        public static Registratie Last()
        {
            try
            {
                return table.OrderByDescending(r => r.regId).First();
            }
            catch { return null; }
        }

        public static List<Registratie> GetRegsForWeek()
        {
            var now = DateTime.Today;            
            var begin = now.AddDays(-(double)now.DayOfWeek);
            var end = begin.AddDays(7);
            return table.Where(r => r.checkIn.CompareTo(begin) != -1).ToList();
        }

        public static List<Registratie> All()
        {
            return table.ToList();
        }

        public static List<Registratie> GetRegsForMonth(DateTime dt)
        {
            return table.Where(r => ((r.checkIn.Month == dt.Month-1 && r.checkIn.Day > 25) || (r.checkIn.Month == dt.Month && r.checkIn.Day <= 25)) 
                && (r.checkIn.Year == dt.Year) 
                && r.checkOut.HasValue)
                .ToList();
        }

        public static List<Registratie> GetRegsForDay(DateTime dt)
        {
            return table.Where(r => r.checkIn.Date == dt.Date).ToList();
        }
    }
}
