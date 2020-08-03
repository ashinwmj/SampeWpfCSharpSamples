using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Application.Interfaces.Models;
using Application.Interfaces.Models.Interfaces;
using Dapper;
using NHibernate.Criterion;

namespace DataAccessLayer.Repositories
{
    public class BaseRepository <T>: IRepository<T> where T:EntityBase
    {
        private readonly string _tableName;

         protected BaseRepository(string tableName)
        {
            _tableName = tableName;
        }
        public T GetById(Guid id)
        {
            using (var con = DapperProvider.Instance.GetConnection())
            {
                var item = con.Query<T>($"SELECT * FROM {_tableName} WHERE Id=@Id", new {Id = id}).FirstOrDefault();
                return item;
            }
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> items = null;
            using (var connection = DapperProvider.Instance.GetConnection())
            {
                items= connection.Query<T>($"select * from {_tableName}");
            }

            return items;
        }
        public IEnumerable<T> GetAll(Predicate<T> predicate)
        {
            IEnumerable<T> items = null;
            using (var connection = DapperProvider.Instance.GetConnection())
            {
                items = connection.Query<T>($"select * from {_tableName}");
            }

            return items.ToList().FindAll(predicate);
        }
    }
}
