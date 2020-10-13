using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcTemplatemailMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcTemplatemail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcTemplatemail> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_templatemail");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.IdLanguage)
                .IsRequired()
                .HasColumnName("id_language")
                .HasColumnType("char(20)")
                .HasMaxLength(20)
                .HasDefaultValueSql("'en'");

            builder.Property(t => t.Mailtype)
                .HasColumnName("mailtype")
                .HasColumnType("char(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Fromemail)
                .HasColumnName("fromemail")
                .HasColumnType("char(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Fromname)
                .HasColumnName("fromname")
                .HasColumnType("char(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Subject)
                .HasColumnName("subject")
                .HasColumnType("varchar(130)")
                .HasMaxLength(130);

            builder.Property(t => t.Messagetext)
                .HasColumnName("messagetext")
                .HasColumnType("varchar(3000)")
                .HasMaxLength(3000);

            builder.Property(t => t.Messagehtml)
                .HasColumnName("messagehtml")
                .HasColumnType("varchar(3000)")
                .HasMaxLength(3000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_templatemail";

        public const string ColumnId = "id";
        public const string ColumnIdLanguage = "id_language";
        public const string ColumnMailtype = "mailtype";
        public const string ColumnFromemail = "fromemail";
        public const string ColumnFromname = "fromname";
        public const string ColumnSubject = "subject";
        public const string ColumnMessagetext = "messagetext";
        public const string ColumnMessagehtml = "messagehtml";
        #endregion
    }
}
