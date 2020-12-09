using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows;
using RecordsViewerClient.Filters;
using RecordsViewerClient.Models;
using RecordsViewerClient.ViewHelpModels;
using RecordsViewerClient.Service;
using System.Data;
using RecordsViewerClient.ReportService;
using Unity;
using RecordsViewerClient.Controls;
using RecordsViewerClient.Enums;

namespace RecordsViewerClient.ViewModels
{
    public class ViewMain : BindableBase, IViews
    {
        
        ClientService _clientService;
        TaskFactory _taskFactory;
        RegWeightFilter _regWeightFilter;
        RegWeightExtendedFilter _extendedFilter;
        ReportFastExecuter _fastExecuter;
        TableConverter tableConverter;
        IMessageSender _sender;
        UnityContainer _container;
        MessageWindow _messageWindow;
        PhotoWindow _photoWindow;
        IPhotoes _photoes;

        List<string> extendedArray;

        public ViewMain(IMessageSender sender, IPhotoes photoes)
        {
            _to = DateTime.Now;
            _from = DateTime.Now;
            _ip = Properties.Settings.Default.IP;
            var p = Properties.Settings.Default.Port;
            _port = p == null || p == "" ? 0 : int.Parse(Properties.Settings.Default.Port);
            _clientService = new ClientService();
            _controlsVisible = new ObservableCollection<ControlSelectModel>();
            tableConverter = new TableConverter();
            PrepareControlVisible();
            WeightNumber = 1;
            _sender = sender;
            _photoes = photoes;

            ConnectServerCommand = new DelegateCommand(async () => await ConnectServer_Click());
            ShowWJGridCommand = new DelegateCommand<string>((s) => ShowWJGrid(s));
            
            GetFilterDatasForWeightJournalCommend = new DelegateCommand(async() => await GetFilterDatasForWeightJournal());
            GetCurrentRowIdCommand = new DelegateCommand(async() => await GetCurrentRowId());
            GetWeighNumberCommand = new DelegateCommand<string>((s) => GetWeighNumber(s));
            SendQueryForGridDatasCommand = new DelegateCommand(async() => await SendQueryForGridDatas());
            SendQueryForAxleGridDatasCommand = new DelegateCommand(async() => await SendQueryForAxleGridDatas());
            GetCurrentAxleRowIdCommand = new DelegateCommand(async() => await GetCurrentAxleRowId());
            SendQueryForExtendedGridDatasCommand = new DelegateCommand(async () => await SendQueryForExtendedGridDatas());
            ShowGridCommand = new DelegateCommand<string>((s) => ShowGrid(s));
            SendQueryForFastReportCommand = new DelegateCommand(async() => await SendQueryForFastReport());
            FormClosingCommand = new DelegateCommand(() => FormClosing());
            SaveSattingsCommand = new DelegateCommand(() => SaveConnectionSettings());
            ShowPhotoWindowCommand = new DelegateCommand<string>((s) => ShowPhotoWindow(s));

            _clientService.GetComboWJBoxDatas += GetComboWJBoxDatas;
            _clientService.GetOtherBaseComboBoxes += GetOtherBaseComboBoxes;
            _clientService.FillWeightJournalDataGrid += FillWeightJournalDataGrid;
            _clientService.FillPictureBoxWithPhoto += FillPictureBoxWithPhoto;
            _clientService.FillSimpleGridWithData += FillSimpleGridWithData;
            _clientService.FillAxleGridWithDatas += FillAxleGridWithDatas;
            _clientService.FillOnEachAxleGridWithDatas += FillOnEachAxleGridWithDatas;
            _clientService.FillExtendedGridWithDatas += FillExtendedGridWithDatas;
            _clientService.CreateXmlData += tableConverter.CreateXmlData;

            _taskFactory = new TaskFactory(TaskScheduler.FromCurrentSynchronizationContext());

            _container = new UnityContainer();
        }

        string _ip;
        public string IP
        {
            get => _ip;
            set { _ip = value; RaisePropertyChanged(nameof(IP)); }
        }

        int _port;
        public int Port
        {
            get => _port;
            set { _port = value; RaisePropertyChanged(nameof(Port)); }
        }

