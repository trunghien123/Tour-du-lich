using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_TourDuLich;
using DTO_TourDuLich;
namespace BUS_TourDuLich
{
    public class BUS_Tour
    {
        DAL_Tour dalTour = new DAL_Tour();

        public DataSet getTour()
        {
            return dalTour.getTour();
        }

        public bool themTour(DTO_Tour tour)
        {
            return dalTour.themTour(tour);
        }

        public bool suaTour(DTO_Tour tour)
        {
            return dalTour.suaTour(tour);
        }

        public bool xoaTour(int matour)
        {
            return dalTour.xoaTour(matour);
        }
    }
}
