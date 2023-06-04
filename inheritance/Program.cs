using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class program
    {
        static void Main(string[] args)
        {
            person person1 = new person ("Kesmo", 20);
            person1.Infoperson();

            //INHERITANCE
            Karyawan karyawan = new Karyawan("Jane Smith", "IT");
            karyawan.InfoKaryawan();

            Console.ReadLine();
        }
    }
}