using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExamples.SolidPrinciple
{
    //public class File
    //{
    //    public string? TypeOfFile { get; set; }

    //    public void SaveToFile(Customer customer) 
    //    {
    //        if (TypeOfFile == "txt")
    //        {
    //            //Save to txt file
    //        }

    //        if (TypeOfFile == "xls")
    //        {
    //            //Save to xls file
    //        }
    //    }
    //}
    //Prensibe göre kodun gelişime açık değişime kapalı olmalı. Var olan şeyleri değiştirmemek gerekli ama bu kod buna uygun olmadı if yapısından dolayı bunun yerine aşağıdaki gibi yaparak bu prensibe uyabiliriz. 
    public abstract class File
    {
        public abstract string SaveToFile(Customer customer);
    }
    
    public class TxtFile : File
    {
        public override string SaveToFile(Customer customer)
        {
            throw new NotImplementedException(); //Saved to txt file
        }
    }
    public class XlsFile : File
    {
        public override string SaveToFile(Customer customer)
        {
            throw new NotImplementedException(); //Saved to xls file
        }
    }
}
