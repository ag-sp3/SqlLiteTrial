﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlLiteTrial
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TMCMeetingsEntities : DbContext
    {
        public TMCMeetingsEntities()
            : base("name=TMCMeetingsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingRole> MeetingRoles { get; set; }
        public virtual DbSet<MeetingRoleGroup> MeetingRoleGroups { get; set; }
        public virtual DbSet<MeetingRoleTaker> MeetingRoleTakers { get; set; }
        public virtual DbSet<ObjectEventLog> ObjectEventLogs { get; set; }
        public virtual DbSet<ObjectType> ObjectTypes { get; set; }
        public virtual DbSet<RoleBookingType> RoleBookingTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
    }
}
