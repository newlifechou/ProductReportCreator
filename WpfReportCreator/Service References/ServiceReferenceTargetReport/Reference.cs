﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfReportCreator.ServiceReferenceTargetReport {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Target", Namespace="Http://www.newlifechou.com")]
    [System.SerializableAttribute()]
    public partial class Target : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DensityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaterialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string POField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WeightField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Density {
            get {
                return this.DensityField;
            }
            set {
                if ((object.ReferenceEquals(this.DensityField, value) != true)) {
                    this.DensityField = value;
                    this.RaisePropertyChanged("Density");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lot {
            get {
                return this.LotField;
            }
            set {
                if ((object.ReferenceEquals(this.LotField, value) != true)) {
                    this.LotField = value;
                    this.RaisePropertyChanged("Lot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Material {
            get {
                return this.MaterialField;
            }
            set {
                if ((object.ReferenceEquals(this.MaterialField, value) != true)) {
                    this.MaterialField = value;
                    this.RaisePropertyChanged("Material");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PO {
            get {
                return this.POField;
            }
            set {
                if ((object.ReferenceEquals(this.POField, value) != true)) {
                    this.POField = value;
                    this.RaisePropertyChanged("PO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resistance {
            get {
                return this.ResistanceField;
            }
            set {
                if ((object.ReferenceEquals(this.ResistanceField, value) != true)) {
                    this.ResistanceField = value;
                    this.RaisePropertyChanged("Resistance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Size {
            get {
                return this.SizeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeField, value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((object.ReferenceEquals(this.WeightField, value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.newlifechou.com", ConfigurationName="ServiceReferenceTargetReport.ITargetReportService")]
    public interface ITargetReportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargets", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetsResponse")]
        WpfReportCreator.ServiceReferenceTargetReport.Target[] GetTargets(int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargets", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetsResponse")]
        System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceTargetReport.Target[]> GetTargetsAsync(int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargetsByCondition", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetsByConditionResponse")]
        WpfReportCreator.ServiceReferenceTargetReport.Target[] GetTargetsByCondition(string lot, string customer, int take, int skip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargetsByCondition", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetsByConditionResponse")]
        System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceTargetReport.Target[]> GetTargetsByConditionAsync(string lot, string customer, int take, int skip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargetCount", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetCountResponse")]
        int GetTargetCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/GetTargetCount", ReplyAction="http://www.newlifechou.com/ITargetReportService/GetTargetCountResponse")]
        System.Threading.Tasks.Task<int> GetTargetCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/AddTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/AddTargetResponse")]
        bool AddTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/AddTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/AddTargetResponse")]
        System.Threading.Tasks.Task<bool> AddTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/UpdateTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/UpdateTargetResponse")]
        bool UpdateTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/UpdateTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/UpdateTargetResponse")]
        System.Threading.Tasks.Task<bool> UpdateTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/DeleteTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/DeleteTargetResponse")]
        bool DeleteTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ITargetReportService/DeleteTarget", ReplyAction="http://www.newlifechou.com/ITargetReportService/DeleteTargetResponse")]
        System.Threading.Tasks.Task<bool> DeleteTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITargetReportServiceChannel : WpfReportCreator.ServiceReferenceTargetReport.ITargetReportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TargetReportServiceClient : System.ServiceModel.ClientBase<WpfReportCreator.ServiceReferenceTargetReport.ITargetReportService>, WpfReportCreator.ServiceReferenceTargetReport.ITargetReportService {
        
        public TargetReportServiceClient() {
        }
        
        public TargetReportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TargetReportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetReportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetReportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfReportCreator.ServiceReferenceTargetReport.Target[] GetTargets(int skip, int take) {
            return base.Channel.GetTargets(skip, take);
        }
        
        public System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceTargetReport.Target[]> GetTargetsAsync(int skip, int take) {
            return base.Channel.GetTargetsAsync(skip, take);
        }
        
        public WpfReportCreator.ServiceReferenceTargetReport.Target[] GetTargetsByCondition(string lot, string customer, int take, int skip) {
            return base.Channel.GetTargetsByCondition(lot, customer, take, skip);
        }
        
        public System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceTargetReport.Target[]> GetTargetsByConditionAsync(string lot, string customer, int take, int skip) {
            return base.Channel.GetTargetsByConditionAsync(lot, customer, take, skip);
        }
        
        public int GetTargetCount() {
            return base.Channel.GetTargetCount();
        }
        
        public System.Threading.Tasks.Task<int> GetTargetCountAsync() {
            return base.Channel.GetTargetCountAsync();
        }
        
        public bool AddTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.AddTarget(product);
        }
        
        public System.Threading.Tasks.Task<bool> AddTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.AddTargetAsync(product);
        }
        
        public bool UpdateTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.UpdateTarget(product);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.UpdateTargetAsync(product);
        }
        
        public bool DeleteTarget(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.DeleteTarget(product);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteTargetAsync(WpfReportCreator.ServiceReferenceTargetReport.Target product) {
            return base.Channel.DeleteTargetAsync(product);
        }
    }
}
