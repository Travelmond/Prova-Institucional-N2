using System;
using Xunit;
using Bhaskara;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braskara_Teste
{
    public class Test
    {

        [Theory]
        [InlineData(0, 2, 5, 4)]
        [InlineData(1, 2, 3, -8)]
        [InlineData(3, 2, 1, -8)]
        [InlineData(2, 2, 2, -12)]
        public void Teste01(float a, float b, float c, float delta)
        {
            //Act
            var resultado = ((b * b) - (4 * a * c));
            //Assert
            Assert.Equal(delta, resultado);
        }

    }
}


