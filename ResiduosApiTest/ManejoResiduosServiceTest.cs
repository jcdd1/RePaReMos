using API_REPAREMOS.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResiduosApiTest
{
    class ManejoResiduosServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ObtenerResiduosTest()
        {
            ManejoResiduosService service = new ManejoResiduosService();
            var result = await service.ObtenerResiduos();
            if (result != null)
            {
                Assert.IsNotNull(result);
            }
            else
            {
                Assert.IsNull(result);

            }
            
        }

    }
}
