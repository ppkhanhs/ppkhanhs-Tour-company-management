﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QL_TOUR
{
    class LoaiTour_BLL
    {
        LoaiTour_DAL dalLoaiiTour; 
        public LoaiTour_BLL()
        {
            dalLoaiiTour = new LoaiTour_DAL();
        }

        public DataTable GetAllLTour()
        {
            return dalLoaiiTour.GetAllLTour();
        }

    }
}
