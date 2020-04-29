using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Entities.Models
{
    [Table("jobs")]
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        public int JobNumber { get; set; }

        public JOB_STATUS Status { get; set; }

        public virtual User Worker { get; set; }

        [ForeignKey(nameof(Worker))]
        public int? WorkerId { get; set; }

        public virtual Customer Customer { get; set; }

        [ForeignKey(nameof(Customer))]
        public int? CustomerId { get; set; }

        public virtual Car Car { get; set; }

        [ForeignKey(nameof(Car))]
        public int? CarId { get; set; }

        [InverseProperty(nameof(JobItem.Job))]
        public virtual ICollection<JobItem> Items { get; set; }
    }
}
