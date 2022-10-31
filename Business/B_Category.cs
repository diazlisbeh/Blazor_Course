

using Blazor_Course.DataAccess;
using Blazor_Course.Entities;

namespace Blazor_Course.Business;

public class B_Category{

    public List<CategoryEntity> GetAll(){
        using(var db = new InventaryContext()){
            return db.Categories.ToList();
        }
    }

    public void Create(CategoryEntity oCategory){
        using(var db = new InventaryContext()){
            db.Categories.Add(oCategory);
            db.SaveChanges();

        }


    }
}