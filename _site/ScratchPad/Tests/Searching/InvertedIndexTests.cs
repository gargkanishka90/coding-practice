using ScratchPadTests.Searching;

namespace ScratchPad.Searching
{
    public class InvertedIndexTests
    {
        public static void Run()
        {
            var ii = new InvertedIndex();
            var words = new System.String[]
            {
                "Kanishka", "Kanishk", "ken", "Kanishka", "Ken", "ken", "Kanishka", "Kanishk", "ken", "Kanishka", "Ken",
                "ken"
            };
            InvertedIndex.PreCompute(words);
            InvertedIndex.PrintDictionary();
        } 
    }
}