using System;

namespace SQ.Core.DTO
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DTOAttribute : Attribute
    {
        private bool allow = true;

        private bool ignore = false;

        private string foreignKeyPropertyName = string.Empty;

        private string foreignKeyEntityName = string.Empty;

        public DTOAttribute(bool allow)
        {
            this.allow = allow;
        }

        public DTOAttribute(bool allow, bool ignore)
        {
            this.allow = allow;
            this.ignore = ignore;
        }

        public DTOAttribute(string foreignKeyPropertyName, string foreignKeyEntityName)
        {
            this.allow = true;
       
            this.foreignKeyPropertyName = foreignKeyPropertyName;

            this.foreignKeyEntityName = foreignKeyEntityName;
        }

        public bool Allow
        {
            get
            {
                return allow;
            }
        }

        public bool Ignore
        {
            get
            {
                return ignore;
            }
        }

        public string ForeignKeyPropertyName
        {
            get
            {
                return foreignKeyPropertyName;
            }
        }

        public string ForeignKeyEntityName
        {
            get
            {
                return foreignKeyEntityName;
            }
        }
    }
}
