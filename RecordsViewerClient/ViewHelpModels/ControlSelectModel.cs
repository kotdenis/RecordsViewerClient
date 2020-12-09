using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RecordsViewerClient.ViewHelpModels
{
    public class ControlSelectModel :BindableBase
    {
        bool isWeightJournal;
        public bool IsWeightJournal
        {
            get => isWeightJournal;
            set { isWeightJournal = value; RaisePropertyChanged(nameof(IsWeightJournal)); }
        }

        bool isExtendedJounal;
        public bool IsExtendedJounal
        {
            get => isExtendedJounal;
            set { isExtendedJounal = value; RaisePropertyChanged(nameof(IsExtendedJounal)); }
        }

        bool isCargoJounal;
        public bool IsCargoJounal
        {
            get => isCargoJounal;
            set { isCargoJounal = value; RaisePropertyChanged(nameof(IsCargoJounal)); }
        }

        bool isCargoCommonJounal;
        public bool IsCargoCommonJounal
        {
            get => isCargoCommonJounal;
            set { isCargoCommonJounal = value; RaisePropertyChanged(nameof(IsCargoCommonJounal)); }
        }

        bool isSimpleCounterparty;
        public bool IsSimpleCounterparty
        {
            get => isSimpleCounterparty;
            set { isSimpleCounterparty = value; RaisePropertyChanged(nameof(IsSimpleCounterparty)); }
        }

        bool isCarrierJounal;
        public bool IsCarrierJounal
        {
            get => isCarrierJounal;
            set { isCarrierJounal = value; RaisePropertyChanged(nameof(IsCarrierJounal)); }
        }
        bool isCarrierCommonJounal;
        public bool IsCarrierCommonJounal
        {
            get => isCarrierCommonJounal;
            set { isCarrierCommonJounal = value; RaisePropertyChanged(nameof(IsCarrierCommonJounal)); }
        }

        bool isDriverExtendedJounal;
        public bool IsDriverExtendedJounal
        {
            get => isDriverExtendedJounal;
            set { isDriverExtendedJounal = value; RaisePropertyChanged(nameof(IsDriverExtendedJounal)); }
        }

        bool isAxleJournal;
        public bool IsAxleJournal
        {
            get => isAxleJournal;
            set { isAxleJournal = value; RaisePropertyChanged(nameof(IsAxleJournal)); }
        }

        bool isAuditJournal;
        public bool IsAuditJournal
        {
            get => isAuditJournal;
            set { isAuditJournal = value; RaisePropertyChanged(nameof(IsAuditJournal)); }
        }
    }
}
