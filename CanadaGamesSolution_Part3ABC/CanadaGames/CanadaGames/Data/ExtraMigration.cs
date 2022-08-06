using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanadaGames.Data
{
    public static class ExtraMigration
    {
        public static void Steps(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetAthleteTimestampOnUpdate
                    AFTER UPDATE ON Athletes
                    BEGIN
                        UPDATE Athletes
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
                @"
                    CREATE TRIGGER SetAthleteTimestampOnInsert
                    AFTER INSERT ON Athletes
                    BEGIN
                        UPDATE Athletes
                        SET RowVersion = randomblob(8)
                        WHERE rowid = NEW.rowid;
                    END
                ");
            migrationBuilder.Sql(
               @"
                    Create View PlacementReporSummary as
                    Select a.ID, a.FirstName, a.MiddleName, a.LastName, Count(*) as TotalEvents, 
	                    Sum(a.Averageplacement) as Averageplacement , Max(a.HighestPlacement) as HighestPlacement , Min(Lowestplacement) as Lowestplacement
                  From Athlete a Join Coach a
                    on a.ID = a.CoachID
                    Group By a.ID, a.FirstName, a.MiddleName, a.LastName
                ");
        }
    }
}
