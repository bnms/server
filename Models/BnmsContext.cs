using Microsoft.EntityFrameworkCore;

namespace server.Models {
    public class BnmsContext: DbContext {
        public BnmsContext(DbContextOptions<BnmsContext> options) : base(options) {
        }
    }
}