using System;

namespace Jehring.Common
{
    public static class ComObject
    {
        public static object CreateCOMObject(string objectName, bool thrwoerror = false) => Activator.CreateInstance(Type.GetTypeFromProgID(objectName, thrwoerror));

    }
}
