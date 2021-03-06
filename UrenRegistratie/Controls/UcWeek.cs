﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UrenRegistratie.Layers;
using UrenRegistratie.Models;

namespace UrenRegistratie.Controls
{
    public delegate void SetFormDelegate();

    public partial class UcWeek : UserControl
    {
        private List<List<Registratie>> _registraties;
        private DateTime _selectedWeek;
        public SetFormDelegate SetFormOnMain;

        public UcWeek()
        {
            InitializeComponent();
            _selectedWeek = DateTime.Today;
            btnPrevWeek.Click += (s, e) => ChangeWeek(-1);
            btnThisWeek.Click += (s, e) => ChangeWeek(0);
            btnNextWeek.Click += (s, e) => ChangeWeek(1);
        }

        public void Init()
        {
            _registraties = Data.SortByDaysOfWeek(Data.GetRegsForWeek(_selectedWeek));
            var sunday = _selectedWeek.SetDayOfWeek(0);
            var ucDays = Controls.OfType<UcDay>().ToList();
            ucDays.ForEach(d => d.SetFormOnMain -= SetFormOnMain);
            for (var i = 0; i < 7; i++)
            {
                //Gets the UcDay with the name containing the day of the week number, and give it the registrations belonging to that day
                var day = ucDays.First(u => u.Name.Contains(i.ToString()));
                day.SetRegistrations(_registraties[i], sunday.AddDays(i));
                day.SetFormOnMain += SetFormOnMain;
            }
        }

        private void ChangeWeek(int week)
        {
            _selectedWeek = week == 0 ? DateTime.Today : _selectedWeek.AddDays(week * 7);
            Init();
        }
    }
}
