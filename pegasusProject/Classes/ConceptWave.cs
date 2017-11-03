using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject.Classes
{
    class ConceptWave
    {
        Connect connect = new Connect();
        
        public ConceptWave(bool ortamBilgisi)
        {
            connect.ConOpen(ortamBilgisi, "CW");
        }

        public List<CW_DataDTO> setDataTip()
        {
            List<CW_DataDTO> cWDataDto = new List<CW_DataDTO>();

            cWDataDto = GetData();

            return cWDataDto;
        }

        public List<CW_DataDTO> GetData()
        {
            List<CW_DataDTO> cwDataList = new List<CW_DataDTO>();

            string query = "select P.APP_SUBSCRIPTION_ID from CW.SI_ACCESS_PORT_PRODUCT P where P.APP_SITUATION ='H' and P.APP_ACCESS_PORT_CODE ='PRD_002' and rownum <=5 order by dbms_random.value";

            connect.cmd = new OleDbCommand(query, connect.conn);
            OleDbDataReader reader = connect.cmd.ExecuteReader();

            while (reader.Read())
            {
                CW_DataDTO cwDataDto = new CW_DataDTO();
                cwDataDto.hizmetNO = reader["APP_SUBSCRIPTION_ID"].ToString();
                cwDataList.Add(cwDataDto);
            }



            return cwDataList;

        }
    }
}
