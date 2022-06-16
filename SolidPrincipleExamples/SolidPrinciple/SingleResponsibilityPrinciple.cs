using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExamples.SolidPrinciple
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void CreateCustomer(Customer customer)
        {
            //Customer created
        }

        //public void SaveToFile(Customer customer)
        //{
        //    //Customer saved to file
        //}
    }

    //SingleResponsibilityPrinciple a göre 1 classta sadece 1 görev olmalı. Yukarıdaki bu prensibe aykırı oldu. SaveToFile ı farklı bir classta yapmak gerekli.
    public class FileSave
    {
        public void SaveToFile(Customer customer)
        {
            //Customer saved to file
        }
    }








}