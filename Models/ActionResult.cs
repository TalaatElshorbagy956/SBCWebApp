﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCISBCWebApp.Models
{
    public class ActionResult
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}