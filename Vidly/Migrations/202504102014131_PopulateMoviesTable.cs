namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockAmount, Genre_Id) VALUES ( 'Shrek', '2001-08-22', '2023-03-23', 5, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockAmount, Genre_Id) VALUES ( 'Green Book', '2018-09-11', '2023-06-23', 4, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockAmount, Genre_Id) VALUES ( 'Die Hard', '1998-09-27', '2023-03-21', 3, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockAmount, Genre_Id) VALUES ( 'Toy Story', '1996-05-01', '2023-10-14', 2, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, StockAmount, Genre_Id) VALUES ( 'Titanic', '1998-02-04', '2023-05-05', 3, 4)");
        }

        public override void Down()
        {
        }
    }
}
