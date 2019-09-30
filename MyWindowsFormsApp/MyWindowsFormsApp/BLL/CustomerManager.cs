using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    class CustomerManager
    {
        CustomerRipository _customerRipository = new CustomerRipository();
        public bool Add(string name, string address)
        {
            return _customerRipository.Add(name, address);
        }
        public bool IsNameExists(string name)
        {
            return _customerRipository.IsNameExists(name);
        }
        public bool Delete(int id)
        {
            return _customerRipository.Delete(id);
        }
        public DataTable Display()
        {
            return _customerRipository.Display();
        }
        public bool Update(string name, string  address, int id)
        {
            return _customerRipository.Update(name, address, id);
        }
        public DataTable Search(string name)
        {
            return _customerRipository.Search(name);
        }


    }
}
