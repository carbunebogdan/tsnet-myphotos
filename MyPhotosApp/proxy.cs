﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotos
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Attribute", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos", IsReference = true)]
    public partial class Attribute : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private MyPhotos.DataFile DataFileField;

        private int DataFileIdField;

        private int IdField;

        private string NameField;

        private string ValueField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.DataFile DataFile
        {
            get
            {
                return this.DataFileField;
            }
            set
            {
                this.DataFileField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DataFileId
        {
            get
            {
                return this.DataFileIdField;
            }
            set
            {
                this.DataFileIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DataFile", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos", IsReference = true)]
    public partial class DataFile : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private MyPhotos.Attribute[] AttributesField;

        private System.DateTime CreationDateField;

        private System.Nullable<bool> DeletedField;

        private int IdField;

        private string LocationField;

        private string NameField;

        private string PathField;

        private MyPhotos.Tag[] TagsField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Attribute[] Attributes
        {
            get
            {
                return this.AttributesField;
            }
            set
            {
                this.AttributesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this.CreationDateField;
            }
            set
            {
                this.CreationDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.Tag[] Tags
        {
            get
            {
                return this.TagsField;
            }
            set
            {
                this.TagsField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Tag", Namespace = "http://schemas.datacontract.org/2004/07/MyPhotos", IsReference = true)]
    public partial class Tag : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private MyPhotos.DataFile[] DataFilesField;

        private int IdField;

        private string NameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyPhotos.DataFile[] DataFiles
        {
            get
            {
                return this.DataFilesField;
            }
            set
            {
                this.DataFilesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMyPhotosFacade")]
public interface IMyPhotosFacade
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/AddAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/AddAttributeResponse")]
    bool AddAttribute(MyPhotos.Attribute attribute);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/AddAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/AddAttributeResponse")]
    System.Threading.Tasks.Task<bool> AddAttributeAsync(MyPhotos.Attribute attribute);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/UpdateAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/UpdateAttributeResponse")]
    MyPhotos.Attribute UpdateAttribute(MyPhotos.Attribute attribute);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/UpdateAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/UpdateAttributeResponse")]
    System.Threading.Tasks.Task<MyPhotos.Attribute> UpdateAttributeAsync(MyPhotos.Attribute attribute);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/DeleteAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/DeleteAttributeResponse")]
    int DeleteAttribute(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/DeleteAttribute", ReplyAction = "http://tempuri.org/InterfaceAttribute/DeleteAttributeResponse")]
    System.Threading.Tasks.Task<int> DeleteAttributeAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/GetAttributeById", ReplyAction = "http://tempuri.org/InterfaceAttribute/GetAttributeByIdResponse")]
    MyPhotos.Attribute GetAttributeById(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/GetAttributeById", ReplyAction = "http://tempuri.org/InterfaceAttribute/GetAttributeByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Attribute> GetAttributeByIdAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/GetAttributes", ReplyAction = "http://tempuri.org/InterfaceAttribute/GetAttributesResponse")]
    MyPhotos.Attribute[] GetAttributes();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceAttribute/GetAttributes", ReplyAction = "http://tempuri.org/InterfaceAttribute/GetAttributesResponse")]
    System.Threading.Tasks.Task<MyPhotos.Attribute[]> GetAttributesAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/AddDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/AddDataFileResponse")]
    bool AddDataFile(MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/AddDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/AddDataFileResponse")]
    System.Threading.Tasks.Task<bool> AddDataFileAsync(MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/UpdateDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/UpdateDataFileResponse")]
    MyPhotos.DataFile UpdateDataFile(MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/UpdateDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/UpdateDataFileResponse")]
    System.Threading.Tasks.Task<MyPhotos.DataFile> UpdateDataFileAsync(MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/DeleteDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/DeleteDataFileResponse")]
    int DeleteDataFile(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/DeleteDataFile", ReplyAction = "http://tempuri.org/InterfaceDataFile/DeleteDataFileResponse")]
    System.Threading.Tasks.Task<int> DeleteDataFileAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/GetDataFileById", ReplyAction = "http://tempuri.org/InterfaceDataFile/GetDataFileByIdResponse")]
    MyPhotos.DataFile GetDataFileById(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/GetDataFileById", ReplyAction = "http://tempuri.org/InterfaceDataFile/GetDataFileByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.DataFile> GetDataFileByIdAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/GetDataFiles", ReplyAction = "http://tempuri.org/InterfaceDataFile/GetDataFilesResponse")]
    MyPhotos.DataFile[] GetDataFiles();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceDataFile/GetDataFiles", ReplyAction = "http://tempuri.org/InterfaceDataFile/GetDataFilesResponse")]
    System.Threading.Tasks.Task<MyPhotos.DataFile[]> GetDataFilesAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/AddTag", ReplyAction = "http://tempuri.org/InterfaceTag/AddTagResponse")]
    bool AddTag(MyPhotos.Tag tag, MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/AddTag", ReplyAction = "http://tempuri.org/InterfaceTag/AddTagResponse")]
    System.Threading.Tasks.Task<bool> AddTagAsync(MyPhotos.Tag tag, MyPhotos.DataFile file);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/UpdateTag", ReplyAction = "http://tempuri.org/InterfaceTag/UpdateTagResponse")]
    MyPhotos.Tag UpdateTag(MyPhotos.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/UpdateTag", ReplyAction = "http://tempuri.org/InterfaceTag/UpdateTagResponse")]
    System.Threading.Tasks.Task<MyPhotos.Tag> UpdateTagAsync(MyPhotos.Tag tag);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/DeleteTag", ReplyAction = "http://tempuri.org/InterfaceTag/DeleteTagResponse")]
    int DeleteTag(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/DeleteTag", ReplyAction = "http://tempuri.org/InterfaceTag/DeleteTagResponse")]
    System.Threading.Tasks.Task<int> DeleteTagAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/GetTagById", ReplyAction = "http://tempuri.org/InterfaceTag/GetTagByIdResponse")]
    MyPhotos.Tag GetTagById(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/GetTagById", ReplyAction = "http://tempuri.org/InterfaceTag/GetTagByIdResponse")]
    System.Threading.Tasks.Task<MyPhotos.Tag> GetTagByIdAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/GetTags", ReplyAction = "http://tempuri.org/InterfaceTag/GetTagsResponse")]
    MyPhotos.Tag[] GetTags();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/InterfaceTag/GetTags", ReplyAction = "http://tempuri.org/InterfaceTag/GetTagsResponse")]
    System.Threading.Tasks.Task<MyPhotos.Tag[]> GetTagsAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyPhotosFacadeChannel : IMyPhotosFacade, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyPhotosFacadeClient : System.ServiceModel.ClientBase<IMyPhotosFacade>, IMyPhotosFacade
{

    public MyPhotosFacadeClient()
    {
    }

    public MyPhotosFacadeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public MyPhotosFacadeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosFacadeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public MyPhotosFacadeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public bool AddAttribute(MyPhotos.Attribute attribute)
    {
        return base.Channel.AddAttribute(attribute);
    }

    public System.Threading.Tasks.Task<bool> AddAttributeAsync(MyPhotos.Attribute attribute)
    {
        return base.Channel.AddAttributeAsync(attribute);
    }

    public MyPhotos.Attribute UpdateAttribute(MyPhotos.Attribute attribute)
    {
        return base.Channel.UpdateAttribute(attribute);
    }

    public System.Threading.Tasks.Task<MyPhotos.Attribute> UpdateAttributeAsync(MyPhotos.Attribute attribute)
    {
        return base.Channel.UpdateAttributeAsync(attribute);
    }

    public int DeleteAttribute(int id)
    {
        return base.Channel.DeleteAttribute(id);
    }

    public System.Threading.Tasks.Task<int> DeleteAttributeAsync(int id)
    {
        return base.Channel.DeleteAttributeAsync(id);
    }

    public MyPhotos.Attribute GetAttributeById(int id)
    {
        return base.Channel.GetAttributeById(id);
    }

    public System.Threading.Tasks.Task<MyPhotos.Attribute> GetAttributeByIdAsync(int id)
    {
        return base.Channel.GetAttributeByIdAsync(id);
    }

    public MyPhotos.Attribute[] GetAttributes()
    {
        return base.Channel.GetAttributes();
    }

    public System.Threading.Tasks.Task<MyPhotos.Attribute[]> GetAttributesAsync()
    {
        return base.Channel.GetAttributesAsync();
    }

    public bool AddDataFile(MyPhotos.DataFile file)
    {
        return base.Channel.AddDataFile(file);
    }

    public System.Threading.Tasks.Task<bool> AddDataFileAsync(MyPhotos.DataFile file)
    {
        return base.Channel.AddDataFileAsync(file);
    }

    public MyPhotos.DataFile UpdateDataFile(MyPhotos.DataFile file)
    {
        return base.Channel.UpdateDataFile(file);
    }

    public System.Threading.Tasks.Task<MyPhotos.DataFile> UpdateDataFileAsync(MyPhotos.DataFile file)
    {
        return base.Channel.UpdateDataFileAsync(file);
    }

    public int DeleteDataFile(int id)
    {
        return base.Channel.DeleteDataFile(id);
    }

    public System.Threading.Tasks.Task<int> DeleteDataFileAsync(int id)
    {
        return base.Channel.DeleteDataFileAsync(id);
    }

    public MyPhotos.DataFile GetDataFileById(int id)
    {
        return base.Channel.GetDataFileById(id);
    }

    public System.Threading.Tasks.Task<MyPhotos.DataFile> GetDataFileByIdAsync(int id)
    {
        return base.Channel.GetDataFileByIdAsync(id);
    }

    public MyPhotos.DataFile[] GetDataFiles()
    {
        return base.Channel.GetDataFiles();
    }

    public System.Threading.Tasks.Task<MyPhotos.DataFile[]> GetDataFilesAsync()
    {
        return base.Channel.GetDataFilesAsync();
    }

    public bool AddTag(MyPhotos.Tag tag, MyPhotos.DataFile file)
    {
        return base.Channel.AddTag(tag, file);
    }

    public System.Threading.Tasks.Task<bool> AddTagAsync(MyPhotos.Tag tag, MyPhotos.DataFile file)
    {
        return base.Channel.AddTagAsync(tag, file);
    }

    public MyPhotos.Tag UpdateTag(MyPhotos.Tag tag)
    {
        return base.Channel.UpdateTag(tag);
    }

    public System.Threading.Tasks.Task<MyPhotos.Tag> UpdateTagAsync(MyPhotos.Tag tag)
    {
        return base.Channel.UpdateTagAsync(tag);
    }

    public int DeleteTag(int id)
    {
        return base.Channel.DeleteTag(id);
    }

    public System.Threading.Tasks.Task<int> DeleteTagAsync(int id)
    {
        return base.Channel.DeleteTagAsync(id);
    }

    public MyPhotos.Tag GetTagById(int id)
    {
        return base.Channel.GetTagById(id);
    }

    public System.Threading.Tasks.Task<MyPhotos.Tag> GetTagByIdAsync(int id)
    {
        return base.Channel.GetTagByIdAsync(id);
    }

    public MyPhotos.Tag[] GetTags()
    {
        return base.Channel.GetTags();
    }

    public System.Threading.Tasks.Task<MyPhotos.Tag[]> GetTagsAsync()
    {
        return base.Channel.GetTagsAsync();
    }
}
