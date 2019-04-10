using System;
using System.Text;

namespace DatabaseManager_lite
{
    public class CorrectDate // Minden dátumot átír olyan formátumba, amit a MySQL elfogad.
    { 
        private readonly StringBuilder _sb = new StringBuilder();
        public string CorrectDateTime(DateTime date)
        {
            _sb.Clear();
            _sb.Append($"{date.Year}/{date.Month}/{date.Day}");
            return _sb.ToString();
        }

        public string CurrentDate()
        {
            _sb.Clear();
            _sb.Append($"{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}");
            return _sb.ToString();
        }
    }
}