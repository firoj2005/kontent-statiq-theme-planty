// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace Planty.Models
{
    public partial class TestimonialsSection
    {
        public const string Codename = "testimonials_section";
        public const string TestimonialsCodename = "testimonials";

        public IContentItemSystemAttributes System { get; set; }
        public IEnumerable<object> Testimonials { get; set; }
    }
}