using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace com.mehmet.proje.MVCWebUI
{
    public static class OturumSinifi
    
    {
        public static void setOturumBilgisi(this ISession session, string key, Object veri)
        {
            string classToString = JsonConvert.SerializeObject(veri); // nesne oturum için string hale getirilir
            session.SetString(key,classToString); // oturum bilgisi tutulur
        }
        
        public static T getNesne<T>(this ISession session, string key) where T: class
        {
            string stringToClass = session.GetString(key);

            if (String.IsNullOrEmpty(stringToClass)) //Session da key değeri yoksa
            {
                return null;
            }
            
            
            return JsonConvert.DeserializeObject<T>(stringToClass);
            
            
            
           

        }
        
    }
}