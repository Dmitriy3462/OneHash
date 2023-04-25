using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Chain
    {
        public List<Block> Blocks { get;  set; }

        public Block Last { get; private set; }

        public Chain()
        {
            Blocks = new List<Block>();
            var genesisBlock = new Block();
            Blocks.Add(genesisBlock);
            Last = genesisBlock;
        }

        public void Add(string data, string user)
        {
            var block = new Block(data, user, Last);
            Blocks.Add(block);
            Last = block;
        }
    }
}
