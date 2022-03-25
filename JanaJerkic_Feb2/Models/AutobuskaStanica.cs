using System;
using System.Collections.Generic;
using System.Text;

namespace JanaJerkic_Feb2.Models
{
    public class AutobuskaStanica
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Grad { get; set; }
        public string KratkiOpis { get; set; }
        public string Fotografija { get; set; }
        public string DugiOpis { get; set; }
        public double CijenaPoKM { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
