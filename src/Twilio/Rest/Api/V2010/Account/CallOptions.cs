/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Create a new outgoing call to phones, SIP-enabled endpoints or Twilio Client connections
    /// </summary>
    public class CreateCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Phone number, SIP address or client identifier to call
        /// </summary>
        public IEndpoint To { get; }
        /// <summary>
        /// Twilio number from which to originate the call
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// Url from which to fetch TwiML
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// ApplicationSid that configures from where to fetch TwiML
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with FallbackUrl
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_event
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// HTTP Method to use with StatusCallback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Digits to send
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// Action to take if a machine has answered the call
        /// </summary>
        public string IfMachine { get; set; }
        /// <summary>
        /// Number of seconds to wait for an answer
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Whether or not to record the Call
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// The recording_channels
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The recording_status_callback
        /// </summary>
        public string RecordingStatusCallback { get; set; }
        /// <summary>
        /// The recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The sip_auth_username
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The sip_auth_password
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// Enable machine detection or end of greeting detection
        /// </summary>
        public string MachineDetection { get; set; }
        /// <summary>
        /// Number of miliseconds to wait for machine detection
        /// </summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>
        /// The recording_status_callback_event
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }

        /// <summary>
        /// Construct a new CreateCallOptions
        /// </summary>
        /// <param name="to"> Phone number, SIP address or client identifier to call </param>
        /// <param name="from"> Twilio number from which to originate the call </param>
        public CreateCallOptions(IEndpoint to, Types.PhoneNumber from)
        {
            To = to;
            From = from;
            StatusCallbackEvent = new List<string>();
            RecordingStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }

            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }

            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }

            if (IfMachine != null)
            {
                p.Add(new KeyValuePair<string, string>("IfMachine", IfMachine));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.Value.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (MachineDetection != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetection", MachineDetection));
            }

            if (MachineDetectionTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionTimeout", MachineDetectionTimeout.Value.ToString()));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// Once the record is deleted, it will no longer appear in the API and Account Portal logs.
    /// </summary>
    public class DeleteCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCallOptions
        /// </summary>
        /// <param name="pathSid"> Call Sid that uniquely identifies the Call to delete </param>
        public DeleteCallOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Fetch the Call specified by the provided Call Sid
    /// </summary>
    public class FetchCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCallOptions
        /// </summary>
        /// <param name="pathSid"> Call Sid that uniquely identifies the Call to fetch </param>
        public FetchCallOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieves a collection of Calls made to and from your account
    /// </summary>
    public class ReadCallOptions : ReadOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Phone number or Client identifier to filter `to` on
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Phone number or Client identifier to filter `from` on
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Parent Call Sid to filter on
        /// </summary>
        public string ParentCallSid { get; set; }
        /// <summary>
        /// Status to filter on
        /// </summary>
        public CallResource.StatusEnum Status { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTimeBefore { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// StartTime to filter on
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// EndTime to filter on
        /// </summary>
        public DateTime? EndTimeAfter { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (ParentCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ParentCallSid", ParentCallSid.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (StartTime != null)
            {
                p.Add(new KeyValuePair<string, string>("StartTime", Serializers.DateTimeIso8601(StartTime)));
            }
            else
            {
                if (StartTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime<", Serializers.DateTimeIso8601(StartTimeBefore)));
                }

                if (StartTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime>", Serializers.DateTimeIso8601(StartTimeAfter)));
                }
            }

            if (EndTime != null)
            {
                p.Add(new KeyValuePair<string, string>("EndTime", Serializers.DateTimeIso8601(EndTime)));
            }
            else
            {
                if (EndTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime<", Serializers.DateTimeIso8601(EndTimeBefore)));
                }

                if (EndTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime>", Serializers.DateTimeIso8601(EndTimeAfter)));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Initiates a call redirect or terminates a call
    /// </summary>
    public class UpdateCallOptions : IOptions<CallResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Call Sid that uniquely identifies the Call to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// URL that returns TwiML
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status to update the Call with
        /// </summary>
        public CallResource.UpdateStatusEnum Status { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with FallbackUrl
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP Method to use with StatusCallback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        /// <summary>
        /// Construct a new UpdateCallOptions
        /// </summary>
        /// <param name="pathSid"> Call Sid that uniquely identifies the Call to update </param>
        public UpdateCallOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }

            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            return p;
        }
    }

}