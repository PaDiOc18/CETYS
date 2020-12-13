using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class User
    {
        public string username { get; }
        public string password { get; }
        public List<Post> posts;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            posts = new List<Post>();
        }

        public void createPost(Post newPost)
        {
            posts.Add(newPost);
        }
        
        public void createPost(string description, string imageRoute)
        {
            posts.Add(new Post(description, imageRoute));
        }

        public void vote(int i, Post currentPost)
        {
            currentPost.getVote(i);
        }

        public List<Post> getPosts()
        {
            return posts;
        }
    }
}
