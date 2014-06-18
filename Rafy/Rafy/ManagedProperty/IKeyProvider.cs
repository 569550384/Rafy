﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建日期：20140515
 * 说明：见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20140515 22:56
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy
{
    /// <summary>
    /// 标识属性相关算法的提供程序
    /// </summary>
    public interface IKeyProvider
    {
        /// <summary>
        /// 标识属性的属性类型
        /// </summary>
        Type KeyType { get; }

        /// <summary>
        /// 标识属性的默认值
        /// </summary>
        object DefaultValue { get; }

        /// <summary>
        /// 获取一个用于表示空引用的 Id 值。
        /// 
        /// 值类型返回空值：
        /// int: 0
        /// Guid: Guid.Empty
        /// 引用类型返回 null：
        /// String: null
        /// </summary>
        /// <returns></returns>
        object GetEmptyIdForRefIdProperty();

        /// <summary>
        /// 判断给的 Id 值是否表示‘有值’的状态。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool HasId(object id);

        /// <summary>
        /// 构造一个不会重复的本地值。
        /// </summary>
        /// <returns></returns>
        object NewLocalId();

        /// <summary>
        /// 如果是值类型，则需要判断：
        /// 当 HasId(value) 返回 false 时，需要返回对应的可空类型的值。如传入 0，返回 default(int?)。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        object ToNullableValue(object value);
    }
}
