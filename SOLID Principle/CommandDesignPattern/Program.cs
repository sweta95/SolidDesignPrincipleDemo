using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDocument wordDoc = new WordDocument();
            Command openCommand = new OpenCommand(wordDoc);
            Command closeCommand = new CloseCommand(wordDoc);
            Command saveCommand = new SaveCommand(wordDoc);

            MenuOption menu = new MenuOption(openCommand, closeCommand, saveCommand);
            menu.clickOpen();
            menu.clickClose();
            menu.clickSave();

            Console.ReadKey();
        }
    }
}
