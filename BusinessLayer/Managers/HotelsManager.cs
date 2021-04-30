using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Models;
using Entity.ViewModels;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class HotelsManager : GenericManager<Hotels>, IHotelsService
    {
        EfHotelsRepository efHotelsRepository = new EfHotelsRepository();

     
        public bool HotelsRegister(HotelsViewModel hotels)
        {
            return efHotelsRepository.HotelsRegister(hotels);
        }

        public bool HotelsUpdate(HotelsViewModel hotels)
        {
            return efHotelsRepository.HotelsUpdate(hotels);
        }
    }
}
