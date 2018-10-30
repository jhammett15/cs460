using HWK5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HWK5.DAL
{
    /// <summary>
    /// The Context file for the database, allows access to the data, extends DbContext
    /// </summary>
    public class RequestContext : DbContext
    {
        /// <summary>
        /// Constructor method for the RequestContext class, calls the constructor from the superclass with the name of the 
        /// database
        /// </summary>
        public RequestContext() : base("name=OurRequests")
        {
        }

        public virtual DbSet<Request> Requests { get; set; }
    }
}