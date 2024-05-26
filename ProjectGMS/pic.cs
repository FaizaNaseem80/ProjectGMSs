using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
   public class pic:DbConnection
    {

        public dbset<ProdImage> ProductImages { get; set; }

        public AppDbContext() : base("name=YourConnectionStringName")
        {
        }
    }

}
