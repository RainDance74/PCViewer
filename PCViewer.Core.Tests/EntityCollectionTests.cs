using PCViewer.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCViewer.Core.Tests
{
    [TestFixture]
    public class EntityCollectionTests
    {
        private EntityCollection<string> _data = [];

        [TearDown]
        public void TearDown()
        {
            _data.Clear();
        }

        [Test]
        public void Count_Should_Return_2()
        {
            _data.Add("Привет");
            _data.Add("мир");

            var count = _data.Count();

            Assert.That(count, Is.EqualTo(2));
        }

        [Test]
        public void Should_Remove_Element_Correct()
        {
            _data.Add("Привет");
            _data.Add("мир");
            _data.Add("!");

            var result = _data.Remove("мир");
            var count = _data.Count;
            var text = string.Concat(_data);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Метод вернул False");
                Assert.That(count, Is.EqualTo(2), "Длинна не равна необходимой длинне");
                Assert.That(text, Is.EqualTo("Привет!"), "Выходной массив не совпадает ожидаемому");
            });
        }

        [Test]
        public void Should_Not_Remove_Element()
        {
            _data.Add("Привет");
            _data.Add("мир");
            _data.Add("!");

            var result = _data.Remove("Слово");
            var count = _data.Count;
            var text = string.Concat(_data);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.False, "Метод вернул True");
                Assert.That(count, Is.EqualTo(3), "Длинна не равна изначальной длинне");
                Assert.That(text, Is.EqualTo("Приветмир!"), "Выходной массив изменил контент");
            });
        }

        [Test]
        public void Contains_Should_Return_True()
        {
            _data.Add("C#");

            var result = _data.Contains("C#");

            Assert.That(result, Is.True);
        }
    }
}
