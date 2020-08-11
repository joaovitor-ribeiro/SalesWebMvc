using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Joao Vitor", "joao@gmail.com", new DateTime(2000, 5, 10), 2000.0, d2);
            Seller s3 = new Seller(3, "Maria Ruy", "maria@gmail.com", new DateTime(1999, 10, 15), 2500.0, d1);
            Seller s4 = new Seller(4, "Ruy Barbosa", "ruy@gmail.com", new DateTime(2001, 12, 26), 500.0, d4);
            Seller s5 = new Seller(5, "Alex Pink", "alex@gmail.com", new DateTime(2000, 1, 9), 7000.0, d3);
            Seller s6 = new Seller(6, "Martha Blue", "martha@gmail.com", new DateTime(1997, 9, 2), 6000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 08, 22), 1000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 07, 15), 2000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 05), 15000.0, SalesStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 08, 23), 21000.0, SalesStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 13), 20000.0, SalesStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 10, 25), 30000.0, SalesStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 11, 03), 31000.0, SalesStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 13), 1000.0, SalesStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 01, 25), 500.0, SalesStatus.Billed, s1);
            SalesRecord r11= new SalesRecord(11, new DateTime(2018, 02, 27), 5000.0, SalesStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 03, 02), 6000.0, SalesStatus.Billed, s2);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 04, 12), 4000.0, SalesStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 05, 14), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 06, 16), 21000.0, SalesStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 06, 20), 9000.0, SalesStatus.Billed, s3);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 06, 02), 8000.0, SalesStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 07, 05), 7000.0, SalesStatus.Billed, s2);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 07, 03), 7000.0, SalesStatus.Billed, s3);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 02, 04), 15000.0, SalesStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 12), 16000.0, SalesStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 15), 19000.0, SalesStatus.Billed, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 17), 13000.0, SalesStatus.Billed, s3);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 12, 18), 14000.0, SalesStatus.Billed, s3);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 12, 17), 15000.0, SalesStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 12, 14), 5000.0, SalesStatus.Billed, s3);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 11, 19), 32000.0, SalesStatus.Billed, s4);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 12, 19), 39000.0, SalesStatus.Billed, s4);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 12, 12), 40000.0, SalesStatus.Billed, s2);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 05, 15), 9000.0, SalesStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30   
                ) ;

            _context.SaveChanges();
        }
    }
}
