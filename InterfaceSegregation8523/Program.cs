using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Work();
            worker.Eat();
            worker.Work();
            worker.GetSalary();

            Robot robot = new Robot();
            //robot.Eat();       // yanlış
            //robot.GetSalary(); // yanlış
            robot.Work();

            Console.ReadLine();

            // Single Responsbility
            // Interface Segregation

        }
    }
    #region (INTERFACES)
    //interface IWorker  // YANLIŞ
    //{
    //    void Work();
    //    void GetSalary();
    //    void Eat();
    //}
    #region 1.Interface (IWork)
    interface IWork
    {
        void Work();
    }
    #endregion
    #region 2.Interface (IEat)
    interface IEat
    {
        void Eat();
    }
    #endregion
    #region 3.Interface (IGetSalary)
    interface IGetSalary
    {
        void GetSalary();
    }
    #endregion
    #endregion
    #region (CLASSES)
    #region 1.Class (Worker)
    //class Worker : IWorker  // YANLIŞ
    class Worker : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker gets salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker works");
        }
    }
    #endregion
    #region 2.Class (Manager)
    //class Manager : IWorker  // YANLIŞ
    class Manager : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager gets salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager works");
        }
    }
    #endregion
    #region 3.Class (Robot)
    //class Robot : IWorker // YANLIŞ
    class Robot : IWork
    {
        //public void Eat()
        //{

        //}

        //public void GetSalary()
        //{

        //}

        public void Work()
        {
            Console.WriteLine("Robot works");
        }
    }
    #endregion
    #endregion
}
