using System;
using System.Collections.Generic;
using System.Text;

namespace PM
{
    public interface ISourceFilesItem
    {
        public string FileNameTemplate
        {
            get; set;
        }
    }
}
