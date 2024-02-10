using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructYapi.Models
{
    internal struct Telefon
    {
        public decimal Fiyati;
        public string Model { get; set; }
        public string Marka;
        public int Hafiza;
    }
}
