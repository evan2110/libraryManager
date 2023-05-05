﻿using System;
using System.Collections.Generic;
using LibraryManagerWeb.BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryManagerWeb.DataAccess;

public partial class DatabaseTestProjectContext : DbContext
{
    public DatabaseTestProjectContext()
    {
    }

    public DatabaseTestProjectContext(DbContextOptions<DatabaseTestProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BooksBorrow> BooksBorrows { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsetting.json")
        .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProjectDB"));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("account_id");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("created_time");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");

            entity.HasOne(d => d.Role).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_Role");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__books__490D1AE18D4D6129");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("book_id");
            entity.Property(e => e.Author)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.AvailableCopies).HasColumnName("available_copies");
            entity.Property(e => e.PublicationDate)
                .HasColumnType("date")
                .HasColumnName("publication_date");
            entity.Property(e => e.ShelfLocation)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.TotalCopies).HasColumnName("total_copies");
        });

        modelBuilder.Entity<BooksBorrow>(entity =>
        {
            entity.HasKey(e => e.BookBorrowId);

            entity.ToTable("BooksBorrow");

            entity.Property(e => e.BookBorrowId)
                .ValueGeneratedNever()
                .HasColumnName("book_borrow_id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.DateBorrowed)
                .HasColumnType("datetime")
                .HasColumnName("date_borrowed");
            entity.Property(e => e.DateReturn)
                .HasColumnType("datetime")
                .HasColumnName("date_return");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.ReceivedBy)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("received_by");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Account).WithMany(p => p.BooksBorrows)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BooksBorrow_Account");

            entity.HasOne(d => d.Book).WithMany(p => p.BooksBorrows)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BooksBorrow_Books");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("role_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
