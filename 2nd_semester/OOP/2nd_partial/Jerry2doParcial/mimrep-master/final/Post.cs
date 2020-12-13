using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Post
    {
        public string description { get; set; }
        public string imageRoute { get; }
        public int score { get; set; }

        public Post(string description, string imageRoute)
        {
            this.description = description;
            this.imageRoute = imageRoute;
            score = 0;
        }

        public void getVote(int i)
        {
            score += i;
        }
    }
}
