using System;

namespace Script.Dynamic
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NoElementDuplicateAttribute : Attribute
    {
        private string Value { get; set; } = "true";
    }
}