﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using UrenRegistratie.Models;

namespace UrenRegistratie.Layers
{
    public static class Data
    {
        public static string ConnectionString;
        public static bool IsConnected;
        public static bool DbEmpty;
        private static DataContext _context;
        private static Table<Registratie> _table;

        public static void Initialise()
        {
            ConnectionString = @"Data Source=.\RECORNECT;Initial Catalog=JeroenDB;Integrated Security=True";
#if DEBUG
            ConnectionString = ConnectionString.Replace("JeroenDB", "JeroenTest");
#endif
            _context = new DataContext(ConnectionString);
            try
            {
                _table = _context.GetTable<Registratie>();
                DbEmpty = _table.ToList().Count == 0;
                IsConnected = true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Geen verbinding met database: {e.Message}", @"Geen verbinding!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseConnection()
        {
            _context.Connection.Close();
            _context.Dispose();
            _table = null;
            _context = null;
        }

        public static bool IsLoggedIn()
        {
            return GetOpenReg() != null;
        }

        private static Registratie GetOpenReg()
        {
            try
            {
                return _table.First(r => !r.CheckOut.HasValue);
            }
            catch { return null; }
        }

        public static bool CheckIn(string location, string modeOfTransport, double dist)
        {
            if (IsLoggedIn()) return false;
            var reg = new Registratie(location, modeOfTransport, dist);
            return Add(reg);
        }

        public static bool CheckOut()
        {
            if (!IsLoggedIn()) return false;
            var openReg = GetOpenReg();
            openReg.CheckOut = DateTime.Now;
            return SubmitChanges();
        }

        public static bool Add(Registratie reg)
        {
            _table.InsertOnSubmit(reg);
            return SubmitChanges();
        }

        public static bool Update(DateTime time)
        {
            var reg = Last();
            if (IsLoggedIn())
            {
                reg.CheckIn = time;
            }
            else
            {
                reg.CheckOut = time;
            }
            return SubmitChanges();
        }

        public static bool SubmitChanges()
        {
            try
            {
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(Registratie reg)
        {
            if (reg == null) return false;
            _table.DeleteOnSubmit(reg);
            return SubmitChanges();
        }

        public static Registratie Last()
        {
            try
            {
                return _table.OrderByDescending(r => r.RegId).First();
            }
            catch { return null; }
        }

        public static List<Registratie> GetRegsForWeek(DateTime d)
        {
            var begin = d.Date.AddDays(-(double)d.Date.DayOfWeek);
            var end = begin.AddDays(7);
            return GetRegsForPeriod(begin, end);
        }

        public static List<Registratie> GetRegsForPeriod(DateTime begin, DateTime end)
        {
            return _table.Where(r => r.CheckIn.CompareTo(begin) != -1 && (r.CheckOut ?? DateTime.Now).CompareTo(end) != 1).ToList();
        } 

        public static List<Registratie> All()
        {
            return _table.ToList();
        }

        public static List<Registratie> GetRegsForMonth(DateTime dt)
        {
            return _table.Where(r => (r.CheckIn.Month == dt.Month) && (r.CheckIn.Year == dt.Year) && r.CheckOut.HasValue).ToList();
            //return table.Where(r => ((r.checkIn.Month == dt.Month-1 && r.checkIn.Day > 25) || (r.checkIn.Month == dt.Month && r.checkIn.Day <= 25)) 
            //    && (r.checkIn.Year == dt.Year) 
            //    && r.checkOut.HasValue)
            //    .ToList();
        }

        public static List<Registratie> GetRegsForDay(DateTime dt)
        {
            return _table.Where(r => r.CheckIn.Date == dt.Date).ToList();
        }

        public static DateTime SetDayOfWeek(this DateTime dt, double days)
        {
            return dt.AddDays(-(double) dt.DayOfWeek + days);
        }

        public static List<List<Registratie>> SortByDaysOfWeek(List<Registratie> regs)
        {
            var result = new List<List<Registratie>>();
            for (var i = 0; i < 7; i++)
            {
                result.Add(new List<Registratie>());
            }
            regs.ForEach(r => result[(int)r.CheckIn.DayOfWeek].Add(r));
            return result;
        }
    }
}
