using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeforeBuying.Model;

namespace BeforeBuying.Business
{
    public class DBRepository
    {
        private BeforeBuying.Model.BeforeBuyingContainer _context = null;

        public DBRepository()
        {
            _context = new BeforeBuyingContainer();
        }

        public T GetData<T>(int id)
        {
            
            var value = _context.ItemSet.FirstOrDefault(x => x.Id == id);
            //var test = _context.
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}
