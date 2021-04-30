using DataAccessLayer.Abstrack;
using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHotelGalleryRepository : EfGenericRepository2<HotelsGallery>, IHotelGalleryRepository
    {
    }
}
