using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class Post
    {
        //field or a variable of the class
        private static int CurrentPostID;

        //properties this gives you more information about the object
        //protected it means it can be used by this class and derived classes
        protected int PostID {  get; set; }
        protected string PostTitle { get; set; }
        protected string SendByUserName { get; set; }

        protected bool IsPublic { get; set;}

        public Post()
        {
            PostID = 0;
            PostTitle = "Hello World";
            SendByUserName = "Concellia";
            IsPublic = true;
        }

        public  Post( string postTitle, string sendByUserName, bool isPublic)
        {
            PostID = GetNextID();
            PostTitle = postTitle;
            SendByUserName = sendByUserName;
            IsPublic = isPublic;
        }

        public Post (Post post)
        {
            PostID = GetNextID();
            PostTitle = post.PostTitle;
            SendByUserName = post.SendByUserName;
            IsPublic = post.IsPublic;
        }


        protected int GetNextID()
        {
            ++CurrentPostID;
            return CurrentPostID;
        }

        public void EditPost(string title, bool isPublic)
        {
            PostTitle = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} ",PostID,PostTitle,SendByUserName,IsPublic);
        }
    }
}
