//------------------------------------------------------------------------------
// <auto-generated>
//     本文件代码自动生成。用于实现强类型接口，方便应用层使用。
//     版本号:1.5.0
//
//     请勿修改，否则在重新生成时，所有修改会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Rafy;
using Rafy.Data;
using Rafy.Domain;
using Rafy.Domain.ORM;

namespace Rafy.RBAC
{
    partial class OrgPositionUserList
    {
        #region 强类型公有接口

        /// <summary>
        /// 获取或设置指定位置的实体。
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new OrgPositionUser this[int index]
        {
            get
            {
                return base[index] as OrgPositionUser;
            }
            set
            {
                base[index] = value;
            }
        }

        /// <summary>
        /// 获取本实体列表的迭代器。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new IEnumerator<OrgPositionUser> GetEnumerator()
        {
            return new EntityListEnumerator<OrgPositionUser>(this);
        }

        /// <summary>
        /// 返回子实体的强类型迭代接口，方便使用 Linq To Object 操作。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public IEnumerable<OrgPositionUser> Concrete()
        {
            return this.Cast<OrgPositionUser>();
        }

        /// <summary>
        /// 添加指定的实体到集合中。
        /// </summary>
        [DebuggerStepThrough]
        public void Add(OrgPositionUser entity)
        {
            base.Add(entity);
        }

        /// <summary>
        /// 判断本集合是否包含指定的实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool Contains(OrgPositionUser entity)
        {
            return base.Contains(entity);
        }

        /// <summary>
        /// 判断指定的实体在本集合中的索引号。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public int IndexOf(OrgPositionUser entity)
        {
            return base.IndexOf(entity);
        }

        /// <summary>
        /// 在指定的位置插入实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public void Insert(int index, OrgPositionUser entity)
        {
            base.Insert(index, entity);
        }

        /// <summary>
        /// 在集合中删除指定的实体。返回是否成功删除。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public bool Remove(OrgPositionUser entity)
        {
            return base.Remove(entity);
        }

        #endregion
    }

    partial class OrgPositionUserRepository
    {
        #region 私有方法，本类内部使用

        /// <summary>
        /// 在查询接口方法中，调用此方法来向服务端执行对应参数的 FetchBy 数据层方法，并返回第一个实体。
        /// </summary>
        /// <param name="parameters">可传递多个参数。</param>
        /// <returns>返回服务端返回的列表中的第一个实体。</returns>
        [DebuggerStepThrough]
        private new OrgPositionUser FetchFirst(params object[] parameters)
        {
            return base.FetchFirst(parameters) as OrgPositionUser;
        }

        /// <summary>
        /// 在查询接口方法中，调用此方法来向服务端执行对应参数的 FetchBy 数据层方法，并返回满足条件的实体列表。
        /// </summary>
        /// <param name="parameters">可传递多个参数。</param>
        /// <returns>返回满足条件的实体列表。</returns>
        [DebuggerStepThrough]
        private new OrgPositionUserList FetchList(params object[] parameters)
        {
            return base.FetchList(parameters) as OrgPositionUserList;
        }

        /// <summary>
        /// 在查询接口方法中，调用此方法来导向服务端执行指定的数据层查询方法，并返回统计的行数。
        /// </summary>
        /// <param name="dataQueryExp">调用子仓库类中定义的数据查询方法的表达式。</param>
        /// <returns>返回统计的行数。</returns>
        [DebuggerStepThrough]
        protected int FetchCount(Expression<Func<OrgPositionUserRepository, EntityList>> dataQueryExp)
        {
            return this.FetchCount<OrgPositionUserRepository>(dataQueryExp);
        }

        /// <summary>
        /// 在查询接口方法中，调用此方法来导向服务端执行指定的数据层查询方法，并返回第一个满足条件的实体。
        /// </summary>
        /// <param name="dataQueryExp">调用仓库类中定义的数据查询方法的表达式。</param>
        /// <returns>返回第一个满足条件的实体。</returns>
        [DebuggerStepThrough]
        private OrgPositionUser FetchFirst(Expression<Func<OrgPositionUserRepository, EntityList>> dataQueryExp)
        {
            return this.FetchFirst<OrgPositionUserRepository>(dataQueryExp) as OrgPositionUser;
        }

