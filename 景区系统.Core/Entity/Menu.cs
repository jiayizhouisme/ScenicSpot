using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 景区系统.Core.Entity
{
    public class Menu : IEntity, IEntityTypeBuilder<Menu>
    {
        [Comment("主键ID")]
        public int Id { get; set; }

        [Comment("菜单名称")]
        [MaxLength(36)]
        [DisallowNull]
        public string MenuName { get; set; }

        [Comment("菜单跳转链接")]
        [MaxLength(256)]
        [AllowNull]
        public string MenuUrl { get; set; }

        [Comment("排序顺序")]
        public int Sort { get; set; }

        [Comment("父级菜单ID")]
        public int ParentID { get; set; }

        [Comment("创建时间")]
        public DateTime CreateTime { get; set; }

        [MaxLength(128)]
        [Comment("菜单图标")]
        public string Icon { get; set; }

        [Comment("软删除")]
        public bool IsDeleted { get; set; }

        void IPrivateEntityTypeBuilder<Menu>.Configure(EntityTypeBuilder<Menu> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(a => a.Id);
            entityBuilder.Property(a => a.Id).ValueGeneratedOnAdd();
            entityBuilder.HasQueryFilter(a => a.IsDeleted == false);
        }
    }
}
