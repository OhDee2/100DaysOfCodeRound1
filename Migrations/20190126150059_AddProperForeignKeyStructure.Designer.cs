﻿// <auto-generated />
using System;
using KingdomOfRelationships.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KingdomOfRelationships.Migrations
{
    [DbContext(typeof(TempRepoContext))]
    [Migration("20190126150059_AddProperForeignKeyStructure")]
    partial class AddProperForeignKeyStructure
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

                    b.Property<int?>("ChildCharacterId");

                    b.Property<int?>("ParentCharacterId");

                    b.Property<int?>("RelationshipId");

                    b.HasKey("CharacterRelationshipsId");

                    b.HasIndex("ChildCharacterId");

                    b.HasIndex("ParentCharacterId");

                    b.HasIndex("RelationshipId");

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

            modelBuilder.Entity("KingdomOfRelationships.Models.CharacterRelationships", b =>
                {
                    b.HasOne("KingdomOfRelationships.Models.Character", "ChildCharacter")
                        .WithMany()
                        .HasForeignKey("ChildCharacterId");

                    b.HasOne("KingdomOfRelationships.Models.Character", "ParentCharacter")
                        .WithMany()
                        .HasForeignKey("ParentCharacterId");

                    b.HasOne("KingdomOfRelationships.Models.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipId");
                });
#pragma warning restore 612, 618
        }
    }
}