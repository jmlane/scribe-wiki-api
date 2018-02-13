using System.Collections.Generic;
using System.IO;
using Scribe.Wiki.Api.Models;

namespace Scribe.Wiki.Api.Repositories
{
    public class FSPageRepository : IPageRepository
    {
        public Page Get(string title)
        {
            using (var stream = new FileStream(title, FileMode.Open, FileAccess.Read, FileShare.Read))
            { }

            return new Page { Title = "", Contents = ""};
        }

        public IEnumerable<Page> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}