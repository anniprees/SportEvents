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
            InitializeParticipants(db);
            InitializeRegistrations(db);
        }

        private static void InitializeSportsCategories(EventsDbContext db)
        {
            if (db.SportsCategories.Count() != 0) return;

            var categories = new[]
            {
                new SportsCategoryData {Id="1", Name = "Bikram Yoga"},
                new SportsCategoryData {Id="2", Name = "Pilates"},
                new SportsCategoryData {Id="3", Name = "Crossfit"},
            };

            db.SportsCategories.AddRange(categories);
            db.SaveChanges();

        }

        private static void InitializeEvents(EventsDbContext db)
        {
            if (db.Events.Count() != 0) return;

            var events = new[]
            {
                new EventData{Id = "1", SportsCategoryId = "1", Name = "Friday Morning Bikram ", MaxParticipants = 12, EventDate = Convert.ToDateTime("15/01/2021 09:00"), Location = "Green"},
                new EventData{Id = "2", SportsCategoryId = "3", Name = "Friday Crossfit", MaxParticipants = 8, EventDate = Convert.ToDateTime("15/01/2021 09:00"), Location = "Bright"},
                new EventData{Id = "3", SportsCategoryId = "1", Name = "Saturday Relax Bikram", MaxParticipants = 12, EventDate = Convert.ToDateTime("16/01/2021 09:00"), Location = "Bright"},
                new EventData{Id = "4", SportsCategoryId = "2", Name = "Weekend Pilates", MaxParticipants = 6, EventDate = Convert.ToDateTime("16/01/2021 09:00"), Location = "Tech"},
                new EventData{Id = "5", SportsCategoryId = "3", Name = "Saturday Crossfit", MaxParticipants = 8, EventDate = Convert.ToDateTime("16/01/2021 09:00"), Location = "Green"},
                new EventData{Id = "6", SportsCategoryId = "1", Name = "Sunday Wake Up Bikram", MaxParticipants = 12, EventDate = Convert.ToDateTime("17/01/2021 09:00"), Location = "Bright"},
                new EventData{Id = "7", SportsCategoryId = "3", Name = "Sunday Crossfit", MaxParticipants = 8, EventDate = Convert.ToDateTime("17/01/2021 09:00"), Location = "Green"},
            };

            db.Events.AddRange(events);
            db.SaveChanges();

        }

        private static void InitializeParticipants(EventsDbContext db)
        {
            if (db.Participants.Count() != 0) return;

            var participants = new[]
            {
                new ParticipantData {Id = "1", Name = "John"},
                new ParticipantData {Id = "2", Name = "Mary"},
                new ParticipantData {Id = "3", Name = "Mari"},
                new ParticipantData {Id = "4", Name = "Juhan"},
                new ParticipantData {Id = "5", Name = "Jevgeni"},
                new ParticipantData {Id = "6", Name = "Olga"},
                new ParticipantData {Id = "7", Name = "Marju"},
                new ParticipantData {Id = "8", Name = "Juha"},
                new ParticipantData {Id = "9", Name = "Una"},
                new ParticipantData {Id = "10", Name = "Felipe"},
                new ParticipantData {Id = "11", Name = "Giorgos"},
                new ParticipantData {Id = "12", Name = "Eleni"},
                new ParticipantData {Id = "13", Name = "Mihkel"},
                new ParticipantData {Id = "14", Name = "Elsa"},
            };

            db.Participants.AddRange(participants);
            db.SaveChanges();

        }

        private static void InitializeRegistrations(EventsDbContext db)
        {
            if (db.Registrations.Count() != 0) return;

            var registrations = new[]
            {
                new EventRegistrationData {Id = "1", EventId = "1", ParticipantId = "1"},
                new EventRegistrationData {Id = "2", EventId = "1", ParticipantId = "2"},
                new EventRegistrationData {Id = "3", EventId = "1", ParticipantId = "5"},
                new EventRegistrationData {Id = "4", EventId = "1", ParticipantId = "9"},
                new EventRegistrationData {Id = "5", EventId = "1", ParticipantId = "10"},
                new EventRegistrationData {Id = "6", EventId = "2", ParticipantId = "3"},
                new EventRegistrationData {Id = "7", EventId = "2", ParticipantId = "7"},
                new EventRegistrationData {Id = "8", EventId = "2", ParticipantId = "6"},
                new EventRegistrationData {Id = "9", EventId = "2", ParticipantId = "14"},
                new EventRegistrationData {Id = "10", EventId = "2", ParticipantId = "12"},
                new EventRegistrationData {Id = "11", EventId = "2", ParticipantId = "10"},
                new EventRegistrationData {Id = "12", EventId = "2", ParticipantId = "8"},
                new EventRegistrationData {Id = "13", EventId = "3", ParticipantId = "3"},
                new EventRegistrationData {Id = "14", EventId = "3", ParticipantId = "4"},
                new EventRegistrationData {Id = "15", EventId = "3", ParticipantId = "8"},
                new EventRegistrationData {Id = "16", EventId = "4", ParticipantId = "9"},
                new EventRegistrationData {Id = "17", EventId = "4", ParticipantId = "10"},
                new EventRegistrationData {Id = "18", EventId = "4", ParticipantId = "11"},
                new EventRegistrationData {Id = "19", EventId = "4", ParticipantId = "12"},
                new EventRegistrationData {Id = "20", EventId = "4", ParticipantId = "13"},
                new EventRegistrationData {Id = "21", EventId = "4", ParticipantId = "14"},
                new EventRegistrationData {Id = "22", EventId = "5", ParticipantId = "2"},
                new EventRegistrationData {Id = "23", EventId = "5", ParticipantId = "11"},
                new EventRegistrationData {Id = "24", EventId = "6", ParticipantId = "3"},
                new EventRegistrationData {Id = "25", EventId = "6", ParticipantId = "2"},
                new EventRegistrationData {Id = "26", EventId = "6", ParticipantId = "5"},
                new EventRegistrationData {Id = "27", EventId = "7", ParticipantId = "3"},
                new EventRegistrationData {Id = "28", EventId = "7", ParticipantId = "7"},
                new EventRegistrationData {Id = "29", EventId = "7", ParticipantId = "6"},
                new EventRegistrationData {Id = "30", EventId = "7", ParticipantId = "12"},
            };

            db.Registrations.AddRange(registrations);
            db.SaveChanges();

        }

    }
}
