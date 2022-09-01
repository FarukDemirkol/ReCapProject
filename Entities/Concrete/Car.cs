using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    class Car : IEntity
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
    }
}
