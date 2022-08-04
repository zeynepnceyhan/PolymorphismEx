using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }
        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }
        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }
        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
        new SqlServerCustomerDal(),
        new OracleCustomerDal(),
        new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }
}