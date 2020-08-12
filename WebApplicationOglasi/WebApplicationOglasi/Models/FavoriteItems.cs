using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationOglasi.Models
{
    public class FavoriteItems
    {
        public List<Oglas> omileniOglasi { get; set; }
        public FavoriteItems()
        {
            omileniOglasi = new List<Oglas>();
        }
    }
}