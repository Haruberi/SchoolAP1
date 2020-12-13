using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalculator.Command_Pattern
{
    //Invoker
    public class StackClass
    {
        private Stack<IPatternClass> _UndoCommand = new Stack<IPatternClass>();
        private Stack<IPatternClass> _RedoCommand = new Stack<IPatternClass>();

        public void Redo(int level)
        {
            for(int i = 0; i <= level; i++)
            {
                if (_RedoCommand.Count != 0)
                {
                    IPatternClass command = _RedoCommand.Pop();
                    command.Redo();
                    _UndoCommand.Push(command);
                }
            }
        }

        public void Undo(int level)
        {
            for (int i = 0; i <= level; i++)
            {
                if (_RedoCommand.Count != 0)
                {
                    IPatternClass command = _UndoCommand.Pop();
                    command.Undo();
                    _UndoCommand.Push(command);
                }
            }
        }

        public bool operationPerformedCorrectly 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
    }
}

