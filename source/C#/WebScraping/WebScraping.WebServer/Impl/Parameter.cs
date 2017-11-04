﻿using System;

namespace WebScraping.WebServer.Impl
{
    class Parameter
    {
        public String Key { get; set; }
        public String Code { get; set; }
        public String Id { get; set; }
        public String Starttime { get; set; }
        public String Pingtime { get; set; }
        public String Status { get; set; }
        public override string ToString()
        {
            return "Code=" + Code + "&Id=" + Id;
        }
    }
}
