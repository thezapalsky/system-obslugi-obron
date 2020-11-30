using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObslugiObron
{
    public interface IObserver
    {
        void Update(ThesisProposal t);
    }
}
