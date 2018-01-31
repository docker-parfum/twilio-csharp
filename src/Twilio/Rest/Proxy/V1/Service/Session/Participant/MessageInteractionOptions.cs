/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Proxy.V1.Service.Session.Participant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Create a new Message to a Participant
    /// </summary>
    public class CreateMessageInteractionOptions : IOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The media_url
        /// </summary>
        public List<Uri> MediaUrl { get; set; }

        /// <summary>
        /// Construct a new CreateMessageInteractionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        public CreateMessageInteractionOptions(string pathServiceSid, string pathSessionSid, string pathParticipantSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
            MediaUrl = new List<Uri>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaUrl != null)
            {
                p.AddRange(MediaUrl.Select(prop => new KeyValuePair<string, string>("MediaUrl", Serializers.Url(prop))));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Fetch a specific Message Interaction.
    /// </summary>
    public class FetchMessageInteractionOptions : IOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Message Interaction.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageInteractionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Message Interaction. </param>
        public FetchMessageInteractionOptions(string pathServiceSid, 
                                              string pathSessionSid, 
                                              string pathParticipantSid, 
                                              string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a list of all Message to a Participant.
    /// </summary>
    public class ReadMessageInteractionOptions : ReadOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        public string PathParticipantSid { get; }

        /// <summary>
        /// Construct a new ReadMessageInteractionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        public ReadMessageInteractionOptions(string pathServiceSid, string pathSessionSid, string pathParticipantSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
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