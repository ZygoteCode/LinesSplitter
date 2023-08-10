using System.Collections.Generic;

namespace LinesSplitter
{
    public class Splitter
    {
        public static List<string> Split(string input)
        {
            List<string> splitted = new List<string>();

            foreach (string line in SplitToLines(input))
            {
                splitted.Add(line);
            }

            return splitted;
        }

        private static IEnumerable<string> SplitToLines(string input)
        {
            if (input == null)
            {
                yield break;
            }

            using (System.IO.StringReader reader = new System.IO.StringReader(input))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}