        DateTime _to;
        public DateTime To
        {
            get => _to;
            set { _to = value; RaisePropertyChanged(nameof(To)); }
        }

        DateTime _from;
        public DateTime From
        {
            get => _from;
            set { _from = value; RaisePropertyChanged(nameof(From)); }
        }

        string _number;
        public string Number
        {
            get => _number;
            set { _number = value; RaisePropertyChanged(nameof(Number)); }
        }

        public string Message { get; set; }

        ObservableCollection<ControlSelectModel> _controlsVisible;
        public ObservableCollection<ControlSelectModel> ControlsVisible => _controlsVisible;

        #region Properties

        Dictionary<int, string> WeiRoomIdList { get; set; }

        Dictionary<int, string> OperationTypeIdList { get; set; }

        List<Tuple<int, string>> tupleGrid;

        public List<string> WeiRoomsList { get; set; }

        public List<string> OperationTypeList { get; set; }

        private List<string> _cargoList;

        public int WeightNumber { get; set; }

        bool IsConnected;

        bool _isHandleWeighing;
        public bool IsHandleWeighing
        {
            get => _isHandleWeighing;
            set { _isHandleWeighing = value; RaisePropertyChanged(nameof(IsHandleWeighing)); }
        }

        bool _isCancelledOnly;
        public bool IsCancelledOnly
        {
            get => _isCancelledOnly;
            set { _isCancelledOnly = value; RaisePropertyChanged(nameof(IsCancelledOnly)); }
        }

        string _weiRoom;
        public string WeiRoom
        {
            get => _weiRoom;
            set { _weiRoom = value; RaisePropertyChanged(nameof(WeiRoom)); }
        }

        string _cargo;
        public string Cargo
        {
            get => _cargo;
            set { _cargo = value; RaisePropertyChanged(nameof(Cargo)); }
        }

        string _cargoType;
        public string CargoType
        {
            get => _cargoType;
            set { _cargoType = value; RaisePropertyChanged(nameof(CargoType)); }
        }

        string _counterparty;
        public string Counterparty
        {
            get => _counterparty;
            set { _counterparty = value; RaisePropertyChanged(nameof(Counterparty)); }
        }

        string _carrier;
        public string Carrier
        {
            get => _carrier;
            set { _carrier = value; RaisePropertyChanged(nameof(Carrier)); }
        }

        string _driver;
        public string Driver
        {
            get => _driver;
            set { _driver = value; RaisePropertyChanged(nameof(Driver)); }
        }

        string _store;
        public string Store
        {
            get => _store;
            set { _store = value; RaisePropertyChanged(nameof(Store)); }
        }

        string _placement;
        public string Placement
        {
            get => _placement;
            set { _placement = value; RaisePropertyChanged(nameof(Placement)); }
        }
        string _typeOperation;
        public string TypeOperation
        {
            get => _typeOperation;
            set { _typeOperation = value; RaisePropertyChanged(nameof(TypeOperation)); }
        }

        public List<string> CargoList
        {
            get => _cargoList;
            set { _cargoList = value; RaisePropertyChanged(nameof(CargoList)); }
        }

        List<string> _cargoTypeList;
        public List<string> CargoTypeList
        {
            get => _cargoTypeList;
            set { _cargoTypeList = value; RaisePropertyChanged(nameof(CargoTypeList)); }
        }

        List<string> _counterpartyList;
        public List<string> CounterpartyList
        {
            get => _counterpartyList;
            set { _counterpartyList = value; RaisePropertyChanged(nameof(CounterpartyList)); }
        }

        List<string> _carrierList;
        public List<string> CarrierList
        {
            get => _carrierList;
            set { _carrierList = value; RaisePropertyChanged(nameof(CarrierList)); }
        }

        List<string> _driverList;
        public List<string> DriverList
        {
            get => _driverList;
            set { _driverList = value;  RaisePropertyChanged(nameof(DriverList)); }
        }

        List<string> _storeList;
        public List<string> StoreList
        {
            get => _storeList;
            set { _storeList = value; RaisePropertyChanged(nameof(StoreList)); }
        }

