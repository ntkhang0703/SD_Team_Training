
// using API.Data;
// using Microsoft.EntityFrameworkCore.Storage;

// namespace API._Repositories
// {
//     public class RepositoryAccessor : IRepositoryAccessor
//     {
//         private DBContext _dbContext;


//         public RepositoryAccessor(DBContext dbContext)
//         {
//             _dbContext = dbContext;
//             // ERP_ISSUE_DTL = new ERP_ISSUE_DTL_Repository(_dbContext);
//         }

//         // public IERP_ISSUE_DTL_Repository ERP_ISSUE_DTL {get;set;}
//         public async Task<bool> Save()
//         {
//             return await _dbContext.SaveChangesAsync() > 0;
//         }

//         public async Task<IDbContextTransaction> BeginTransactionAsync()
//         {
//             return await _dbContext.Database.BeginTransactionAsync();
//         }
//     }
// }