using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalculator.Command_Pattern
{
    //Command
    public interface IPatternClass
    {
        //Undo
       void Undo();
        //Redo
       void Redo();

        bool operationPerformedCorrectly { get; set; }
        //Execute
        void equal_click(object sender, EventArgs e);
    }
}
