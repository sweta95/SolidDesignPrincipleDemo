using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    /// <summary>
    /// Receiver of command
    /// </summary>
    public class WordDocument
    {
        public void Open()
        {
            Console.WriteLine("Open the document.");
        }
        public void Close()
        {
            Console.WriteLine("Close the document.");
        }
        public void Save()
        {
            Console.WriteLine("Save the document.");
        }
    }
    /// <summary>
    /// Command abstract object
    /// </summary>
    public interface Command
    {
        void execute();
    }
    /// <summary>
    /// Concreate command classes
    /// </summary>
    public class OpenCommand : Command
    {
        private WordDocument wordDoc;
        public OpenCommand(WordDocument wordDoc)
        {
            this.wordDoc = wordDoc;
        }
        public void execute()
        {
            wordDoc.Open();
        }
    }
    public class CloseCommand : Command
    {
        private WordDocument wordDoc;
        public CloseCommand(WordDocument wordDoc)
        {
            this.wordDoc = wordDoc;
        }
        public void execute()
        {
            wordDoc.Close();
        }
    }
    public class SaveCommand : Command
    {
        private WordDocument wordDoc;
        public SaveCommand(WordDocument wordDoc)
        {
            this.wordDoc = wordDoc;
        }
        public void execute()
        {
            wordDoc.Save();
        }
    }
    /// <summary>
    /// Invoker object
    /// </summary>
    public class MenuOption
    {
        private Command openCommand;
        private Command closeCommand;
        private Command saveCommand;
        public MenuOption(Command open, Command close, Command save)
        {
            this.openCommand = open;
            this.closeCommand = close;
            this.saveCommand = save;
        }
        public void clickOpen()
        {
            this.openCommand.execute();
        }
        public void clickClose()
        {
            this.closeCommand.execute();
        }
        public void clickSave()
        {
            this.saveCommand.execute();
        }
    }
}
