using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static DatabaseContext context;
        private static object _lockSync = new object();
        protected RepositoryBase()
        {//new lenmesin die protected kullandik örn ogrenci s=new ogrenci deki new gibi olmicak bunda

            CreateContext();
        }
        private void CreateContext()
        {
            if (context == null)
            {
                lock (_lockSync)
                {//lock tek bir parçacik kullanir maltat trad uygulamalar
                    if (context == null)
                    {
                        context = new DatabaseContext();
                    }
                }
            }
        }
    }
}
