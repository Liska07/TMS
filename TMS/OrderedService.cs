using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Companies;

namespace TMS
{
    public enum TypeOfService
    {
        Cleaning,
        Delivery,
        Test //для тестирования try-catch
    }
    internal class OrderedService
    {
        public string Date {  get; set; }

        public string Description { get; set; }

        public OrderedService(string date, string description) 
        { 
            Date = date;
            Description = description;
        }

        public void OrderService(TypeOfService typeOfService, string nameOfCompany)
        {
            Company Company;

            switch (typeOfService)
            {
                case TypeOfService.Cleaning:
                    Company = new Cleaning(nameOfCompany);
                    break;
                case TypeOfService.Delivery:
                    Company = new Delivery(nameOfCompany);
                    break;
                default:
                    throw new NotImplementedException("В классе OrderService нет реализации для " + nameof(TypeOfService));
            }
            Company.Work();
        }
    }
}
