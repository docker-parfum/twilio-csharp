/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// EngagementResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Studio.V1.Flow 
{

    public class EngagementResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Ended = new StatusEnum("ended");
        }

        private static Request BuildReadRequest(ReadEngagementOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static ResourceSet<EngagementResource> Read(ReadEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<EngagementResource>.FromJson("engagements", response.Content);
            return new ResourceSet<EngagementResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EngagementResource>> ReadAsync(ReadEngagementOptions options, 
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EngagementResource>.FromJson("engagements", response.Content);
            return new ResourceSet<EngagementResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static ResourceSet<EngagementResource> Read(string pathFlowSid, 
                                                           int? pageSize = null, 
                                                           long? limit = null, 
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadEngagementOptions(pathFlowSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<EngagementResource>> ReadAsync(string pathFlowSid, 
                                                                                                   int? pageSize = null, 
                                                                                                   long? limit = null, 
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadEngagementOptions(pathFlowSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<EngagementResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<EngagementResource> NextPage(Page<EngagementResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<EngagementResource> PreviousPage(Page<EngagementResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

        private static Request BuildFetchRequest(FetchEngagementOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static EngagementResource Fetch(FetchEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<EngagementResource> FetchAsync(FetchEngagementOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static EngagementResource Fetch(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEngagementOptions(pathFlowSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<EngagementResource> FetchAsync(string pathFlowSid, 
                                                                                       string pathSid, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchEngagementOptions(pathFlowSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateEngagementOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                "/v1/Flows/" + options.PathFlowSid + "/Engagements",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static EngagementResource Create(CreateEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<EngagementResource> CreateAsync(CreateEngagementOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="to"> The to </param>
        /// <param name="from"> The from </param>
        /// <param name="parameters"> The parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns> 
        public static EngagementResource Create(string pathFlowSid, 
                                                Types.PhoneNumber to, 
                                                Types.PhoneNumber from, 
                                                string parameters = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new CreateEngagementOptions(pathFlowSid, to, from){Parameters = parameters};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathFlowSid"> The flow_sid </param>
        /// <param name="to"> The to </param>
        /// <param name="from"> The from </param>
        /// <param name="parameters"> The parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns> 
        public static async System.Threading.Tasks.Task<EngagementResource> CreateAsync(string pathFlowSid, 
                                                                                        Types.PhoneNumber to, 
                                                                                        Types.PhoneNumber from, 
                                                                                        string parameters = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateEngagementOptions(pathFlowSid, to, from){Parameters = parameters};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a EngagementResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EngagementResource object represented by the provided JSON </returns> 
        public static EngagementResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EngagementResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The flow_sid
        /// </summary>
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }
        /// <summary>
        /// The contact_sid
        /// </summary>
        [JsonProperty("contact_sid")]
        public string ContactSid { get; private set; }
        /// <summary>
        /// The contact_channel_address
        /// </summary>
        [JsonProperty("contact_channel_address")]
        public string ContactChannelAddress { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EngagementResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The context
        /// </summary>
        [JsonProperty("context")]
        public object Context { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private EngagementResource()
        {

        }
    }

}