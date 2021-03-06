﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20120330
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20120330
 * 
*******************************************************/

using System;
using Rafy.ManagedProperty;

namespace Rafy.MetaModel
{
    /// <summary>
    /// 验证规则及元数据。
    /// </summary>
    public interface IRule
    {
        /// <summary>
        /// 如果这个规则是适用到某个实体属性上，那么这个属性就表示这个实体的属性。
        /// </summary>
        IManagedProperty Property { get; }

        /// <summary>
        /// 获取用于表示规则名称。
        /// </summary>
        /// <remarks>
        /// The rule's name must be unique and is used
        /// to identify a broken rule in the BrokenRules
        /// collection.
        /// </remarks>
        string Key { get; }

        /// <summary>
        /// 规则对应的元数据。
        /// </summary>
        RuleMeta Meta { get; }

        /// <summary>
        /// 用于执行验证的规则逻辑。
        /// </summary>
        IValidationRule ValidationRule { get; }
    }

    /// <summary>
    /// 表示规则的作用范围
    /// </summary>
    [Flags]
    public enum RuleScope
    {
        /// <summary>
        /// 作用于数据的插入操作。
        /// </summary>
        Add = 1,
        /// <summary>
        /// 作用于数据的更新操作。
        /// </summary>
        Update = 2,
        /// <summary>
        /// Add | Update
        /// </summary>
        AddOrUpdate = Add | Update,
        /// <summary>
        /// 作用于数据的插入、更新操作。
        /// </summary>
        Delete = 4,
        /// <summary>
        /// Add | Update | Delete
        /// </summary>
        All = Add | Update | Delete
    }
}