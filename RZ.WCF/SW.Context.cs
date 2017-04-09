﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuckZuck_WCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SWEntitiesApi : DbContext
    {
        public SWEntitiesApi()
            : base("name=SWEntitiesApi")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Content> Content { get; set; }
        public DbSet<DeploymentType> DeploymentType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductVersion> ProductVersion { get; set; }
        public DbSet<ProductVersionDownloads> ProductVersionDownloads { get; set; }
        public DbSet<ProductVersionFeedback> ProductVersionFeedback { get; set; }
        public DbSet<WindowsInstallerIDs> WindowsInstallerIDs { get; set; }
        public DbSet<vActiveLatestProducts> vActiveLatestProducts { get; set; }
        public DbSet<vAllSWDetails> vAllSWDetails { get; set; }
        public DbSet<vDownloadsByInstalltype> vDownloadsByInstalltype { get; set; }
        public DbSet<vDownloadsByProductVersion> vDownloadsByProductVersion { get; set; }
        public DbSet<vFeedbackSuccessRatio> vFeedbackSuccessRatio { get; set; }
        public DbSet<vListProducts> vListProducts { get; set; }
        public DbSet<vPendingSoftwareRequests> vPendingSoftwareRequests { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<vFeedbackNotWorking> vFeedbackNotWorking { get; set; }
        public DbSet<vProductsWithIssues> vProductsWithIssues { get; set; }
        public DbSet<vProductVersionChanges> vProductVersionChanges { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<vCategorySummary> vCategorySummary { get; set; }
        public DbSet<vProductCategories> vProductCategories { get; set; }
        public DbSet<PreRequisite> PreRequisite { get; set; }
        public DbSet<vLatestProducts> vLatestProducts { get; set; }
        public DbSet<vPreRequisites> vPreRequisites { get; set; }
    }
}
