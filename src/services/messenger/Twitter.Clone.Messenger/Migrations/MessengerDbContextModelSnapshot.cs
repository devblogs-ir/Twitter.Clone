﻿// <auto-generated />
using System;
using Messanger.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Twitter.Clone.Messenger.Migrations
{
    [DbContext(typeof(MessengerDbContext))]
    partial class MessengerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.Participant", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanSendMessage")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.Property<bool>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("bit");

                    b.Property<Guid>("PublicChatChatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("PublicChatChatId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PrivateChat", b =>
                {
                    b.Property<Guid>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeletedForStarter")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeletedForTarget")
                        .HasColumnType("bit");

                    b.Property<string>("LastMessageBrief")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastMessageDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StarterUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TargetUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("UnseenNumbers")
                        .HasColumnType("tinyint");

                    b.HasKey("ChatId");

                    b.ToTable("PrivateChats");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PrivateMessage", b =>
                {
                    b.Property<long>("PrivateMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PrivateMessageId"));

                    b.Property<DateTime>("DeliverDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeletedForStarter")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeletedForTarget")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<bool>("IsForStarter")
                        .HasColumnType("bit");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("MessageStatus")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("PrivateChatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PrivateMessageId");

                    b.HasIndex("PrivateChatId");

                    b.ToTable("PrivateMessages");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicChat", b =>
                {
                    b.Property<Guid>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatorUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastMessageBrief")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastMessageDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("UnseenNumbers")
                        .HasColumnType("tinyint");

                    b.HasKey("ChatId");

                    b.ToTable("PublicChats");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicMessage", b =>
                {
                    b.Property<long>("PublicMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PublicMessageId"));

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MessageOwner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SentDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PublicMessageId");

                    b.HasIndex("ChatId");

                    b.ToTable("PublicMessages");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicMessageStatus", b =>
                {
                    b.Property<long>("PublicMessageStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PublicMessageStatusId"));

                    b.Property<DateTime>("DeliverDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("PublicMessageId")
                        .HasColumnType("bigint");

                    b.Property<byte>("SentMessageSatus")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PublicMessageStatusId");

                    b.HasIndex("PublicMessageId");

                    b.ToTable("PublicMessageStatus");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.Participant", b =>
                {
                    b.HasOne("Twitter.Clone.Messenger.Models.PublicChat", "PublicChat")
                        .WithMany("Participants")
                        .HasForeignKey("PublicChatChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicChat");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PrivateMessage", b =>
                {
                    b.HasOne("Twitter.Clone.Messenger.Models.PrivateChat", "PrivateChat")
                        .WithMany("PrivateMessages")
                        .HasForeignKey("PrivateChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PrivateChat");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicMessage", b =>
                {
                    b.HasOne("Twitter.Clone.Messenger.Models.PublicChat", "PublicChat")
                        .WithMany("PublicMessages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicChat");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicMessageStatus", b =>
                {
                    b.HasOne("Twitter.Clone.Messenger.Models.PublicMessage", "PublicMessage")
                        .WithMany("ParticipantStatus")
                        .HasForeignKey("PublicMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublicMessage");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PrivateChat", b =>
                {
                    b.Navigation("PrivateMessages");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicChat", b =>
                {
                    b.Navigation("Participants");

                    b.Navigation("PublicMessages");
                });

            modelBuilder.Entity("Twitter.Clone.Messenger.Models.PublicMessage", b =>
                {
                    b.Navigation("ParticipantStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
