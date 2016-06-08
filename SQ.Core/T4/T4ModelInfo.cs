﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using SQ.Core.Data;

namespace SQ.Core.T4
{
    /// <summary>
    /// T4实体模型信息类
    /// </summary>
    public class T4ModelInfo
    {
        /// <summary>
        /// 获取 是否使用模块文件夹
        /// </summary>
        public bool UseModuleDir { get; private set; }

        /// <summary>
        /// 获取 模型所在模块名称
        /// </summary>
        public string ModuleName { get; private set; }

        /// <summary>
        /// 获取 模型名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 获取 模型描述
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 主键类型
        /// </summary>
        public Type KeyType { get; set; }

        /// <summary>
        /// 主键类型名称
        /// </summary>
        public string KeyTypeName { get; set; }

        public IEnumerable<PropertyInfo> Properties { get; private set; }

        public Dictionary<string, string> TypeDic { get; private set; }

        public T4ModelInfo(Type modelType, bool useModuleDir = false)
        {
            var @namespace = modelType.Namespace;
            if (@namespace == null)
            {
                return;
            }
            UseModuleDir = useModuleDir;
            if (UseModuleDir)
            {
                var index = @namespace.LastIndexOf('.') + 1;
                ModuleName = @namespace.Substring(index, @namespace.Length - index);
            }

            Name = modelType.Name;
            PropertyInfo keyProp = modelType.GetProperty("Id");
            KeyType = keyProp.PropertyType;
            KeyTypeName = KeyType.Name;

            var descAttributes = modelType.GetCustomAttributes(typeof(DescriptionAttribute), true);
            Description = descAttributes.Length == 1 ? ((DescriptionAttribute)descAttributes[0]).Description : Name;

            Properties = modelType.GetProperties();

            TypeDic = InitialTypeDic();
        }

        public Dictionary<string, string> InitialTypeDic()
        {

            var dic = new Dictionary<string, string>();

            dic.Add("String", "string");

            dic.Add("Int32", "int");

            dic.Add("Nullable`1", "int?");

            return dic;
        }
    }

    
}