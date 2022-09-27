using SortOfStringFrecuency;

namespace SortStringByFrecuencyTests
{
    public class SortStringByFrecuencyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Case1()
        {
            SortStringByFrequency sortStringByFrecuency = new SortStringByFrequency();
            int size = 2;
            string[] words = new string[size];
            words[0] = "abaccadcc";
            words[1] = "xxyyz";

            string[] expectedResult = new string[size];
            expectedResult[0] = "ccccaaabd";
            expectedResult[1] = "xxyyz";

            var actualResult = sortStringByFrecuency.SortByStringByFrequency(words,size);
         
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Case2()
        {
            SortStringByFrequency sortStringByFrecuency = new SortStringByFrequency();
            int size = 10;
            string[] words = new string[size];
            words[0] = "dulgvqzwqg";
            words[1] = "gxtjtmtywr";
            words[2] = "hnlnxiupgt";
            words[3] = "gzjotckivp";
            words[4] = "dpwwsdptae";
            words[5] = "pcscpilknb";
            words[6] = "btvyhmflf";
            words[7] = "artrtnqxcr";
            words[8] = "nrtcmcpadn";
            words[9] = "fkdsgnekft";

            string[] expectedResult = new string[size];
            expectedResult[0] = "gggdlquvwz";
            expectedResult[1] = "tttgjmrwxy";
            expectedResult[2] = "nnghilptux";
            expectedResult[3] = "cgijkoptvz";
            expectedResult[4] = "ddppwwaest";
            expectedResult[5] = "ccppbiklns";
            expectedResult[6] = "ffhhblmtvy";
            expectedResult[7] = "rrrttacnqx";
            expectedResult[8] = "ccnnadmort";
            expectedResult[9] = "ffkkdegnst";

            var actualResult = sortStringByFrecuency.SortByStringByFrequency(words, size);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }


        [Test]
        public void Case3()
        {
            SortStringByFrequency sortStringByFrecuency = new SortStringByFrequency();
            int size = 5;
            string[] words = new string[size];
            words[0] = "wzenwebuau";
            words[1] = "vokfxzynwl";
            words[2] = "neldfeyrxk";
            words[3] = "wqadfiodgs";
            words[4] = "ykiuvzfcbc";
  

            string[] expectedResult = new string[size];
            expectedResult[0] = "eeuuwwabnz";
            expectedResult[1] = "fklnovwxyz";
            expectedResult[2] = "eedfklnrxy";
            expectedResult[3] = "ddafgioqsw";
            expectedResult[4] = "ccbfikuvyz";
        

            var actualResult = sortStringByFrecuency.SortByStringByFrequency(words, size);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Case4()
        {
            SortStringByFrequency sortStringByFrecuency = new SortStringByFrequency();
            int size = 10;
            string[] words = new string[size];
            words[0] = "qakmc";
            words[1] = "rrtbk";
            words[2] = "vaixn";
            words[3] = "wmpnj";
            words[4] = "uproi";
            words[5] = "btska";
            words[6] = "ejqwr";
            words[7] = "elwlg";
            words[8] = "oaoiy";
            words[9] = "hrqkn";

            string[] expectedResult = new string[size];
            expectedResult[0] = "ackmq";
            expectedResult[1] = "rrbkt";
            expectedResult[2] = "ainvx";
            expectedResult[3] = "jmnpw";
            expectedResult[4] = "iopru";
            expectedResult[5] = "abkst";
            expectedResult[6] = "ejqrw";
            expectedResult[7] = "llegw";
            expectedResult[8] = "ooaiy";
            expectedResult[9] = "hknqr";

            var actualResult = sortStringByFrecuency.SortByStringByFrequency(words, size);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}