using System;

namespace DatabaseManager_lite
{
    public class CorrectDate // Minden dátumot átír olyan formátumba, amit a MySQL elfogad.
    { 
        public string CorrectDateTime(DateTime date)
        {
            return $"{date.Year}/{date.Month}/{date.Day}";
        }

        public string CurrentDate()
        {
            return $"{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}";
        }
    }
}