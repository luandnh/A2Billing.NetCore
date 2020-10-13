using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NesopsService.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NesopsService.Base.Controller
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseEntityController<TDBContext, TEntity, TReadModel, TCreateModel, TUpdateModel, TRequestModel> : ControllerBase
        where TDBContext : DbContext
        where TEntity : class, IHaveIdentifier
        where TRequestModel : class, IBaseRequestModel
        where TReadModel : class
        where TCreateModel : class
        where TUpdateModel : class
    {
        protected TDBContext _dbContext { get; }
        protected IMapper _mapper { get; }

        protected BaseEntityController(TDBContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        protected virtual async Task<BaseResponseModel<TReadModel>> ReadModel(long id, TRequestModel requestModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var entity = await HandleRequest(requestModel).FirstOrDefaultAsync(p=>p.Id==id,cancellationToken);
            if (entity == null)
            {
                return null;
            }
            var readModel = _mapper.Map<TEntity, TReadModel>(entity);
            //var result = new GetResponseModel<TReadModel, TRequestModel>(readModel);
            var result = new BaseResponseModel<TReadModel> { 
                success = true,
                code = 200,
                data = readModel
            };
            return result;
        }
        protected virtual IQueryable<TEntity> HandleRequest(TRequestModel request)
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }
        protected virtual async Task<BaseResponseModel<List<TReadModel>>> ListModel(TRequestModel requestModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = HandleRequest(requestModel);
            var readModel = _mapper.Map<List<TReadModel>>((await query.ToListAsync(cancellationToken)));
            //var result = new GetResponseModel<TReadModel, TRequestModel>(readModel, requestModel);
            var result = new BaseResponseModel<List<TReadModel>>
            {
                success = true,
                code = 200,
                data = readModel
            };
            return result;
        }
        protected virtual async Task<TReadModel> CreateModel(TCreateModel createModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            //var result = await _service.CreateAsync(createModel, cancellationToken);
            var entity = _mapper.Map<TEntity>(createModel);
            var createTask = await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
            if (createTask.State != EntityState.Added)
            {
                return null;
            }
            await _dbContext.SaveChangesAsync(cancellationToken);
            var result = _mapper.Map<TReadModel>(createTask.Entity);
            return result;
        }
        protected virtual async Task<TReadModel> UpdateModel(long id, TUpdateModel updateModel, CancellationToken cancellationToken = default(CancellationToken))
        {
            var entity = _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (entity == null)
            {
                return default;
            }
            entity = _mapper.Map<TUpdateModel, TEntity>(updateModel, entity);
            var updateTask = _dbContext.Set<TEntity>().Update(entity);
            if(updateTask.State != EntityState.Modified)
            {
                return null;
            }
            await _dbContext.SaveChangesAsync(cancellationToken);
            var result = _mapper.Map<TReadModel>(updateTask.Entity);
            return result;
        }
        protected virtual async Task<TReadModel> DeleteModel(long id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var entity = _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (entity == null)
            {
                return default;
            }
            var result = _mapper.Map<TReadModel>(entity);
            var deleteTask = _dbContext.Set<TEntity>().Remove(entity);
            if (deleteTask.State != EntityState.Deleted)
            {
                return null;
            }
            await _dbContext.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
