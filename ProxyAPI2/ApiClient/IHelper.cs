using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyAPI2.ApiClient
{
    public interface IHelper
    {
        ApiModel.User GetUser(int userId);
        ApiModel.Post[] GetPosts(int userId);
        List<ApiModel.Comment> GetPostComments(int postId);
    }

}
