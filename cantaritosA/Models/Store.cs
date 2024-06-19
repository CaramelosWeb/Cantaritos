using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantaritosA.Models
{
    public class Store
    {
        public int Id { get; set; }
        public required string header { get; set; }
        public required string producto { get; set; }
        public int costo { get; set; }
        public double puntuacion { get; set; }
    }
}
