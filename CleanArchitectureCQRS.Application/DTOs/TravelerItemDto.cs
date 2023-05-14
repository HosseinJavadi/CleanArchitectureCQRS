using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Application.DTOs
{
    public class TravelerItemDto
    {
        public string Name { get; set; }
        public uint Quaintity { get; set; }
        public bool IsTaken { get; set; }

    }
}
