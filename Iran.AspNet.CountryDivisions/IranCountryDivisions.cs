using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Iran.CountryDivisions.AspNet.Data.Models;
using Iran.CountryDivisions.AspNet.Extensions;

using Microsoft.EntityFrameworkCore;

using Rahnavard724.Core.Data.DatabaseContext;

namespace Iran.CountryDivisions.AspNet
{
    public class IranCountryDivisions : IIranCountryDivisions
    {
        private readonly LocationsDbContext _db;

        public IranCountryDivisions()
        {
            _db = new LocationsDbContext();
        }


        private async Task UpdateDatabaseAsync()
        {
            var a = await _db.Abadis.ToListAsync();
            _db.Abadis.RemoveRange(a);

            var b= await _db.Bakhshs.ToListAsync();
            _db.Bakhshs.RemoveRange(b);

            var c = await _db.Dehestans.ToListAsync();
            _db.Dehestans.RemoveRange(c);

            var d = await _db.Ostans.ToListAsync();
            _db.Ostans.RemoveRange(d);

            var e = await _db.Shahrs.ToListAsync();
            _db.Shahrs.RemoveRange(e);

            var f = await _db.Shahrestans.ToListAsync();
            _db.Shahrestans.RemoveRange(f);

            await _db.SaveChangesAsync();


            var txt1 = System.IO.File.ReadAllText(JsonDataPath.AbadiJsonPath);
            var ostans1 = JsonToDataConvert.ToAbadiList(txt1);
            foreach (var item in ostans1.ToList())
            {
                await _db.Abadis.AddAsync(item);
            }
            var txt2 = System.IO.File.ReadAllText(JsonDataPath.BakhshJsonPath);
            var ostans2 = JsonToDataConvert.ToBakhshList(txt2);
            foreach (var item in ostans2.ToList())
            {
                await _db.Bakhshs.AddAsync(item);
            }
            var txt3 = System.IO.File.ReadAllText(JsonDataPath.DehestanJsonPath);
            var ostans3 = JsonToDataConvert.ToDehestanList(txt3);
            foreach (var item in ostans3.ToList())
            {
                await _db.Dehestans.AddAsync(item);
            }
            var txt4 = System.IO.File.ReadAllText(JsonDataPath.OstanJsonPath);
            var ostans4 = JsonToDataConvert.ToOstanList(txt4);
            foreach (var item in ostans4.ToList())
            {
                await _db.Ostans.AddAsync(item);
            }
            var txt5 = System.IO.File.ReadAllText(JsonDataPath.ShahrJsonPath);
            var ostans5 = JsonToDataConvert.ToShahrList(txt5);
            foreach (var item in ostans5.ToList())
            {
                await _db.Shahrs.AddAsync(item);
            }
            var txt6 = System.IO.File.ReadAllText(JsonDataPath.ShahrestanJsonPath);
            var ostans6 = JsonToDataConvert.ToShahrestanList(txt6);
            foreach (var item in ostans6.ToList())
            {
                await _db.Shahrestans.AddAsync(item);
            }

            await _db.SaveChangesAsync();
        }



        #region sync
        public IEnumerable<Ostan> GetOstans(Expression<Func<Ostan, bool>> filter = null,
Func<IQueryable<Ostan>, IOrderedQueryable<Ostan>> orderBy = null,  int count = 0)
        {


            var query = _db.Ostans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public IEnumerable<Abadi> GetAbadis(Expression<Func<Abadi, bool>> filter = null,
              Func<IQueryable<Abadi>, IOrderedQueryable<Abadi>> orderBy = null,int count = 0)
        {

            var query = _db.Abadis.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }

        }
        public IEnumerable<Bakhsh> GetBakhshs(Expression<Func<Bakhsh, bool>> filter = null,
             Func<IQueryable<Bakhsh>, IOrderedQueryable<Bakhsh>> orderBy = null,int count = 0)
        {
            var query = _db.Bakhshs.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public IEnumerable<Dehestan> GetDehestans(Expression<Func<Dehestan, bool>> filter = null,
             Func<IQueryable<Dehestan>, IOrderedQueryable<Dehestan>> orderBy = null,int count = 0)
        {
            var query = _db.Dehestans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public IEnumerable<Shahr> GetShahrs(Expression<Func<Shahr, bool>> filter = null,
             Func<IQueryable<Shahr>, IOrderedQueryable<Shahr>> orderBy = null,int count = 0)
        {
            var query = _db.Shahrs.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<Shahrestan> GetShahrestans(Expression<Func<Shahrestan, bool>> filter = null,
             Func<IQueryable<Shahrestan>, IOrderedQueryable<Shahrestan>> orderBy = null,int count = 0)
        {
            var query = _db.Shahrestans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        #endregion

        #region async
        public async Task<IEnumerable<Ostan>> GetOstansAsync(Expression<Func<Ostan, bool>> filter = null,
Func<IQueryable<Ostan>, IOrderedQueryable<Ostan>> orderBy = null,  int count = 0)
        {


            var query = _db.Ostans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public async Task<IEnumerable<Abadi>> GetAbadisAsync(Expression<Func<Abadi, bool>> filter = null,
              Func<IQueryable<Abadi>, IOrderedQueryable<Abadi>> orderBy = null,int count = 0)
        {

            var query = _db.Abadis.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }

        }
        public async Task<IEnumerable<Bakhsh>> GetBakhshsAsync(Expression<Func<Bakhsh, bool>> filter = null,
                     Func<IQueryable<Bakhsh>, IOrderedQueryable<Bakhsh>> orderBy = null,int count = 0)
        {
            var query = _db.Bakhshs.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public async Task<IEnumerable<Dehestan>> GetDehestansAsync(Expression<Func<Dehestan, bool>> filter = null,
                     Func<IQueryable<Dehestan>, IOrderedQueryable<Dehestan>> orderBy = null,int count = 0)
        {
            var query = _db.Dehestans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public async Task<IEnumerable<Shahr>> GetShahrsAsync(Expression<Func<Shahr, bool>> filter = null,
                     Func<IQueryable<Shahr>, IOrderedQueryable<Shahr>> orderBy = null,int count = 0)
        {
            var query = _db.Shahrs.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public async Task<IEnumerable<Shahrestan>> GetShahrestansAsync(Expression<Func<Shahrestan, bool>> filter = null,
                     Func<IQueryable<Shahrestan>, IOrderedQueryable<Shahrestan>> orderBy = null,int count = 0)
        {
            var query = _db.Shahrestans.AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            count = Math.Abs(count);
            if (count > 0)
                query = query.Take(count);

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        #endregion


        public IQueryable<TEntity> GetEntity<TEntity>(bool asTracking = false) where TEntity : class
        {
            if(asTracking)
            {
                return _db.Set<TEntity>().AsTracking();
            }
            else
            {
                return _db.Set<TEntity>().AsNoTracking();
            }
        }

        #region dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    

        ~IranCountryDivisions()
        {
            Dispose(false);
        }

        #endregion
    }
}
