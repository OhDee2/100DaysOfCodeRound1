﻿// <auto-generated />
using KingdomOfRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KingdomOfRelationships.Migrations
{
    [DbContext(typeof(TempRepoContext))]
    [Migration("20190125183431_AddStringLimits")]
    partial class AddStringLimits
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KingdomOfRelationships.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("KingdomOfRelationships.Models.CharacterRelationships", b =>
                {
                    b.Property<int>("CharacterRelationshipsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<int>("RelationshipId");

                    b.HasKey("CharacterRelationshipsId");

                    b.ToTable("CharacterRelationship");
                });

            modelBuilder.Entity("KingdomOfRelationships.Models.Relationship", b =>
                {
                    b.Property<int>("RelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.HasKey("RelationshipId");

                    b.ToTable("Relationships");
                });
#pragma warning restore 612, 618
        }
    }
}
