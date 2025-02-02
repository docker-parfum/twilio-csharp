/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service.Entity
{

    /// <summary> Create a new Factor for the Entity </summary>
    public class CreateNewFactorOptions : IOptions<NewFactorResource>
    {
        
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }

        ///<summary> The friendly name of this Factor. This can be any string up to 64 characters, meant for humans to distinguish between Factors. For `factor_type` `push`, this could be a device name. For `factor_type` `totp`, this value is used as the “account name” in constructing the `binding.uri` property. At the same time, we recommend avoiding providing PII. </summary> 
        public string FriendlyName { get; }

        
        public NewFactorResource.FactorTypesEnum FactorType { get; }

        ///<summary> The algorithm used when `factor_type` is `push`. Algorithm supported: `ES256` </summary> 
        public string BindingAlg { get; set; }

        ///<summary> The Ecdsa public key in PKIX, ASN.1 DER format encoded in Base64.  Required when `factor_type` is `push` </summary> 
        public string BindingPublicKey { get; set; }

        ///<summary> The ID that uniquely identifies your app in the Google or Apple store, such as `com.example.myapp`. It can be up to 100 characters long.  Required when `factor_type` is `push`. </summary> 
        public string ConfigAppId { get; set; }

        
        public NewFactorResource.NotificationPlatformsEnum ConfigNotificationPlatform { get; set; }

        ///<summary> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Must be between 32 and 255 characters long.  Required when `factor_type` is `push`. </summary> 
        public string ConfigNotificationToken { get; set; }

        ///<summary> The Verify Push SDK version used to configure the factor  Required when `factor_type` is `push` </summary> 
        public string ConfigSdkVersion { get; set; }

        ///<summary> The shared secret for TOTP factors encoded in Base32. This can be provided when creating the Factor, otherwise it will be generated.  Used when `factor_type` is `totp` </summary> 
        public string BindingSecret { get; set; }

        ///<summary> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive. The default value is defined at the service level in the property `totp.time_step`. Defaults to 30 seconds if not configured.  Used when `factor_type` is `totp` </summary> 
        public int? ConfigTimeStep { get; set; }

        ///<summary> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive. The default value is defined at the service level in the property `totp.skew`. If not configured defaults to 1.  Used when `factor_type` is `totp` </summary> 
        public int? ConfigSkew { get; set; }

        ///<summary> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive. The default value is defined at the service level in the property `totp.code_length`. If not configured defaults to 6.  Used when `factor_type` is `totp` </summary> 
        public int? ConfigCodeLength { get; set; }

        
        public NewFactorResource.TotpAlgorithmsEnum ConfigAlg { get; set; }

        ///<summary> Custom metadata associated with the factor. This is added by the Device/SDK directly to allow for the inclusion of device information. It must be a stringified JSON with only strings values eg. `{\\\"os\\\": \\\"Android\\\"}`. Can be up to 1024 characters in length. </summary> 
        public object Metadata { get; set; }


        /// <summary> Construct a new CreateNewFactorOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="friendlyName"> The friendly name of this Factor. This can be any string up to 64 characters, meant for humans to distinguish between Factors. For `factor_type` `push`, this could be a device name. For `factor_type` `totp`, this value is used as the “account name” in constructing the `binding.uri` property. At the same time, we recommend avoiding providing PII. </param>
        /// <param name="factorType">  </param>
        public CreateNewFactorOptions(string pathServiceSid, string pathIdentity, string friendlyName, NewFactorResource.FactorTypesEnum factorType)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            FriendlyName = friendlyName;
            FactorType = factorType;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (FactorType != null)
            {
                p.Add(new KeyValuePair<string, string>("FactorType", FactorType.ToString()));
            }
            if (BindingAlg != null)
            {
                p.Add(new KeyValuePair<string, string>("Binding.Alg", BindingAlg));
            }
            if (BindingPublicKey != null)
            {
                p.Add(new KeyValuePair<string, string>("Binding.PublicKey", BindingPublicKey));
            }
            if (ConfigAppId != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.AppId", ConfigAppId));
            }
            if (ConfigNotificationPlatform != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.NotificationPlatform", ConfigNotificationPlatform.ToString()));
            }
            if (ConfigNotificationToken != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.NotificationToken", ConfigNotificationToken));
            }
            if (ConfigSdkVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.SdkVersion", ConfigSdkVersion));
            }
            if (BindingSecret != null)
            {
                p.Add(new KeyValuePair<string, string>("Binding.Secret", BindingSecret));
            }
            if (ConfigTimeStep != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.TimeStep", ConfigTimeStep.ToString()));
            }
            if (ConfigSkew != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.Skew", ConfigSkew.ToString()));
            }
            if (ConfigCodeLength != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.CodeLength", ConfigCodeLength.ToString()));
            }
            if (ConfigAlg != null)
            {
                p.Add(new KeyValuePair<string, string>("Config.Alg", ConfigAlg.ToString()));
            }
            if (Metadata != null)
            {
                p.Add(new KeyValuePair<string, string>("Metadata", Serializers.JsonObject(Metadata)));
            }
            return p;
        }
        

    }
}

