/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Notify
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.Notify.V1.Service
{

    /// <summary> create </summary>
    public class CreateBindingOptions : IOptions<BindingResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Up to 20 Bindings can be created for the same Identity in a given Service. </summary> 
        public string Identity { get; }

        
        public BindingResource.BindingTypeEnum BindingType { get; }

        ///<summary> The channel-specific address. For APNS, the device token. For FCM and GCM, the registration token. For SMS, a phone number in E.164 format. For Facebook Messenger, the Messenger ID of the user or a phone number in E.164 format. </summary> 
        public string Address { get; }

        ///<summary> A tag that can be used to select the Bindings to notify. Repeat this parameter to specify more than one tag, up to a total of 20 tags. </summary> 
        public List<string> Tag { get; set; }

        ///<summary> The protocol version to use to send the notification. This defaults to the value of `default_xxxx_notification_protocol_version` for the protocol in the [Service](https://www.twilio.com/docs/notify/api/service-resource). The current version is `\\\"3\\\"` for `apn`, `fcm`, and `gcm` type Bindings. The parameter is not applicable to `sms` and `facebook-messenger` type Bindings as the data format is fixed. </summary> 
        public string NotificationProtocolVersion { get; set; }

        ///<summary> The SID of the [Credential](https://www.twilio.com/docs/notify/api/credential-resource) resource to be used to send notifications to this Binding. If present, this overrides the Credential specified in the Service resource. Applies to only `apn`, `fcm`, and `gcm` type Bindings. </summary> 
        public string CredentialSid { get; set; }

        ///<summary> Deprecated. </summary> 
        public string Endpoint { get; set; }


        /// <summary> Construct a new CreateBindingOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Up to 20 Bindings can be created for the same Identity in a given Service. </param>
        /// <param name="bindingType">  </param>
        /// <param name="address"> The channel-specific address. For APNS, the device token. For FCM and GCM, the registration token. For SMS, a phone number in E.164 format. For Facebook Messenger, the Messenger ID of the user or a phone number in E.164 format. </param>
        public CreateBindingOptions(string pathServiceSid, string identity, BindingResource.BindingTypeEnum bindingType, string address)
        {
            PathServiceSid = pathServiceSid;
            Identity = identity;
            BindingType = bindingType;
            Address = address;
            Tag = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (BindingType != null)
            {
                p.Add(new KeyValuePair<string, string>("BindingType", BindingType.ToString()));
            }
            if (Address != null)
            {
                p.Add(new KeyValuePair<string, string>("Address", Address));
            }
            if (Tag != null)
            {
                p.AddRange(Tag.Select(Tag => new KeyValuePair<string, string>("Tag", Tag)));
            }
            if (NotificationProtocolVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationProtocolVersion", NotificationProtocolVersion));
            }
            if (CredentialSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialSid", CredentialSid));
            }
            if (Endpoint != null)
            {
                p.Add(new KeyValuePair<string, string>("Endpoint", Endpoint));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteBindingOptions : IOptions<BindingResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to delete the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Binding resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteBindingOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to delete. </param>
        public DeleteBindingOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchBindingOptions : IOptions<BindingResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to fetch the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Binding resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchBindingOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to fetch. </param>
        public FetchBindingOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadBindingOptions : ReadOptions<BindingResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to read the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Only include usage that has occurred on or after this date. Specify the date in GMT and format as `YYYY-MM-DD`. </summary> 
        public DateTime? StartDate { get; set; }

        ///<summary> Only include usage that occurred on or before this date. Specify the date in GMT and format as `YYYY-MM-DD`. </summary> 
        public DateTime? EndDate { get; set; }

        ///<summary> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. </summary> 
        public List<string> Identity { get; set; }

        ///<summary> Only list Bindings that have all of the specified Tags. The following implicit tags are available: `all`, `apn`, `fcm`, `gcm`, `sms`, `facebook-messenger`. Up to 5 tags are allowed. </summary> 
        public List<string> Tag { get; set; }



        /// <summary> Construct a new ListBindingOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to read the resource from. </param>
        public ReadBindingOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            Identity = new List<string>();
            Tag = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }
            if (Identity != null)
            {
                p.AddRange(Identity.Select(Identity => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (Tag != null)
            {
                p.AddRange(Tag.Select(Tag => new KeyValuePair<string, string>("Tag", Tag)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

