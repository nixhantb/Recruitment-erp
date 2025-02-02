﻿// <auto-generated />
using System;
using System.Collections.Generic;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace JobLeet.WebApi.Migrations.BaseDB
{
    [DbContext(typeof(BaseDBContext))]
    partial class BaseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("address_id");

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("address_city");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("address_country");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text")
                        .HasColumnName("address_postalCode");

                    b.Property<string>("State")
                        .HasColumnType("text")
                        .HasColumnName("address_state");

                    b.Property<string>("Street")
                        .HasColumnType("text")
                        .HasColumnName("address_street");

                    b.HasKey("Id");

                    b.ToTable("jblt_userAddress", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("education_id");

                    b.Property<decimal>("Cgpa")
                        .HasColumnType("numeric")
                        .HasColumnName("education_cgpa");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("education_degree");

                    b.Property<DateOnly>("GraduationDate")
                        .HasColumnType("date")
                        .HasColumnName("education_graduationdate");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("education_nstitution");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("education_major");

                    b.HasKey("Id");

                    b.ToTable("jblt_education", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("text");

                    b.Property<int>("EmailType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("experience_id");

                    b.Property<string>("CompanyId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExperienceDateFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExperienceDateTill")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExperienceLevel")
                        .HasColumnType("integer")
                        .HasColumnName("experience_type");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("jblt_experience", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("personname_id");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("personName_firstname");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("personName_lastname");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text")
                        .HasColumnName("personName_middlename");

                    b.HasKey("Id");

                    b.ToTable("jblt_personName", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("jblt_phoneid");

                    b.Property<int>("CountryCode")
                        .HasColumnType("integer")
                        .HasColumnName("jblt_countrycode");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("jblt_phonenumber");

                    b.HasKey("Id");

                    b.ToTable("jblt_phone", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Project", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("GitHubUrl")
                        .HasColumnType("text");

                    b.Property<string>("ProjectUrl")
                        .HasColumnType("text");

                    b.Property<List<string>>("Responsibilities")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<List<string>>("TechnologiesUsed")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("qualification_id");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("QualificationInformation")
                        .HasColumnType("text")
                        .HasColumnName("qualification_information");

                    b.Property<int>("QualificationType")
                        .HasColumnType("integer")
                        .HasColumnName("qualification_type");

                    b.HasKey("Id");

                    b.ToTable("jblt_qualification", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("skill_id");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("jblt_skill", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("company_id");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ProfileId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("jblt_company", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.CompanyProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("companyprofile_id");

                    b.Property<string>("CompanyAddressId")
                        .HasColumnType("text");

                    b.Property<string>("ContactEmailId")
                        .HasColumnType("text");

                    b.Property<string>("ContactPhoneId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IndustryTypesId")
                        .HasColumnType("text");

                    b.Property<string>("ProfileInfo")
                        .HasColumnType("text");

                    b.Property<string>("Website")
                        .HasColumnType("text")
                        .HasColumnName("company_website");

                    b.HasKey("Id");

                    b.HasIndex("CompanyAddressId");

                    b.HasIndex("ContactEmailId");

                    b.HasIndex("ContactPhoneId");

                    b.HasIndex("IndustryTypesId");

                    b.ToTable("jblt_companyprofile", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Industry", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("industry_id");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IndustryType")
                        .HasColumnType("integer")
                        .HasColumnName("industry_type");

                    b.HasKey("Id");

                    b.ToTable("jblt_industryType", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1.Employer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("employer_id");

                    b.Property<string>("AddressId")
                        .HasColumnType("text");

                    b.Property<string>("CompanyId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IndustryTypeId")
                        .HasColumnType("text");

                    b.Property<string>("NameId")
                        .HasColumnType("text");

                    b.Property<string>("PhoneId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("IndustryTypeId");

                    b.HasIndex("NameId");

                    b.HasIndex("PhoneId");

                    b.ToTable("jblt_employer", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.Application", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("application_id");

                    b.Property<string>("ApplicationDateId")
                        .HasColumnType("text");

                    b.Property<string>("CompanyId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("JobsId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SeekerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StatusId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationDateId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobsId");

                    b.HasIndex("SeekerId");

                    b.HasIndex("StatusId");

                    b.ToTable("jblt_application", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.ApplicationDate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DecisionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ApplicationDate");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.JobEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("job_id");

                    b.Property<DateTime?>("ApplicationDeadline")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("job_applicationdeadline");

                    b.Property<string>("BasicPay")
                        .HasColumnType("text")
                        .HasColumnName("job_basic_pay");

                    b.Property<string>("Benefits")
                        .HasColumnType("text")
                        .HasColumnName("job_benefits");

                    b.Property<string>("CompanyDescriptionId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FunctionalArea")
                        .HasColumnType("text")
                        .HasColumnName("job_functional_area");

                    b.Property<string>("JobAddressId")
                        .HasColumnType("text");

                    b.Property<string>("JobDescription")
                        .HasColumnType("text")
                        .HasColumnName("job_description");

                    b.Property<string>("JobResponsibilities")
                        .HasColumnType("text")
                        .HasColumnName("job_responsibility");

                    b.Property<string>("JobTitle")
                        .HasColumnType("text")
                        .HasColumnName("job_title");

                    b.Property<string>("JobType")
                        .HasColumnType("text")
                        .HasColumnName("job_type");

                    b.Property<DateTime?>("PostingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("job_posting_date");

                    b.Property<string>("PreferredQualifications")
                        .HasColumnType("text")
                        .HasColumnName("preferred_qualifications");

                    b.Property<string>("RequiredExperienceId")
                        .HasColumnType("text");

                    b.Property<string>("RequiredQualificationId")
                        .HasColumnType("text");

                    b.Property<string>("SkillsRequiredId")
                        .HasColumnType("text");

                    b.Property<string>("Tags")
                        .HasColumnType("text")
                        .HasColumnName("job_tags");

                    b.Property<int?>("Vacancies")
                        .HasColumnType("integer")
                        .HasColumnName("job_vacancies");

                    b.Property<string>("WorkEnvironment")
                        .HasColumnType("text")
                        .HasColumnName("job_workenvironment");

                    b.HasKey("Id");

                    b.HasIndex("CompanyDescriptionId");

                    b.HasIndex("JobAddressId");

                    b.HasIndex("RequiredExperienceId");

                    b.HasIndex("RequiredQualificationId");

                    b.HasIndex("SkillsRequiredId");

                    b.ToTable("jblt_job", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.Status", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StatusName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Seeker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("seeker_id");

                    b.Property<List<string>>("Achievements")
                        .HasColumnType("text[]");

                    b.Property<string>("AddressId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EducationId")
                        .HasColumnType("text");

                    b.Property<string>("ExperienceId")
                        .HasColumnType("text");

                    b.Property<List<string>>("Interests")
                        .HasColumnType("text[]");

                    b.Property<string>("PersonNameId")
                        .HasColumnType("text");

                    b.Property<string>("PhoneId")
                        .HasColumnType("text");

                    b.Property<string>("ProfileSummary")
                        .HasColumnType("text");

                    b.Property<string>("ProjectsId")
                        .HasColumnType("text");

                    b.Property<string>("QualificationsId")
                        .HasColumnType("text");

                    b.Property<string>("SkillsId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("EducationId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("PersonNameId");

                    b.HasIndex("PhoneId");

                    b.HasIndex("ProjectsId");

                    b.HasIndex("QualificationsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("jblt_seeker", (string)null);
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.SocialMedia", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SeekerId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SeekerId");

                    b.ToTable("SocialMedia");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.CompanyProfile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.CompanyProfile", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", "CompanyAddress")
                        .WithMany()
                        .HasForeignKey("CompanyAddressId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Email", "ContactEmail")
                        .WithMany()
                        .HasForeignKey("ContactEmailId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", "ContactPhone")
                        .WithMany()
                        .HasForeignKey("ContactPhoneId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Industry", "IndustryTypes")
                        .WithMany()
                        .HasForeignKey("IndustryTypesId");

                    b.Navigation("CompanyAddress");

                    b.Navigation("ContactEmail");

                    b.Navigation("ContactPhone");

                    b.Navigation("IndustryTypes");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1.Employer", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Industry", "IndustryType")
                        .WithMany()
                        .HasForeignKey("IndustryTypeId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", "Name")
                        .WithMany()
                        .HasForeignKey("NameId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId");

                    b.Navigation("Address");

                    b.Navigation("Company");

                    b.Navigation("IndustryType");

                    b.Navigation("Name");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.Application", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.ApplicationDate", "ApplicationDate")
                        .WithMany()
                        .HasForeignKey("ApplicationDateId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.JobEntity", "Jobs")
                        .WithMany()
                        .HasForeignKey("JobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Seeker", "Seekers")
                        .WithMany()
                        .HasForeignKey("SeekerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.Navigation("ApplicationDate");

                    b.Navigation("Company");

                    b.Navigation("Jobs");

                    b.Navigation("Seekers");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Jobs.V1.JobEntity", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Company", "CompanyDescription")
                        .WithMany()
                        .HasForeignKey("CompanyDescriptionId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", "JobAddress")
                        .WithMany()
                        .HasForeignKey("JobAddressId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", "RequiredExperience")
                        .WithMany()
                        .HasForeignKey("RequiredExperienceId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", "RequiredQualification")
                        .WithMany()
                        .HasForeignKey("RequiredQualificationId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", "SkillsRequired")
                        .WithMany()
                        .HasForeignKey("SkillsRequiredId");

                    b.Navigation("CompanyDescription");

                    b.Navigation("JobAddress");

                    b.Navigation("RequiredExperience");

                    b.Navigation("RequiredQualification");

                    b.Navigation("SkillsRequired");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Seeker", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.PersonName", "PersonName")
                        .WithMany()
                        .HasForeignKey("PersonNameId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Project", "Projects")
                        .WithMany()
                        .HasForeignKey("ProjectsId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Qualification", "Qualifications")
                        .WithMany()
                        .HasForeignKey("QualificationsId");

                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Skill", "Skills")
                        .WithMany()
                        .HasForeignKey("SkillsId");

                    b.Navigation("Address");

                    b.Navigation("Education");

                    b.Navigation("Experience");

                    b.Navigation("PersonName");

                    b.Navigation("Phone");

                    b.Navigation("Projects");

                    b.Navigation("Qualifications");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.SocialMedia", b =>
                {
                    b.HasOne("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Seeker", null)
                        .WithMany("SocialMedias")
                        .HasForeignKey("SeekerId");
                });

            modelBuilder.Entity("JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1.Seeker", b =>
                {
                    b.Navigation("SocialMedias");
                });
#pragma warning restore 612, 618
        }
    }
}
