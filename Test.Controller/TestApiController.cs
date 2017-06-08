using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace IISvsSelfHost
{
    public class TestApiController : ApiController
    {
        public IList<Foo> GetAll()
        {
            return new List<Foo>
                  {
                      new Foo {Id = 1, Name = "Foo 1", CreatedOn = DateTime.Now},
                      new Foo {Id = 2, Name = "Foo 2", CreatedOn = DateTime.Now},
                      new Foo {Id = 3, Name = "Foo 3", CreatedOn = DateTime.Now}
                  };
        }
    }
}
