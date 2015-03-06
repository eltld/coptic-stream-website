using System;
using System.Collections.Generic;
using System.Linq;
using Verse.DAL;

namespace Verse.BLL
{
    /// <summary>
    /// Summary description for VerseData
    /// </summary>
    public static class VerseData
    {
         static VerseData()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static List<DAL.Verse> GetAllVerse()
        {
            using (VersesEntities db = new VersesEntities())
            {
                return (from v in db.Verses select v).ToList();
            }
        }

        public static void AddNew(string date, string english, string arabic)
        {
            using (VersesEntities db = new VersesEntities())
            {
                Verse.DAL.Verse v = new DAL.Verse()
                {
                    verseDate = date,
                    verseEnglish = english,
                    verseArabic = arabic
                };

                db.Verses.Add(v);
                db.SaveChanges();


            }
        }

        public static void Delete(int id)
        {
            using (VersesEntities db = new VersesEntities())
            {
                var d = (from v in db.Verses where v.verseID == id select v).SingleOrDefault();

                try
                {
                    db.Verses.Remove(d);
                    db.SaveChanges();

                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        public static void Edit(int id,string date, string english, string arabic)
        {
            using (VersesEntities db = new VersesEntities())
            {
                var d = (from v in db.Verses where v.verseID == id select v).SingleOrDefault();

                if (d != null)
                {
                    d.verseArabic = arabic;
                    d.verseEnglish = english;
                    d.verseDate = date;

                }
                db.SaveChanges();

            }
        }

        public static Verse.DAL.Verse GetVerseOfTheDay()
        {
            DAL.Verse verse = new DAL.Verse();


            using (VersesEntities db = new VersesEntities())
            {
                DateTime dateTime = DateTime.Now;
                string day = dateTime.Day.ToString();
                string month = dateTime.Month.ToString();

                verse = (from v in db.Verses where v.verseDate == month + "/" + day select v).SingleOrDefault();
            }

            return verse;
        }

    }
}