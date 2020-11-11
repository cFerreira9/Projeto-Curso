using RecipesSite.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesSite.Services.Services
{
    class CommentsService
    {
        private CommentsRepository _repo;

        public CommentsService()
        {
            _repo = new CommentsRepository();
        }

        public List<Comments> GetAll()
        {
            return null;
        }

        public Comments GetById(int id)
        {
            return null;
        }

        public void Add(Comments comments)
        {

        }

        public void Update(Comments comments)
        {

        }

        public void Remove(int id)
        {

        }
    }
}
