using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public class TopicValidator : IValidator
    {
        //sprawdzamy czy w temacie pracy znajda sie slowa ze stoplisty (uzyte do mocka)
        public bool IsTopicCorrect(string topic)
        {
            string[] stoplist = { "wziąść", "test123", "matematyka" };
            stoplist = stoplist.Select(s => s.ToUpperInvariant()).ToArray();

            string[] topicWords = Regex.Split(topic, @"\W+");
            topicWords = topicWords.Select(s => s.ToUpperInvariant()).ToArray();

            foreach (string word in topicWords)
            {
                if (stoplist.Contains(word))
                {
                    return false;
                    //zakazany wyraz w temacie
                }
            }
            return true;
        }
    }
}
