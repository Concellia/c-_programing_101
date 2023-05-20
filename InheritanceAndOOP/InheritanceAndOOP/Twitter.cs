using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Twitter: Post
    {
        public string Body { get; set; }
        public Twitter() { }
        public Twitter(string postTitle, string sendByUserName, bool isPublic, string body)
        { 
            this.PostID = GetNextID();
            this.PostTitle = postTitle;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            this.Body = body;
        
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} ", this.PostID, this.PostTitle, this.SendByUserName, this.IsPublic,this.Body);
        }
    }
}
