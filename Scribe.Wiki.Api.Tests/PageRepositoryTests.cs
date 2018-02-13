using System.Collections.Generic;
using System.IO;
using Scribe.Wiki.Api.Repositories;
using Xunit;

namespace Scribe.Wiki.Api.Tests
{
    public class FSPageRepositoryTests : System.IDisposable
    {
        private readonly List<string> filePaths = new List<string> { "test" };
        private readonly FSPageRepository repository;

        public FSPageRepositoryTests()
        {
            foreach (var file in filePaths)
            {
                File.Create(file).Dispose();
            }

            repository = new FSPageRepository();
        }

        public void Dispose()
        {
            foreach (var path in filePaths)
            {
                File.Delete(path);
            }
        }

        [Fact]
        public void GetFile_ShouldReturnPageWithMatchingTitle()
        {
            var title = "test";

            var result = repository.Get(title);

            Assert.Equal(title, result.Title);
        }
    }
}
