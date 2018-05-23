﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bing.Domains.Entities;

namespace Bing.Datas.Stores.Operations
{
    /// <summary>
    /// 查找实体列表
    /// </summary>
    /// <typeparam name="TEntity">对象类型</typeparam>
    /// <typeparam name="TKey">对象标识类型</typeparam>
    public interface IFindAllNoTrackingAsync<TEntity,in TKey> where TEntity:class,IKey<TKey>
    {
        /// <summary>
        /// 查找实体列表，不跟踪
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <returns></returns>
        Task<List<TEntity>> FindAllNoTrackingAsync(Expression<Func<TEntity, bool>> predicate = null);
    }
}