        List<string> _placementList;
        public List<string> PlacementList
        {
            get => _placementList;
            set { _placementList = value; RaisePropertyChanged(nameof(PlacementList)); }
        }

        public byte[] Image1 { get; set; }

        public byte[] Image2 { get; set; }

        public byte[] Image3 { get; set; }

        public byte[] Image4 { get; set; }

        #endregion

        //Commands
        public DelegateCommand ConnectServerCommand { get; }
        public DelegateCommand<string> ShowWJGridCommand { get; }
        public DelegateCommand GetFilterDatasForWeightJournalCommend { get; }
        public DelegateCommand GetCurrentRowIdCommand { get; }
        public DelegateCommand<string> GetWeighNumberCommand { get; }
        public DelegateCommand SendQueryForGridDatasCommand { get; }
        public DelegateCommand SendQueryForAxleGridDatasCommand { get; }
        public DelegateCommand GetCurrentAxleRowIdCommand { get; }
        public DelegateCommand SendQueryForExtendedGridDatasCommand { get; }
        public DelegateCommand<string> ShowGridCommand { get; }
        public DelegateCommand SendQueryForFastReportCommand { get; }
        public DelegateCommand FormClosingCommand { get; }
        public DelegateCommand SaveSattingsCommand { get; }
        public DelegateCommand<string> ShowPhotoWindowCommand { get; }

        private void CheckHandleWeight()
        {

        }

        private void CheckCancellOnly()
        {

        }

        //Actions
        private async Task ConnectServer_Click()
        {
            try
            {
                _clientService.IP = IP;
                _clientService.Port = Port;
                if (!string.IsNullOrEmpty(IP) || Port != 0)
                {
                    await _clientService.ConnectAsync();
                    await _clientService.SendUserDatasAsync(" ");
                    await SendQueryForWJComboBoxDatas();
                    await SendQueryForGridComboBoxes();
                    ShowMessageWindow("Успешно!", "Соединение с сервером установленно", EnumMessage.Success);
                }
                else
                    ShowMessageWindow("Предупреждение!", "Заполните поля для соединения с сервером", EnumMessage.Danger);

                IsConnected = true;
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); IsConnected = false; }
        }

        

