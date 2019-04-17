using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsmekCrm.Ui.Extentions
{
    public static class SessionExtention
    {

        public static void SetObject(this ISession session,string key,object value)
        {
            var serializedObject = JsonConvert.SerializeObject(value);
            session.SetString(key, serializedObject);//objeyi json veriye çevirip sonra stringe çevrilmiş halini verddik.
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var serializedObject= session.GetString(key);// json tipinde objeyi aldık
            return serializedObject == null ? default(T) : JsonConvert.DeserializeObject<T>(serializedObject);// serileştirilmiş obje null değilse , bize object tipinde geri döndürülür.

        }
    }
}
