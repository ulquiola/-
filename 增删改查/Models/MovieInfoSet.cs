//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 增删改查.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieInfoSet
    {
        public int MoiveId { get; set; }
        public string MoiveName { get; set; }
        public int TypeId { get; set; }
        public int TypeInfo_TypeId { get; set; }
    
        public virtual TypeInfoSet TypeInfoSet { get; set; }
    }
}
