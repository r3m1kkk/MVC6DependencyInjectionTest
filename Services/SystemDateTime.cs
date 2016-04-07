using System;
using MyWebApp.Interfaces;

namespace MyWebApp.Services
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}