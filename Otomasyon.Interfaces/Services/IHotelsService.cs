using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Interfaces.Services
{
   public interface IHotelsService:IGenericServiceIF<Hotels>
    {
        bool HotelsRegister(HotelsViewModel hotels);
        bool HotelsUpdate(HotelsViewModel hotels);

    }
}
