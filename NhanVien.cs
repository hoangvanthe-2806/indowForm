using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace demo
{
    public class NhanVien
    {
        private string _id;
        private string _name;
        private string _tuoi;
        private string _gioiTinh;

        public NhanVien()
        {

        }
        public NhanVien(string id, string name, string tuoi, string gioiTinh)
        {
            _id = id;
            _name = name;
            _tuoi = tuoi;
            _gioiTinh = gioiTinh;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Tuoi { get => _tuoi; set => _tuoi = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
    }
}
