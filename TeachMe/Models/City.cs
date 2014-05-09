﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeachMe.Models
{
    public class City
    {

        #region Fields

        public int Id { get; set; }

        public string Name { get; set; }

        public int GeoLocationId { get; set; }

        public virtual GeoLocation GeoLocation { get; set; }

        #endregion

    }
}