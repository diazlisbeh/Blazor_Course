using Blazor_Course.DataAccess;
using Blazor_Course.Entities;
namespace Blazor_Course.Business
{
    public class Storage
    {
         public List<StorageEntity> GetAll(){
        using(var db = new InventaryContext()){
            return db.Storages.ToList();
        }
    }

    public void Create(StorageEntity oStorage){
        using(var db = new InventaryContext()){
            db.Storages.Add(oStorage);
            db.SaveChanges();

        }


    }

    public void Update(StorageEntity oStorage){
        using(var db = new InventaryContext()){
            db.Storages.Update(oStorage);
            db.SaveChanges();

        }
    }
    }
}