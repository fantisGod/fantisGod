using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier {
    class Soldier {
        public static int count;
        public int ID;
        public int RANK;
        public int PUBKEY;
        public int PRIKEY;
        public int SUBKEY_X;
        public int SUBKEY_Y;
        public Soldier(int RANK=0, int PUBKEY=0, int PRIKEY=0, int SUBKEY_X=0, int SUBKEY_Y=0) {
            this.ID = ++count;
            this.RANK = RANK;
            this.PUBKEY = PUBKEY;
            this.PRIKEY = PRIKEY;
            this.SUBKEY_X = SUBKEY_X;
            this.SUBKEY_Y = SUBKEY_Y;
        }
    }
}
