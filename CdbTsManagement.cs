using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TsManagement.Forms;
using TsManagement.Models;

namespace TsManagement
{
    sealed class CdbTsManagement
    {
        private static CdbTsManagement dBtsManagement { get; set; }

        private static string connString = ConfigurationManager.ConnectionStrings["TsManagement.Properties.Settings.dbTsManagementConnectionString"].ConnectionString;
        private static SqlConnection conn { get; set; }
        private static SqlCommand cmd { get; set; }
        private static SqlDataAdapter sqlDataAdapter { get; set; }
        private static SqlDataReader SqlDataReader { get; set; }
        private static DataTable dataTable { get; set; }

        private CdbTsManagement()
        {
        }

        public static CdbTsManagement GetCdbTsManagement()
        {
            if (dBtsManagement == null)
            {
                dBtsManagement = new CdbTsManagement();
            }
            return dBtsManagement;
        }
        public static Stock getStock(string StockDate_YYYYMM)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("spGetStock", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StockDate_YYYYMM", StockDate_YYYYMM);
                        sqlDataAdapter = new SqlDataAdapter(cmd);
                        dataTable = new DataTable("STOCK");
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable.Rows.Count > 0 ?
                            new Stock(dataTable.Rows[0].ItemArray[0].ToString(), Convert.ToInt32(dataTable.Rows[0].ItemArray[1].ToString()),
                                         Convert.ToDecimal(dataTable.Rows[0].ItemArray[2].ToString()), Convert.ToDecimal(dataTable.Rows[0].ItemArray[3].ToString()))
                            : new Stock("NA", 0, 0, 0);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void UpdateStock(string StockDate_YYYYMM, int StockValue)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string typeOfUpdate = StockValue > 0 ? "spAddStock" : "spSubtractStock";
                    using (cmd = new SqlCommand(typeOfUpdate, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StockValue", Math.Abs(StockValue));
                        cmd.Parameters.AddWithValue("@StockDate_YYYYMM", StockDate_YYYYMM);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static IList<string> GetStockDates()
        {
            try
            {
                IList<string> lstStockDates = new List<string>();
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("spGetStockDates", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        sqlDataAdapter = new SqlDataAdapter(cmd);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            lstStockDates.Add(row.ItemArray[0].ToString());
                        }
                    }
                }

                return lstStockDates.Count <= 0 ? new List<string>() { FormatCurrentDate } : lstStockDates;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static IList<CreditedStockDetails> GetCreditedStockDetails(string StockDate_YYYYMM)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    IList<CreditedStockDetails> lstCreditedStockDetails = new List<CreditedStockDetails>();
                    using (cmd = new SqlCommand("spGetCreditedStockDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StockDate_YYYYMM", StockDate_YYYYMM);
                        sqlDataAdapter = new SqlDataAdapter(cmd);
                        dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        foreach (DataRow r in dataTable.Rows)
                        {
                            lstCreditedStockDetails.Add(new CreditedStockDetails(r.ItemArray[0].ToString(), r.ItemArray[1].ToString(),
                                r.ItemArray[2].ToString(), Convert.ToDecimal(r.ItemArray[3].ToString()), Convert.ToDateTime(r.ItemArray[4].ToString())));
                        }

                    }
                    return lstCreditedStockDetails;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ControlCreditor(CreditedStockDetails creditedStockDetails,string Message)
        {
            try
            {
                using (conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (cmd = new SqlCommand("spControlCreditedStock", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@STOCK_ID", creditedStockDetails.StockId);
                        cmd.Parameters.AddWithValue("@CREDITOR_ID", creditedStockDetails.CellphoneNumber);
                        cmd.Parameters.AddWithValue("@CREDITOR_NAME", creditedStockDetails.Name);
                        cmd.Parameters.AddWithValue("@AMOUNT_TO_BE_PAID", creditedStockDetails.Amount);

                        cmd.ExecuteNonQuery();
                    }
                }
                frmMessageBox frmMessageBox = new frmMessageBox("Saved", Message);
                frmMessageBox.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        #region helper methods
        public static string FormatCurrentDate
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{DateTime.Now.Year}/");
                stringBuilder.Append(DateTime.Now.Month < 10 ? $"0{DateTime.Now.Month}" : $"{DateTime.Now.Month}");
                return stringBuilder.ToString();
            }
        }
        #endregion
    }
}
