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
    public partial class ContactSection
    {
        public const string Codename = "contact_section";
        public const string AddressCodename = "address";
        public const string EMailCodename = "e_mail";
        public const string ImageCodename = "image";
        public const string MapUrlCodename = "map_url";
        public const string NameCodename = "name";
        public const string PhoneCodename = "phone";

        public string Address { get; set; }
        public string EMail { get; set; }
        public IEnumerable<IAsset> Image { get; set; }
        public string MapUrl { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}