/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.BulkExports.Export 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadDayOptions
    /// </summary>
    public class ReadDayOptions : ReadOptions<DayResource> 
    {
        /// <summary>
        /// The resource_type
        /// </summary>
        public string PathResourceType { get; }

        /// <summary>
        /// Construct a new ReadDayOptions
        /// </summary>
        ///
        /// <param name="pathResourceType"> The resource_type </param>
        public ReadDayOptions(string pathResourceType)
        {
            PathResourceType = pathResourceType;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}