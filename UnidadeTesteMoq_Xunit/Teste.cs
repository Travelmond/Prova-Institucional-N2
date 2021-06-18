using System;
using Xunit;
using UnidadeTesteMoq;
using Xunit.Sdk;
//Teste
namespace UnidadeTesteMoq_Xunit
{
    public class Teste
    {
        public class PrimeService_IsPrimeShould
        {
            private readonly PrimeService _primeService;

            public PrimeService_IsPrimeShould()
            {
                _primeService = new PrimeService();
            }

            [Fact]
            public void ReturnFalseGivenValueOf1()
            {
                var result = _primeService.IsPrime(1);

                Assert.False(result, "1 n�o deveria ser n�mero primo");
            }
                [Theory]
                [InlineData(1)]
                public void ReturnFalseGivenValuesLessThan2(int value)
                {
                    var result = _primeService.IsPrime(value);

                    Assert.False(result, $"{value}N�o deveriam ser n�meros primos");
                }
            }
        }
    }

