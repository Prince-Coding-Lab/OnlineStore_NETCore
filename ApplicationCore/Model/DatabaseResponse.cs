using ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Model
{
    public class OperationResponse
    {
        public bool HasSucceeded { get; set; }
        public bool IsDomainValidationErrors { get; set; }
        public string Message { get; set; }
        public string StatusCode { get; set; }
        /// <summary>
        /// Used to envelope created/updated object
        /// </summary>
        public object ReturnedObject { get; set; }

        public OperationResponse()
        {
            HasSucceeded = true;
            Message = "";
            IsDomainValidationErrors = false;
            StatusCode = ((int)ResponseStatus.OK).ToString();
        }
        public OperationResponse(bool hasSucceeded = true, string message = "")
        {
            HasSucceeded = hasSucceeded;
            Message = message;
        }

        public ServerResponse GenerateResponse()
        {
            return new ServerResponse(this.ReturnedObject, HasSucceeded, Message);
        }
    }

    /// <summary>
    /// Server response convey status of request  along with a result data collection. 
    /// </summary>
    public class ServerResponse
    {
        public object Result { get; set; }
        public bool HasSucceeded { get; set; }
        public string Message { get; set; }
        public string StatusCode { get; set; }


        public ServerResponse()
        {
            StatusCode = ((int)ResponseStatus.OK).ToString();
        }
        public ServerResponse(object result, bool hasSucceeded, string msg)
        {
            StatusCode = ((int)ResponseStatus.OK).ToString();
            Result = result;
            HasSucceeded = hasSucceeded;
            Message = msg;
        }


    }

    public class DatabaseResponse
    {
        public int ResponseCode { get; set; }

        public object Results { get; set; }


    }
}
