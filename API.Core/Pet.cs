using AutoMapper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core
{
    [MapsTo(typeof(Dog))]
    public class Pet
    {
        [MapsToProperty(typeof(Pet), "Name")]
        public string PetName { get; set; }
    }
}
