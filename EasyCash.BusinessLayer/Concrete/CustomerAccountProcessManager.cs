using EasyCash.BusinessLayer.Abstract;
using EasyCash.DataAccessLayer.Abstract;
using EasyCash1.EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;
        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProccess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAccountProccess TGetById(int id)
        {
            return _customerAccountProcessDal.GetById(id);
        }

        public List<CustomerAccountProccess> TGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAccountProccess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CustomerAccountProccess t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
