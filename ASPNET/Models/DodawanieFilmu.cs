﻿namespace ASPNET.Models
{
    public class DodawanieFilmu
    {
        public Film Film { get; set; }

        public IFormFile Plakat{ get; set; }
        public List<Kategoria> Kategorie { get; set; }
    }
}
