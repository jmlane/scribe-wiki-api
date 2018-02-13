using System.Collections.Generic;

namespace Scribe.Wiki.Api.Repositories
{
    public interface IPageRepository
    {
        Models.Page Get(string title);
        IEnumerable<Models.Page> GetAll();
    }
}