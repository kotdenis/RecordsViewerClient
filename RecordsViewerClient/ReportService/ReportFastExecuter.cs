using FastReport;
using RecordsViewerClient.FastReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace RecordsViewerClient.ReportService
{
    public class ReportFastExecuter
    {
        public void FastReportShow(string reportName, DateTime dateStart, DateTime dateEnd, string nameParameter1, string nameParameter2, bool isHandle)
        {
            Report report;
            string dir = Directory.GetCurrentDirectory();
            if (reportName == "dircargo")
            {
                report = new CargoWeightReportTwoCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndTime", dateEnd);
                using (var rp = new ReportForm("Отчет по грузам", report))
                {
                    rp.ShowDialog();
                }
            }
            if(reportName == "dircargoCommon")
            {
                report = new CargoWeightReportCommonCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                report.SetParameterValue("CounterpartyName", nameParameter1);
                report.SetParameterValue("CarrierName", nameParameter2);
                using (var rp = new ReportForm("Общий отчет по грузам", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "dircounterparty")
            {
                report = new CounterpartyWeightReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                using (var rp = new ReportForm("Общий отчет по контрагентам", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "dircarrier")
            {
                report = new CarrierWeightReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                using (var rp = new ReportForm("Отчет по перевозчикам", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "dircarrierCommon")
            {
                report = new CarrierWeightReportCommonCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                report.SetParameterValue("CargoName", nameParameter1);
                report.SetParameterValue("CarrierName", nameParameter2);
                using (var rp = new ReportForm("Общий отчет по перевозчикам", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "dirstorage")
            {
                report = new StorageWeightReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                using (var rp = new ReportForm("Отчет по складам", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "dirdriver")
            {
                report = new DriverFastReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                
                using (var rp = new ReportForm("Отчет по водителям", report))
                {
                    rp.ShowDialog();
                }
            }

            if (reportName == "weightJournal")
            {
                report = new WeightFullReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                report.SetParameterValue("TSNum", nameParameter2);
                report.SetParameterValue("OperationTypeId", nameParameter1);
                report.SetParameterValue("HandleWeight", isHandle);
                using (var rp = new ReportForm("Журнал взвешиваний", report))
                {
                    rp.ShowDialog();
                }
            }
            if(reportName == "auditJournal")
            {
                report = new AuditWeightReportCS();
                report.SetParameterValue("Connect_String", dir);
                report.SetParameterValue("StartDate", dateStart);
                report.SetParameterValue("EndDate", dateEnd);
                using (var rp = new ReportForm("Отчет по аудиту", report))
                {
                    rp.ShowDialog();
                }
            }
        }

        public void FastExtendedReportShow(DateTime start, DateTime end, string tableName, params object[] param)
        {

        }
    }
}
