using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class all_loop
    {
        static int i = 0;
        static void Main(String[] arg)
        {
            for(i=0;i<=10;i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            i = 0;
            while (i <= 10)
            {
                Console.Write(i+" ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            i = 0;
            do
            {
                Console.Write(i+" ");
                i++;
            }while (i <= 10);
            Console.WriteLine();
            Console.WriteLine();
            for (i = 1; i <= 100;i++)
            {
                if (i%3==0 && i%4==0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Car car = new("A", "B", "C", "12743");
            car.OutputAll();
        }
    }
    class Car
    {
        private String _make="";
        private String _model="";
        private String _colour="";
        private String _registration_number="";
        public String Make
        {
            get
            { return _make; }
            set
            {
                if (value != "")
                {
                    _make = value;
                }
                else
                {
                    // 这里可以抛出异常，或者采取其他措施
                    throw new ArgumentOutOfRangeException(nameof(value), "Make must not be NULL.");
                }
            }
        }
        public String Model
        {
            get; set;
        }
        public String Colour
        {
            get;set;
        }
        public String Registration_Number
        {
            get; private set;
        }
        public Car(String make, String model, String colour, String registration_number)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Registration_Number = registration_number;
        }
        public void OutputAll()
        {
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(Colour);
            Console.WriteLine(Registration_Number);
        }
    }

}
