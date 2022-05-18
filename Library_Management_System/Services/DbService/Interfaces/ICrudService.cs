using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Services.DbService.Interfaces
{
    public class ICrudService<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
        TGetByName(string entityName);
        void Delete(int entityId);



    }
}
