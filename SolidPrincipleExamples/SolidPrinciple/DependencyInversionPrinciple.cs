using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExamples.SolidPrinciple
{
    //public class Blog
    //{
    //    //High level class
    //    public void Create()
    //    {
    //        Post post = new Post();
    //        post.CreatePost(true);
    //    }


    //}
    //class Post
    //{
    //    //Low level class
    //    public void CreatePost(bool picture)
    //    {
    //        //Process
    //    }
    //}

    //DIP'E göre componentler, bileşikler her zaman abstraction(soyutlama) üzerine bağlı olacak. A class ı B class ını direk tanımamalı.Bunun için araya Interface koyucaz. A class ı Interface i bilecek.Bu durumda yukarıdaki kod bu prensibe uygun olmadı. Bunun yerine prensibe göre şu yolu izlemeliz;

    public interface IContent
    {
        void CreatePost(bool picture);
    }
    public class Blog
    {
        //High level class
        IContent content;
        public Blog()
        {
            content = new Post();
        }
        public void Create()
        {
            content.CreatePost(true);
        }
    }
    class Post : IContent
    {
        //Low level method
        public void CreatePost(bool picture)
        {
            //Process
        }
    }

}
