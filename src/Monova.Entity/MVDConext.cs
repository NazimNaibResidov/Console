using System;
using Microsoft.EntityFramewrokCore;
namespace Monova.Entity {
    public class MVDConext : DbCotext {
      
        public MVDConext (DbContextOptions options) : base (options)
         {
          
        }
    }
}