using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public Clock()
        {
        }

        public Clock(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException();
                else
                    hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 59)
                {
                    Hour += value / 60;
                    minute = value % 60;
                }
                else
                    minute = value;
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value > 59)
                {
                    Minute += value / 60;
                    second = value % 60;
                }
                else
                    second = value;
            }
        }

        public static Clock operator +(Clock clock, Timer timer)
        {
            Clock newClock = new Clock
            {
                Hour = clock.Hour,
                Minute = clock.Minute + timer.Minute,
                Second = clock.Second + timer.Second + timer.Millisecond / 60,
            };
            return newClock;
        }

        public static Clock operator -(Clock clock, Timer timer)
        {
            Clock newClock = new Clock()
            {
                Hour = clock.Hour,
                Minute = clock.Minute - timer.Minute,
                Second = clock.Second - timer.Second - timer.Millisecond / 60
            };
            return newClock;
        }

        public static bool operator <(Clock clock1, Clock clock2)
        {
            if (clock1.Hour != clock2.Hour)
                return clock1.Hour < clock2.Hour;

            if (clock1.Minute != clock2.Minute)
                return clock1.Minute < clock2.Minute;

            if (clock1.Second != clock2.Second)
                return clock1.Second < clock2.Second;

            return true;
        }

        public static bool operator >(Clock clock1, Clock clock2)
        {
            if (clock1.Hour != clock2.Hour)
                return clock1.Hour > clock2.Hour;

            if (clock1.Minute != clock2.Minute)
                return clock1.Minute > clock2.Minute;

            if (clock1.Second != clock2.Second)
                return clock1.Second > clock2.Second;

            return true;
        }

        public static bool operator <=(Clock clock1, Clock clock2)
        {
            if (clock1.Hour == clock2.Hour && clock1.Minute == clock2.Minute && clock1.Second == clock2.Second)
                return true;

            if (clock1.Hour != clock2.Hour)
                return clock1.Hour < clock2.Hour;

            if (clock1.Minute != clock2.Minute)
                return clock1.Minute < clock2.Minute;

            if (clock1.Second != clock2.Second)
                return clock1.Second < clock2.Second;

            return true;
        }

        public static bool operator >=(Clock clock1, Clock clock2)
        {
            if (clock1.Hour == clock2.Hour && clock1.Minute == clock2.Minute && clock1.Second == clock2.Second)
                return true;

            if (clock1.Hour != clock2.Hour)
                return clock1.Hour > clock2.Hour;

            if (clock1.Minute != clock2.Minute)
                return clock1.Minute > clock2.Minute;

            if (clock1.Second != clock2.Second)
                return clock1.Second > clock2.Second;

            return true;
        }

        public static bool operator ==(Clock clock1, Clock clock2)
        {
            return (clock1.Hour == clock2.Hour && clock1.Minute == clock2.Minute && clock1.Second == clock2.Second);
        }

        public static bool operator !=(Clock clock1, Clock clock2)
        {
            return (clock1.Hour != clock2.Hour || clock1.Minute != clock2.Minute || clock1.Second != clock2.Second);
        }

        public override string ToString()
        {
            return $"{Hour}h:{Minute}m:{Second}s";
        }
    }
}