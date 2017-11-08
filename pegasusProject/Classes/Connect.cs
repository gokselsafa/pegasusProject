using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pegasusProject
{
    class Connect
    {
        private string conStringTmsUAT = "Provider=MSDAORA;Data Source=10.6.46.12:1523/TMSUAT;Persist Security Info=True;User ID=UATIK;Password=Ugurcan_9168";
        private string conStringTmsBAU = "Provider=MSDAORA;Data Source=10.6.46.13:1523/TMSBAU;Persist Security Info=True;User ID=UATIK;Password=Ugurcan_9168";

        private string conStringXdslUAT = "Provider=MSDAORA;Data Source=XDSL;Persist Security Info=True;User ID=UATIK;Password=Ugurcan_9168";
        private string conStringXdslBAU = "Provider=MSDAORA;Data Source=XDSLBAUN;Persist Security Info=True;User ID=UATIK;Password=Ugurcan_9168";


        private string conStringCWUAT = "Provider=MSDAORA;Data Source=10.6.82.180:1521/SRUAT01;Persist Security Info=True;User ID=SGOKSEL;Password=Safa_1256";
        private string conStringCWBAU = "Provider=MSDAORA;Data Source=10.6.82.180:1521/SRITAM01;Persist Security Info=True;User ID=SGOKSEL;Password=Safa_1256";
        

        private string conStringSiebelUAT = "Provider=MSDAORA;Data Source=10.233.168.2:1521/SBUAT01;Persist Security Info=True;User ID=SGOKSEL;Password=Safa_1256";
        private string conStringSiebelBAU = "Provider=MSDAORA;Data Source=10.233.168.4:1521/SBITAM01;Persist Security Info=True;User ID=SGOKSEL;Password=Safa_1256";

        private string conStringTelauraUAT = "Provider=MSDAORA;Data Source=10.6.148.209:1521/TELRAUAT;Persist Security Info=True;User ID=UATIK;Password=UGURCAN_9168";
        private string conStringTelauraBAU = "Provider=MSDAORA;Data Source=10.6.148.209:1521/TELRABAU;Persist Security Info=True;User ID=UATIK;Password=Ugurcan_9168";

        public OleDbConnection conn;
        public OleDbCommand cmd;

        public void ConOpen(bool uatMi, string sistem)
        {
            switch (sistem)
            {
                case "TMS":
                    {
                        if (uatMi == true)
                        {
                            conn = new OleDbConnection(conStringTmsUAT);
                        }
                        else
                            conn = new OleDbConnection(conStringTmsBAU);
                    }break;
                case "XDSL":
                    {
                        if (uatMi == true)
                        {
                            conn = new OleDbConnection(conStringXdslUAT);
                        }
                        else
                            conn = new OleDbConnection(conStringXdslBAU);
                    }
                    break;
                case "TELAURA":
                    {
                        if (uatMi == true)
                        {
                            conn = new OleDbConnection(conStringTelauraUAT);
                        }
                        else
                            conn = new OleDbConnection(conStringTelauraBAU);
                    }break;
                 case "TAHAKUK":
                    {
                        if (uatMi == true)
                        {
                            conn = new OleDbConnection(conStringTmsUAT);
                        }
                        else
                            conn = new OleDbConnection(conStringTmsBAU);
                    }break;
                case "SIEBEL":
                    {
                        if (uatMi == true)
                        {
                            conn = new OleDbConnection(conStringSiebelUAT);
                        }
                        else
                            conn = new OleDbConnection(conStringSiebelBAU);
                    }
                    break;
            }
            conn.Open();
        }


    }
}
