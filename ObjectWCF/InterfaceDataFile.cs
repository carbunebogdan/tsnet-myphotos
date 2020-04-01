using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceDataFile
    {
        [OperationContract]
        bool AddDataFile(DataFile file);

        [OperationContract]
        DataFile UpdateDataFile(DataFile file);

        [OperationContract]
        int DeleteDataFile(int id);

        [OperationContract]
        DataFile GetDataFileById(int id);

        [OperationContract]
        List<DataFile> GetDataFiles();
    }

}
