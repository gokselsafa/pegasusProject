using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject.Classes
{
    class Tahakkuk
    {
        Connect connect = new Connect();
        public string bireyselMi = "G";

        public Tahakkuk(bool ortamBilgisi)
        {
            connect.ConOpen(ortamBilgisi, "TAHAKUK");
        }

        public List<DataDTO> setDataTip(string bireyselKurumsal, int selectedIndex)
        {
            bireyselMi = bireyselKurumsal;

            List<DataDTO> tahakkukList = new List<DataDTO>();
            TMS tms = new TMS(true);
            switch(selectedIndex)
            {
                case 0: tahakkukList = GetData("0");break;
            }
            

            return tahakkukList;
        }

        public List<DataDTO> GetData(string hizmetTuru)
        {
            List<DataDTO> tahakukList = new List<DataDTO>();

            string query = "select  distinct(A.HIZMET_NO) , B.BAGIMSIZ_BOLUM_KODU , M.TC_KIMLIK_NO  ,M.CRM_CUSTOMER_ID,  A.tesis_tarihi from TMS.ABONE a , TMS.ABONE_TESIS_ADRESI b  , TMS.MUSTERI m ,TMS.PGM1_MESAJ p    where A.ID=B.ID";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and P.CRM_CUSTOMER_ID = M.CRM_CUSTOMER_ID";
            query += " and A.ALT_HIZMET_TURU = 1";
            query += " and A.HIZMET_TURU = " + hizmetTuru;
            query += " and A.SEBEKE_TIPI = 0";
            query += " and A.FATURA_HESAP_ID is not null";
            query += " and M.SIEBEL_FLAG = 1";
            query += " and a.DURUM = 'T'";
            query += " and M.GERCEK_TUZEL = '"+ bireyselMi +"'";//-- > Tüzel müşteri için T bireysl müşteri için G kullanılır";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No in (select v.service_number from PRODBGW.vw_orders @BILLDBL v ,PRODBGW.product_order @BILLDBL p where  v.header_id = p.header_id and v.faulty_detail = 'SUCCESS' and v.om_name = 'TMS' and v.service_Type = '0' and v.order_type = 1 and p.order_sub_type = 'A' and v.service_number is not null)";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";//and P.STATUS in (1) and P.ERROR_DESC is null
            query += " and A.tesis_tarihi < add_months(SYSDATE, -1)";//and A.tesis_tarihi >= '01/01/2010' and rownum<6
            query += " order by DBMS_RANDOM.VALUE";



            connect.cmd = new OleDbCommand(query, connect.conn);
            OleDbDataReader reader = connect.cmd.ExecuteReader();

            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();
                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.tckimlikno = reader["TC_KIMLIK_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                tahakukList.Add(dataDTO);
            }



            return tahakukList;

        }
    }
}
