﻿// <auto-generated />
using System;
using KoalaWiki.Provider.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KoalaWiki.Provider.Sqlite.Migrations
{
    [DbContext(typeof(SqliteContext))]
    [Migration("20250430094200_AddGitUser")]
    partial class AddGitUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("KoalaWiki.Entities.Document", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<long>("CommentCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GitPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT");

                    b.Property<long>("LikeCount")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WarehouseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentCatalog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DucumentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WarehouseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("DucumentId");

                    b.HasIndex("Name");

                    b.HasIndex("ParentId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("DocumentCatalogs");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentCommitRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommitId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommitMessage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("WarehouseId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CommitId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("DocumentCommitRecords");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentFile.DocumentFileItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<long>("CommentCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentCatalogId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Extra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Metadata")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RequestToken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResponseToken")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("DocumentCatalogId");

                    b.HasIndex("Title");

                    b.ToTable("DocumentFileItems");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentFile.DocumentFileItemSource", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentFileItemId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("DocumentFileItemId");

                    b.HasIndex("Name");

                    b.ToTable("DocumentFileItemSources");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentOverview", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("Title");

                    b.ToTable("DocumentOverviews");
                });

            modelBuilder.Entity("KoalaWiki.Entities.Warehouse", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Error")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GitPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("GitUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenAIEndpoint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OpenAIKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prompt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Address");

                    b.HasIndex("Branch");

                    b.HasIndex("CreatedAt");

                    b.HasIndex("Name");

                    b.HasIndex("OrganizationName");

                    b.HasIndex("Status");

                    b.HasIndex("Type");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("KoalaWiki.Entities.DocumentFile.DocumentFileItemSource", b =>
                {
                    b.HasOne("KoalaWiki.Entities.DocumentFile.DocumentFileItem", "DocumentFileItem")
                        .WithMany()
                        .HasForeignKey("DocumentFileItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentFileItem");
                });
#pragma warning restore 612, 618
        }
    }
}
