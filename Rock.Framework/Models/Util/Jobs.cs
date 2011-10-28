//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Rock.Models;

namespace Rock.Models.Util
{
    [Table( "utilJobs" )]
    public partial class Jobs : ModelWithAttributes
    {
		[DataMember]
		public Guid Guid { get; set; }
		
		[DataMember]
		public bool? System { get; set; }
		
		[DataMember]
		public bool? Active { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Name { get; set; }
		
		[MaxLength( 500 )]
		[DataMember]
		public string Description { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Assemby { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Class { get; set; }
		
		[DataMember]
		public time StartTime { get; set; }
		
		[DataMember]
		public time EndTime { get; set; }
		
		[MaxLength( 35 )]
		[DataMember]
		public string Days { get; set; }
		
		[DataMember]
		public DateTime? LastSuccessfulRun { get; set; }
		
		[MaxLength( 1000 )]
		[DataMember]
		public string NotificationEmails { get; set; }
		
		[DataMember]
		public int? NotificationStatus { get; set; }
		
		[DataMember]
		public DateTime? CreateDateTime { get; set; }
		
		[DataMember]
		public DateTime? ModifyDateTime { get; set; }
		
		[DataMember]
		public int? CreateByPersonId { get; set; }
		
		[DataMember]
		public int? ModifiedByPersonId { get; set; }
		
		[NotMapped]
		public override string AuthEntity { get { return "Util.Jobs"; } }

		public virtual Crm.Person CreateByPerson { get; set; }

		public virtual Crm.Person ModifiedByPerson { get; set; }

        public static Jobs Read(int id)
        {
            return new Rock.Services.Util.JobsService().GetJobs( id );
        }
    }

    public partial class JobsConfiguration : EntityTypeConfiguration<Jobs>
    {
        public JobsConfiguration()
        {
			this.HasOptional( p => p.CreateByPerson ).WithMany( p => p.Jobss ).HasForeignKey( p => p.CreateByPersonId );
			this.HasOptional( p => p.ModifiedByPerson ).WithMany( p => p.Jobss ).HasForeignKey( p => p.ModifiedByPersonId );
		}
    }
}
