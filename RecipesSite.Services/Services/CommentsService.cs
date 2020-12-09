using RecipesSite.Data.Repositories;
using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    public class CommentsService
    {
        private CommentsRepository _repo;

        public CommentsService()
        {
            _repo = new CommentsRepository();
        }

        public Comments GetCommentByUserID(int id)
        {
            Comments comment = _repo.GetCommentByUserID(id);
            return comment;
        }

        public void Add(Comments comment)
        {
            _repo.Add(comment);
        }

        public void Update(Comments comment)
        {
            _repo.Update(comment);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
