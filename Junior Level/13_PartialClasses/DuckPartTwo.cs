using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PartialClasses
{
    partial class Duck
    {
        private void Swim()
        {
            Console.WriteLine("Swimming in a pond");
        }

        public partial void Fly()
        {
            Console.WriteLine("Flying high in the sky");
        }
    }
}
