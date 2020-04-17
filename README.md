# Test Unitario (ejemplo)

### Generación de consola
> Desde Visual Studio generar una solucion de tipo consola y agregar el siguiente codigo de ejemplo:

```csharp
using System;

namespace ConsoleApp1
{
    public class Calculos
    {
        private int _dividendo;
        private int _divisor;

        public static void Main(string[] args)
        {
            Calculos calc = new Calculos(22, 4);
            Console.WriteLine("El resultado es {0}", calc.Division());
            Console.ReadKey();
        }

        private Calculos() { }

        public Calculos(int param1, int param2)
        {
            _dividendo = param1;
            _divisor = param2;
        }

        public double Division()
        {
            try
            {
                return _dividendo / _divisor;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
```

### Generación de test
> Desde el Solution Explorer, generar una nueva solución de tipo MSTest Test Project, se debera agregar el siguiente codigo de test

```csharp
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int param1 = 22;
            int param2 = 4;
            double expected = 5;

            // Act
            Calculos calc = new Calculos(param1, param2);
           
            // Assert
            double result = calc.Division();
            Assert.AreEqual(expected, result, "Test correcto");
        }
    }
}
```

> el paso siguiente es realizar build de la solucion

### Ejecutar
Test > Windows > Test Explorer > Runn All
