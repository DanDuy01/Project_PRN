using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Logics
{
    class AddressManagement
    {
        public static List<string> GetAddre()
        {
            return new List<string> { "All address", "Ha Noi", "Bac Ninh", 
                "Hai Duong", "Hai Phong", "Quang Ninh",
                "Hue", "Da Nang", "Nghe An",
                "Ho Chi Minh", "Can Tho" };
        }
    }
}
