﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pegasusProject.Classes
{
    class xDSL
    {
        Connect connect = new Connect();
        DataTipi dataTipi = new DataTipi();

        public xDSL(bool ortamBilgisi)
        {
            connect.ConOpen(ortamBilgisi,"XDSL");
        }

        public List<xDSLDataDTO> setDataTip(string kurumBilgisi, string xdslTipi)
        {
            List<xDSLDataDTO> xdslDataDto = new List<xDSLDataDTO>();
            string ndslFlag = "";
            switch (xdslTipi)
            {
                case "ADSL":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "1";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "1";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "1";
                                    ndslFlag = "0";
                                }
                                break;
                        }
                    }
                    break;

                case "NDSL":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "1";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "1";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "1";
                                    ndslFlag = "1";
                                }
                                break;
                        }

                    }
                    break;

                case "VDSL":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "6";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "6";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "6";
                                    ndslFlag = "0";
                                }
                                break;
                        }
                    }
                    break;

                case "NVDSL":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "6";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "6";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "6";
                                    ndslFlag = "1";
                                }
                                break;
                        }
                    }
                    break;

                case "GSHDSL":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "2";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "2";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "2";
                                    ndslFlag = "0";
                                }
                                break;
                        }

                    }
                    break;
                case "GSHDSL YALIN":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "2";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "2";
                                    ndslFlag = "1";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "2";
                                    ndslFlag = "1";
                                }
                                break;
                        }
                    }
                    break;

                case "FTTX":
                    {
                        switch (kurumBilgisi)
                        {
                            case "VODAFONE VAE":
                                {
                                    kurumBilgisi = "12024";
                                    xdslTipi = "7";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TURK TELEKOM":
                                {
                                    kurumBilgisi = "1";
                                    xdslTipi = "7";
                                    ndslFlag = "0";
                                }
                                break;
                            case "TTNET":
                                {
                                    kurumBilgisi = "2";
                                    xdslTipi = "7";
                                    ndslFlag = "0";
                                }
                                break;
                        }
                    }
                    break;

                case "NN ADSL":
                    {
                        kurumBilgisi = "1";
                        xdslTipi = "5";
                        ndslFlag = "0";
                    }
                    break;

                case "NN GHSDSL":
                    {
                        kurumBilgisi = "1";
                        xdslTipi = "4";
                        ndslFlag = "0";
                    }
                    break;

                case "NN GSHDSL(İKİ UÇ)":
                    {
                        kurumBilgisi = "1";
                        xdslTipi = "3";
                        ndslFlag = "0";
                    }
                    break;
            }
            xdslDataDto = GetADSL(kurumBilgisi, ndslFlag, xdslTipi);
            return xdslDataDto;
        }

        public List<xDSLDataDTO> GetADSL(string kurumBilgisi, string ndslFlag, string tipKodu)
        {
            List<xDSLDataDTO> xdslDataDto = new List<xDSLDataDTO>();

            string query = "select DISTINCT (AA.CIHAZ_NO), ";
            query += " CC.TT_CUSTOMER_ID,";
            query += " CC.XDSL_CUSTOMER_ID";
            query += " from CRM.ADSL_abone AA,";
            query += " crm.basvuru BB,";
            query += " CRM.MUSTERI_p1_ext CC";
            query += " where AA.CIHAZ_NO = BB.ADSL_NO";
            query += " and AA.MUSTERI_ID = CC.XDSL_CUSTOMER_ID";
            query += " and BB.IPTAL_TESIS_BASV NOT IN('D', 'K', 'B')";
            query += " and AA.ISLEM_TARIHI < TO_DATE('10/27/2017 11:34:06', 'MM/DD/YYYY HH24:MI:SS')";
            query += " and AA.KURUM_ID = " + kurumBilgisi;// -- vodafone 12024, tt 1, ttnet 2";
            query += " and AA.XDSL_TIP_KODU = " + tipKodu;
            query += " and AA.NDSL_FLAG = " + ndslFlag;// --1 olursa ndsl";
            query += " AND ROWNUM<10";
            
            connect.cmd = new OleDbCommand(query, connect.conn);
            OleDbDataReader reader = connect.cmd.ExecuteReader();

                while (reader.Read())
                {
                    xDSLDataDTO dataDTO = new xDSLDataDTO();

                    dataDTO.adslNo = reader["CIHAZ_NO"].ToString();
                    dataDTO.musteriId = reader["TT_CUSTOMER_ID"].ToString();
                    xdslDataDto.Add(dataDTO);
                }
                return xdslDataDto;
        }
    }
}
