using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository()
        {
            Book rememberMe = new Book(10001, "Mary Higgins Clark", "Remember Me", 210.25m, 1994);
            rememberMe.Publisher = "Pocket Books";
            rememberMe.ISBN = "0671867091";
            rememberMe.ImageFileName = "remember-me.jfif";
            rememberMe.Category = "Book";

            Book atss = new Book(10002, "Khaled Hosseini", "A Thousand Splendid Suns", 103.05m, 2007);
            atss.Publisher = "ATSS Publications, LLC";
            atss.ISBN = "978 0 7475 8279 3 10 9 8 7 6";
            atss.ImageFileName = "atss.jfif";
            atss.Category = "Book";

            Products.Add(rememberMe);
            Products.Add(atss);

            Movie gdt = new Movie(10003, "Gladiator", 130.50m, "gladiator.jpg", "Ridley Scott");
            Movie jb = new Movie(10004, "Jungle Book", 160.50m, "junglebook.jpg", "John Favreau");
            gdt.Category = "Movie";
            jb.Category = "Movie";

            Products.Add(gdt);
            Products.Add(jb);

            MusicCD nightVisions = new MusicCD(10005, "Imagine Dragons", "Night Visions", 150.00m, 2012);
            nightVisions.Label = "KIDinaKORNER";
            nightVisions.ImageFileName = "night_visions.jpeg";
            nightVisions.Category = "CD";

            nightVisions.AddTrack(new Track("Radioactive", "Grant", new TimeSpan(0, 3, 16)));
            nightVisions.AddTrack(new Track("Tiptoe", "Dan Reynolds", new TimeSpan(0, 3, 13)));
            nightVisions.AddTrack(new Track("It's Time", new TimeSpan(0, 3, 57)));
            nightVisions.AddTrack(new Track("Demons", "Mosser, Grant", new TimeSpan(0, 2, 55)));
            nightVisions.AddTrack(new Track("On Top of The World", "Grant", new TimeSpan(0, 3, 19)));
            nightVisions.AddTrack(new Track("Amsterdam", new TimeSpan(0, 4, 10)));
            nightVisions.AddTrack(new Track("Hear Me", "Wayne Sermon", new TimeSpan(0, 3, 52)));
            nightVisions.AddTrack(new Track("Every Night", "Grant", new TimeSpan(0, 3, 35)));
            nightVisions.AddTrack(new Track("Bleading Out", "Jay Pow", new TimeSpan(0, 3, 41)));
            nightVisions.AddTrack(new Track("Underdog", new TimeSpan(0, 3, 26)));
            nightVisions.AddTrack(new Track("Nothing Left To Say", new TimeSpan(0, 8, 56)));
            nightVisions.AddTrack(new Track("Working Man", new TimeSpan(0, 3, 53)));
            nightVisions.AddTrack(new Track("Fallen", new TimeSpan(0, 2, 59)));

            MusicCD sdn = new MusicCD(10006, "Milky Chance", "Sadnecessary", 149.05m, 2013);
            sdn.Label = "Lichtdicht";
            sdn.ImageFileName = "sadnecessary.jfif";

            sdn.AddTrack(new Track("Stunner", "Dausch, Rehbein", new TimeSpan(0, 4, 50)));
            sdn.AddTrack(new Track("Flashed Junk Mind", "Dausch, Rehbein", new TimeSpan(0, 4, 24)));
            sdn.AddTrack(new Track("Becoming", "Dausch, Rehbein", new TimeSpan(0, 2, 26)));
            sdn.AddTrack(new Track("Running", "Dausch, Rehbein", new TimeSpan(0, 4, 30)));
            sdn.AddTrack(new Track("Feathery", "Dausch, Rehbein", new TimeSpan(0, 3, 18)));
            sdn.AddTrack(new Track("Indigo", "Dausch, Rehbein", new TimeSpan(0, 1, 28)));
            sdn.AddTrack(new Track("Sadnecessary", "Dausch, Rehbein", new TimeSpan(0, 5, 10)));
            sdn.AddTrack(new Track("Down by the River", "Dausch, Rehbein", new TimeSpan(0, 4, 13)));
            sdn.AddTrack(new Track("Sweet Sun", "Dausch, Rehbein", new TimeSpan(0, 4, 36)));
            sdn.AddTrack(new Track("Fairytale", "Dausch, Rehbein", new TimeSpan(0, 4, 18)));
            sdn.AddTrack(new Track("Stolen Dance", "Dausch, Rehbein", new TimeSpan(0, 5, 15)));
            sdn.AddTrack(new Track("Loveland", "Dausch, Rehbein", new TimeSpan(0, 3, 38)));
            sdn.Category = "CD";

            Products.Add(nightVisions);
            Products.Add(sdn);

            Customer c1 = new Customer(00001, "Susanna", "Porras", "Jardines de S.I., 26-62", "01016", "Guatemala City");
            c1.AddPhone("+502 50552657");
            c1.Birthday = new DateTime(1996, 7, 20);

            Customer c2 = new Customer(00002, "Niels", "Jensen", "Haslecentervej, 92", "8210", "Aarhus V");
            c2.AddPhone("+45 91953438");
            c2.Birthday = new DateTime(1993, 6, 30);

            Invoice invoice1 = new Invoice(1, new DateTime(2021, 2, 25), c2);
            Invoice i2 = new Invoice(2, new DateTime(2021, 2, 26), c1);

            invoice1.AddOrderItem(sdn, 1);
            invoice1.AddOrderItem(atss, 2);

            i2.AddOrderItem(gdt, 1);
            i2.AddOrderItem(nightVisions, 3);

            Invoices.Add(i2);
            Invoices.Add(invoice1);
        }

    }
}
