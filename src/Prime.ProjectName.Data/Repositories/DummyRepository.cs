using AutoMapper;
using Prime.ProjectName.Data.Entities;
using Prime.ProjectName.Domain.Abstractions.Repositories;

namespace Prime.ProjectName.Data.Repositories
{
    public class DummyRepository : BaseRepository<BaseEntity>, IDummyRepository
    {
        public DummyRepository(ProjectNameDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
