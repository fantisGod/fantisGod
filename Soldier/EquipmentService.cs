using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier {
    class EquipmentService {
        private int key;
        public EquipmentService(int key) {
            this.key =key;
        }
        public  Soldier[] DistributeSubkey(Soldier[] soldiers) {
            int a1, a2,count = soldiers.Length;
            Random random = new Random();
            a1 = random.Next(200);
            a2 = random.Next(200);
            for(int i=1;i<=count; ++i) {
                soldiers[i-1].SUBKEY_X = i;
                soldiers[i-1].SUBKEY_Y = key + a1 * i + a2 *i*i;
            }
            return soldiers;
        }
        public bool CheckValid(Soldier[] soldiers) {
            int currentKey=0,l1,l2,l3;
            if (soldiers.Length < 3) {
                return false;
            }
            else {
                l1 = soldiers[1].SUBKEY_X * soldiers[2].SUBKEY_X * soldiers[0].SUBKEY_Y / (soldiers[0].SUBKEY_X - soldiers[1].SUBKEY_X) / (soldiers[0].SUBKEY_X - soldiers[2].SUBKEY_X);
                l2 = soldiers[0].SUBKEY_X * soldiers[2].SUBKEY_X * soldiers[1].SUBKEY_Y / (soldiers[1].SUBKEY_X - soldiers[0].SUBKEY_X) / (soldiers[1].SUBKEY_X - soldiers[2].SUBKEY_X);
                l3 = soldiers[0].SUBKEY_X * soldiers[1].SUBKEY_X * soldiers[2].SUBKEY_Y / (soldiers[2].SUBKEY_X - soldiers[1].SUBKEY_X) / (soldiers[2].SUBKEY_X - soldiers[0].SUBKEY_X);
                currentKey = l1 + l2 + l3;
                if (currentKey == this.key) {
                    return true;
                }
                else
                    return false;
            }
                
        }
    }
}
