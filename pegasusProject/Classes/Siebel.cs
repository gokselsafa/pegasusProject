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
            string query;
            if (bireyselKurumsal == "G")
                query = " and X_TT_R2_MERNIS_TC_ID_TEMP is not null";
            else
                query = " and TAX_IDEN_NUM is not null";

            return GetData(query); ;
        }

        public List<SiebelDTO> GetData(string bireyselKurumsal)
        {
            List<SiebelDTO> siebelList = new List<SiebelDTO>();

            string query = "Select name,created from siebel.s_org_ext";
            query += " where (CUST_STAT_CD='ACC_0002' or CUST_STAT_CD='ACC_0003')";
            //query += " and X_TT_R2_MERNIS_TC_ID_TEMP is not null";
            //query += " and TAX_IDEN_NUM is not null";
            query += bireyselKurumsal;
            query += " and created > add_months(sysdate,-3)";
            query += " and rownum <5";
            
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
