using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject.Classes
{
    class Siebel
    {
        Connect connect = new Connect();
        public string bireyselMi = "G";

        public Siebel(bool ortamBilgisi)
        {
            connect.ConOpen(ortamBilgisi, "SIEBEL");
        }

        public List<SiebelDTO> setDataTip(string bireyselKurumsal)
        {
            string query="";
            if (bireyselKurumsal == "G")//bireysel
            {
                query = "and A.MARKET_CLASS_CD='ACC_0085' and X_TT_R2_MERNIS_TC_ID is not null ";
            }
            else if (bireyselKurumsal == "T")//kurumsal
            {
                query = "and A.MARKET_CLASS_CD='ACC_0084' and A.MARKET_TYPE_CD not in ('ACC_0011','ACC_0012') and tax_iden_num is not null ";
            }
            else if(bireyselKurumsal == "SOHO")//soho
            {
                query = "and A.MARKET_CLASS_CD='ACC_0084' and A.MARKET_TYPE_CD = 'ACC_0012' ";
            }
            else if(bireyselKurumsal == "TOPTAN")//toptan
            {
                query = "and A.MARKET_CLASS_CD='ACC_0084' and A.MARKET_TYPE_CD = 'ACC_0011' and tax_iden_num is not null ";
            }

            return GetData(query); ;
        }

        public List<SiebelDTO> GetData(string bireyselKurumsal)
        {
            List<SiebelDTO> siebelList = new List<SiebelDTO>();

            string query = "select * from (select a.name, a.created from siebel.s_org_ext a where ";
            query += "(CUST_STAT_CD = 'ACC_0002' or CUST_STAT_CD = 'ACC_0003') ";
            query += bireyselKurumsal;
            query += "and created > add_months(sysdate,-3) order by dbms_random.value)";
            query += "where rownum < 6";

            connect.cmd = new OleDbCommand(query, connect.conn);
            OleDbDataReader reader = connect.cmd.ExecuteReader();

            while (reader.Read())
            {
                SiebelDTO dataDTO = new SiebelDTO();
                dataDTO.musteriID = reader["NAME"].ToString();
                dataDTO.date = reader["CREATED"].ToString();
                siebelList.Add(dataDTO);
            }
            return siebelList;

        }
    }
}
