using System;
namespace academia
{
    public interface IDao<T>    {
        public bool save(T o);
        public bool merge(T o);
        public bool delete(T o);
        public List<T> findAll();

    }

    


}