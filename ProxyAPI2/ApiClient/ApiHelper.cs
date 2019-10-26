using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProxyAPI2.ApiClient;
using ProxyAPI2.ApiModel;

namespace ProxyAPI2.ApiClient
{
    public class ApiHelper: IHelper
    {

        public User GetUser(int userId)
        { 
            string jsonData = ApiClient.Get(Utilities.Utility.PLACE_HOLDER_URL, "users/", userId).Result;
            var user = User.FromJson(jsonData);
            //var user2 = JsonConvert.DeserializeObject<ApiModel.User>(jsonData);
            return user;
        }

        public Post[] GetPosts(int userId)
        {
            string jsonData = ApiClient.Get(Utilities.Utility.PLACE_HOLDER_URL, "posts?userId=", userId).Result;
            var post = Post.FromJson(jsonData);
            return post;
        }

        public List<Comment> GetPostComments(int postId)
        {
            string jsonData = ApiClient.Get(Utilities.Utility.PLACE_HOLDER_URL, "comments?postId=", postId).Result;
            var comment = Comment.FromJson(jsonData);
            return comment;
        }
    }
}
