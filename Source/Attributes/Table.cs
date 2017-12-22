﻿using System;

namespace EntityWorker.Core.Attributes
{
    /// <summary>
    /// Define diffrent name for the table
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class Table : Attribute
    {
        public string Name { get; private set; }

        public string DisplayName { get; private set; }

        public Table(string name, string displayName = null)
        {
            Name = name;
            DisplayName = displayName ?? Name;
        }
    }
}
