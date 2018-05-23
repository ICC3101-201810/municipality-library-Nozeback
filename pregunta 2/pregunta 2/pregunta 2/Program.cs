using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClassLibrary1.Address> Direcciones = new List<ClassLibrary1.Address>();
            List<ClassLibrary1.Car> Autos = new List<ClassLibrary1.Car>();
            List<ClassLibrary1.Person> persona = new List<ClassLibrary1.Person>();
            Console.WriteLine("=======================");
            Console.WriteLine("-Para cambiar el titulo de propiedad de un vehiculo o bien raiz presione el numero '2'");
            Console.WriteLine("-Para cambiar Nombre o Apellido de una persona presione el numero '3'");
            Console.WriteLine("-Para modificar la cantidad de piezas o banos de una propiedad ingrese el numero '4'");
            Console.WriteLine("-Para adoptar, ser adoptado o abandonar a una persona ingrese el numero '5'");
            Console.WriteLine("-Para ingresar un nuevo nivel de educacion de una person ingrese el numero '6'");
            Console.WriteLine("=======================");
            string ver = Console.ReadLine();
            int ve = Int32.Parse(ver);
            if (ve == 1) {

                Console.WriteLine("=======================");
                Console.WriteLine("-Para un vehiculo ingrese el numero '1'");
                Console.WriteLine("-Para una nueva propiedad ingrese el numero '2'");
                string vr = Console.ReadLine();
                int er = Int32.Parse(vr);
                if (er == 3)
                {
                    Console.WriteLine("ingrese el numero de patente del vehiculo");
                    string patente = Console.ReadLine();
                    Console.WriteLine("ingrese el rut del nuevo propietario");
                    string rut = Console.ReadLine();
                    ClassLibrary1.Car car;
                    ClassLibrary1.Person per;
                    bool nu;
                    foreach (ClassLibrary1.Car c in Autos)
                    {
                        if (patente == c.License_plate)
                        {
                            car = c;
                            nu = true;
                        }
                        else
                        {
                            nu = false;
                        }
                    }
                    foreach(ClassLibrary1.Person p in persona)
                    {
                        if (rut == p.Rut)
                        {
                            per = p;
                            nu = true;
                        }
                        else
                        {
                            nu = false;
                        }
                    }
                    if (nu == true)
                    {

                    }
                }
                if (er == 2)
                {
                    Console.WriteLine("ingrese el nombre del nuevo propietario");
                }
                }
            if (ve == 2) { }
            if (ve == 3) { }
            if (ve == 4) { }
            if (ve == 5) { }
            if (ve == 6) { }
            if (ve == 7) { }
            else
            {
                Environment.Exit(0);
            }
            
        }
    }
}
