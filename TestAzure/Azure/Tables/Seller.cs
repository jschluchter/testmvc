using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.WindowsAzure.StorageClient;

namespace TestAzure.Azure.Tables
{
    public class Seller : TableServiceEntity
    {
        public  Seller(string partitionKey, string rowKey)
        {
            this.PartitionKey = partitionKey;
            this.RowKey = rowKey;
        }

        public Seller()
        {

        }
        
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address required")]
        public string AddressLine1 { get; set; }

        [DisplayName("Suite")]
        public string AddressLine2 { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City required")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "State required")]
        public string State { get; set; }

        [DisplayName("Postal Code")]
        [Required(ErrorMessage = "Postal Code required")]
        public string PostalCode { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone required")]
        public string Phone { get; set; }

        [DisplayName("Email Address")]
        [RegularExpression(@"^([\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+\.)*[\w\!\#$\%\&\'\*\+\-\/\=\?\^\`{\|\}\~]+@((((([a-zA-Z0-9]{1}[a-zA-Z0-9\-]{0,62}[a-zA-Z0-9]{1})|[a-zA-Z])\.)+[a-zA-Z]{2,6})|(\d{1,3}\.){3}\d{1,3}(\:\d{1,5})?)$", ErrorMessage = "Not a valid Email")]
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
    }
}
