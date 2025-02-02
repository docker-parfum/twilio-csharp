/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
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




namespace Twilio.Rest.Autopilot.V1.Assistant.Task
{

    /// <summary> create </summary>
    public class CreateFieldOptions : IOptions<FieldResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the new resource. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the new Field resource. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The Field Type of the new field. Can be: a [Built-in Field Type](https://www.twilio.com/docs/autopilot/built-in-field-types), the `unique_name`, or the `sid` of a custom Field Type. </summary> 
        public string FieldType { get; }

        ///<summary> An application-defined string that uniquely identifies the new resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        public string UniqueName { get; }


        /// <summary> Construct a new CreateFieldOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the new resource. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the new Field resource. </param>
        /// <param name="fieldType"> The Field Type of the new field. Can be: a [Built-in Field Type](https://www.twilio.com/docs/autopilot/built-in-field-types), the `unique_name`, or the `sid` of a custom Field Type. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </param>
        public CreateFieldOptions(string pathAssistantSid, string pathTaskSid, string fieldType, string uniqueName)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
            FieldType = fieldType;
            UniqueName = uniqueName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FieldType != null)
            {
                p.Add(new KeyValuePair<string, string>("FieldType", FieldType));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteFieldOptions : IOptions<FieldResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resources to delete. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resource to delete. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Field resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteFieldOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resources to delete. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Field resource to delete. </param>
        public DeleteFieldOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
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
    public class FetchFieldOptions : IOptions<FieldResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resource to fetch. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resource to fetch. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Field resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFieldOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resource to fetch. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Field resource to fetch. </param>
        public FetchFieldOptions(string pathAssistantSid, string pathTaskSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
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
    public class ReadFieldOptions : ReadOptions<FieldResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resources to read. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resources to read. </summary> 
        public string PathTaskSid { get; }



        /// <summary> Construct a new ListFieldOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task associated with the resources to read. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) resource associated with the Field resources to read. </param>
        public ReadFieldOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
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

