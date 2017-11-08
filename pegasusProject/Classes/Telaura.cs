using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject.Classes
{
    class Telaura
    {
        Connect connect = new Connect();
        
        public Telaura(bool ortamBilgisi)
        {
            connect.ConOpen(ortamBilgisi, "TELAURA");
        }

        public List<TelauraDTO> setDataTip(string bireyselKurumsal)
        { 
            if(bireyselKurumsal == "B")
                return GetData("='140'");
            else
                return GetData("<140");
        }

        public List<TelauraDTO> GetData(string bireyselKurumsal)
        {
            List<TelauraDTO> telauraDataList = new List<TelauraDTO>();

            string query = "select b.ident_val1 as Hizmet_Numarasi from telaura.prod_char_srch a join telaura.prod b on a.val=b.ident_val1 and a.st_id='10525' ";
            query += "join telaura.cust_acct_prod_invl c on b.prod_id = c.prod_id and b.st_id = '116' and b.descr = 'PSTN' ";
            query += "join telaura.cust_acct d on c.cust_acct_id = d.cust_acct_id and c.shrt_code = 'PAYMENT' ";
            query += "join telaura.cust e on d.cust_id = e.cust_id and e.cust_tp_id " + bireyselKurumsal + " group by b.ident_val1 ";


            connect.cmd = new OleDbCommand(query, connect.conn);
            OleDbDataReader reader = connect.cmd.ExecuteReader();

            while (reader.Read())
            {
                TelauraDTO telauraDataDto = new TelauraDTO();
                telauraDataDto.hizmetNO = reader["HIZMET_NUMARASI"].ToString();
                telauraDataList.Add(telauraDataDto);
            }



            return telauraDataList;

        }
    }
}