        /// <summary>
        /// 在查询接口方法中，调用此方法来向服务端执行指定的数据层查询方法，并返回满足条件的实体列表。
        /// </summary>
        /// <param name="dataQueryExp">调用仓库类中定义的数据查询方法的表达式。</param>
        /// <returns>返回满足条件的实体列表。</returns>
        [DebuggerStepThrough]
        private OrgPositionUserList FetchList(Expression<Func<OrgPositionUserRepository, EntityList>> dataQueryExp)
        {
            return this.FetchList<OrgPositionUserRepository>(dataQueryExp) as OrgPositionUserList;
        }

        /// <summary>
        /// 在查询接口方法中，调用此方法来向服务端执行指定的数据层查询方法，并返回满足条件的数据表格。
        /// </summary>
        /// <param name="dataQueryExp">调用仓库类中定义的数据查询方法的表达式。</param>
        /// <returns>返回满足条件的数据表格。</returns>
        [DebuggerStepThrough]
        private LiteDataTable FetchTable(Expression<Func<OrgPositionUserRepository, LiteDataTable>> dataQueryExp)
        {
            return this.FetchTable<OrgPositionUserRepository>(dataQueryExp);
        }

        /// <summary>
        /// 创建一个实体类的 Linq 查询器
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        private IQueryable<OrgPositionUser> CreateLinqQuery()
        {
            return base.CreateLinqQuery<OrgPositionUser>();
        }

        #endregion

        #region 强类型公有接口

        /// <summary>
        /// 创建一个新的实体。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUser New()
        {
            return base.New() as OrgPositionUser;
        }

        /// <summary>
        /// 创建一个全新的列表
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList NewList()
        {
            return base.NewList() as OrgPositionUserList;
        }

        /// <summary>
        /// 优先使用缓存中的数据来通过 Id 获取指定的实体对象
        /// 
        /// 如果该实体的缓存没有打开，则本方法会直接调用 GetById 并返回结果。
        /// 如果缓存中没有这些数据，则本方法同时会把数据缓存起来。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUser CacheById(object id)
        {
            return base.CacheById(id) as OrgPositionUser;
        }

        /// <summary>
        /// 优先使用缓存中的数据来查询所有的实体类
        /// 
        /// 如果该实体的缓存没有打开，则本方法会直接调用 GetAll 并返回结果。
        /// 如果缓存中没有这些数据，则本方法同时会把数据缓存起来。
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList CacheAll()
        {
            return base.CacheAll() as OrgPositionUserList;
        }

        /// <summary>
        /// 通过Id在数据层中查询指定的对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUser GetById(object id)
        {
            return base.GetById(id) as OrgPositionUser;
        }

        /// <summary>
        /// 查询第一个实体类
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUser GetFirst()
        {
            return base.GetFirst() as OrgPositionUser;
        }

        /// <summary>
        /// 查询所有的实体类
        /// </summary>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetAll()
        {
            return base.GetAll() as OrgPositionUserList;
        }

        /// <summary>
        /// 分页查询所有的实体类
        /// </summary>
        /// <param name="pagingInfo"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetAll(PagingInfo pagingInfo)
        {
            return base.GetAll(pagingInfo) as OrgPositionUserList;
        }

        /// <summary>
        /// 获取指定 id 集合的实体列表。
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByIdList(params object[] idList)
        {
            return base.GetByIdList(idList) as OrgPositionUserList;
        }

        /// <summary>
        /// 通过组合父对象的 Id 列表，查找所有的组合子对象的集合。
        /// </summary>
        /// <param name="parentIdList"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByParentIdList(params object[] parentIdList)
        {
            return base.GetByParentIdList(parentIdList) as OrgPositionUserList;
        }

        /// <summary>
        /// 查询某个父对象下的子对象
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByParentId(object parentId)
        {
            return base.GetByParentId(parentId) as OrgPositionUserList;
        }

        /// <summary>
        /// 通过父对象 Id 分页查询子对象的集合。
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="pagingInfo"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByParentId(object parentId, PagingInfo pagingInfo)
        {
            return base.GetByParentId(parentId, pagingInfo) as OrgPositionUserList;
        }

        /// <summary>
        /// 递归查找所有树型子
        /// </summary>
        /// <param name="treeIndex"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByTreeParentIndex(string treeIndex)
        {
            return base.GetByTreeParentIndex(treeIndex) as OrgPositionUserList;
        }

        /// <summary>
        /// 查找指定树节点的直接子节点。
        /// </summary>
        /// <param name="treePId">需要查找的树节点的Id.</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new OrgPositionUserList GetByTreePId(object treePId)
        {
            return base.GetByTreePId(treePId) as OrgPositionUserList;
        }

        #endregion
    }
}