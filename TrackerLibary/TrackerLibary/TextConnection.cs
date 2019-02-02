using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibary;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        // TODO: wire up the createptize for the text files.
        public PrizeModel CretePrize(PrizeModel model)
        {
           // TODO: Create a prize and save it in text file.

            model.Id = 1;
            return model;
        }
    }
}
