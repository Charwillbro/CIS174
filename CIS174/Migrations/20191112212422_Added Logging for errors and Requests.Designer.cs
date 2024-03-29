﻿// <auto-generated />
using System;
using CIS174;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174.Migrations
{
    [DbContext(typeof(PersonAccomplishmentContext))]
    [Migration("20191112212422_Added Logging for errors and Requests")]
    partial class AddedLoggingforerrorsandRequests
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIS174.Entities.Accomplishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfAccomplishment");

                    b.Property<string>("Name")
                        .HasMaxLength(25);

                    b.Property<string>("PersonId");

                    b.Property<int?>("PersonId1");

                    b.HasKey("Id");

                    b.HasIndex("PersonId1");

                    b.ToTable("Accomplishments");
                });

            modelBuilder.Entity("CIS174.Entities.ExceptionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExceptionMessage");

                    b.Property<string>("ExceptionStackTrace");

                    b.Property<int>("HttpStatusCode");

                    b.Property<DateTime>("LogTime");

                    b.Property<Guid>("RequestId");

                    b.HasKey("Id");

                    b.ToTable("Exceptions");
                });

            modelBuilder.Entity("CIS174.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("City")
                        .HasMaxLength(25);

                    b.Property<string>("FirstName")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("CIS174.Entities.RequestResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LogTime");

                    b.Property<string>("Request");

                    b.Property<string>("Response");

                    b.HasKey("Id");

                    b.ToTable("RequestResponses");
                });

            modelBuilder.Entity("CIS174.Entities.Accomplishment", b =>
                {
                    b.HasOne("CIS174.Entities.Person")
                        .WithMany("Accomplishments")
                        .HasForeignKey("PersonId1");
                });
#pragma warning restore 612, 618
        }
    }
}
