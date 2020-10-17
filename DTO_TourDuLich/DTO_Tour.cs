using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_TourDuLich
{
    public class DTO_Tour
    {
        
        public int matour { get; set; }
        public string tentour { get; set; }

        public DTO_Tour()
        {

        }
        
        public DTO_Tour(int matour, string tentour)
        {
            this.matour = matour;
            this.tentour = tentour;
        }
    }
}
