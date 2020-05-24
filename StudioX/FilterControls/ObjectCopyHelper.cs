using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudioX.FilterControls
{
    public class ObjectCopyHelper
    {
        /// <summary>
        /// 通过序列化和反序列化的方式深度拷贝指定的对象。
        /// </summary>
        /// <typeparam name="T">对象的类型。</typeparam>
        /// <param name="sourceObject">原始对象。</param>
        /// <returns>返回深度拷贝生成的对象。</returns>
        public static T Clone<T>(T sourceObject)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, sourceObject);
                ms.Position = 0;
                object value = bf.Deserialize(ms);

                return (T)value;
            }
        }
    }
}
