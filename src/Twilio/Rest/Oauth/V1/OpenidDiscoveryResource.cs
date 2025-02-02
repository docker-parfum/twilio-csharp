/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Oauth
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Oauth.V1
{
    public class OpenidDiscoveryResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchOpenidDiscoveryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/.well-known/openid-configuration";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Oauth,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="options"> Fetch OpenidDiscovery parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OpenidDiscovery </returns>
        public static OpenidDiscoveryResource Fetch(FetchOpenidDiscoveryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="options"> Fetch OpenidDiscovery parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OpenidDiscovery </returns>
        public static async System.Threading.Tasks.Task<OpenidDiscoveryResource> FetchAsync(FetchOpenidDiscoveryOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of OpenidDiscovery </returns>
        public static OpenidDiscoveryResource Fetch(
                                         ITwilioRestClient client = null)
        {
            var options = new FetchOpenidDiscoveryOptions(){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch configuration details about the OpenID Connect Authorization Server </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of OpenidDiscovery </returns>
        public static async System.Threading.Tasks.Task<OpenidDiscoveryResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchOpenidDiscoveryOptions(){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a OpenidDiscoveryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> OpenidDiscoveryResource object represented by the provided JSON </returns>
        public static OpenidDiscoveryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<OpenidDiscoveryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The issuer URL </summary> 
        [JsonProperty("issuer")]
        public Uri Issuer { get; private set; }

        ///<summary> The URL of authorization endpoint </summary> 
        [JsonProperty("authorization_endpoint")]
        public Uri AuthorizationEndpoint { get; private set; }

        ///<summary> The URL of device code authorization endpoint </summary> 
        [JsonProperty("device_authorization_endpoint")]
        public Uri DeviceAuthorizationEndpoint { get; private set; }

        ///<summary> The URL of token endpoint </summary> 
        [JsonProperty("token_endpoint")]
        public Uri TokenEndpoint { get; private set; }

        ///<summary> The URL of user info endpoint </summary> 
        [JsonProperty("userinfo_endpoint")]
        public Uri UserinfoEndpoint { get; private set; }

        ///<summary> The URL of revocation endpoint </summary> 
        [JsonProperty("revocation_endpoint")]
        public Uri RevocationEndpoint { get; private set; }

        ///<summary> The URL of public JWK endpoint </summary> 
        [JsonProperty("jwk_uri")]
        public Uri JwkUri { get; private set; }

        ///<summary> List of response type supported for identity token </summary> 
        [JsonProperty("response_type_supported")]
        public List<string> ResponseTypeSupported { get; private set; }

        ///<summary> List of subject supported for identity token </summary> 
        [JsonProperty("subject_type_supported")]
        public List<string> SubjectTypeSupported { get; private set; }

        ///<summary> List of JWS signing algorithms supported for identity token </summary> 
        [JsonProperty("id_token_signing_alg_values_supported")]
        public List<string> IdTokenSigningAlgValuesSupported { get; private set; }

        ///<summary> List of scopes supported identity token </summary> 
        [JsonProperty("scopes_supported")]
        public List<string> ScopesSupported { get; private set; }

        ///<summary> List of claims supported for identity token </summary> 
        [JsonProperty("claims_supported")]
        public List<string> ClaimsSupported { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private OpenidDiscoveryResource() {

        }
    }
}

