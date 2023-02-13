using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Testowe_WinF_Dev.DataModels.UnitOfWorks;
using Testowe_WinF_Dev.DataModels.Repositories;
using System.Linq;
using Testowe_WinF_Dev.Models;
using DevExpress.Utils.Extensions;

namespace Testowe_WinF_Dev.ViewModels
{
    [POCOViewModel]
    public abstract class BaseViewModel<TEntity, FEntity, TUnitOfWork>:DocumentManagerViewModel
        where TEntity : class
        where FEntity: class
        where TUnitOfWork : IUnitOfWork
    {
        IUnitOfWork _uow;
        IRepository<TEntity> _repository;
        IRepository<FEntity> _foreignRepository;

        public virtual TEntity SelectedEntity { get; set; }
        public virtual ObservableCollection<TEntity> Source { get; set; }
        public virtual ObservableCollection<FEntity> ForeignSource { get; set; }
 
        protected BaseViewModel()
        {

        }
        protected void SetUnitOfWork(IUnitOfWork unitOfWork, IRepository<TEntity> repo, IRepository<FEntity> foreignRepo)
        {
            _uow = unitOfWork;
            _repository = repo;
            _foreignRepository = foreignRepo;
        }

        protected virtual void UpdateResult(TEntity item, object ID)
        {
            if (item != null)
            {
                UpdateItemInSource(item, ID);
                _repository.Update(item);
                _uow.SaveChanges();
            }
        }
        protected virtual void InsertResult(TEntity item, object ID)
        {
            if (item != null)
            {
                AddItemInSource(item);
                _repository.Create(item);
                _uow.SaveChanges();
            }
        }
        protected void AddItemInSource(TEntity item)
        {
            Source.Add(item);
            SelectedEntity = item;
        }
        protected void UpdateItemInSource(TEntity item, object ID)
        {
            var dbItem = Get(ID);
            var index = Source.IndexOf(dbItem);
            if (index != -1)
            {
                Source[index] = item;

                SelectedEntity = item;
            }
        }
        public virtual void Init()
        {
            Source = _repository.GetAll();
            if(_foreignRepository != null)
                ForeignSource = _foreignRepository.GetAll();
            SelectedEntity = Source.FirstOrDefault();
        }
        public IEnumerable<TEntity> GetItems(Func<TEntity, bool> predicate) => _repository.GetWhere(predicate);
        public TEntity Get(object Id) => _repository.Get(Id);
        public TEntity SetSelected(object itemObject)
        {
            if (itemObject == null) return null;

            return (TEntity)itemObject;
        }
        public virtual void Delete(TEntity item)
        {
            if (item == null) return;

            _repository.Delete(item);
            _uow.SaveChanges();

            var index = Source.IndexOf(item);
            Source.Remove(item);

            SelectedEntity = ((index - 1 > 0)? Source[index - 1]: Source.FirstOrDefault());
            
        }
    }
}