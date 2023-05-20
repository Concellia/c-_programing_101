using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOOP
{
    internal class VideoPost: Post
    {
        public string VideoURL { get; set; }
        public int VideoLength { get; set; }

        public VideoPost()
        { }

        public VideoPost(string videoURL, int videoLength, string postTitle, string sendByUserName, bool isPublic)
        {
            this.PostID = GetNextID();
            this.PostTitle = postTitle; 
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            VideoURL = videoURL;
            VideoLength = videoLength;
        }

        public void Play()
        {
            Console.WriteLine();
        }

        public override string ToString() 
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} ", this.PostID, this.PostTitle, this.SendByUserName, this.IsPublic, this.VideoURL);
        }
    }
}
