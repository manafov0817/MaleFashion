using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreOptionValueRepository : EfCoreGenericRepository<OptionValue, MaleFashionDbContext>, IOptionValueRepository
    {
        public List<OptionValue> GetAllColors ()
        {
            using (var context = new MaleFashionDbContext( ))
            {

                return context.OptionValues
                                    .Include(ov => ov.Option)
                                    .Where(op => op.Option.Name.ToLower( ) == "Color".ToLower( ))
                                    .ToList( ); ;
            }
        }

        public List<OptionValue> GetAllWithOptions ()
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.OptionValues.Include(ov => ov.Option).ToList( );
            }
        }

        public List<OptionValue> GetOptionValuesByOptionId ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.OptionValues.Where(ov => ov.OptionId==id).ToList( );
            }
        }
    }
}
