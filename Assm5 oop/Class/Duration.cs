using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assm5_oop.Class
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public Duration(double totalSeconds)
            : this((int)totalSeconds)
        {
        }

        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() + d2.ToTotalSeconds();
            return new Duration(totalSeconds);
        }


        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = d.ToTotalSeconds() + seconds;
            return new Duration(totalSeconds);
        }


        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }


        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() - d2.ToTotalSeconds();
            if (totalSeconds < 0) totalSeconds = 0;
            return new Duration(totalSeconds);
        }


        public static Duration operator ++ (Duration d)
        {
            return d + 60;
        }


        //public static Duration operator -- (Duration d)
        //{
        //    return d - 60;
        //}


        //public static bool operator >(Duration d1, Duration d2)
        //{
        //    return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        //}


        //public static bool operator <=(Duration d1, Duration d2)
        //{
        //    return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        //}

        public static implicit operator bool(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }

        public static implicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}
