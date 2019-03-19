﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClassLib
{
    public class Packages
    {
        //PackageId
        //PkgName
        //PkgStartDate
        //PkgEndDate
        //PkgDesc
        //PkgBasePrice
        //PkgAgencyCommission
        public int PackageId { get; set; }

        public string PkgName { get; set; }

        public DateTime? PkgStartDate { get; set; }

        public DateTime? PkgEndDate { get; set; }

        public string PkgDesc { get; set; }

        public decimal PkgBasePrice { get; set; }

        public decimal PkgAgencyCommission { get; set; }

    }
}
