using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AidMethods;
using SportEvents.Data;

namespace SportEvents.Infra
{
    public class EventsDataInitializer
    {
        
        public static void Initialize(EventsDbContext db)
        {
            InitializeSportsCategories(db);
            InitializeEvents(db);
        }

        private static void InitializeSportsCategories(EventsDbContext db)
        {
            if (db.SportsCategories.Count() != 0) return;

            var categories = new[]
            {
                new SportsCategoryData {Id="1", Name = "Basketball"},
                new SportsCategoryData {Id="2", Name = "Handball"},
                new SportsCategoryData {Id="3", Name = "Football"},
                new SportsCategoryData {Id="4", Name = "Tennis"},
                new SportsCategoryData {Id="5", Name = "Volleyball"},
                new SportsCategoryData {Id="6", Name = "Rugby"},
                new SportsCategoryData {Id="7", Name = "Floorball"},
            };

            db.SportsCategories.AddRange(categories);
            db.SaveChanges();

        }

        private static void InitializeEvents(EventsDbContext db)
        {
            if (db.Events.Count() != 0) return;

            var events = new[]
            {
                new EventData{Id = "1", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("13/01/2021 09:00"), Location = "Green Hall"},
                new EventData{Id = "2", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("15/01/2021 09:00"), Location = "Bright Hall"},
                new EventData{Id = "3", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("15/01/2021 09:00"), Location = "Hall Hall"},
                new EventData{Id = "4", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("16/01/2021 09:00"), Location = "Tech Hall"},
                new EventData{Id = "5", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("16/01/2021 09:00"), Location = "Green Hall"},
                new EventData{Id = "6", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("17/01/2021 09:00"), Location = "Red Hall"},
                new EventData{Id = "7", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("17/01/2021 09:00"), Location = "Green Hall"},
                new EventData{Id = "8", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("25/01/2021 09:00"), Location = "Red Hall"},
                new EventData{Id = "9", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("26/01/2021 09:00"), Location = "Pristine Hall"},
                new EventData{Id = "10", SportsCategoryId = GetRandom.Int16(1,7).ToString(), Name = "", MaxParticipants = GetRandom.Int16(10,22), EventDate = Convert.ToDateTime("26/01/2021 09:00"), Location = "Green Hall"},
            };

            db.Events.AddRange(events);
            db.SaveChanges();

        }

    }
}
