using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Jehring.Common
{
    public static class XMLSerialize
    {
        public static string Serialize<T>(this T toSerialize)
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                new XmlSerializer(toSerialize.GetType()).Serialize(stringWriter, toSerialize);
                return stringWriter.ToString();
            }
        }

        public static T Deserialize<T>(this string toDeserialize)
        {
            using (StringReader stringReader = new StringReader(toDeserialize))
                return (T)new XmlSerializer(typeof(T)).Deserialize(stringReader);
        }
    }
}
