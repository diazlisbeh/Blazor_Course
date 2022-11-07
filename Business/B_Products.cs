using Blazor_Course.DataAccess;
using Blazor_Course.Entities;
namespace Blazor_Course.Business
{
    public class B_Products
    {
         public List<ProductEntity> GetAll(){
        using(var db = new InventaryContext()){
            return db.Products.ToList();
        }
    }

    public void Create(ProductEntity oProduct){
        using(var db = new InventaryContext()){
            db.Products.Add(oProduct);
            db.SaveChanges();

        }


    }

    public void Update(ProductEntity oProduct){
        using(var db = new InventaryContext()){
            db.Products.Update(oProduct);
            db.SaveChanges();

        }
    }
    }
}