namespace BlazoeEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy is a 2005 science fiction comedy film directed by Garth Jennings, based upon previous works in the media franchise of the same name, created by Douglas Adams. It stars Martin Freeman, Sam Rockwell, Mos Def, Zooey Deschanel, Bill Nighy, Anna Chancellor, John Malkovich, and the voices of Stephen Fry, Helen Mirren, Thomas Lennon, Richard Griffiths, Ian McNeice, Bill Bailey and Alan Rickman. Adams co-wrote the screenplay with Karey Kirkpatrick but died in 2001, before production began; the film is dedicated to Adams. The film grossed over $100 million worldwide.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Hitchhikers_guide_to_the_galaxy.jpg/220px-Hitchhikers_guide_to_the_galaxy.jpg",
                    Price = 9.99m
                },
        new Product
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2018 American science fiction adventure film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg, from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. Set in 2045, much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. The orphaned Wade Watts finds clues to a contest that promises the ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
            Price = 7.99m
        },
        new Product
        {
            Id = 3,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg",
            Price = 6.99m
        }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
