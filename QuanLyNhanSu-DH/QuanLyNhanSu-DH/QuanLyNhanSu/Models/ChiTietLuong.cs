//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanSu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietLuong
    {
        public string MaChiTietBangLuong { get; set; }
        public string MaNhanVien { get; set; }
        public double LuongCoBan { get; set; }
        public Nullable<double> BHXH { get; set; }
        public Nullable<double> BHYT { get; set; }
        public Nullable<double> BHTN { get; set; }
        public Nullable<double> PhuCap { get; set; }
        public Nullable<double> ThueThuNhap { get; set; }
        public Nullable<int> TienThuong { get; set; }
        public Nullable<int> TienPhat { get; set; }
        public System.DateTime NgayNhanLuong { get; set; }
        public string TongTienLuong { get; set; }
    
        public virtual Luong Luong { get; set; }
    }
}