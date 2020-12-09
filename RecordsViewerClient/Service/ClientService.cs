using Microsoft.AspNet.SignalR.Client;
using RecordsViewerClient.Filters;
using RecordsViewerClient.Models;
using RecordsViewerClient.ReportService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Service
{
    public class ClientService
    {
        private IHubProxy hubProxy { get; set; }
        private HubConnection connection;
        private string url;

        private event Action ConnectionClosed;
        public event Action<Dictionary<int, string>, Dictionary<int, string>> GetComboWJBoxDatas;
        public event Action<List<List<string>>, List<Tuple<int, string>>> GetOtherBaseComboBoxes;
        public event Action<List<WeightJournalViewModel>> FillWeightJournalDataGrid;
        public event Action<List<byte[]>> FillPictureBoxWithPhoto;
        public event Action<List<ReportGridData>> FillSimpleGridWithData;
        public event Action<List<AxleReportViewData>> FillAxleGridWithDatas;
        public event Action<List<TransportAxleWeightViewModel>, List<TrailerAxleWeightViewModel>, bool, bool> FillOnEachAxleGridWithDatas;
        public event Action<List<ReportExtendedGridData>> FillExtendedGridWithDatas;
        public event Action<DataTable, string> CreateXmlData;

        //public event Action<string[], int[], bool> GetDatasForExtendedFilter;
        //public event Action<List<WeightJournalViewModel>> FillWeightJournalDataGrid;
        //public event Action<List<ReportGridData>> FillSimpleGridWithData;
        //public event Action<List<object[]>, List<Tuple<int, string>>> GetOtherBaseComboBoxes;
        //public event Action<List<ReportExtendedGridData>> FillExtendedGridWithDatas;
        //public event Action<List<AxleReportViewData>> FillAxleGridWithDatas;
        //public event Action<List<TransportAxleWeightViewModel>, List<TrailerAxleWeightViewModel>, bool, bool> FillOnEachAxleGridWithDatas;
        //public event Action<List<WeighingRoomSettingsModel>, bool, bool> AcceptWeighingDatas;
        //public event Action<List<byte[]>> FillPictureBoxWithPhoto;
        //public event Action<Dictionary<int, string>> GetDatasForAuditCombos;
        //public event Action<List<AuditWeighing>> FillAuditGridWithDatas;
        //public event Action<List<byte[]>> FillAuditPictureBoxWithPhoto;
        //public event Action<string> ErrorMessageFromServer;
        //public event Action ShowEndOfLicenseMessage;
        //public event Action OnForceStopConnection;

        public string IP { get; set; }
        public int Port { get; set; }

        public async Task ConnectAsync()
        {
            try
            {
                url = $"http://{IP}:{Port}/signalr";
                connection = new HubConnection(url);
                //имя в параметре должно соответствовать имени концентратора
                hubProxy = connection.CreateHubProxy("ChatHubs");
                hubProxy.On< Dictionary<int, string>, Dictionary<int, string>>("GetComboWJBoxDatas", (i, t) => GetComboWJBoxDatas.Invoke(i, t));
                hubProxy.On<List<List<string>>, List<Tuple<int, string>>> ("GetOtherBaseComboBoxes", (l,t) => GetOtherBaseComboBoxes.Invoke(l,t));
                hubProxy.On<List<WeightJournalViewModel>>("FillWeightJournalDataGrid", (w) => FillWeightJournalDataGrid.Invoke(w));
                hubProxy.On<List<byte[]>>("FillPictureBoxWithPhoto", (p) => FillPictureBoxWithPhoto.Invoke(p));
                hubProxy.On<List<ReportGridData>>("FillSimpleGridWithData", (l) => FillSimpleGridWithData.Invoke(l));
                hubProxy.On<List<AxleReportViewData>>("FillAxleGridWithDatas", (a) => FillAxleGridWithDatas.Invoke(a));
                hubProxy.On<List<TransportAxleWeightViewModel>, List<TrailerAxleWeightViewModel>, bool, bool>("FillOnEachAxleGridWithDatas", (t, tr, it, itr) => FillOnEachAxleGridWithDatas.Invoke(t, tr, it, itr));
                hubProxy.On<List<ReportExtendedGridData>>("FillExtendedGridWithDatas", (l) => FillExtendedGridWithDatas.Invoke(l));
                hubProxy.On<DataTable, string>("CreateXmlData", (d, s) => CreateXmlData.Invoke(d, s));


                //hubProxy.On<List<object[]>, List<Tuple<int, string>>>("GetOtherBaseComboBoxes", (list, t) => GetOtherBaseComboBoxes.Invoke(list, t));
                //hubProxy.On<string[], int[], bool>("GetDatasForExtendedFilter", (n, i, a) => GetDatasForExtendedFilter.Invoke(n, i, a));
                //hubProxy.On<List<WeightJournalViewModel>>("FillWeightJournalDataGrid", (w) => FillWeightJournalDataGrid.Invoke(w));

                //hubProxy.On<List<ReportGridData>>("FillSimpleGridWithData", (l) => FillSimpleGridWithData.Invoke(l));

                //hubProxy.On<List<ReportExtendedGridData>>("FillExtendedGridWithDatas", (l) => FillExtendedGridWithDatas.Invoke(l));
                //hubProxy.On<List<AxleReportViewData>>("FillAxleGridWithDatas", (a) => FillAxleGridWithDatas.Invoke(a));
                //hubProxy.On<List<WeighingRoomSettingsModel>, bool, bool>("AcceptWeighingDatas", (l, b1, b2) => AcceptWeighingDatas.Invoke(l, b1, b2));
                //hubProxy.On<List<byte[]>>("FillPictureBoxWithPhoto", (p) => FillPictureBoxWithPhoto.Invoke(p));
                //hubProxy.On<Dictionary<int, string>>("GetDatasForAuditCombos", (l) => GetDatasForAuditCombos.Invoke(l));
                ////hubProxy.On<DataTable, string>("CreateXmlData", (d, s) => tableConverter.CreateXmlData(d, s));
                //hubProxy.On<List<AuditWeighing>>("FillAuditGridWithDatas", (aw) => FillAuditGridWithDatas.Invoke(aw));
                //hubProxy.On<List<byte[]>>("FillAuditPictureBoxWithPhoto", (b) => FillAuditPictureBoxWithPhoto.Invoke(b));
                //hubProxy.On<string>("ErrorMessageFromServer", (m) => ErrorMessageFromServer.Invoke(m));
                //hubProxy.On("ShowEndOfLicenseMessage", () => ShowEndOfLicenseMessage.Invoke());
                //hubProxy.On("OnForceStopConnection", () => OnForceStopConnection.Invoke());

                connection.Closed += Disconnected;
                await connection.Start();
                //CustomMessageBox.ShowBox("Соединение с сервером выполнено", "Уведомление", CustomMessageBox.MessageIcon.Success, false);
            }
            catch (Exception ex)
            {
                //CustomMessageBox.ShowBox("Нет связи с сервером или ошибка в настройках пользователя. " +
                //"Проверьте IP адрес и порт, имя весовой.", "Предупреждение", CustomMessageBox.MessageIcon.Warning, false);
            }
        }

        private void Disconnected()
        {
            ConnectionClosed?.Invoke();
        }

        public async Task SendUserDatasAsync(string user)
        {
            await hubProxy.Invoke("AcceptClient", user);
        }

        public async Task SendQueryForWJComboBoxDatas()
        {
            await hubProxy.Invoke("SetDatasForWeightjournalCombos");
        }

        public async Task SendQueryForGridComboBoxes(List<string> tableArray)
        {
            await hubProxy.Invoke("SendDataForGridCombos", tableArray);
        }

        public async Task SendQueryForPhotoes(int weightNumber, int id, int platformNumber)
        {
            await hubProxy.Invoke("SendPhotosToClient", weightNumber, id, platformNumber);
        }

        public async Task SendQueryForGridDatas( List<string> list, List<string> param, DateTime from, DateTime to)
        {
            await hubProxy.Invoke("SendDatasForSimpleGrid", list, param, from, to);
        }

        public async Task SendQueryForAxleGridDatas(ReportGridFilter filter)
        {
            await hubProxy.Invoke("SendDatasForAxleLoadsGrid", filter);
        }

        public async Task SendQueryForOnEachAxleTable(int weighingId)
        {
            await hubProxy.Invoke("SendDatasForOnEachAxleTable", weighingId);
        }

        public async Task SendQueryForExtendedGridDatas(List<string> datas, List<string> extArray, DateTime from, DateTime to, string tsNumber)
        {
            await hubProxy.Invoke("SendDatasForExtendedGrid",  datas, extArray, from, to, tsNumber);
        }

        public async Task SendQueryForSimpleGridFastReport(string id, string secondId, string thirdId, DateTime startDateTime, DateTime endDateTime, string reportName)
        {
            await hubProxy.Invoke("SendTableForFastReportToClient", id, thirdId, secondId, startDateTime, endDateTime, reportName);
        }













        public async Task SendQueryForExtendedFilter(string extendedQuery)
        {
            await hubProxy.Invoke("SetDatasForExtendedFilter", extendedQuery);
        }
        

        public async Task SendFilterDatas(RegWeightFilter weightFilter, RegWeightExtendedFilter extendedFilter)
        {
                await hubProxy.Invoke("GetWeightJournal", weightFilter, extendedFilter);
        }

        

        public async Task SendQueryForWeightJournalFastReport(RegWeightExtendedFilter regWeight, RegWeightFilter filter)
        {
            await hubProxy.Invoke("SendWeightJournalTableForFastReport", regWeight, filter);
        }
        
        public async Task SendQueryForExtendedGridCombos(List<string> tableList)
        {
            await hubProxy.Invoke("SendDataForExtendedGridCombos", tableList);
        }

        

        public async Task SendQueryForExtendedGridFastReport(DateTime start, DateTime end, string tableName, List<string> param)
        {
            await hubProxy.Invoke("SendExtendedTableForFastReportToClient", start, end, tableName, param);
        }

        
        

        public async Task SendQueryForAuditCombos()
        {
            await hubProxy.Invoke("SendDatasForAuditCombos");
        }

        public async Task GetDataGridTableForAudit(SimpleRegWeightFilter simple)
        {
            await hubProxy.Invoke("SendGridDataForAudit", simple);
        }

        public async Task SendQueryForAuditPhotos(int id, int platformNumber)
        {
            await hubProxy.Invoke("GetPhotosForAudit", id, platformNumber);
        }

        public async Task SendQueryForAuditFastReport(DateTime startDate, DateTime endDate, int? auditId)
        {
            await hubProxy.Invoke("SendAuditTableForFastReport", startDate, endDate, auditId);
        }


    }
}
