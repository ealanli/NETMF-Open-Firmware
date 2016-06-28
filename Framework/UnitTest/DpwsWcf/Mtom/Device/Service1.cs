//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     .NET Micro Framework MFSvcUtil.Exe
//     Runtime Version:2.0.00001.0001
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Xml;
using System.Ext;
using System.Ext.Xml;
using Ws.ServiceModel;
using Ws.Services.Mtom;
using Ws.Services.Serialization;
using XmlElement = Ws.Services.Xml.WsXmlNode;
using XmlAttribute = Ws.Services.Xml.WsXmlAttribute;
using XmlConvert = Ws.Services.Serialization.WsXmlConvert;

namespace tempuri.org
{
    
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class GetData
    {
        
        [DataMember(Order=0, IsRequired=false)]
        public int value;
    }
    
    public class GetDataDataContractSerializer : DataContractSerializer
    {
        
        public GetDataDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public GetDataDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            GetData GetDataField = null;
            if (IsParentStartElement(reader, false, true))
            {
                GetDataField = new GetData();
                reader.Read();
                if (IsChildStartElement(reader, "value", false, false))
                {
                    reader.Read();
                    GetDataField.value = XmlConvert.ToInt32(reader.ReadString());
                    reader.ReadEndElement();
                }
                reader.ReadEndElement();
            }
            return GetDataField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            GetData GetDataField = ((GetData)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                if (WriteChildElement(writer, "value", false, false, GetDataField.value))
                {
                    writer.WriteString(XmlConvert.ToString(GetDataField.value));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class GetDataResponse
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public schemas.datacontract.org.WcfMtomService.MtomData GetDataResult;
    }
    
    public class GetDataResponseDataContractSerializer : DataContractSerializer
    {
        
        public GetDataResponseDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public GetDataResponseDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            GetDataResponse GetDataResponseField = null;
            if (IsParentStartElement(reader, false, true))
            {
                GetDataResponseField = new GetDataResponse();
                reader.Read();
                schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer GetDataResultDCS = new schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer("GetDataResult", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                GetDataResultDCS.BodyParts = this.BodyParts;
                GetDataResponseField.GetDataResult = ((schemas.datacontract.org.WcfMtomService.MtomData)(GetDataResultDCS.ReadObject(reader)));
                reader.ReadEndElement();
            }
            return GetDataResponseField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            GetDataResponse GetDataResponseField = ((GetDataResponse)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer GetDataResultDCS = new schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer("GetDataResult", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                GetDataResultDCS.BodyParts = this.BodyParts;
                GetDataResultDCS.WriteObject(writer, GetDataResponseField.GetDataResult);
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetData
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public schemas.datacontract.org.WcfMtomService.MtomData data;
    }
    
    public class SetDataDataContractSerializer : DataContractSerializer
    {
        
        public SetDataDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetDataDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetData SetDataField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetDataField = new SetData();
                reader.Read();
                schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer dataDCS = new schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer("data", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                dataDCS.BodyParts = this.BodyParts;
                SetDataField.data = ((schemas.datacontract.org.WcfMtomService.MtomData)(dataDCS.ReadObject(reader)));
                reader.ReadEndElement();
            }
            return SetDataField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetData SetDataField = ((SetData)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer dataDCS = new schemas.datacontract.org.WcfMtomService.MtomDataDataContractSerializer("data", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                dataDCS.BodyParts = this.BodyParts;
                dataDCS.WriteObject(writer, SetDataField.data);
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetDataResponse
    {
    }
    
    public class SetDataResponseDataContractSerializer : DataContractSerializer
    {
        
        public SetDataResponseDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetDataResponseDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetDataResponse SetDataResponseField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetDataResponseField = new SetDataResponse();
                reader.Read();
                reader.ReadEndElement();
            }
            return SetDataResponseField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetDataResponse SetDataResponseField = ((SetDataResponse)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetFileInfo
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public schemas.datacontract.org.WcfMtomService.ArrayOfFileInfo files;
    }
    
    public class SetFileInfoDataContractSerializer : DataContractSerializer
    {
        
        public SetFileInfoDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetFileInfoDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetFileInfo SetFileInfoField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetFileInfoField = new SetFileInfo();
                reader.Read();
                schemas.datacontract.org.WcfMtomService.ArrayOfFileInfoDataContractSerializer filesDCS = new schemas.datacontract.org.WcfMtomService.ArrayOfFileInfoDataContractSerializer("files", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                filesDCS.BodyParts = this.BodyParts;
                SetFileInfoField.files = ((schemas.datacontract.org.WcfMtomService.ArrayOfFileInfo)(filesDCS.ReadObject(reader)));
                reader.ReadEndElement();
            }
            return SetFileInfoField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetFileInfo SetFileInfoField = ((SetFileInfo)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                schemas.datacontract.org.WcfMtomService.ArrayOfFileInfoDataContractSerializer filesDCS = new schemas.datacontract.org.WcfMtomService.ArrayOfFileInfoDataContractSerializer("files", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                filesDCS.BodyParts = this.BodyParts;
                filesDCS.WriteObject(writer, SetFileInfoField.files);
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetFileInfoResponse
    {
    }
    
    public class SetFileInfoResponseDataContractSerializer : DataContractSerializer
    {
        
        public SetFileInfoResponseDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetFileInfoResponseDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetFileInfoResponse SetFileInfoResponseField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetFileInfoResponseField = new SetFileInfoResponse();
                reader.Read();
                reader.ReadEndElement();
            }
            return SetFileInfoResponseField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetFileInfoResponse SetFileInfoResponseField = ((SetFileInfoResponse)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class GetNestedData
    {
    }
    
    public class GetNestedDataDataContractSerializer : DataContractSerializer
    {
        
        public GetNestedDataDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public GetNestedDataDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            GetNestedData GetNestedDataField = null;
            if (IsParentStartElement(reader, false, true))
            {
                GetNestedDataField = new GetNestedData();
                reader.Read();
                reader.ReadEndElement();
            }
            return GetNestedDataField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            GetNestedData GetNestedDataField = ((GetNestedData)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class GetNestedDataResponse
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public schemas.datacontract.org.WcfMtomService.NestedClass GetNestedDataResult;
    }
    
    public class GetNestedDataResponseDataContractSerializer : DataContractSerializer
    {
        
        public GetNestedDataResponseDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public GetNestedDataResponseDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            GetNestedDataResponse GetNestedDataResponseField = null;
            if (IsParentStartElement(reader, false, true))
            {
                GetNestedDataResponseField = new GetNestedDataResponse();
                reader.Read();
                schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer GetNestedDataResultDCS = new schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer("GetNestedDataResult", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                GetNestedDataResultDCS.BodyParts = this.BodyParts;
                GetNestedDataResponseField.GetNestedDataResult = ((schemas.datacontract.org.WcfMtomService.NestedClass)(GetNestedDataResultDCS.ReadObject(reader)));
                reader.ReadEndElement();
            }
            return GetNestedDataResponseField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            GetNestedDataResponse GetNestedDataResponseField = ((GetNestedDataResponse)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer GetNestedDataResultDCS = new schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer("GetNestedDataResult", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                GetNestedDataResultDCS.BodyParts = this.BodyParts;
                GetNestedDataResultDCS.WriteObject(writer, GetNestedDataResponseField.GetNestedDataResult);
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetNestedData
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public schemas.datacontract.org.WcfMtomService.NestedClass data;
    }
    
    public class SetNestedDataDataContractSerializer : DataContractSerializer
    {
        
        public SetNestedDataDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetNestedDataDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetNestedData SetNestedDataField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetNestedDataField = new SetNestedData();
                reader.Read();
                schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer dataDCS = new schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer("data", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                dataDCS.BodyParts = this.BodyParts;
                SetNestedDataField.data = ((schemas.datacontract.org.WcfMtomService.NestedClass)(dataDCS.ReadObject(reader)));
                reader.ReadEndElement();
            }
            return SetNestedDataField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetNestedData SetNestedDataField = ((SetNestedData)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer dataDCS = new schemas.datacontract.org.WcfMtomService.NestedClassDataContractSerializer("data", "http://tempuri.org/", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                dataDCS.BodyParts = this.BodyParts;
                dataDCS.WriteObject(writer, SetNestedDataField.data);
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://tempuri.org/")]
    public class SetNestedDataResponse
    {
    }
    
    public class SetNestedDataResponseDataContractSerializer : DataContractSerializer
    {
        
        public SetNestedDataResponseDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public SetNestedDataResponseDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            SetNestedDataResponse SetNestedDataResponseField = null;
            if (IsParentStartElement(reader, false, true))
            {
                SetNestedDataResponseField = new SetNestedDataResponse();
                reader.Read();
                reader.ReadEndElement();
            }
            return SetNestedDataResponseField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            SetNestedDataResponse SetNestedDataResponseField = ((SetNestedDataResponse)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [ServiceContract(Namespace="http://tempuri.org/")]
    [PolicyAssertion(Namespace="http://schemas.xmlsoap.org/ws/2004/09/policy/optimizedmimeserialization", Name="OptimizedMimeSerialization", PolicyID="WSHttpBinding_IDataAccessService_policy")]
    [PolicyAssertion(Namespace="http://www.w3.org/2006/05/addressing/wsdl", Name="UsingAddressing", PolicyID="WSHttpBinding_IDataAccessService_policy")]
    public interface IIDataAccessService
    {
        
        [OperationContract(Action="http://tempuri.org/IDataAccessService/GetData")]
        GetDataResponse GetData(GetData req);
        
        [OperationContract(Action="http://tempuri.org/IDataAccessService/SetData")]
        SetDataResponse SetData(SetData req);
        
        [OperationContract(Action="http://tempuri.org/IDataAccessService/SetFileInfo")]
        SetFileInfoResponse SetFileInfo(SetFileInfo req);
        
        [OperationContract(Action="http://tempuri.org/IDataAccessService/GetNestedData")]
        GetNestedDataResponse GetNestedData(GetNestedData req);
        
        [OperationContract(Action="http://tempuri.org/IDataAccessService/SetNestedData")]
        SetNestedDataResponse SetNestedData(SetNestedData req);
    }
}
namespace schemas.datacontract.org.WcfMtomService
{
    
    
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/WcfMtomService")]
    public class MtomData
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public byte[] Data;
    }
    
    public class MtomDataDataContractSerializer : DataContractSerializer
    {
        
        public MtomDataDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public MtomDataDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            MtomData MtomDataField = null;
            if (IsParentStartElement(reader, false, true))
            {
                MtomDataField = new MtomData();
                reader.Read();
                if (IsChildStartElement(reader, "Data", true, false))
                {
                    reader.Read();
                    if (IsAttribute(reader, "href"))
                    {
                        string contentID;
                        contentID = reader.Value;
                        reader.MoveToElement();
                        reader.ReadStartElement("Include", "http://www.w3.org/2004/08/xop/include");
                        reader.ReadEndElement();
                        MtomDataField.Data = GetBodyPartContent(contentID, BodyParts);
                    }
                    else
                    {
                        MtomDataField.Data = ConvertBase64.FromBase64String(reader.ReadString());
                        reader.ReadEndElement();
                    }
                }
                reader.ReadEndElement();
            }
            return MtomDataField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            MtomData MtomDataField = ((MtomData)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                if (WriteChildElement(writer, "Data", true, false, MtomDataField.Data))
                {
                    BodyParts.Add(CreateNewBodyPart(MtomDataField.Data, "<1@body>"));
                    writer.WriteStartElement("xop", "Include", "http://www.w3.org/2004/08/xop/include");
                    writer.WriteAttributeString(null, "href", null, "cid:1@body");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/WcfMtomService")]
    public class FileInfo
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public string Name;
        
        [DataMember(Order=1, IsRequired=false)]
        public int Size;
    }
    
    public class FileInfoDataContractSerializer : DataContractSerializer
    {
        
        public FileInfoDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public FileInfoDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            FileInfo FileInfoField = null;
            if (IsParentStartElement(reader, false, true))
            {
                FileInfoField = new FileInfo();
                reader.Read();
                if (IsChildStartElement(reader, "Name", true, false))
                {
                    reader.Read();
                    FileInfoField.Name = reader.ReadString();
                    reader.ReadEndElement();
                }
                if (IsChildStartElement(reader, "Size", false, false))
                {
                    reader.Read();
                    FileInfoField.Size = XmlConvert.ToInt32(reader.ReadString());
                    reader.ReadEndElement();
                }
                reader.ReadEndElement();
            }
            return FileInfoField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            FileInfo FileInfoField = ((FileInfo)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                if (WriteChildElement(writer, "Name", true, false, FileInfoField.Name))
                {
                    writer.WriteString(FileInfoField.Name);
                    writer.WriteEndElement();
                }
                if (WriteChildElement(writer, "Size", false, false, FileInfoField.Size))
                {
                    writer.WriteString(XmlConvert.ToString(FileInfoField.Size));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/WcfMtomService")]
    public class ArrayOfFileInfo
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public FileInfo[] FileInfo;
    }
    
    public class ArrayOfFileInfoDataContractSerializer : DataContractSerializer
    {
        
        public ArrayOfFileInfoDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public ArrayOfFileInfoDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            ArrayOfFileInfo ArrayOfFileInfoField = null;
            if (IsParentStartElement(reader, false, true))
            {
                ArrayOfFileInfoField = new ArrayOfFileInfo();
                reader.Read();
                FileInfoDataContractSerializer FileInfoDCS = new FileInfoDataContractSerializer("FileInfo", "http://schemas.datacontract.org/2004/07/WcfMtomService", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                System.Collections.ArrayList FileInfo_List = new System.Collections.ArrayList();
                for (int i = 0; (i > -1); i = (i + 1))
                {
                    if (!IsChildStartElement(reader, "FileInfo", false, false))
                    {
                        ArrayOfFileInfoField.FileInfo = new FileInfo[FileInfo_List.Count];
                        FileInfo_List.CopyTo(ArrayOfFileInfoField.FileInfo);
						break;
                    }
                    FileInfo_List.Add(((FileInfo)(FileInfoDCS.ReadObject(reader))));
                }
                reader.ReadEndElement();
            }
            return ArrayOfFileInfoField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            ArrayOfFileInfo ArrayOfFileInfoField = ((ArrayOfFileInfo)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                FileInfoDataContractSerializer FileInfoDCS = new FileInfoDataContractSerializer("FileInfo", "http://schemas.datacontract.org/2004/07/WcfMtomService", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                for (int i = 0; (i < ArrayOfFileInfoField.FileInfo.Length); i = (i + 1))
                {
                    FileInfoDCS.WriteObject(writer, ArrayOfFileInfoField.FileInfo[i]);
                }
                writer.WriteEndElement();
            }
            return;
        }
    }
    
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/WcfMtomService")]
    public class NestedClass
    {
        
        [DataMember(Order=0, IsNillable=true, IsRequired=false)]
        public MtomData MTData;
        
        [DataMember(Order=1, IsNillable=true, IsRequired=false)]
        public byte[] MyData;
    }
    
    public class NestedClassDataContractSerializer : DataContractSerializer
    {
        
        public NestedClassDataContractSerializer(string rootName, string rootNameSpace) : 
                base(rootName, rootNameSpace)
        {
        }
        
        public NestedClassDataContractSerializer(string rootName, string rootNameSpace, string localNameSpace) : 
                base(rootName, rootNameSpace, localNameSpace)
        {
        }
        
        public override object ReadObject(XmlReader reader)
        {
            NestedClass NestedClassField = null;
            if (IsParentStartElement(reader, false, true))
            {
                NestedClassField = new NestedClass();
                reader.Read();
                MtomDataDataContractSerializer MTDataDCS = new MtomDataDataContractSerializer("MTData", "http://schemas.datacontract.org/2004/07/WcfMtomService", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                MTDataDCS.BodyParts = this.BodyParts;
                NestedClassField.MTData = ((MtomData)(MTDataDCS.ReadObject(reader)));
                if (IsChildStartElement(reader, "MyData", true, false))
                {
                    reader.Read();
                    if (IsAttribute(reader, "href"))
                    {
                        string contentID;
                        contentID = reader.Value;
                        reader.MoveToElement();
                        reader.ReadStartElement("Include", "http://www.w3.org/2004/08/xop/include");
                        reader.ReadEndElement();
                        NestedClassField.MyData = GetBodyPartContent(contentID, BodyParts);
                    }
                    else
                    {
                        NestedClassField.MyData = ConvertBase64.FromBase64String(reader.ReadString());
                        reader.ReadEndElement();
                    }
                }
                reader.ReadEndElement();
            }
            return NestedClassField;
        }
        
        public override void WriteObject(XmlWriter writer, object graph)
        {
            NestedClass NestedClassField = ((NestedClass)(graph));
            if (WriteParentElement(writer, true, true, graph))
            {
                MtomDataDataContractSerializer MTDataDCS = new MtomDataDataContractSerializer("MTData", "http://schemas.datacontract.org/2004/07/WcfMtomService", "http://schemas.datacontract.org/2004/07/WcfMtomService");
                MTDataDCS.BodyParts = this.BodyParts;
                MTDataDCS.WriteObject(writer, NestedClassField.MTData);
                if (WriteChildElement(writer, "MyData", true, false, NestedClassField.MyData))
                {
                    BodyParts.Add(CreateNewBodyPart(NestedClassField.MyData, "<2@body>"));
                    writer.WriteStartElement("xop", "Include", "http://www.w3.org/2004/08/xop/include");
                    writer.WriteAttributeString(null, "href", null, "cid:2@body");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            return;
        }
    }
}