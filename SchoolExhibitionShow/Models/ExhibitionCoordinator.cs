using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolExhibition.Models
{
    public class ExhibitionCoordinator
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public string Name { get; set; }

        public Class Class { get; set; }
    }
}
