using ProxyAPI2.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyAPI2.Proxy;
using ProxyAPI2.ApiModel;

namespace ProxyAPI2
{
    public class ProxyClient: IMyResponseProxy
    {

        IHelper apiHelper;

        public ProxyClient(IHelper apiHelper)
        {
            this.apiHelper = apiHelper;
        }

        public MyResponse getMyResponse(int userId)
        {

            var user = apiHelper.GetUser(userId);
            var userPosts = apiHelper.GetPosts(userId);
            
            MyResponse myResponse = new MyResponse
            {
                id = user.Id,
                name = user.Name,
                username = user.Username,
                email = user.Email,
                posts = new List<Post>()
            };

            myResponse.posts.AddRange(userPosts);

            foreach (var post in myResponse.posts)
            {
                var postComments = apiHelper.GetPostComments(post.Id);
                post.Comments = new List<Comment>();
                post.Comments.AddRange(postComments);

            }

            return myResponse;

        }
    }
    
}
