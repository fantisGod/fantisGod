using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldier {
    class Program {
        static void Main(string[] args) {
            
            #region 初始化士兵列表
            int N = 10;
            Soldier[] soldiers=new Soldier[N];
            for (int i=0;i< N; i++) {
                soldiers[i] = new Soldier();
            }
            #endregion

            #region 装备拾取测试
            EquipmentService es = new EquipmentService(1234); //1234为要设置的初始密码，任意正整数
            es.DistributeSubkey(soldiers); //分配SUBKEY
            Soldier[] CheckSoldier = { soldiers[0], soldiers[1], soldiers[2]}; //认证的士兵列表
            Console.WriteLine(es.CheckValid(CheckSoldier).ToString());  //返回false有两种情况(1)CheckSoldier.Length<3（2）有间谍
            #endregion
            Console.Read();
        }
    }
}
