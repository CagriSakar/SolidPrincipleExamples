using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExamples.SolidPrinciple
{
    //public abstract class Player
    //{
    //    public virtual void KickTheBall() //bu metodu farklı classlarda da kullanmak için virtual yaptık.
    //    {
    //        //Ball was kicked
    //    }

    //    public virtual void KeepTheBall()
    //    {
    //        //Ball was kept
    //    }
    //}
    //public class Striker : Player
    //{
    //    public override void KeepTheBall()
    //    {
    //        //Striker should not keep the ball
    //    }

    //    public override void KickTheBall()
    //    {
    //        //Ball was kicked by striker
    //    }
    //}
    //public class GoalKeeper : Player
    //{
    //    public override void KeepTheBall()
    //    {
    //        //Striker should not keep the ball
    //    }

    //    public override void KickTheBall()
    //    {
    //        //Ball was kicked by striker
    //    }

    //}
    //LSP ye göre iki class birbiri arasında yer değiştirdiği zaman uygulamanın kırılmaksızın birbirleri arasında change edilebilir olması lazım. Bu ayrıştırmayı yapmak için aşağıdaki gibi bir kodlama yapmalıyız.

    public abstract class Player
    {
        public virtual void KickTheBall() //bu metodu farklı classlarda da kullanmak için virtual yaptık.
        {
            //Ball was kicked
        }
    }
     public interface IKeepTheBall
    {
        void KeepTheBall();
    }

    public class Striker : Player
    {
        public override void KickTheBall()
        {
            //Ball was kicked by Striker
        }
    }

    public class GoalKeeper : Player,IKeepTheBall
    {
        public override void KickTheBall()
        {
            //Ball was kicked by GoalKeeper
        }
        public void KeepTheBall()
        {
            //Ball was kept by GoalKeeper
        }
    }
}
