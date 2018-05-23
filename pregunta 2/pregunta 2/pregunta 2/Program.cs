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
            Console.WriteLine("-Para cambiar el titulo de propiedad de un vehiculo o bien raiz presione el numero '1'");
            Console.WriteLine("-Para cambiar Nombre o Apellido de una persona presione el numero '2'");
            Console.WriteLine("-Para modificar la cantidad de piezas o banos de una propiedad ingrese el numero '3'");
            Console.WriteLine("-Para adoptar, ser adoptado o abandonar a una persona ingrese el numero '4'");
            Console.WriteLine("-Para ingresar un nuevo nivel de educacion de una person ingrese el numero '5'");
            Console.WriteLine("=======================");
            string ver = Console.ReadLine();
            int ve = Int32.Parse(ver);
            if (ve == 1)
            {

                Console.WriteLine("=======================");
                Console.WriteLine("-Para un vehiculo ingrese el numero '1'");
                Console.WriteLine("-Para una propiedad ingrese el numero '2'");
                string vr = Console.ReadLine();
                int er = Int32.Parse(vr);
                if (er == 3)
                {
                    Console.WriteLine("ingrese el numero de patente del vehiculo");
                    string patente = Console.ReadLine();
                    Console.WriteLine("ingrese el rut del nuevo propietario");
                    string rut = Console.ReadLine();
                    ClassLibrary1.Car Car;
                    ClassLibrary1.Person per;
                    bool nu;
                    foreach (ClassLibrary1.Car c in Autos)
                    {
                        if (patente == c.License_plate)
                        {
                            Car = c;
                            nu = true;
                        }
                        else
                        {
                            nu = false;
                        }
                    }
                    foreach (ClassLibrary1.Person p in persona)
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
                        Car.giveUpOwnershipToThirdParty(per);
                        Console.WriteLine("=======================");
                    }
                }
                if (er == 2)
                {
                    Console.WriteLine("ingrese el rut del propietario actual");
                    string rut1 = Console.ReadLine();
                    Console.WriteLine("ingrese el rut del nuevo propietario");
                    string rut2 = Console.ReadLine();
                    Console.WriteLine("ingrese la comuna");
                    string com = Console.ReadLine();
                    Console.WriteLine("ingrese la calle");
                    string call = Console.ReadLine();
                    Console.WriteLine("ingrese el numero");
                    string sm = Console.ReadLine();
                    int nro = Int32.Parse(sm);
                    ClassLibrary1.Address dir;
                    ClassLibrary1.Person per1;
                    ClassLibrary1.Person per2;
                    bool nu;
                    foreach (ClassLibrary1.Address c in Direcciones)
                    {
                        if (c.Commune == com && c.Street == call && c.Number == nro)
                        {
                            dir = c;
                            nu = true;
                        }
                        else
                        {
                            nu = false;
                        }
                    }
                    foreach (ClassLibrary1.Person p in persona)
                    {
                        if (rut == p.Rut)
                        {
                            per2 = p;
                            nu = true;
                        }
                        else
                        {
                            nu = false;
                        }
                    }
                    if (nu == true)
                    {
                        dir.changeOwner(per2);
                        Console.WriteLine("=======================");
                    }
                }
            }
            if (ve == 2)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("ingrese el rut de la persona que quiere modificar");
                string rut = Console.ReadLine();
                Console.WriteLine("para cambiar de nombre ingrese '1', para cambiar de apellido '2'");
                int nm = Int32.Parse(Console.ReadLine());
                if (nm == 1)
                {
                    foreach (ClassLibrary1.Person p in persona)
                    {
                        if (p.Rut == rut)
                        {
                            Console.WriteLine("ingrese el nuevo apellido");
                            string ap = Console.ReadLine();
                            p.changeLastName(ap);
                        }
                    }
                }
                if (nm == 2)
                {
                    foreach (ClassLibrary1.Person p in persona)
                    {
                        if (p.Rut == rut)
                        {
                            Console.WriteLine("ingrese el nuevo nombre");
                            string ap = Console.ReadLine();
                            p.changeFirstName(ap);
                        }
                    }
                }
                Console.WriteLine("=======================");
            }
            if (ve == 3)
            {
                Console.WriteLine("para cambiar el numero de banos ingrese '1', para cambiar el numero de cuartos ingrese '2'");
                int dec = Int32.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la comuna");
                string com = Console.ReadLine();
                Console.WriteLine("ingrese la calle");
                string call = Console.ReadLine();
                Console.WriteLine("ingrese el numero");
                string sm = Console.ReadLine();
                int nro = Int32.Parse(sm);
                if (dec == 1)
                {
                    foreach (ClassLibrary1.Address c in Direcciones)
                    {
                        if (c.Commune == com && c.Street == call && c.Number == nro)
                        {
                            Console.WriteLine("ingrese el nuevo numero de banos");
                            c.addBathrooms(Int32.Parse(Console.ReadLine()));
                        }
                    }
                    Console.WriteLine("=======================");
                }
                if (dec == 2)
                {
                    foreach (ClassLibrary1.Address c in Direcciones)
                    {
                        if (c.Commune == com && c.Street == call && c.Number == nro)
                        {
                            Console.WriteLine("ingrese el nuevo numero de cuartos");
                            c.addBeedrooms(Int32.Parse(Console.ReadLine()));
                        }
                    }
                    Console.WriteLine("=======================");
                }

            }
            if (ve == 4)
            {
                Console.WriteLine("Para adoptar ingrese'1', abandonar a una persona '2'");
                int dec = Int32.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el rut de la persona");
                string rut1 = Console.ReadLine();
                if (dec == 1)
                {
                    Console.WriteLine("ingrese el rut de padre");
                    string rut2 = Console.ReadLine();
                    ClassLibrary1.Person pap;
                    foreach (ClassLibrary1.Person p in persona)
                    {
                        if (p.Rut == rut2)
                        {
                            pap = p;
                        }
                    }
                    foreach (ClassLibrary1.Person p in persona)
                    {
                        if (p.Rut == rut1)
                        {
                            p.getAdopted(pap);
                            p.changeLastName(pap.Last_name);
                        }
                    }
                    if (dec == 2)
                    {
                        foreach (ClassLibrary1.Person p in persona)
                        {
                            if (p.Rut == rut1)
                            {
                                p.getAbandoned();
                                p.changeLastName("snow");
                            }
                        }
                    }
                    Console.WriteLine("=======================");
                }
                if (ve == 5)
                {
                    Console.WriteLine("ingrese el rut de la persona");
                    string rut4 = Console.ReadLine();
                    foreach(ClassLibrary1.Person g in persona)
                    {
                        if (rut4 == g.Rut)
                        {
                            Console.WriteLine("ingrese la institucion educacional");
                            string AlmaMater = Console.ReadLine();
                            Console.WriteLine("ingrese el nuevo grado de educacion");
                            string grado = Console.ReadLine();
                            g.setEducation(AlmaMater, grado);
                        }
                    }
                    Console.WriteLine("=======================");
                }
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("=======================");
                    Console.WriteLine("=======================");
                    Console.WriteLine("=======================");
                    Environment.Exit(0);
                }

            }
        }
    }
}
