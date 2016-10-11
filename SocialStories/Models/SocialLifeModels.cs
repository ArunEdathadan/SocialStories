using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialStories.Models
{
   [Table("PostStoryMode")]
   public partial class PostStoryMode
   {
      [Key]
      public int PostStoryModeID { get; set; }
      public string Title { get; set; }
      public string MetaTags { get; set; }
      public string Content { get; set; }
      public int ParentID { get; set; }
      public int MyProperty { get; set; }
      public int CreatedByUserID { get; set; }
      public int ResponseID { get; set; }
      public int EmotionID { get; set; }
      public int RevisionHistoryID { get; set; }
      public DateTime CreatedOn { get; set; }
   }

   public partial class SocialLifeDbContext : DbContext
   {
      public SocialLifeDbContext() : base("name=DefaultConnection")
      {
      }

      public DbSet<PostStoryMode> PostStoryMode { get; set; }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {

      }
   }

}