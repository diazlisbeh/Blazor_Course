using Blazor_Course.DataAccess;
using Blazor_Course.Entities;
namespace Blazor_Course.Business
{
    public class B_Wherehouse
    {
        
         public List<WherehouseEntity> GetAll(){
        using(var db = new InventaryContext()){
            return db.Wherehouses.ToList();
        }
    }

    public void Create(WherehouseEntity oWherehouse){
        using(var db = new InventaryContext()){
            db.Wherehouses.Add(oWherehouse);
            db.SaveChanges();

        }


    }

    public void Update(WherehouseEntity oWherehouse){
        using(var db = new InventaryContext()){
            db.Wherehouses.Update(oWherehouse);
            db.SaveChanges();

        }
    }
    }
}