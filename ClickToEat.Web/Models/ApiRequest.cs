﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ClickToEat.Web.SD;

namespace ClickToEat.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
