using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Iran.AspNet.CountryDivisions.Data.Models;

namespace Iran.AspNet.CountryDivisions
{
    public interface IIranCountryDivisions
    {
        IEnumerable<Abadi> GetAbadis(Expression<Func<Abadi, bool>> filter = null,
              Func<IQueryable<Abadi>, IOrderedQueryable<Abadi>> orderBy = null, int count = 0);
        IEnumerable<Bakhsh> GetBakhshs(Expression<Func<Bakhsh, bool>> filter = null,
             Func<IQueryable<Bakhsh>, IOrderedQueryable<Bakhsh>> orderBy = null,int count = 0);
        IEnumerable<Dehestan> GetDehestans(Expression<Func<Dehestan, bool>> filter = null,
             Func<IQueryable<Dehestan>, IOrderedQueryable<Dehestan>> orderBy = null, int count = 0);
        IEnumerable<Ostan> GetOstans(Expression<Func<Ostan, bool>> filter = null,
             Func<IQueryable<Ostan>, IOrderedQueryable<Ostan>> orderBy = null, int count = 0);
        IEnumerable<Shahr> GetShahrs(Expression<Func<Shahr, bool>> filter = null,
             Func<IQueryable<Shahr>, IOrderedQueryable<Shahr>> orderBy = null, int count = 0);
        IEnumerable<Shahrestan> GetShahrestans(Expression<Func<Shahrestan, bool>> filter = null,
             Func<IQueryable<Shahrestan>, IOrderedQueryable<Shahrestan>> orderBy = null, int count = 0);
      Task<IEnumerable<Abadi>> GetAbadisAsync(Expression<Func<Abadi, bool>> filter = null,
        Func<IQueryable<Abadi>, IOrderedQueryable<Abadi>> orderBy = null, int count = 0);
        Task<IEnumerable<Bakhsh>> GetBakhshsAsync(Expression<Func<Bakhsh, bool>> filter = null,
             Func<IQueryable<Bakhsh>, IOrderedQueryable<Bakhsh>> orderBy = null, int count = 0);
        Task<IEnumerable<Dehestan>> GetDehestansAsync(Expression<Func<Dehestan, bool>> filter = null,
             Func<IQueryable<Dehestan>, IOrderedQueryable<Dehestan>> orderBy = null, int count = 0);
        Task<IEnumerable<Ostan>> GetOstansAsync(Expression<Func<Ostan, bool>> filter = null,
             Func<IQueryable<Ostan>, IOrderedQueryable<Ostan>> orderBy = null, int count = 0);
        Task<IEnumerable<Shahr>> GetShahrsAsync(Expression<Func<Shahr, bool>> filter = null,
             Func<IQueryable<Shahr>, IOrderedQueryable<Shahr>> orderBy = null, int count = 0);
        Task<IEnumerable<Shahrestan>> GetShahrestansAsync(Expression<Func<Shahrestan, bool>> filter = null,
             Func<IQueryable<Shahrestan>, IOrderedQueryable<Shahrestan>> orderBy = null, int count = 0);
        IQueryable<TEntity> GetEntity<TEntity>(bool asTracking = false) where TEntity : class;
    }
}
