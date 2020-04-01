using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceAttribute
    {
        [OperationContract]
        bool AddAttribute(Attribute attribute);

        [OperationContract]
        DataFile UpdateAttribute(Attribute attribute);

        [OperationContract]
        int DeleteAttribute(int id);

        [OperationContract]
        Attribute GetAttributeById(int id);

        [OperationContract]
        List<Attribute> GetAttributes();
    }
}
