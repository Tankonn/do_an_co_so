﻿namespace do_an_co_so.Models
{
    public class DatTour
    {
        public int IdDattour { get; set; }
        public string? TenKh { get; set; }
        public string sdt {  get; set; }
        public string? email { get; set; }
        public string? diachi { get; set; }
        public Phuongthucthanhtoan phuongthucthanhtoan { get; set; }
        public string? yeucau {  get; set; }
        public Tour Matour {  get; set; }
        public int? Tinhtrang {  get; set; } 

    }
}
