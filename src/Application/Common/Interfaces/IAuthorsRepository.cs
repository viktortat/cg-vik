namespace CleanGraphQLApi.Application.Common.Interfaces;

using System.Threading.Tasks;
using CleanGraphQLApi.Application.Entities;

public interface IAuthorsRepository
{
    Task<List<Author>> ReadAllAuthors(CancellationToken cancellationToken);
    Task<Author?> ReadAuthorById(Guid id, CancellationToken cancellationToken);
    Task<bool> AuthorExists(Guid id, CancellationToken cancellationToken);
}
