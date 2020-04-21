using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    [ServiceContract]
    public interface IMyPhotosFacade : InterfaceAttribute, InterfaceDataFile, InterfaceTag
    {
    }
}
