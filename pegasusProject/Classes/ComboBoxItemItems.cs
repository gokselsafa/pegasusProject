using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject
{
    class ComboBoxItemItemsTMS
    {
        public ComboBoxItemItemsTMS() {
            cbTMS();

        }
        
            public string [] ortakTesis= new string[4];
            public string [] ggac = new string[6];
            public string [] isdn = new string[2];
            public string [] pstn = new string[5];
            public string [] yapa = new string[2];
            

            public string[] kurumsal = new string[4];
            public string[] bireysel = new string[2];

            public string[] kurumsalTahakkuk = new string[1];
            public string[] bireyselTahakkuk = new string[1];


        private void cbTMS() {
            ortakTesis[0] = "PSTN DSL";
            ortakTesis[1] = "PSTN DSL IPTV";
            ortakTesis[2] = "TTNET THK PSTN DSL IPTV";
            ortakTesis[3] = "TTNET THK PSTN DSL";

            ggac[0] = "Standart ADSL";
            ggac[1] = "Standart ME ADSL";
            ggac[2] = "Standart GHDSL";
            ggac[3] = "7 rakalmlı ADSL";
            ggac[4] = "7 Rakamlı ME ADSL";
            ggac[5] = "7 Rakamlı  GHDSL";
            


            isdn[0] = "ISDN BA";
            isdn[1] = "ISDN PRI";

            
            yapa[0] = "Paylaşımlı";
            yapa[1] = "Tam";

            pstn[0] = "Bakır";
            pstn[1] = "Fiber";
            pstn[2] = "THK(OLO)";
            pstn[3] = "MSAN";
            pstn[4] = "PSTN(xDSL İçin)";

            kurumsal[0] = "PSTN";
            kurumsal[1] = "ISDN";
            kurumsal[2] = "YAPA";
            kurumsal[3] = "GGAC";

            bireysel[0] = "PSTN";
            bireysel[1] = "Ortak Tesis(FTC'li)";

            bireyselTahakkuk[0] = "PSTN";
            kurumsalTahakkuk[0] = "PSTN";
        }
        
    }
}
