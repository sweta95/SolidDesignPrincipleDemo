using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IMoose
    {
        void Chase();
    }
    public class Moose : IMoose
    {
        public void Chase()
        {
            Console.WriteLine("Specific Request");
        }
    }
    public interface ICharacter
    {
        void Run();
    }
    public class MooseAdapter : ICharacter
    {
        IMoose _moose;
        public MooseAdapter(IMoose moose)
        {
            this._moose = moose;
        }
        public void Run() => _moose.Chase();
    }
}
