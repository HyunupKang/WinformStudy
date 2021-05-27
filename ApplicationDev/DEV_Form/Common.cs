using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDev
{
    public class Common
    {
        public static string LoginID = string.Empty;        // static : 객체 생성을 안해도, 코드 실행되면 자동으로 메모리에 객체가 올라감. 직접 호출하는 형태임
        public static string LoginName = string.Empty;
        public static string db = "Data Source = 222.235.141.8; Initial Catalog = AppDev; USER ID = kfqs1; Password = 1234"; // 접속주소 
    }
}
