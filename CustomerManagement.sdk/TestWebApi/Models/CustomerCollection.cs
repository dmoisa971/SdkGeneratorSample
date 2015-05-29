// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using CustomerManagement.sdk.Models;
using Newtonsoft.Json.Linq;

namespace CustomerManagement.sdk.Models
{
    public static partial class CustomerCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Customer> DeserializeJson(JToken inputObject)
        {
            IList<Customer> deserializedObject = new List<Customer>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Customer customer = new Customer();
                customer.DeserializeJson(iListValue);
                deserializedObject.Add(customer);
            }
            return deserializedObject;
        }
    }
}
