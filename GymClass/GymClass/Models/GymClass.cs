﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymClass.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; }  }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
    }
}