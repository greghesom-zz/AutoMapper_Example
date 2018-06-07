using AutoMapper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    [MapsTo(typeof(Customer))]
    public class Person
    {
        [MapsToProperty(typeof(Customer), "FirstName")]
        public string Name { get; set; }
    }
}