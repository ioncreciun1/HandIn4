using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandIn4.Database.Context;
using HandIn4.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HandIn4.Database
{
    public class DataFromDB:DAOAdults,DAOUser
    {
        private AdultsDBContext context;

        public DataFromDB()
        {
            context = new AdultsDBContext();
        }
        public async Task<IList<Adult>> getAdults(string firstName,
            string lastName,
            string jobTitle,
            string hairColor,
            string eyeColor,
            string sex,
            int? age,
            int? AdultID)
        {
            IList<Adult> adults = context.Adults.ToList();;
            
            if (firstName != null)
            {
                adults =  adults.Where(adult => adult.FirstName == firstName).ToList();
            }

            if (lastName != null)
            {
                adults = adults.Where(adult => adult.LastName == lastName).ToList();
            }

            if (jobTitle != null)
            {
                adults =  adults.Where(adult => adult.JobTitle == lastName).ToList();
            }

            if (hairColor != null)
            {
                adults = adults.Where(adult => adult.HairColor == hairColor).ToList();
            }

            if (eyeColor != null)
            {
                adults = adults.Where(adult => adult.EyeColor == eyeColor).ToList();
            }

            if (sex != null)
            {
                
                adults = adults.Where(adult => adult.Sex == sex).ToList();
            }

            if (age != null)
            {
                adults =  adults.Where(adult => adult.Age == age).ToList();
                
            }

            if (AdultID != null)
            {
                adults = adults.Where(adult => adult.Id == AdultID).ToList();
            }
            return adults;
        }

        public async Task addAdult(Adult adult)
        {
            await context.Adults.AddAsync(adult);
            await context.SaveChangesAsync();
        }

        public async Task deleteAdult(int Id)
        {
            Adult removeAdult = context.Adults.Where(adult => adult.Id == Id).First();
            context.Adults.Remove(removeAdult);
            await context.SaveChangesAsync();
        }

        public async Task<IList<User>> getUsers()
        {
            IList<User> users = context.Users.ToList();
            return users;
        }
    }
}