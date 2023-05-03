using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Utest
{
    [TestFixture]
    internal class U_test
    {
        [TestCase]
        public void Duimtosantimetr()
        {
            Class1 f = new Class1();
            Assert.AreEqual(7.62,f.DuimtoSantimetr(3.0));
        }
        [TestCase]
        public void Duimtosantimetr1()
        {
            Class1 f = new Class1();
            Assert.AreEqual(-7.62, f.DuimtoSantimetr(-3.0));
        }
        [TestCase]
        public void chetnotChet()
        {
            Class1 f = new Class1();
            //тестирование функции вычитания
            Assert.AreEqual(true, f.ChetnotChet(12));
        }
        [TestCase]
        public void chetnotChet1()
        {
            Class1 f = new Class1();
            var ex = Assert.Throws<ArgumentException>(() => f.ChetnotChet(0));
            //тестирование функции вычитания
            Assert.That(ex.Message, Is.EqualTo("Ноль не имеет четности"));

            //проверка выполняется успешно, если исключение не было сгенерировано
            Assert.DoesNotThrow(() => f.ChetnotChet(2));
        }

        [TestCase]
        public void maxElement()
        {
            Class1 f = new Class1();
            int[] arr = { 1, 3, 5, 2 };
           
            //тестирование функции вычитания
            Assert.AreEqual(5, f.MaxElement(arr));
        }
        [TestCase]
        public void maxElement2()
        {
            Class1 f = new Class1();
            int[] arr2 = { };
            //тестирование функции вычитания
            Assert.AreEqual(0, f.MaxElement(arr2));
        }
        [TestCase]
        public void modul()
        {
            Class1 f = new Class1();
            var ex = Assert.Throws<ArgumentException>(() => f.Modul(2, 0));
            //тестирование функции вычитания
            Assert.That(ex.Message, Is.EqualTo("Делитель должен быть >= 0"));

            //проверка выполняется успешно, если исключение не было сгенерировано
            Assert.DoesNotThrow(() => f.Modul(2, 1));
        }
       
    }
}
