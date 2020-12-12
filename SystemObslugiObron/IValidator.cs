using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public interface IValidator
    {
        bool IsTopicCorrect(string topic);
    }
}
