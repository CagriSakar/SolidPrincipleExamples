using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExamples.SolidPrinciple
{
    //public interface Ipost
    //{
    //    void CreatePost();
    //    void ReadPost();
    //}
    //ISP'e göre interface genel amaçlı olmasındansa Cliente özgü olması daha iyidir. Bu durumda;

    public interface IPostCreate
    {
        void CreatePost();
    }
    public interface IPostRead
    {
        void ReadPost();
    }





}
