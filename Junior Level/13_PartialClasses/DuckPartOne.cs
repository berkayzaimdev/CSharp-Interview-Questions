using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PartialClasses
{
    partial class Duck
    {
        private void Quack()
        {
            Console.WriteLine("Quack, quack, I'm a duck");
        }

        public partial void Fly();
    }
}
