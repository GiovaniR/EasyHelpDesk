using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHD.Domain.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get; set; }
        public int ModifiedByUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Ticket(int id, string title, string description, int createdByUserId, int modifiedByUserId, DateTime dateCreated, DateTime dateModified)
        {
            Id = id;
            Title = title;
            Description = description;
            CreatedByUserId = createdByUserId;
            ModifiedByUserId = modifiedByUserId;
            DateCreated = dateCreated;
            DateModified = dateModified;
        }
    }
}
