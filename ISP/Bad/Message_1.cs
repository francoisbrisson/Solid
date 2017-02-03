using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    public interface IMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }
        bool Send();
        IList<String> BccAddresses { get; set; }
    }

    public class SmtpMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public IList<String> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }

        public bool Send()
        {
            //Do the real work here
            return true;
        }
    }

    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public bool Send()
        {
            //Do the real work here
            return true;
        }
        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public IList<string> BccAddreses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<string> BccAddresses
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
