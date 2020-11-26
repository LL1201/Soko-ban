using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soko_ban
{    
    public class Level
    {        
        public string Name;
        public int nPacchi;
        public int Matrixc;
        public int Matrixr;
        public int Matrixpr;
        public int Matrixpc;
        public IList<int> Matrixp;
        public IList<int> Matrix;
    }
    class LevelsRoot
    {
        public IList<Level> Levels;
    }
}
