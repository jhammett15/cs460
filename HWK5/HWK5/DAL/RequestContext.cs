using HWK5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HWK5.DAL
{
    public class RequestContext : DbContext
    {
        public RequestContext() : base("name=OurRequests")
        {

        }

        public virtual DbSet<Request> Requests { get; set; }
    }
}