        List<WeighingRoomSettingsModel> serverSettings;
        private void AcceptWeighingDatas(List<WeighingRoomSettingsModel> settingsModels, bool isAxleEnable, bool isAuditEnable)
        {
            try
            {
                serverSettings = new List<WeighingRoomSettingsModel>();
                foreach (var t in settingsModels)
                {
                    serverSettings.Add(t);
                }
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No);}
        }

        //Отправка значений для комбобоксов
        private async Task SendQueryForWJComboBoxDatas()
        {
            try
            {
                await _clientService.SendQueryForWJComboBoxDatas();
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); IsConnected = false; }
        }

        //Принимает данные для комбобоксов журнала взвешиваний
        private void GetComboWJBoxDatas(Dictionary<int, string> weiRoomId, Dictionary<int, string> typeOfOper)
        {
            try
            {
                WeiRoomIdList = new Dictionary<int, string>();
                OperationTypeIdList = new Dictionary<int, string>();
                WeiRoomsList = new List<string>();
                OperationTypeList = new List<string>();

                _taskFactory.StartNew(() =>
                {
                    if (weiRoomId.Count > 0)
                        foreach (var t in weiRoomId)
                        {
                            WeiRoomIdList.Add(t.Key, t.Value);
                            WeiRoomsList.Add(t.Value);
                        }
                    if (typeOfOper.Count > 0)
                        foreach (var t in typeOfOper)
                        {
                            OperationTypeIdList.Add(t.Key, t.Value);
                            OperationTypeList.Add(t.Value);
                        }
                    RaisePropertyChanged(nameof(WeiRoomsList));
                    RaisePropertyChanged(nameof(OperationTypeList));
                });
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No);}
        }

        //Отправка значений для комбобоксов
        private async Task SendQueryForGridComboBoxes()
        {
            try
            {
                extendedArray = new List<string>() { "dir_storage", "dir_placement", "dir_cargo", "dir_typeOfCargo", "dir_counterparty", "dir_carrier",
            "dir_driver"};
                await _clientService.SendQueryForGridComboBoxes(extendedArray);

            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No);}
        }

        
        private void GetOtherBaseComboBoxes(List<List<string>> lists , List<Tuple<int, string>> tuple)
        {
            try
            {
                tupleGrid = new List<Tuple<int, string>>();
                foreach (var t in tuple)
                    tupleGrid.Add(t);

                if (lists.Count > 0)
                {
                    _storeList = lists[0];
                    _placementList = lists[1];
                    _cargoList = lists[2];
                    _cargoTypeList = lists[3];
                    _counterpartyList = lists[4];
                    _carrierList = lists[5];
                    _driverList = lists[6];
                }
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }


        #region Work with WeightJournal
        
        private async Task GetFilterDatasForWeightJournal()
        {
            try
            {
                _extendedFilter = new RegWeightExtendedFilter();
                int? topId = TypeOperation != "" ? OperationTypeIdList.Where(x => x.Value == TypeOperation).Select(y => y.Key).FirstOrDefault() : 0;
                int? wrId = WeiRoom == "" ? WeiRoomIdList.Where(x => x.Value == WeiRoom).Select(y => y.Key).FirstOrDefault() : 0;
                _regWeightFilter = new RegWeightFilter()
                {
                    From = From,
                    To = To,
                    TransportNumber = Number != "" ? Number : null,
                    HandleWeightOnly = IsHandleWeighing,
                    CancelledWeightOnly = IsCancelledOnly,
                    TypeOfOperationId = topId == 0 ? null : topId,
                    WeightRoomId = wrId == 0 ? null : wrId
                };
                await _clientService.SendFilterDatas(_regWeightFilter, _extendedFilter);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        
        public List<WeightJournalViewModel> WeightJournalViewModels { get; set; }
        private void FillWeightJournalDataGrid(List<WeightJournalViewModel> weightJournals)
        {
            try
            {
                WeightJournalViewModels = new List<WeightJournalViewModel>();
                _taskFactory.StartNew(() =>
                {
                    int num = 1;
                    foreach (var t in weightJournals)
                    {
                        WeightJournalViewModels.Add(new WeightJournalViewModel()
                        {
                            Number = num++,
                            id = t.id,
                            DateTimeFirstWeight = t.DateTimeFirstWeight,
                            FirstWeight = t.FirstWeight,
                            DateTimeSecondWeight = t.DateTimeSecondWeight,
                            SecondWeight = t.SecondWeight,
                            NumberInvoice = t.NumberInvoice,
                            DateInvoice = t.DateInvoice,
                            TrailerNumber = t.TrailerNumber,
                            TypeTransport = t.TypeTransport,
                            ModelTrailer = t.ModelTrailer,
                            ModelTransport = t.ModelTransport,
                            TransportNumber = t.TransportNumber,
                            TypeTrailer = t.TypeTrailer,
                            TypeOperation = t.TypeOperation,
                            Driver = t.Driver,
                            Cargo = t.Cargo,
                            Fund = t.Fund,
                            Carrier = t.Carrier,
                            Counterparty = t.Counterparty,
                            HandleFirstWeight = t.HandleFirstWeight,
                            HandleSecondWeight = t.HandleSecondWeight,
                            Placement = t.Placement,
                            Storage = t.Storage,
                            WeightRoomFirstWeight = t.WeightRoomFirstWeight,
                            WeightRoomSecondWeight = t.WeightRoomSecondWeight
                        });
                    }
                    
                    RaisePropertyChanged(nameof(WeightJournalViewModels));
                });
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        public int Id { get; set; }
        private async Task GetCurrentRowId()
        {
            try
            {
                RaisePropertyChanged(nameof(Id));
                if (WeightJournalViewModels.Count > 0)
                {
                    int id = WeightJournalViewModels[Id].id;
                    await _clientService.SendQueryForPhotoes(WeightNumber, id, 1);
                }
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        List<byte[]> Photos;
        private void FillPictureBoxWithPhoto(List<byte[]> photos)
        {
            try
            {
                Photos = new List<byte[]>();
                _taskFactory.StartNew(() =>
                {
                    Image1 = null;
                    Image2 = null;
                    Image3 = null;
                    Image4 = null;
                    RaisePropertyChanged(nameof(Image1));

                    if (photos.Count > 0)
                    {
                        Photos.Add(photos[0]);
                        Image1 = photos[0];
                        RaisePropertyChanged(nameof(Image1));
                    }
                    if (photos.Count > 1)
                    {
                        Photos.Add(photos[1]);
                        Image2 = photos[1];
                        RaisePropertyChanged(nameof(Image2));
                    }
                    if (photos.Count > 2)
                    {
                        Photos.Add(photos[2]);
                        Image3 = photos[2];
                        RaisePropertyChanged(nameof(Image3));
                    }
                    if (photos.Count > 3)
                    {
                        Photos.Add(photos[3]);
                        Image4 = photos[3];
                        RaisePropertyChanged(nameof(Image4));
                    }
                });
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        private void GetWeighNumber(string number)
        {
            WeightNumber = int.Parse(number);
            RaisePropertyChanged(nameof(WeightNumber));
        }

        #endregion

        #region SimpleGrid

        private async Task SendQueryForGridDatas()
        {
            try
            {
                var param = new List<string>()
                {
                     Store, Placement, Cargo, CargoType, Counterparty, Carrier, Driver, TypeOperation
                };
                extendedArray = new List<string>() { "dir_storage", "dir_placement", "dir_cargo", "dir_typeOfCargo", "dir_counterparty", "dir_carrier",
            "dir_driver", "dir_typeOfOperation"};
                await _clientService.SendQueryForGridDatas(extendedArray, param, From, To);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        public List<ReportGridData> ReportGridDatas { get; set; }
        private void FillSimpleGridWithData(List<ReportGridData> gridDataList)
        {
            ReportGridDatas = new List<ReportGridData>();

            try
            {
                _taskFactory.StartNew(() =>
                {
                    int num = 1;
                    foreach (var t in gridDataList)
                    {
                        ReportGridDatas.Add(new ReportGridData()
                        {
                            Number = num++,
                            idWeighting = t.idWeighting,
                            DateTimeFirstWeight = t.DateTimeFirstWeight,
                            DateTimeSecondWeight = t.DateTimeSecondWeight,
                            Cargo = t.Cargo,
                            Carrier = t.Carrier,
                            Counterparty = t.Counterparty,
                            Price = t.Price,
                            FirstWeight = t.FirstWeight,
                            SecondWeight = t.SecondWeight,
                            DateInvoice = t.DateInvoice,
                            Driver = t.Driver,
                            Fund = t.Fund,
                            NumberInvoice = t.NumberInvoice,
                            Placement = t.Placement,
                            Storage = t.Storage,
                            TotalCost = t.TotalCost,
                            TrailerModel = t.TrailerModel,
                            TrailerNumber = t.TrailerNumber,
                            TransportModel = t.TransportModel,
                            TransportNumber = t.TransportNumber,
                            TypeOperation = t.TypeOperation,
                            TypeTransport = t.TypeTransport
                        });
                    }
                });
                
                RaisePropertyChanged(nameof(ReportGridDatas));
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }

        }

        
        //FastReport
        private async Task SendQueryForFastReport()
        {
            try
            {
                _fastExecuter = new ReportFastExecuter();
                string id1 = "";
                string id2 = "";
                string id3 = "";
                string table = "";
                string item1 = "";
                string item2 = "";
                bool notExtended = true;
                int k = 0;
                foreach (var t in controlVisibleDictionary)
                {
                    if (t.Value && (t.Key == 1 || t.Key == 7))
                    {
                        notExtended = false;
                        List<string> param = new List<string>();
                        string[] temp = new string[9];
                        temp[0] = tupleGrid.Where(x => x.Item2 == Store).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[1] = tupleGrid.Where(x => x.Item2 == Placement).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[2] = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[3] = tupleGrid.Where(x => x.Item2 == CargoType).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[4] = tupleGrid.Where(x => x.Item2 == Counterparty).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[5] = tupleGrid.Where(x => x.Item2 == Carrier).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[6] = tupleGrid.Where(x => x.Item2 == Driver).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[7] = tupleGrid.Where(x => x.Item2 == TypeOperation).Select(y => y.Item1).FirstOrDefault().ToString();
                        temp[8] = Number;
                        for (int i = 0; i < temp.Length; i++)
                        {
                            var s = temp[i] != "0" ? temp[i] : "";
                            param.Add(s);
                        }
                        if (t.Key == 1)
                            table = "dirstorage";
                        if (t.Key == 7)
                            table = "dirdriver";

                        await _clientService.SendQueryForExtendedGridFastReport(From, To, table, param);
                    }
                    if (t.Value && t.Key == 2)
                    {
                        var t1 = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t2 = tupleGrid.Where(x => x.Item2 == CargoType).Select(y => y.Item1).FirstOrDefault().ToString();
                        item1 = Cargo;
                        item2 = CargoType;
                        id1 = t1 == "0" ? "" : t1;
                        id2 = t2 == "0" ? "" : t2;
                        table = "dircargo";
                    }
                    if (t.Value && t.Key == 3)
                    {
                        var t1 = tupleGrid.Where(x => x.Item2 == Carrier).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t2 = tupleGrid.Where(x => x.Item2 == Counterparty).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t3 = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        item1 = Cargo;
                        item2 = CargoType;
                        id1 = t1 == "0" ? "" : t1;
                        id2 = t2 == "0" ? "" : t2;
                        id3 = t3 == "0" ? "" : t3;
                        table = "dircargoCommon";
                    }
                    if (t.Value && t.Key == 4)
                    {
                        var t1 = tupleGrid.Where(x => x.Item2 == Counterparty).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t2 = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        item1 = Cargo;
                        item2 = CargoType;
                        id1 = t1 == "0" ? "" : t1;
                        id2 = t2 == "0" ? "" : t2;
                        table = "dircounterparty";
                    }
                    if (t.Value && t.Key == 5)
                    {
                        var t1 = tupleGrid.Where(x => x.Item2 == Carrier).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t2 = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        item1 = Cargo;
                        item2 = CargoType;
                        id1 = t1 == "0" ? "" : t1;
                        id2 = t2 == "0" ? "" : t2;
                        table = "dircarrier";
                    }
                    if (t.Value && t.Key == 5)
                    {
                        var t1 = tupleGrid.Where(x => x.Item2 == Counterparty).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t2 = tupleGrid.Where(x => x.Item2 == Carrier).Select(y => y.Item1).FirstOrDefault().ToString();
                        var t3 = tupleGrid.Where(x => x.Item2 == Cargo).Select(y => y.Item1).FirstOrDefault().ToString();
                        item1 = Cargo;
                        item2 = CargoType;
                        id1 = t1 == "0" ? "" : t1;
                        id2 = t2 == "0" ? "" : t2;
                        id3 = t3 == "0" ? "" : t3;
                        table = "dircarrierCommon";
                    }
                }
                if (notExtended)
                    await _clientService.SendQueryForSimpleGridFastReport(id1, id2, id3, From, To, table);
                try
                {
                    _fastExecuter.FastReportShow(table, From, To, item1, item2, false);
                }
                catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }
        #endregion

        #region Axle

        private async Task SendQueryForAxleGridDatas()
        {
            try
            {
                ReportGridFilter filter = new ReportGridFilter()
                {
                    From = From,
                    To = To
                };
                await _clientService.SendQueryForAxleGridDatas(filter);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        public List<AxleReportViewData> AxleReports { get; set; }
        private void FillAxleGridWithDatas(List<AxleReportViewData> axleReports)
        {
            AxleReports = new List<AxleReportViewData>();
            try
            {
                _taskFactory.StartNew(() =>
                {
                    foreach (var t in axleReports)
                    {
                        int k = 1;
                        float tw = 0;
                        foreach (var x in t.TotalWeifgt.Split(';').ToList())
                            tw += float.Parse(x);
                        AxleReports.Add(new AxleReportViewData()
                        {
                            Number = k++,
                            AllAxles = t.AllAxles,
                            DriverName = t.DriverName,
                            Height = t.Height,
                            WeightDate = t.WeightDate,
                            WeightTime = t.WeightTime,
                            id = t.id,
                            Length = t.Length,
                            TotalWeifgt = tw.ToString(),
                            TrailerModel = t.TrailerModel,
                            TrailerNumber = t.TrailerNumber,
                            TrailerType = t.TrailerType,
                            TransportMark = t.TransportMark,
                            TransportModel = t.TransportModel,
                            TransportNumber = t.TransportNumber,
                            TransportType = t.TransportType,
                            WeightAllowed = t.WeightAllowed,
                            WeightNumber = t.WeightNumber,
                            Width = t.Width
                        });
                    }
                });

                var gh = AxleReports.Count;
                RaisePropertyChanged(nameof(AxleReports));
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        public int AxleId { get; set; }
        private async Task GetCurrentAxleRowId()
        {
            try
            {

                RaisePropertyChanged(nameof(AxleId));
                if (AxleReports.Count > 0)
                {
                    int id = AxleReports[AxleId].id;
                    await _clientService.SendQueryForOnEachAxleTable(id);
                }
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }


        public List<OnEachAxleModel> TransportAxleWeightList { get; set; }
        AxleService axleService;
        private void FillOnEachAxleGridWithDatas(List<TransportAxleWeightViewModel> transports, List<TrailerAxleWeightViewModel> trailers, bool isTransport, bool isTrailer)
        {
            try
            {
                TransportAxleWeightList = new List<OnEachAxleModel>();
                axleService = new AxleService();
                _taskFactory.StartNew(() =>
                {
                    try
                    {
                        TransportAxleWeightList = axleService.FillOnEachAxleGridWithDatas(transports, trailers, isTransport, isTrailer, this);
                    }
                    catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
                });
                RaisePropertyChanged(nameof(TransportAxleWeightList));
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        #region ExtendedGrid 


        #endregion

        private async Task SendQueryForExtendedGridDatas()
        {
            try
            {
                var nb = Cargo;
                var datas = new List<string>()
                {
                     Store, Placement, Cargo, CargoType, Counterparty, Carrier, Driver, TypeOperation
                };
                extendedArray = new List<string>() { "dir_storage", "dir_placement", "dir_cargo", "dir_typeOfCargo", "dir_counterparty", "dir_carrier",
            "dir_driver", "dir_typeOfOperation"};
                await _clientService.SendQueryForExtendedGridDatas(datas, extendedArray, From, To, Number);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        public List<ReportExtendedGridData> ReportExtendeds { get; set; }
        private void FillExtendedGridWithDatas(List<ReportExtendedGridData> reportExtendeds)
        {
            try
            {
                ReportExtendeds = new List<ReportExtendedGridData>();
                _taskFactory.StartNew(() =>
                {
                    int num = 1;
                    foreach (var t in reportExtendeds)
                    {
                        ReportExtendeds.Add(new ReportExtendedGridData()
                        {
                            Number = num++,
                            Cargo = t.Cargo,
                            Carrier = t.Carrier,
                            Counterparty = t.Counterparty,
                            TypeOfCargo = t.TypeOfCargo,
                            DateTimeSecondWeight = t.DateTimeSecondWeight,
                            Driver = t.Driver,
                            FirstWeight = t.FirstWeight,
                            idWeighting = t.idWeighting,
                            Placement = t.Placement,
                            SecondWeight = t.SecondWeight,
                            Storage = t.Storage,
                            TransportNumber = t.TransportNumber,
                            TypeOperation = t.TypeOperation
                        });
                    }
                });
                RaisePropertyChanged(nameof(ReportExtendeds));
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        #endregion

        #region Grids
        private void ShowWJGrid(string number)
        {
            try
            {
                Image1 = null;
                Image2 = null;
                Image3 = null;
                Image4 = null;
                _to = DateTime.Now;
                _from = DateTime.Now;
                int a = int.Parse(number);
                SetControlVisible(a);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        private void ShowGrid(string number)
        {
            try
            {
                TransportAxleWeightList = new List<OnEachAxleModel>();
                RaisePropertyChanged(nameof(TransportAxleWeightList));
                _to = DateTime.Now;
                _from = DateTime.Now;
                Cargo = Carrier = TypeOperation = Counterparty = Store = Driver = Placement = CargoType = "";
                int a = int.Parse(number);
                SetControlVisible(a);
            }
            catch (Exception) { }
        }
        

        private void PrepareControlVisible()
        {
            _controlsVisible.Add(new ControlSelectModel()
            {
                IsAuditJournal = false,
                IsAxleJournal = false,
                IsExtendedJounal = false,
                IsCargoJounal = false,
                IsWeightJournal = true,
                IsCargoCommonJounal = false,
                IsSimpleCounterparty = false,
                IsCarrierCommonJounal = false,
                IsCarrierJounal = false,
                IsDriverExtendedJounal = false
            });
        }

        Dictionary<int, bool> controlVisibleDictionary;
        private void SetControlVisible(int number)
        {
            try
            {
                if (IsConnected)
                {
                    controlVisibleDictionary = new Dictionary<int, bool>();
                    for (int i = 0; i < 10; i++)
                    {
                        controlVisibleDictionary.Add(i, false);
                        if (i == number)
                            controlVisibleDictionary[i] = true;
                    }
                    _controlsVisible.FirstOrDefault().IsWeightJournal = controlVisibleDictionary[0];
                    _controlsVisible.FirstOrDefault().IsExtendedJounal = controlVisibleDictionary[1];
                    _controlsVisible.FirstOrDefault().IsCargoJounal = controlVisibleDictionary[2];
                    _controlsVisible.FirstOrDefault().IsCargoCommonJounal = controlVisibleDictionary[3];
                    _controlsVisible.FirstOrDefault().IsSimpleCounterparty = controlVisibleDictionary[4];
                    _controlsVisible.FirstOrDefault().IsCarrierJounal = controlVisibleDictionary[5];
                    _controlsVisible.FirstOrDefault().IsCarrierCommonJounal = controlVisibleDictionary[6];
                    _controlsVisible.FirstOrDefault().IsDriverExtendedJounal = controlVisibleDictionary[7];
                    _controlsVisible.FirstOrDefault().IsAxleJournal = controlVisibleDictionary[8];
                    _controlsVisible.FirstOrDefault().IsAuditJournal = controlVisibleDictionary[9];
                }
                else ShowMessageWindow("Предупреждение!", "Установите соединения с сервером", EnumMessage.Danger);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }
        #endregion

        private void CloseMessageWindow()
        {
            _messageWindow.Close();
        }

        public void ShowMessageWindow(string label, string message, EnumMessage enumMessage)
        {
            _sender.Label = label;
            _sender.Message = message;
            _sender.EnumCount = (int)enumMessage;
            _sender.CloseWindow += CloseMessageWindow;
            _container.RegisterInstance<IMessageSender>(_sender);
            _messageWindow = _container.Resolve<MessageWindow>();
            _messageWindow.ShowDialog();
        }

        private void FormClosing()
        {
            _messageWindow.Close();
            _container.Dispose();
        }

        private void SaveConnectionSettings()
        {
            try
            {
                Properties.Settings.Default.IP = IP;
                Properties.Settings.Default.Port = Port.ToString();
                Properties.Settings.Default.Save();
                ShowMessageWindow("Успешно!", "Настройки сохранены!", EnumMessage.Success);
            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }

        private void ShowPhotoWindow(string number)
        {
            try
            {
                if (Photos.Count > int.Parse(number) - 1)
                {
                    _photoes.Photos = Photos[int.Parse(number) - 1];
                    _photoes.Label = "Изображение " + number;
                    _container.RegisterInstance<IPhotoes>(_photoes);
                    _photoWindow = _container.Resolve<PhotoWindow>();
                    _photoWindow.ShowDialog();
                }
                else
                    ShowMessageWindow("Предупреждение!", "Изображение отсутствует.", EnumMessage.Danger);

            }
            catch (Exception ex) { ShowMessageWindow("Ошибка!", ex.Message, EnumMessage.No); }
        }
    }
}
