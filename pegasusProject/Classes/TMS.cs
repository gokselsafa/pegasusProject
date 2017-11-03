using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pegasusProject.Classes;
using System.Data.OleDb;
using pegasusProject;
using System.Windows.Forms;

namespace pegasusProject
{
    class TMS
    { 
        Connect connect1 = new Connect();
        DataTipi dataTipi = new DataTipi();

        public TMS(bool ortamBilgisi) {
           
            connect1.ConOpen(ortamBilgisi, "TMS");
            //asdasd
            //asdasdasd
        }
        public List<DataDTO> setDataType(string kurumsal_Bireysel, int cbUrunSI, int cbAltUrunSI)
        {
            List<DataDTO> returnedDataDto = new List<DataDTO>();
            
            if (kurumsal_Bireysel == "G")
            {
                switch (cbUrunSI)
                {
                    case 0://pstn
                        {
                            switch (cbAltUrunSI)
                            {
                                case 0://Bakır
                                    {
                                        returnedDataDto = GetBakırOrTHK("", "G");// and M.ID =";// 17177098 ise TTNET OLO datası  değilse TMS datası"; " and M.ID = '17177098'"
                                    }
                                    break;

                                case 1://Fiber
                                    {
                                        returnedDataDto = GetFiber("G");
                                    }
                                    break;

                                case 2://THK(OLO)
                                    {
                                        returnedDataDto = GetBakırOrTHK(" and M.ID = '17177098'", "G");
                                    }
                                    break;

                                case 3://MSAN
                                    {
                                        returnedDataDto = GetMSAN("G");
                                    }
                                    break;

                                case 4://PSTN(xDSL İçin)
                                    {
                                        returnedDataDto = GetPSTNforXDSL("G");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 1://ortak tesis
                        {
                            switch (cbAltUrunSI)
                            {
                                case 0://PSTN DSL
                                    {
                                        returnedDataDto = GetOrtakTesis(" ", " 0");
                                    }
                                    break;

                                case 1://PSTN DSL IPTV
                                    {
                                        returnedDataDto = GetOrtakTesis("", " 1");
                                    }
                                    break;

                                case 2://TTNET THK PSTN DSL IPTV
                                    {
                                        returnedDataDto = GetOrtakTesis(" and A.MUSTERI_ID ='17177098'", " 1");
                                    }
                                    break;

                                case 3://TTNET THK PSTN DSL
                                    {
                                        returnedDataDto = GetOrtakTesis(" and A.MUSTERI_ID ='17177098'", " 0");
                                    }
                                    break;


                            }
                            break;
                        }
                }
            }
            else
            {
                switch (cbUrunSI)
                {
                    case 0://pstn
                        {
                            switch (cbAltUrunSI)
                            {
                                case 0://Bakır
                                    {
                                        returnedDataDto = GetBakırOrTHK("", "T");// and M.ID =";// 17177098 ise TTNET OLO datası  değilse TMS datası"; " and M.ID = '17177098'"
                                    }
                                    break;

                                case 1://Fiber
                                    {
                                        returnedDataDto = GetFiber("T");
                                    }
                                    break;

                                case 2://THK(OLO)
                                    {
                                        returnedDataDto = GetBakırOrTHK(" and M.ID = '17177098'", "T");
                                    }
                                    break;

                                case 3://MSAN
                                    {
                                        returnedDataDto = GetMSAN("T");
                                    }
                                    break;

                                case 4://PSTN(xDSL İçin)
                                    {
                                        returnedDataDto = GetPSTNforXDSL("T");
                                    }
                                    break;
                            }
                            break;
                        }

                    case 1://isdn
                        {
                            switch (cbAltUrunSI)
                            {
                                case 0: //0  ise ISDN BA  //5ise ISDN BA  
                                    {
                                        returnedDataDto = GetIsdn("0","5");
                                    }
                                    break;

                                case 1://15 ise ISDN PRI //1 ise ISDN PRI
                                    {
                                        returnedDataDto = GetIsdn("15", "1");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 2://yapa
                        {
                            switch (cbAltUrunSI)
                            {
                                case 0://1 olursa TAM
                                    {
                                        returnedDataDto = GetYapa("1");
                                    }
                                    break;

                                case 1://2 olursa PAYLAŞIMLI 
                                    {
                                        returnedDataDto = GetYapa("2");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 3://ggac
                        {// althizmet_turu 1 demek GGAC  2 demek GGAC 7 rakamlı
                            // erisim tipi 3 ME ,2 GHDSL, 1 ADSL
                            switch (cbAltUrunSI)
                            {
                                case 0://Standart ADSL alt hizmet= 1; erişim_tipi = 1
                                    {
                                        returnedDataDto = GetGGAC("1" , "1");
                                    }
                                    break;

                                case 1://Standart ME ADSL alt hizmet= 1; erişim_tipi = 3
                                    {
                                        returnedDataDto = GetGGAC("1" , "3");
                                    }
                                    break;
                                case 2://Standart GHDSL alt hizmet= 1; erişim_tipi = 2
                                    {
                                        returnedDataDto = GetGGAC("1", "2");
                                    }
                                    break; 
                                case 3://7 rakalmlı ADSL alt hizmet= 2; erişim_tipi = 1
                                    {
                                        returnedDataDto = GetGGAC("2", "1");
                                    }
                                    break;
                                case 4://7 Rakamlı ME ADSL alt hizmet= 2; erişim_tipi = 3
                                    {
                                        returnedDataDto = GetGGAC("2", "3");
                                    }
                                    break;
                                case 5://7 Rakamlı  GHDSL alt hizmet= 2; erişim_tipi = 2
                                    {
                                        returnedDataDto = GetGGAC("2", "2");
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            
            return returnedDataDto;
        }


        public List<DataDTO> GetGGAC(string altHizmetTuru, string erisimTipi)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select A.HIZMET_NO , G.TTVPN_HIZMET_NO , T.BAGIMSIZ_BOLUM_KODU ,M.CRM_CUSTOMER_ID, A.TESIS_TARIHI from TMS.ABONE a, TMS.ABONE_GGAC g, TMS.MUSTERI m, TMS.ABONE_TESIS_ADRESI t";
            query += " where A.ID = G.ID";
            query += " and m.id = A.MUSTERI_ID";
            query += " and A.ID = T.ID";
            query += " and M.GERCEK_TUZEL = 'T'";
            query += " and A.HIZMET_TURU = 24";
            query += " and A.ALT_HIZMET_TURU = '" + altHizmetTuru + "'";// althizmet_turu 1 demek GGAC  2 demek GGAC rakamlı
            query += " and A.durum = 'T'";
            query += " and A.sebeke_tipi = 0";
            query += " and A.IS_TURU is null";
            query += " and A.ALT_IS_TURU is null";
            query += " and G.ERISIM_TIPI = '" + erisimTipi + "'";// erisim tipi 3 ME ,2 GHDSL, 1 ADSL
            query += " and G.TTVPN_HIZMET_NO is not null";
            query += " and G.CW_VPN_NO is not null";
            query += " and T.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TESIS_TARIHI is not null ";
            query += " and A.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);

            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.TTVPN_Hizmet_NO = reader["TTVPN_HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }

        public List<DataDTO> GetBakırOrTHK(string mID , string gercekTuzel)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select A.HIZMET_NO, A.TESIS_TARIHI , B.BAGIMSIZ_BOLUM_KODU , M.TC_KIMLIK_NO  ,M.CRM_CUSTOMER_ID from TMS.ABONE a, TMS.ABONE_TESIS_ADRESI b, TMS.MUSTERI m     where A.ID = B.ID and M.ID = A.MUSTERI_ID";
            query += mID;// and M.ID =";// 17177098 ise TTNET OLO datası  değilse TMS datası"; " and M.ID = '17177098'"
            query += " and A.ALT_HIZMET_TURU = 1";
            query += " and A.HIZMET_TURU = 0";
            query += " and A.SEBEKE_TIPI = '0'";
            query += " and M.GERCEK_TUZEL = '" + gercekTuzel +"'";
            query += " and a.DURUM = 'T'";
            query += " and A.EV_IS = 'I'";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No is not null";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TESIS_TARIHI is not null ";
            query += " and A.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                dataDTO.tckimlikno = reader["TC_kimlik_no"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }



        public List<DataDTO> GetFiber(string gercekTuzel)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select A.HIZMET_NO , A.TESIS_TARIHI , B.BAGIMSIZ_BOLUM_KODU  , M.TC_KIMLIK_NO  from TMS.ABONE a , TMS.ABONE_TESIS_ADRESI b  , TMS.MUSTERI m , TMS.ISEMRI k  , TMS.ISEMRI_FTTX_KMS f where A.ID=B.ID";
            query += " and K.ABONE_ID = A.ID";
            query += " and K.ID = F.ISEMRI_ID";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and B.ID = A.ID";
            query += " and A.ALT_HIZMET_TURU = 1";
            query += " and A.HIZMET_TURU = 0";
            query += " and A.SEBEKE_TIPI = 1";
            query += " and m.gercek_tuzel = '" + gercekTuzel + "'";
            query += " and a.DURUM = 'T'";
            query += " and K.ALT_IS_TURU = 'A'";
            query += " and K.IS_TURU = 1";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No like '312%'";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TESIS_TARIHI is not null ";
            query += " and A.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();
                
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                dataDTO.tckimlikno = reader["TC_kimlik_no"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }



        public List<DataDTO> GetMSAN(string gercekTuzel)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select C.BAGIMSIZ_BOLUM_KODU , B.HIZMET_NO , b.tesis_tarihi from TMS.ABONE_PSTN_SEBEKE a , TMS.ABONE b , TMS.ABONE_TESIS_ADRESI c , TMS.MSAN m , TMS.musteri d where A.ABONE_ID=B.ID and B.ID =C.ID and M.ID=A.MSAN_ID";
            query += " and d.id = B.musteri_id";
            query += " AND d.gercek_tuzel = '" + gercekTuzel + "'";
            query += " and A.MSAN_DEVRE is not null";
            query += " and B.DURUM = 'T'";
            query += " and B.hizmet_turu = 0";
            query += " and B.alt_hizmet_turu = 1";
            query += " and C.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TT_BINA_ID = '6019000000000004'";
            query += " and B.tesis_tarihi >= '01/01/2010'";
            query += " and B.hizmet_no is not null";
            query += " and B.TESIS_TARIHI is not null ";
            query += " and B.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }


        public List<DataDTO> GetPSTNforXDSL(string gercekTuzel)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select a.hizmet_no, T.BAGIMSIZ_BOLUM_KODU , A.TESIS_TARIHI from tMS.abone a , tms.abone_pstn b , tms.musteri m, TMS.ABONE_TEBLIGAT_ADRESI t  where b.id =A.id";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and T.ID = A.id";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and B.ABONE_ADSL_NO is null";
            query += " and M.GERCEK_TUZEL = '" + gercekTuzel + "'";
            query += " and A.HIZMET_TURU = 0";
            query += " and A.DURUM = 'T'";
            query += " and A.ALT_HIZMET_TURU = 1";
            query += " and T.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TESIS_TARIHI is not null ";
            query += " and A.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }



        public List<DataDTO> GetYapa(string altHizmetTuru)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select A.HIZMET_NO , B.BAGIMSIZ_BOLUM_KODU , M.TC_KIMLIK_NO  ,M.CRM_CUSTOMER_ID , A.TESIS_TARIHI from TMS.ABONE a, TMS.ABONE_TESIS_ADRESI b, TMS.MUSTERI m";
            query += " where A.ID = B.ID";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and M.GERCEK_TUZEL = 'T'";
            query += " and A.ALT_HIZMET_TURU = '" + altHizmetTuru + "'"; //1 olursa TAM 2 olursa PAYLAŞIMLI
            query += " and A.HIZMET_TURU = 20";
            query += " and a.DURUM = 'T'";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No is not null";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and A.TESIS_TARIHI is not null ";
            query += " and A.TESIS_TARIHI >= '01/01/2012' ";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";
            connect1.cmd = new OleDbCommand(query, connect1.conn);
            
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                dataDTO.tckimlikno = reader["TC_kimlik_no"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }


        public List<DataDTO> GetIsdn(string altHizmetTuru, string hizmetTuru)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();
            string query = "select A.HIZMET_NO , B.BAGIMSIZ_BOLUM_KODU , M.TC_KIMLIK_NO  ,M.CRM_CUSTOMER_ID , A.TESIS_TARIHI from TMS.ABONE a, TMS.ABONE_TESIS_ADRESI b, TMS.MUSTERI m";
            query += " where A.ID = B.ID";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and A.ALT_HIZMET_TURU = '" + altHizmetTuru + "'"; //0  ise ISDN BA  15 ise ISDN PRI
            query += " and A.HIZMET_TURU = '" + hizmetTuru + "'"; //5ise ISDN BA  1 ise ISDN PRI
            query += " and A.SEBEKE_TIPI = 0";  
            query += " and M.GERCEK_TUZEL = 'T'";
            query += " and a.DURUM = 'T'";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No is not null";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                dataDTO.tckimlikno = reader["TC_kimlik_no"].ToString();

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }



        public List<DataDTO> GetOrtakTesis(string Musteri_ID, string IPTV_Mı)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();
            string query = "select a.hizmet_no , O.ORTAK_TESIS_ID, A.TESIS_TARIHI from TMS.ISEMRI_ORTAK_TESIS o,tms.abone a, tms.isemri k";
            query += " where A.ID = K.ABONE_ID";
            query += " and k.id = O.ID";
            query += " and A.IS_TURU is null";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.DURUM = 'T'";
            query += Musteri_ID;
            query += " and A.HIZMET_TURU = 0";
            query += " and K.ALT_HIZMET_TURU = 1";
            query += " and K.HIZMET_TURU = 0";
            query += " and O.IPTV_MI = '" + IPTV_Mı + "'";
            query += " and O.FTC_PROTOKOLUNDE_MI = '1'";
            query += " and rownum<6";
            query += " order by DBMS_RANDOM.VALUE";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.Ortak_Tesis_id = reader["Ortak_Tesis_id"].ToString();
                dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();
                

                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }



        public List<DataDTO> GetTahakkukData(string [] tahakuk)
        {
            List<DataDTO> dataDtoList = new List<DataDTO>();

            string query = "select  A.HIZMET_NO , B.BAGIMSIZ_BOLUM_KODU , M.TC_KIMLIK_NO  ,M.CRM_CUSTOMER_ID   from TMS.ABONE a , TMS.ABONE_TESIS_ADRESI b  , TMS.MUSTERI m     where A.ID=B.ID";
            query += " and M.ID = A.MUSTERI_ID";
            query += " and A.ALT_HIZMET_TURU = 1";
            query += " and A.HIZMET_TURU = 0";
            query += " and A.SEBEKE_TIPI = 0";
            query += " and a.DURUM = 'T'";
            query += " and A.EV_IS = 'E'";
            query += " and M.GERCEK_TUZEL = 'G'";
            query += " and A.ALT_IS_TURU is null";
            query += " and A.IS_TURU is null";
            query += " and A.HIZMET_No IN (" + tahakuk[0] + " , " + tahakuk[1] + " , " + tahakuk[2] + " , " + tahakuk[3] + " , " + tahakuk[4] + " ) ";
            query += " and B.BAGIMSIZ_BOLUM_KODU is not null";
            query += " and rownum<6 order by dbms_random.value";

            connect1.cmd = new OleDbCommand(query, connect1.conn);
            OleDbDataReader reader = connect1.cmd.ExecuteReader();
            while (reader.Read())
            {
                DataDTO dataDTO = new DataDTO();

                dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                dataDTO.BBK= reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                dataDTO.tckimlikno = reader["TC_KIMLIK_NO"].ToString();
                dataDTO.musteriId = reader["CRM_CUSTOMER_ID"].ToString();
                
                dataDtoList.Add(dataDTO);
            }

            var orderedList = dataDtoList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

            return orderedList;
        }


        /* public List<DataDTO> GetData() {
             List<DataDTO> dataDTOList = new List<DataDTO>();

             string query = "select  A.HIZMET_NO , B.BAGIMSIZ_BOLUM_KODU ,A.TESIS_TARIHI from TMS.ABONE a, TMS.ABONE_TESIS_ADRESI b, TMS.MUSTERI m     where A.ID = B.ID ";
             query += "and M.ID = A.MUSTERI_ID ";
             query += "and A.ALT_HIZMET_TURU = " + dataTipi.altHizmetTuru + " ";
             query += "and A.HIZMET_TURU = " + dataTipi.hizmetTuru + " ";
             query += "and A.SEBEKE_TIPI = 0 ";
             query += "and a.DURUM = 'T' ";
             query += "and A.EV_IS = 'E' ";
             query += "and M.GERCEK_TUZEL = '" + dataTipi.musteriSinifi + "' ";
             query += "and A.ALT_IS_TURU is null ";
             query += "and A.IS_TURU is null ";
             query += "and A.HIZMET_No is not null ";
             query += "and A.TESIS_TARIHI is not null ";
             query += "and A.TESIS_TARIHI >= '01/01/2012' ";
             query += "and B.BAGIMSIZ_BOLUM_KODU is not null and rownum <= 6 order by dbms_random.value";

             connect.cmd = new OleDbCommand(query, connect.conn) ;

             OleDbDataReader reader = connect.cmd.ExecuteReader();
             //int kontrol = 0;
             while (reader.Read())
             {
                 //kontrol += 1;
                 DataDTO dataDTO = new DataDTO();

                 dataDTO.hizmetNo = reader["HIZMET_NO"].ToString();
                 dataDTO.BBK = reader["BAGIMSIZ_BOLUM_KODU"].ToString();
                 dataDTO.tesisTarihi = reader["TESIS_TARIHI"].ToString();

                     dataDTOList.Add(dataDTO);

                // if (kontrol > 4)
                    // break;
             }

             var orderedList = dataDTOList.OrderByDescending(x => DateTime.Parse(x.tesisTarihi)).ToList();

             return orderedList;
         }*/
    }
}
