﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfReportCreator.ServiceReferenceSampleReport {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sample", Namespace="http://www.newlifechou.com")]
    [System.SerializableAttribute()]
    public partial class Sample : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ForTargetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaterialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string POField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Weight1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Weight2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Weight3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Weight4Field;
        
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
        public string ForTarget {
            get {
                return this.ForTargetField;
            }
            set {
                if ((object.ReferenceEquals(this.ForTargetField, value) != true)) {
                    this.ForTargetField = value;
                    this.RaisePropertyChanged("ForTarget");
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
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight1 {
            get {
                return this.Weight1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Weight1Field, value) != true)) {
                    this.Weight1Field = value;
                    this.RaisePropertyChanged("Weight1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight2 {
            get {
                return this.Weight2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Weight2Field, value) != true)) {
                    this.Weight2Field = value;
                    this.RaisePropertyChanged("Weight2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight3 {
            get {
                return this.Weight3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Weight3Field, value) != true)) {
                    this.Weight3Field = value;
                    this.RaisePropertyChanged("Weight3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight4 {
            get {
                return this.Weight4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Weight4Field, value) != true)) {
                    this.Weight4Field = value;
                    this.RaisePropertyChanged("Weight4");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.newlifechou.com", ConfigurationName="ServiceReferenceSampleReport.ISampleReportService")]
    public interface ISampleReportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSamples", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSamplesResponse")]
        WpfReportCreator.ServiceReferenceSampleReport.Sample[] GetSamples(int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSamples", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSamplesResponse")]
        System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceSampleReport.Sample[]> GetSamplesAsync(int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSamplesByCondition", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSamplesByConditionResponse")]
        WpfReportCreator.ServiceReferenceSampleReport.Sample[] GetSamplesByCondition(string lot, string customer, int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSamplesByCondition", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSamplesByConditionResponse")]
        System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceSampleReport.Sample[]> GetSamplesByConditionAsync(string lot, string customer, int skip, int take);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSampleCount", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSampleCountResponse")]
        int GetSampleCount(string lot, string customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/GetSampleCount", ReplyAction="http://www.newlifechou.com/ISampleReportService/GetSampleCountResponse")]
        System.Threading.Tasks.Task<int> GetSampleCountAsync(string lot, string customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/AddSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/AddSampleResponse")]
        bool AddSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/AddSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/AddSampleResponse")]
        System.Threading.Tasks.Task<bool> AddSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/UpdateSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/UpdateSampleResponse")]
        bool UpdateSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/UpdateSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/UpdateSampleResponse")]
        System.Threading.Tasks.Task<bool> UpdateSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/DeleteSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/DeleteSampleResponse")]
        bool DeleteSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.newlifechou.com/ISampleReportService/DeleteSample", ReplyAction="http://www.newlifechou.com/ISampleReportService/DeleteSampleResponse")]
        System.Threading.Tasks.Task<bool> DeleteSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleReportServiceChannel : WpfReportCreator.ServiceReferenceSampleReport.ISampleReportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleReportServiceClient : System.ServiceModel.ClientBase<WpfReportCreator.ServiceReferenceSampleReport.ISampleReportService>, WpfReportCreator.ServiceReferenceSampleReport.ISampleReportService {
        
        public SampleReportServiceClient() {
        }
        
        public SampleReportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleReportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleReportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleReportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfReportCreator.ServiceReferenceSampleReport.Sample[] GetSamples(int skip, int take) {
            return base.Channel.GetSamples(skip, take);
        }
        
        public System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceSampleReport.Sample[]> GetSamplesAsync(int skip, int take) {
            return base.Channel.GetSamplesAsync(skip, take);
        }
        
        public WpfReportCreator.ServiceReferenceSampleReport.Sample[] GetSamplesByCondition(string lot, string customer, int skip, int take) {
            return base.Channel.GetSamplesByCondition(lot, customer, skip, take);
        }
        
        public System.Threading.Tasks.Task<WpfReportCreator.ServiceReferenceSampleReport.Sample[]> GetSamplesByConditionAsync(string lot, string customer, int skip, int take) {
            return base.Channel.GetSamplesByConditionAsync(lot, customer, skip, take);
        }
        
        public int GetSampleCount(string lot, string customer) {
            return base.Channel.GetSampleCount(lot, customer);
        }
        
        public System.Threading.Tasks.Task<int> GetSampleCountAsync(string lot, string customer) {
            return base.Channel.GetSampleCountAsync(lot, customer);
        }
        
        public bool AddSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.AddSample(sample);
        }
        
        public System.Threading.Tasks.Task<bool> AddSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.AddSampleAsync(sample);
        }
        
        public bool UpdateSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.UpdateSample(sample);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.UpdateSampleAsync(sample);
        }
        
        public bool DeleteSample(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.DeleteSample(sample);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSampleAsync(WpfReportCreator.ServiceReferenceSampleReport.Sample sample) {
            return base.Channel.DeleteSampleAsync(sample);
        }
    }
}
