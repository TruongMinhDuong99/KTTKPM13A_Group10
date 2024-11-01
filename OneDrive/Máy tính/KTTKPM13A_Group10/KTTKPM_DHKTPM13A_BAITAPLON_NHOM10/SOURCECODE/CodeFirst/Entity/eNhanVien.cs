﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Entity
{
    [DataContract]
    public class eNhanVien
    {
        [DataMember]
        public string maNhanVien { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string CMND { get; set; }
        [DataMember]
        public string diaChi { get; set; }
        [DataMember]
        public Boolean gioiTinh { get; set; }
        [DataMember]
        public string tenKH { get; set; }
        [DataMember]
        public DateTime ngaySinh { get; set; }
        [DataMember]
        public string soDienThoai { get; set; }
        [DataMember]
        public string chuyenMon { get; set; }
        [DataMember]
        public string maTaiKhoan { get; set; }
        [DataMember]
        public string maChucVu { get; set; }
    }
}
