using Blazor_Course.DataAccess;
using Blazor_Course.Entities;
namespace Blazor_Course.Business
{
    public static class B_Products
    {
         public static List<ProductEntity> GetAll(){
        using(var db = new InventaryContext()){
            return db.Products.ToList();
        }
    }

    public  static async void  Create(ProductEntity oProduct){
        using(var db = new InventaryContext()){
            db.Products.Add(oProduct);
            await db.SaveChangesAsync();

        }


    }

    public static void Update(ProductEntity oProduct){
        using(var db = new InventaryContext()){
            db.Products.Update(oProduct);
            db.SaveChanges();

        }
    }
    }
}