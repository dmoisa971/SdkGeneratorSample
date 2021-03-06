// Code generated by Microsoft (R) AutoRest Code Generator 0.9.6.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Microsoft.Rest;
using MyApps.CustomerManagement.sdk;

namespace MyApps.CustomerManagement.sdk
{
    public partial interface ITestWebApi : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        IArticleOperations Article
        {
            get; 
        }
        
        ICustomerOperations Customer
        {
            get; 
        }
        
        IOrderOperations Order
        {
            get; 
        }
    }
}
