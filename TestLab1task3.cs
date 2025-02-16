using Lab1task3;
namespace TestLab1task3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string[] words1 = { "кот", "собака", "птица" };
            string[] words2 = { "собака", "слон", "кот" };
            string[] results = new string[words1.Length];
            int count = Third.CompareWords(words1, words2, results);
            CollectionAssert.AreEqual(new string[]
            { "кот - входит", "собака - входит", "птица - не входит" },
            results[..count]);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            // Проверка на дубликаты в первом предложении
            string[] words1 = { "кот", "кот", "собака" };
            string[] words2 = { "собака", "слон", "кот" };
            string[] results = new string[words1.Length];
            int count = Third.CompareWords(words1, words2, results);
            CollectionAssert.AreEqual(new string[]
            { "кот - входит", "собака - входит" },
            results[..count]);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            // Полностью разные слова
            string[] words1 = { "дом", "река", "гора" };
            string[] words2 = { "море", "озеро", "луг" };
            string[] results = new string[words1.Length];
            int count = Third.CompareWords(words1, words2, results);
            CollectionAssert.AreEqual(new string[]
            { "дом - не входит", "река - не входит", "гора - не входит" },
            results[..count]);
            Assert.Pass();
        }
    }
}
