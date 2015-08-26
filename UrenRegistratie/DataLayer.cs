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
            ConnectionString = @"Data Source=.\RECORNECT;Initial Catalog=JeroenTest;Integrated Security=True";
            context = new DataContext(ConnectionString);
            try
            {
                table = context.GetTable<Registratie>();
                table.ToList();
                IsConnected = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Geen verbinding met database! " + e.Message);
            }
        }

        public static bool IsLoggedIn()
        {
            try
            {
                var openReg = table.Where(r => r.checkOut == null).First();
                return true;
            }
            catch { return false; }
        }

        public static Registratie GetOpenReg()
        {
            try
            {
                return table.Where(r => r.checkOut == null).First();
            }
            catch { return null; }
        }

        public static bool CheckIn()
        {
            if (IsLoggedIn()) return false;
            var reg = new Registratie();
            reg.checkIn = DateTime.Now;
            reg.checkOut = null;
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
    }
}
