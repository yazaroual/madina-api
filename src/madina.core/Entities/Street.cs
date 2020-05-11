using Madina.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madina.Core.Entities
{
    public class Street
    {
        public string Name { get; set; }
        public List<Coordinate> Path { get; set; }
        public Gender StreetNameGender { get; set; }
    }
}
