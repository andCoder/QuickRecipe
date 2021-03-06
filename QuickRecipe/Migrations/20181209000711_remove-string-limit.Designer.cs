﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickRecipe.Data.Context;

namespace QuickRecipe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181209000711_remove-string-limit")]
    partial class removestringlimit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuickRecipe.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("productid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnName("amount");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<int>("RecipeId")
                        .HasColumnName("recipe");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("QuickRecipe.Data.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recipeid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int>("Portions")
                        .HasColumnName("portions");

                    b.Property<string>("TimeAmount")
                        .HasColumnName("cooking_time");

                    b.Property<string>("Title")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("QuickRecipe.Data.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("stepid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("image");

                    b.Property<int>("RecipeId")
                        .HasColumnName("recipe");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("steps");
                });

            modelBuilder.Entity("QuickRecipe.Data.Models.Product", b =>
                {
                    b.HasOne("QuickRecipe.Data.Models.Recipe", "Parent")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuickRecipe.Data.Models.Step", b =>
                {
                    b.HasOne("QuickRecipe.Data.Models.Recipe", "Parent")
                        .WithMany("Steps")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
