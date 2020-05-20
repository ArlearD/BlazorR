using System;
using System.Collections.Generic;
using System.Text;

namespace BlazoR.Data.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAlElements();
        void Create(T obj);
        T GetElementById(long id);
        void Update(T obj);
        void DeleteById(long id);
        void Save();
    }
}
