using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly Libreria= Assembly.LoadFrom("C:\\Users\\RECOIL\\Desktop\\municipality-library-Nozeback\\lector biblioteca\\ConsoleApp4\\ClassLibrary1.dll");
            foreach(Type tipo in Libreria.GetTypes())
            {
                Console.WriteLine(tipo.Namespace);
                Console.WriteLine(tipo.Name);
                string sb = "";

                sb += ("================================================================\n");
                sb += (String.Format("Type Name: {0}\n", tipo.Name));
                if (tipo.IsClass)
                    sb += "CLASS\n";
                sb += ("================================================================\n");
                foreach (PropertyInfo property in tipo.GetProperties())
                {
                    sb += ("----------------------------------------------------------------\n");
                    sb += (String.Format("Property Name: {0}\n", property.Name));
                    sb += ("----------------------------------------------------------------\n");

                    sb += (String.Format("Property Type Name: {0}\n", property.PropertyType.Name));
                    sb += (String.Format("Property Type FullName: {0}\n", property.PropertyType.FullName));

                    sb += (String.Format("Can we read the property?: {0}\n", property.CanRead.ToString()));
                    sb += (String.Format("Can we write the property?: {0}\n", property.CanWrite.ToString()));
                }
                foreach (MethodInfo method in tipo.GetMethods())
                {
                    sb += (String.Format("Method info: {0}\n", method));
                    sb += ("***\n");
                }
                Console.WriteLine(sb);

            }
            Console.ReadKey();
        }
    }
}
