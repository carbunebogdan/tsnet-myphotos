using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos;

namespace ObjectWCF
{
    [ServiceContract]
    public interface InterfaceTag
    {
        [OperationContract]
        bool AddTag(Tag tag, DataFile file);

        [OperationContract]
        Tag UpdateTag(Tag tag);

        [OperationContract]
        int DeleteTag(int id);

        [OperationContract]
        Tag GetTagById(int id);

        [OperationContract]
        List<Tag> GetTags();
    }
}
