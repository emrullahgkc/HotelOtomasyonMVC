using DataAccessLayer.Abstrack;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository /*:*/
        //EfGenericRepository<Personels>, IProductRepository
    {
        public EfProductRepository() : base()
        {

        }

        //public bool ProductDelete(int ProductId)
        //{
        //    return context.Database.ExecuteSqlCommand("delete from Product where Id={0}", ProductId) > 0;
        //}

        //public List<Product> ProductGetAll()
        //{
        //    return context.Product.ToList();
        //}
        //public IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, TResult>> select)
        //{
        //    return context.Set<ProductViewModel>().Select(select);    
                
                
        //        }

        //public IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, bool>> predicate, Expression<Func<ProductViewModel, TResult>> select)
        //{
        //    return context.Set<ProductViewModel>().Where(predicate).Select(select).Cast<TResult>();
        //}

        //public List<ProductViewModel> ProductList()
        //{
        //    string sql = @" select
        //                                        p.Id as ProducID,p.ProductPhoto,
        //                                        p.ProductNo,p.ProductBarcode,p.ProductName,p.ProductExplanation,p.Price,p.Stock,p.CreatedOn,
        //                                        pc.CategoryName,h.HotelName
        //                                        from Product p
        //                                        left outer join ProductCategory pc on(pc.Id= p.Categoryid)
        //                                        left outer join Hotels h on(h.Id= p.Hotelid)
        //                                        where h.IsAktive= 1
        //                                        order by p.ProductName";
        //    return context.Database.SqlQuery<ProductViewModel>(sql).ToList();
        //}

        //public List<ProductViewModel> ProductList(int id)
        //{
        //    string sql =@" select
        //                                        p.Id as ProducID,p.ProductPhoto,
        //                                        p.ProductNo,p.ProductBarcode,p.ProductName,p.ProductExplanation,p.Price,p.Stock,p.CreatedOn,
        //                                        pc.CategoryName,h.HotelName
        //                                        from Product p
        //                                        left outer join ProductCategory pc on(pc.Id= p.Categoryid)
        //                                        left outer join Hotels h on(h.Id= p.Hotelid)
        //                                        where h.IsAktive= 1 and Categoryid='"+id+"'order by p.ProductName";
        //    return context.Database.SqlQuery<ProductViewModel>(sql,id).ToList();
        //}

        //public List<ProductViewModel> ProductListLnq(int Categoryid)

        //{
        //    return context.Product.Where(x => x.Categoryid == Categoryid)
        //       .Join(context.ProductCategory, s => s.Categoryid, t=>t.Id, (s, t) => new { s, t })
        //       .Join(context.Hotels, s1 => s1.s.Hotelid, t1 => t1.Id, (s1, t1) => new ProductViewModel()
        //       {
        //         ProductName=s1.s.ProductName,
        //         ProductBarcode=s1.s.ProductBarcode,
        //         ProductExplanation=s1.s.ProductExplanation,
        //         ProducID=s1.s.Id,
        //         ProductNo=s1.s.ProductNo,
        //         ProductPhoto=s1.s.ProductPhoto,
        //         Price=s1.s.Price??0,
        //         CategoryName=s1.t.CategoryName,
        //         HotelName=t1.HotelName,
        //           Stock=s1.s.Stock??0,
        //           CreatedOn=s1.s.CreatedOn.Value

        //       }).OrderBy(x => x.CategoryName).ThenBy(c => c.HotelName).ToList();


        //    throw new NotImplementedException();
        //}

        //public bool ProductRegister(Product product)
        //{

        //    return false;
        //}

        //public bool ProductUpdate(Product product)
        //{
        //    const string sql = "update Product set ProductNo={0},ProductName={1}, ProductExplanation={2},ProductPhoto={3},ProductBarcode={4},Stock={5},Price={6},IsCampaign={7} where Id={8}";
        //    return context.Database.ExecuteSqlCommand(sql, product.ProductNo, product.ProductName, product.ProductExplanation, product.ProductPhoto, product.ProductBarcode, product.Stock, product.Price, product.IsCampaign, product.Id) > 0;
        //}
    }
}
