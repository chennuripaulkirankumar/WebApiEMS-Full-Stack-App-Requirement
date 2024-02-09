﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiEMS_Full_Stack_App_Requirement.Data;

#nullable disable

namespace WebApiEMS_Full_Stack_App_Requirement.Migrations
{
    [DbContext(typeof(EmpolyeeContext))]
    partial class EmpolyeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiEMS_Full_Stack_App_Requirement.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"), 1L, 1);

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("DeptMAster");
                });

            modelBuilder.Entity("WebApiEMS_Full_Stack_App_Requirement.Models.EmpProfile", b =>
                {
                    b.Property<int>("Empcode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Empcode"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<int?>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Empcode");

                    b.HasIndex("DeptMasterDeptCode");

                    b.ToTable("EmpProfile");
                });

            modelBuilder.Entity("WebApiEMS_Full_Stack_App_Requirement.Models.EmpProfile", b =>
                {
                    b.HasOne("WebApiEMS_Full_Stack_App_Requirement.Models.DeptMaster", "DeptMaster")
                        .WithMany("EmpProfiles")
                        .HasForeignKey("DeptMasterDeptCode");

                    b.Navigation("DeptMaster");
                });

            modelBuilder.Entity("WebApiEMS_Full_Stack_App_Requirement.Models.DeptMaster", b =>
                {
                    b.Navigation("EmpProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
